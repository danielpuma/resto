using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using NHibernate.Expression;
using FSO_NHDATA;

namespace FastFood.Core
{
    public partial class Mesa
    {
        private static BBMesa BB = new BBMesa();
        public new void Guardar()
        {
            BB.Guardar(this);
        }

        public void Eliminar()
        {
            BB.Delete(this);
        }

        public new static Mesa GetById(Int32 ID)
        {
            return BB.GetById(ID, true);
        }
        public static List<Mesa> GetAll()
        {
            return BB.GetAll();
        }
        public static IList GetAllList()
        {
            return BB.GetAllList();
            
        }


        public static List<Mesa> OrdenarColeccion(List<Mesa> Lista, string Propiedad, SortDirection Direccion)
        {
            return BBMesa.SortCollection(Lista, Propiedad, Direccion);
        }
        public static List<ICriterion> GetFiltrosFromString(string Filtros)
        {
            return BBMesa.GetFiltrosFromString(Filtros);
        }
    }
}
