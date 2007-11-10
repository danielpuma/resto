using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.bb;
using System.Collections;
using NHibernate.Expression;

namespace FastFood.Core
{
    public class BBMesa : FNegocio<Mesa>, IGenericDao<Mesa, Int32>, IFSOComboDataSource
    {
        public void Guardar(Mesa Obj)
        {
            Obj.SubTipo = "Mesa";
            base.PersistirDatos(Obj);
        }
        public override void Validar(Mesa dominio)
        {
            BBParametro BBP = new BBParametro();
            BBP.Validar((Parametro)dominio);
        }

        public List<Mesa> GetAllActive()
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("EsBaja", false);
            filtrosActivos.Add(f1);
            return  GetAll(filtrosActivos);         
            

        }
        
    }
}
