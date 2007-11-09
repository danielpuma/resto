using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.Core;
using FSO_NHDATA;
using System.Collections;
using NHibernate.Expression;

namespace FastFood.Core
{
    public partial class Articulo
    {

        private static BBArticulo BBA = new BBArticulo();
        public new  void Guardar()
        {
            BBA.Guardar(this);
        }

        public void Eliminar()
        {
            BBA.Delete(this);
        }

        public new static Articulo GetById(Int32 ID)
        {            
            return BBA.GetById(ID, true);            
        }
        public static List<Articulo> GetAll()
        {
            return BBA.GetAll();            
        }
        public static IList GetAllList()
        {
            return BBA.GetAllList();
        }

        public static List<Articulo> OrdenarColeccion(List<Articulo> Lista, string Propiedad, SortDirection Direccion)
        {
            return BBArticulo.SortCollection(Lista, Propiedad, Direccion);
        }
        public static List<ICriterion> GetFiltrosFromString(string Filtros)
        {
            return BBArticulo.GetFiltrosFromString(Filtros);
        }
    }
}
