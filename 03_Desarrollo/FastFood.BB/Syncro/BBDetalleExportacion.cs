using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.bb;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using System.Collections;
using FSO.NH.Core;
using FSO.NH.ClasesBase.Core;
using FSO_NH.log4Net;
using NHibernate.Criterion;

namespace FastFood.BB.Syncro
{
    public class BBDetalleExportacion : FNegocio<DetalleExportacion>, IGenericDao<DetalleExportacion, Int32>, IFSOComboDataSource
    {
        public override void ValidarDatos(DetalleExportacion dominio)
        {
         
        }


        private DetalleExportacion GetExportLog(DomainObject obj, Exportacion MyExp)
        {
            DetalleExportacion logExp = new DetalleExportacion();
            logExp.Exportacion = MyExp;
            logExp.Identificador = obj.ID;
            logExp.Objeto = obj.GetType().ToString();
            return logExp;
        }

        internal void MarcarParaReexportar(DomainObject dominio)
        {
            try
            {
                DetalleExportacion MyDet = GetFilteredByObject(dominio);
                this.Delete(MyDet);
            }
            catch(Exception ex) 
            {
                FSOLog4Net.LogError("Error al marcar para exportar: " + ex.Message);
            }
        }
        public DetalleExportacion GetFilteredByObject(DomainObject obj)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();

            ICriterion Filtro1 = Expression.Eq("Objeto", obj.GetType().ToString());
            ICriterion Filtro2 = Expression.Eq("Identificador", obj.ID);
            filtrosActivos.Add(Filtro1);
            filtrosActivos.Add(Filtro2);

                List<DetalleExportacion> det =  this.GetAll(filtrosActivos);
                if (det.Count == 1)
                {
                    return det[0];
                }
                else {
                    if(det.Count>1)
                        throw new FSOException("Hay más de un registro de exportación para el mismo objeto");
                    else
                        throw new FSOException("Objecto No Exportado");
                }

        }





        public void ExportarClientes(List<Cliente> list, Exportacion MyExp)
        {
            foreach (Cliente Objecto in list)
            {
                Guardar(GetExportLog(Objecto, MyExp));
            }
        }



        public void ExportarTipoDoc(List<Tipo_Documento> list, Exportacion MyExp)
        {
            foreach (Parametro Objecto in list)
            {
                Guardar(GetExportLog((Parametro)Objecto, MyExp));
            }
        }



        public void ExportarListaDePrecio(List<ListaDePrecio> list, Exportacion MyExp)
        {
            foreach (ListaDePrecio Objecto in list)
            {
                Guardar(GetExportLog(Objecto, MyExp));
            }
        }

    }
}
