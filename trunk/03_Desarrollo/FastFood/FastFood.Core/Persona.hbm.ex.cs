using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using FSO_NHDATA;
using NHibernate.Expression;
using FSO_NH.UserInterfaz;

namespace FastFood.Core
{
    public partial  class Personal
    {
        private static BBPersonal BB = new BBPersonal();
        public new void Guardar()
        {
            BB.Guardar(this);
        }

        public void Eliminar()
        {
            BB.Delete(this);
        }
        public static void DeleteByID(Int32 ID)
        {            
            BB.BorrarDatos(ID);
        }
        public new static Personal GetById(Int32 ID)
        {
            return BB.GetById(ID, true);
        }
        public static List<Personal> GetAll()
        {
            return BB.GetAll();
        }
        public static IList GetAllList()
        {
            return BB.GetAllList();

        }
        public static IFSOComboDataSource GetFSODataSource()
        {
            return (IFSOComboDataSource)BB;
        }

        public static List<Personal> OrdenarColeccion(List<Personal> Lista, string Propiedad, SortDirection Direccion)
        {
            return BBPersonal.SortCollection(Lista, Propiedad, Direccion);
        }
        public static List<ICriterion> GetFiltrosFromString(string Filtros)
        {
            return BBPersonal.GetFiltrosFromString(Filtros);
        }
    }
}
