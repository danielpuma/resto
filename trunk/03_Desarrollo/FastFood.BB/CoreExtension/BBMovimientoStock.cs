using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.bb;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FastFood.Core.Domain;
using FastFood.Core;
using NHibernate.Criterion;

namespace FastFood.BB.CoreExtension
{
    public class BBMovimientoStock : FNegocio<MovimientoStock>, IGenericDao<MovimientoStock, Int32>, IFSOComboDataSource
    {
        public void ActualizarStock(Pedido MyPedido)
        {
            if (MyPedido.Activo)
            {
                //Revisar si ya existe registro de stock para este Pedido
                MovimientoStock Mov = GetFromPedido(MyPedido);
                if (Mov != null)                
                {
                    //No es null, entonces debo borrar el registro actual y crear uno nuevo.
                    this.Delete(Mov);                  
                }
                MovimientoStock MovNuevo = new MovimientoStock();
                MovNuevo.Activo = true;
                MovNuevo.Fecha = MyPedido.FechaContable;
                MovNuevo.IdMovimientoExterno = MyPedido.ID;
                MovNuevo.Ingreso = false;
                Guardar(MovNuevo);
                MovNuevo.MyMovimientoStockDetalle = GetDetalleStock(MyPedido, MovNuevo);
                
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

        private List<MovimientoStockDetalle> GetDetalleStock(Pedido MyPedido, MovimientoStock MyMov)
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            List<MovimientoStockDetalle> Detalle = new List<MovimientoStockDetalle>();
            foreach (CuerpoPedido cp in MyPedido.CuerpoPedido)
            {
                MovimientoStockDetalle md = new MovimientoStockDetalle();
                md.Cantidad = cp.Cantidad;
                md.EsComponente = false;
                md.MyArticulo = cp.Articulo;
                md.MyArticuloPadre = null;//ERR
                md.MyMovimientoStock = MyMov;
                BBMSD.Guardar(md);
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
                    mdsub.MyMovimientoStock = mdPadre.MyMovimientoStock;
                    BBMSD.Guardar(mdsub);
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


    }
}
