using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FastFood.Core;

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
    }
}
