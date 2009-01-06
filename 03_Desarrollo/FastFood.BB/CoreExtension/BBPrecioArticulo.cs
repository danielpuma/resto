using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FSO.NH.UserInterfaz;
using NHibernate.Criterion;


namespace FastFood.BB.CoreExtension
{
    public class BBPrecioArticulo : FNegocio<PrecioArticulo>, IGenericDao<PrecioArticulo, Int32>, IFSOComboDataSource
    {
        public PrecioArticulo GetByListaYArticulo(int IdLista, int IdArticulo)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f1 = Expression.Eq("Articulo.ID", IdArticulo);
            filtrosActivos.Add(f1);

            ICriterion f2 = Expression.Eq("ListaDePrecio.ID", IdLista);
            filtrosActivos.Add(f2);

            List<PrecioArticulo> ps = this.GetAll((filtrosActivos));
            if (ps.Count > 0)
                return ps[0];
            else
                return null;
        }
    }
}
