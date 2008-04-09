using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.bb;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.Core;
using NHibernate.Expression;

namespace FastFood.Core
{
    public class BBParametro : FNegocio<Parametro>, IGenericDao<Parametro, Int32>, IFSOComboDataSource
    {
        private string SubTipo;
        public BBParametro(String pSubTipo)
        {
            SubTipo = pSubTipo;
        }
        public void Guardar(Parametro Obj)
        {   
        }
        public override void Validar(Parametro Obj)
        {
            
            if (Obj.Codigo.Trim() == "")
            {
                throw new Exception("El Código no puede estar vacío");
            }
            if (Obj.Descripcion.Trim() == "")
            {
                throw new Exception("La Descripción no puede estar vacía");
            }
        }
        public List<Parametro> GetFiltered(String Codigo, String Descripcion)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f1 = Expression.Eq("SubTipo", SubTipo);
            filtrosActivos.Add(f1);

            if (Codigo == "" && Descripcion == "")
            {
                return base.GetAll(filtrosActivos);
            }
            if (Codigo != "")
            {
                ICriterion f2 = Expression.InsensitiveLike("Codigo", Codigo, MatchMode.Start);
                filtrosActivos.Add(f2);
            }
            if (Descripcion != "")
            {
                ICriterion f3 = Expression.InsensitiveLike("Descripcion", Descripcion, MatchMode.Start);
                filtrosActivos.Add(f3);
            }

            return this.GetAll((filtrosActivos));

        }
        public Parametro GetByCodigo(string Codigo)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f1 = Expression.Eq("SubTipo", SubTipo);
            filtrosActivos.Add(f1);

            ICriterion f2 = Expression.Eq("Codigo", Codigo);
            filtrosActivos.Add(f2);

            List<Parametro> p = this.GetAll((filtrosActivos));
            if (p.Count > 0)
                return p[0];
            else
                return null;

        }
        public void ValidarDatos(Parametro dominio)
        {
            if (dominio.Codigo.Trim() == "")
                throw new Exception("El Código Ingresado es inválido");
            if (dominio.Descripcion.Trim() == "")
                throw new Exception("La Descripción Indicada es Inválida");

            List<Parametro> LstParam;
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion f1 = Expression.Eq("Codigo", dominio.Codigo);
            ICriterion f2 = Expression.Eq("SubTipo", dominio.SubTipo);
            filtrosActivos.Add(f1);
            filtrosActivos.Add(f2);
            LstParam = base.GetAll(filtrosActivos);
            if (LstParam.Count > 0)
            {
                if (LstParam[0].ID != dominio.ID)
                    throw new Exception("El Código ingresado ya existe");
            }

        }
    }
}
