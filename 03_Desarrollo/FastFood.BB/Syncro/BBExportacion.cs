using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.bb;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;
using FastFood.BB.CoreExtension;
using FSO_NH.log4Net;
using NHibernate.Criterion;

namespace FastFood.BB.Syncro
{
    public class BBExportacion : FNegocio<Exportacion>, IGenericDao<Exportacion, Int32>, IFSOComboDataSource
    {
        public List<Exportacion> GetFiltered(DateTime? FechaDesde, DateTime? FechaHasta)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion DesdeHasta = (ICriterion) GetRangoDeFechas("FechaCreacion", FechaDesde, FechaHasta);


            filtrosActivos.Add(DesdeHasta);
            try
            {
                return SortCollection(this.GetAll(filtrosActivos), "FechaCreacion", FSO.NHDATA.SortDirection.Ascending);
            }
            catch (Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Exportacion: " + ex.Message);
                return SortCollection(this.GetAll(), "FechaCreacion", FSO.NHDATA.SortDirection.Ascending);
            }
        }
        public void DeleteAll()
        {
            getSession().Delete("from DetalleExportacion");
            getSession().Delete("From Exportacion");
            getSession().Flush();

        }
    }
}
