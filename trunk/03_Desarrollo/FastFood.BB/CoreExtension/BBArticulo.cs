using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.bb;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;
using NHibernate.Criterion;
using FSO_NH.log4Net;

namespace FastFood.BB.CoreExtension
{
    public class BBArticulo : FNegocio<Articulo>, IGenericDao<Articulo, Int32>, IFSOComboDataSource
    {
        public List<Articulo> GetFiltered(string Codigo, string Nombre, int IdGrupo)
        {
            try
            {
                List<ICriterion> filtrosActivos = new List<ICriterion>();
                if (IdGrupo > 0)
                {
                    ICriterion f1 = Expression.Eq("MyGrupoArticulo.ID", IdGrupo);
                    filtrosActivos.Add(f1);
                }
                if (Codigo.Trim() != "")
                {
                    ICriterion f2 = Expression.InsensitiveLike("Codigo", Codigo, MatchMode.Start);
                    filtrosActivos.Add(f2);
                }
                if (Nombre.Trim() != "")
                {
                    ICriterion f3 = Expression.InsensitiveLike("Nombre", Nombre, MatchMode.Start);
                    filtrosActivos.Add(f3);
                }
                return SortCollection(this.GetAll((filtrosActivos)), "Nombre", FSO.NHDATA.SortDirection.Ascending);
            }
            catch (Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Artículo: " + ex.Message);
                return new List<Articulo>();
            }
        }

        public Articulo GetNuevo()
        {
            return new Articulo();
        }

        public override void ValidarDatos(Articulo dominio)
        {
            if (dominio.Codigo.Trim() == "")
            {
                throw new Exception("El Código del Artículo es obligatorio");
            }
            if (dominio.Nombre.Trim() == "")
            {
                throw new Exception("El Nombre del Artículo es obligatorio");
            }
        }
    }
}
