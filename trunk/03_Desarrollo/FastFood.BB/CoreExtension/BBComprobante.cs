using System;
using System.Collections.Generic;
using System.Text;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;
using FastFood.Core;
using FSO.NH.bb;
using NHibernate.Criterion;

namespace FastFood.BB.CoreExtension
{
    public class BBComprobante : FNegocio<Comprobante>, IGenericDao<Comprobante, Int32>, IFSOComboDataSource
    {
        public override void BorrarDatos(int pId)
        {
            Comprobante C = GetById(pId,false);

            if (C!=null && C.Codigo != "P")
            {
                base.BorrarDatos(pId);
            }
            else {
                throw new Exception("No es posible eliminar este comprobante");
            }

        }
        public Comprobante GetByCodigo(string p)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("Codigo", "P");
            List<Comprobante> l = this.GetAll(filtrosActivos);
            if (l.Count > 0)
                return l[0];
            else
                throw new Exception("No se encuentra el Comprobante correspondiente a los pedidos, la aplicación no puede continuar");

        }
    }
}
