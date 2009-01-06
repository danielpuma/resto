using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FastFood.BB.CoreExtension;
using FSO.NH.Seguridad.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.BB.SupportClass;
using FSO_NH.log4Net;
using NHibernate.Criterion;

namespace FastFood.BB.Syncro
{
    public class BBDatosImportacion : FNegocio<DatosImportacion>, IGenericDao<DatosImportacion, Int32>, IFSOComboDataSource
    {
        internal List<DatosImportacion> GetBySucursalTipoIdDestino(int IdSucursalOrigen, string TipoDeObjeto, int IdDestino)
        {
            List<ICriterion> Filtros = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("IdSucursalOrigen", IdSucursalOrigen);
            ICriterion f2 = Expression.Eq("Objeto", TipoDeObjeto);
            ICriterion f3 = Expression.Eq("IdentificadorLocal", IdDestino);
            Filtros.Add(f1);
            Filtros.Add(f2);
            Filtros.Add(f3);
            return this.GetAll(Filtros);

        }
    }
}
