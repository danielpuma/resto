﻿using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FastFood.Core.Domain;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FastFood.Core;
using NHibernate.Criterion;
using NHibernate;

namespace FastFood.BB.CoreExtension
{
    public class BBMovimientoStockDetalle : FNegocio<MovimientoStockDetalle>, IGenericDao<MovimientoStockDetalle, Int32>, IFSOComboDataSource
    {
        public IList<MovimientoStockDetalle> GetByArticuloFecha(int IdArticulo, DateTime Desde, DateTime Hasta)
        {
            try
            {
                IQuery query = Session.GetNamedQuery("spConsultaDetalleStockPorArticuloFecha");
                query.SetInt32("xID", IdArticulo);
                query.SetDateTime("FechaDesde", new DateTime(Desde.Year,Desde.Month, Desde.Day));
                query.SetDateTime("FechaHasta", new DateTime(Hasta.Year, Hasta.Month, Hasta.Day).AddMinutes(1439));
                return query.List<MovimientoStockDetalle>();
            }
            catch (Exception ex)
            {
                string a = ex.Message;
                throw;
            }
        }
    }
}
