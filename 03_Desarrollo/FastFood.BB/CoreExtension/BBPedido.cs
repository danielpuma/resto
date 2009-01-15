using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FastFood.Core;
using NHibernate.Criterion;
using FSO_NH.log4Net;
using FSO.NH.Seguridad.BB;
using FSO.NH.Seguridad.Core;

namespace FastFood.BB.CoreExtension
{
    public class BBPedido : FNegocio<Pedido>, IGenericDao<Pedido, Int32>, IFSOComboDataSource
    {
        public override void ValidarDatos(Pedido dominio)
        {
            if (dominio.Cliente == null)
                throw new Exception("Se requiere seleccionar un cliente");
            if (dominio.CuerpoPedido == null || dominio.CuerpoPedido.Count==0)
                throw new Exception("Se requiere que el pedido tenga al menos una linea de pedido");
            if(dominio.Mesa ==null)
                throw new Exception("Se requiere seleccionar una mesa");
            if (dominio.Usuario == null)
                throw new Exception("El usuario es obligatorio");
            if(!dominio.Mesa.SolicitarCantidadOcupantes)
                dominio.Ocupantes=0;
            else
                if (dominio.Ocupantes <= 0)
                {
                    throw new Exception("Debe indicar la cantidad de ocupantes de la mesa");
                }
        }
        public override void OnPreSaveData(Pedido dominio)
        {
            if (dominio.ID == 0)
            {
                dominio.Comprobante = new BBComprobante().GetByCodigo("P");
                dominio.FechaCarga = DateTime.Now;
                dominio.NumeroInterno = new BBNumerador().TomarProximoNumero(TipoNumerador.Pedido);
            }

            BBMesa BBM = new BBMesa();
            if (dominio.Activo)
            {
                dominio.Mesa.Ocupada = dominio.Pendiente;
                BBM.Guardar(dominio.Mesa);
            }
            else
            {
                if (dominio.Pendiente)
                {
                    //Si Anulo un pendiente, recupero la mesa
                    dominio.Mesa.Ocupada = false;
                    BBM.Guardar(dominio.Mesa);
                }
            }
            
        }
        public Pedido getNuevo()
        {
            Pedido p = new Pedido();
            p.FechaContable = DateTime.Now;
            p.Pendiente = true;
            return p;
        }

        public List<Pedido> GetFiltered(FSO.NH.Seguridad.Core.Usuario usuario, Mesa mesa, Cliente cliente, DateTime? Desde, DateTime? Hasta)
        {
            return GetFiltered(usuario, mesa, cliente, Desde, Hasta, null, null, null, null);
        }

        public List<Pedido> GetFiltered(FSO.NH.Seguridad.Core.Usuario usuario, Mesa mesa, Cliente cliente, DateTime? Desde, DateTime? Hasta, bool? bActivos, bool? bAnulados, bool? bPendientes, bool? bCerrados)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            if (cliente != null)
            {
                ICriterion f1 = Expression.Eq("Cliente.ID", cliente.ID);
                filtrosActivos.Add(f1);
            }
            if (mesa != null)
            {
                ICriterion f2 = Expression.Eq("Mesa.ID", mesa.ID);
                filtrosActivos.Add(f2);
            }
            if (usuario != null)
            {
                ICriterion f3 = Expression.Eq("Usuario.ID", usuario.ID);
                filtrosActivos.Add(f3);
            }
            ICriterion fEstado = Expression.Gt("ID", -1);//Nunca es Verdadero
            ICriterion fa = Expression.Eq("ID", -1); //Nunca es Verdadero
            ICriterion fb = Expression.Eq("ID", -1); //Nunca es Verdadero
            if (bActivos != null)
            {
                fa = Expression.Eq("Activo", bActivos.Value);               
            }
            if (bAnulados != null)
            {
                fb = Expression.Eq("Activo",!bAnulados.Value );               
            }                        
            if (fa.ToString() == fb.ToString())
            {
                filtrosActivos.Add(fa); //Cualquiera de los dos es correcto ya que son iguales
            }
            else
            {
                fEstado = Expression.Or(fa, fb);
                filtrosActivos.Add(fEstado);
            }
            


            ICriterion fCerrado = Expression.Gt("ID", -1);//Nunca es Verdadero
            ICriterion fc = Expression.Eq("ID",-1); //Nunca es Verdadero
            ICriterion fd = Expression.Eq("ID", -1); //Nunca es Verdadero
            if (bPendientes != null)
            {
                fc = Expression.Eq("Pendiente", bPendientes.Value);
            }
            if (bCerrados != null)
            {
                fd = Expression.Eq("Pendiente", !bCerrados.Value);
            }
            if (fc.ToString() == fd.ToString())
            {
                filtrosActivos.Add(fc); //Cualquiera de los dos es correcto ya que son iguales
            }
            else
            {
                fCerrado = Expression.Or(fc, fd);
                filtrosActivos.Add(fCerrado);
            }
            


            filtrosActivos.Add(GetRangoDeFechas("FechaContable", Desde, Hasta));
            try
            {
                return SortCollection(this.GetAll((filtrosActivos)), "FechaContable", FSO.NHDATA.SortDirection.Descending);
            }
            catch (Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Pedido: " + ex.Message);
                return SortCollection(this.GetAll(), "FechaContable", FSO.NHDATA.SortDirection.Descending);
            }
        }

        public void AnularPedido(int Id, Usuario UsuarioAnulacion)
        {
            Pedido P = GetById(Id, false);
            if (!P.Activo)
                throw new Exception("El Pedido ya se encuentra anulado");
            P.Activo = false;            
            if (UsuarioAnulacion == null)
                throw new Exception("Debe indicar el usuario responsable de la anulación");
            P.UsuarioAnulacion = UsuarioAnulacion;
            P.FechaAnulacion = DateTime.Now;
            Guardar(P); //La mesa la libera la funcion guardar!
        }

        public void EliminarPedido(int Id)
        {
            try
            {
                Pedido P = GetById(Id, false);
                if (P.Pendiente)
                {
                    //Si Anulo un pendiente, recupero la mesa
                    BBMesa BBM = new BBMesa();
                    P.Mesa.Ocupada = false;
                    BBM.Guardar(P.Mesa);
                    BBM.Flush();
                }
                Delete(P);
                Flush();
            }
            catch (Exception Ex)
            {
                
                throw Ex;
            }
        }

        public Pedido GetPedidoPendientePorMesa(Int32 IdMesa)
        {            
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("Mesa.ID", IdMesa);
            filtrosActivos.Add(f1);
            ICriterion f2 =  Expression.Eq("Pendiente", true);
            filtrosActivos.Add(f2);
            ICriterion f3 = Expression.Eq("Activo", true);
            filtrosActivos.Add(f3);
            List<Pedido> lista = this.GetAll(filtrosActivos);
            if (lista != null && lista.Count > 0)
                return lista[0];
            else
                return null;
        }
    }
}
