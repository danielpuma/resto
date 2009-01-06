using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FSO.NH.ClasesBase.Core;
using FSO.NH.Core;
using FSO.NH.Data;
using FastFood.BB.BaseExtension;

using FSO.NH.ClasesBase.BB;
using NHibernate.Criterion;



namespace FastFood.BB.CoreExtension
{
    public class BBListaDePrecio : FNegocio<ListaDePrecio>, IGenericDao<ListaDePrecio, Int32>, IFSOComboDataSource
    {
        private string subtipo = "ListaPrecio";

        public override void ValidarDatos(ListaDePrecio dominio)
        {
            BBParametro_FastFood p = new BBParametro_FastFood(subtipo);
            p.ValidarDatos(dominio);
            ListaDePrecio X = GetPredeterminada();
            if (X != null && X.ID != dominio.ID)
            {
                X.Predeterminado = false;
                Update(X);
                Flush();
                ResetSession();
            }
            if (X == null)
            {
                dominio.Predeterminado = true;
            }

        }

        public List<Parametro> GetFiltered(String Codigo, String Descripcion)
        {
            List<Parametro> Listado;
            BBParametro p = new BBParametro(subtipo);
            Listado = p.GetFiltered(Codigo, Descripcion);
            return Listado;
        }
        public ListaDePrecio GetByCodigo(String Codigo)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f2 = Expression.Eq("Codigo", Codigo);
            filtrosActivos.Add(f2);

            List<ListaDePrecio> p = GetAll(filtrosActivos);
            if (p.Count > 0)
                return p[0];
            else
                return null;
        }


        public  ListaDePrecio GetPredeterminada()
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f2 = Expression.Eq("Predeterminado", true);
            filtrosActivos.Add(f2);

            List<ListaDePrecio> p = this.GetAll((filtrosActivos));
            if (p.Count > 0)
                return p[0];
            else
                return null;
        }

        internal List<ListaDePrecio> GetObjetosAExportar(Exportacion MyObject)
        {
            String ssql;
            String ssqlInner;

            ssql = "IdListaDePrecio NOT IN ( @InnerSQL )";
            ssqlInner = "Select Identificador from DetalleExportacion where Objeto = '" + typeof(ListaDePrecio).ToString() + "'";

            String sqlfinal = ssql.Replace("@InnerSQL", ssqlInner);
            return GetAll(null, sqlfinal, null, null, null);
        }
    }
}
