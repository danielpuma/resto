using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.bb;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FastFood.Core.Domain;
using FastFood.Core;
using NHibernate.Criterion;
using System.Collections;

namespace FastFood.BB.CoreExtension
{
    public class BBMovimientoStock : FNegocio<MovimientoStock>, IGenericDao<MovimientoStock, Int32>, IFSOComboDataSource
    {
        public void ActualizarStock(Pedido MyPedido)
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            if (MyPedido.Activo)
            {
                //Revisar si ya existe registro de stock para este Pedido
                MovimientoStock Mov = GetFromPedido(MyPedido);
                if (Mov != null)                
                {
                    //No es null, entonces debo borrar el registro actual y crear uno nuevo.
                    foreach (MovimientoStockDetalle msd in Mov.MyMovimientoStockDetalle)
                    {
                        BBMSD.Delete(msd);
                        this.session.Flush();
                    }
                    this.Delete(Mov);
                    this.session.Flush();
                }
                MovimientoStock MovNuevo = new MovimientoStock();                
                MovNuevo.Activo = true;
                MovNuevo.Fecha = MyPedido.FechaContable;
                MovNuevo.IdMovimientoExterno = MyPedido.ID;
                MovNuevo.Ingreso = false;
                MovNuevo.IdUsuarioCarga = FSO.NH.Auditoria.Win32Session.UsuarioActual.ID;
                MovNuevo.MyMovimientoStockDetalle = new List<MovimientoStockDetalle>();
                Guardar(MovNuevo); // La Validación de stock se hace en BBPedido, es por eso que aqui puedo guardar
                                   // el detalle del movimiento con la seguridad de que la validación esta hecha.
                MovNuevo.MyMovimientoStockDetalle = GetDetalleStock(MyPedido, MovNuevo);
                foreach (MovimientoStockDetalle msd in MovNuevo.MyMovimientoStockDetalle)
                {
                    BBMSD.Guardar(msd);
                }              
            }
            else
            {
                MovimientoStock Mov = GetFromPedido(MyPedido);
                if (Mov != null)
                {
                    Mov.Activo = false;
                    Guardar(Mov);
                }
            }
        }

        public override void OnPreSaveData(MovimientoStock dominio)
        {
            //Supongo que:
            // 1- Un nuevo movimiento siempre tiene fecha de carga y nunca de anulación
            // 2- Una vez que el movimiento se anulo no puede volver a ser guardado, queda solo lectura.  
            if (dominio.Activo)
                dominio.FechaCarga = DateTime.Now;
            else            
                dominio.FechaAnulacion = DateTime.Now; //La fecha de carga siempre queda seteada, ya que un mov. nuevo no puede crearse anulado.
            
        }
        public override void OnPostSaveData(MovimientoStock dominio)
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            foreach (MovimientoStockDetalle msd in dominio.MyMovimientoStockDetalle)
            {
                msd.IdMovimientoStock = dominio.ID;
                BBMSD.SaveOrUpdate(msd);
            }
        }
        public override void ValidarDatos(MovimientoStock dominio)
        {
            ValidarStock(dominio);
        }
        public List<MovimientoStockDetalle> GetDetalleStock(Pedido MyPedido, MovimientoStock MyMov)
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            List<MovimientoStockDetalle> Detalle = new List<MovimientoStockDetalle>();
            foreach (CuerpoPedido cp in MyPedido.CuerpoPedido)
            {
                MovimientoStockDetalle md = new MovimientoStockDetalle();
                md.Cantidad = cp.Cantidad;
                md.EsComponente = false;
                md.MyArticulo = cp.Articulo;
                md.MyArticuloPadre = cp.Articulo;
                md.IdMovimientoStock= MyMov.ID;
                Detalle.Add(md);
                CompletarDetalleDeStockRecursivo(ref Detalle, md);
            }
            return Detalle;
        }
        private void CompletarDetalleDeStockRecursivo(ref List<MovimientoStockDetalle> Detalle, MovimientoStockDetalle mdPadre)
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            BBComposicionArticulo BBCA = new BBComposicionArticulo();
            if (mdPadre.MyArticulo.EsCompuesto)
            {
                List<ComposicionArticulo> componentes = BBCA.GetByArticulo(mdPadre.MyArticulo);
                foreach (ComposicionArticulo compo in componentes)
                {
                    MovimientoStockDetalle mdsub = new MovimientoStockDetalle();
                    mdsub.Cantidad = mdPadre.Cantidad * compo.Cantidad;
                    mdsub.EsComponente = true;
                    mdsub.MyArticulo = compo.ArticuloComponente;
                    mdsub.MyArticuloPadre = compo.ArticuloPadre;
                    mdsub.IdMovimientoStock = mdPadre.IdMovimientoStock;
                    
                    Detalle.Add(mdsub);
                    if (compo.ArticuloComponente.EsCompuesto)
                    {
                        CompletarDetalleDeStockRecursivo(ref Detalle, mdsub);
                    }
                }                
            }            
        }

        public MovimientoStock GetFromPedido(Pedido MyPedido)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("IdMovimientoExterno", MyPedido.ID);
            filtrosActivos.Add(f1);
            IList<MovimientoStock> X = this.GetAll(filtrosActivos);
            if (X.Count > 0)
                return X[0];
            else
                return null;
        }
        private void ValidarStock(MovimientoStock dominio)
        {
            if (dominio.Ingreso)
                return;
            BBArticulo BBA = new BBArticulo();
            IList detalle = dominio.MyMovimientoStockDetalle;
            foreach (MovimientoStockDetalle msd in detalle)
            {
                if (!msd.MyArticulo.PermiteStockNegativo)
                {
                    decimal stockactual = BBA.GetStockCantidad(msd.MyArticulo);
                    if (stockactual - msd.Cantidad < 0)
                    {
                        throw new Exception("El Artículo: " + msd.MyArticulo.Nombre + " no permite stock en negativo.");
                    }
                }
            }
        }
    }
}
