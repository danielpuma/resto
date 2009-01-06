using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using NHibernate.Criterion;
using FSO_NH.log4Net;


namespace FastFood.BB.CoreExtension
{
    public class BBNumerador : FNegocio<Numerador>, IGenericDao<Numerador, Int32>, IFSOComboDataSource
    {
        public int TomarProximoNumero(TipoNumerador IdNumerador)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("ID", Convert.ToInt32(IdNumerador));
            filtrosActivos.Add(f1);
            IList<Numerador> X = this.GetAll(filtrosActivos);
            int rta = 0;
            if (X.Count == 1)
            {
                rta = X[0].ProximoNumero;
                X[0].ProximoNumero++;
                Save(X[0]);
                return rta;
            }
            else {
                throw new FSOException("El Numerador seleccionado no existe");
            }
        }
    }
    public enum TipoNumerador
    { 
       Trabajo=1, Presupuesto
    }
}
