using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using NHibernate.Expression;
using FSO_NHDATA;
using FSO_NH.UserInterfaz;

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
        public static void DeleteByID(Int32 ID)
        {
            BB.BorrarDatos(ID);
        }
        public new static Mesa GetById(Int32 ID)
        {
            return BB.GetById(ID, true);
        }
        public static List<Mesa> GetAll()
        {
            return BB.GetAll();
        }
        public static List<Mesa> GetAllActive()
        {
            return BB.GetAllActive();
        }
        public static IList GetAllList()
        {
            return BB.GetAllList();            
        }
        public static IFSOComboDataSource GetFSODataSource()
        {
            return (IFSOComboDataSource)BB;
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
