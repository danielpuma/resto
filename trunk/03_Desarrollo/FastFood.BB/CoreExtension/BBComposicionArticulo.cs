using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.UserInterfaz;
using FSO.NH.bb;
using FSO.NHDATA.DataInterfaces;
using NHibernate.Criterion;

namespace FastFood.BB.CoreExtension
{
    public class BBComposicionArticulo : FNegocio<ComposicionArticulo>, IGenericDao<ComposicionArticulo, Int32>, IFSOComboDataSource
    {
        public List<ComposicionArticulo> GetByArticulo(Articulo ArticuloPadre)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("ArticuloPadre.ID", ArticuloPadre.ID);
            filtrosActivos.Add(f1);
            return this.GetAll(filtrosActivos);
          

        }
        public override void ValidarDatos(ComposicionArticulo Componente)
        {
            if(Es_A_PadreDe_B(Componente.ArticuloComponente, Componente.ArticuloPadre))
            {
                throw new Exception ("No pueden crearse referencias circulares entre articulos compuestos");
            }
        }

        public  bool Es_A_PadreDe_B(Articulo A, Articulo B)
        {
            List<ComposicionArticulo> hijos = GetByArticulo(A);
            foreach (ComposicionArticulo hijo in hijos)
            {
                if (hijo.ArticuloComponente.ID == B.ID)
                    return true;
                else
                    if (hijo.ArticuloComponente.EsCompuesto)
                        return Es_A_PadreDe_B(hijo.ArticuloComponente, B);
            }
            return false;
        }
        public void BorrarPorArticulo(Articulo ArticuloPadre)
        {
            List<ComposicionArticulo> l = GetByArticulo(ArticuloPadre);
            foreach (ComposicionArticulo Compo in l)
            {
                this.Delete(Compo);
            }
            this.Flush();
        }
    }
}
