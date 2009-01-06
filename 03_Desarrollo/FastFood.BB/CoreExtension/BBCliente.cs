using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.Core;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FSO.NH.ClasesBase.Core;
using FSO.NH.Data;
using FSO.NH.ClasesBase.BB;
using FSO_NH.log4Net;
using FastFood.BB.Syncro;
using NHibernate.Criterion;



namespace FastFood.BB.CoreExtension
{
    public class BBCliente : FNegocio<Cliente>, IGenericDao<Cliente, Int32>, IFSOComboDataSource
    {


        public override void ValidarDatos(Cliente dominio)
        {
            BBPersona.ValidarDatos((Persona)dominio);
            if (dominio.ID > 0)
            {
                MarcarParaReexportar(dominio);
            }
            List<Cliente> MyList = GetFiltered(dominio.NumeroDocumento, 0, "", "", "",null, null);
            if (MyList.Count > 0)
            {
                if(MyList[0].ID != dominio.ID)
                    throw new FSOException("Ya existe una Persona con Documento Número: " + dominio.NumeroDocumento);
            }
            if (dominio.Telefonos==null || dominio.Telefonos == "")
            {
                throw new FSOException("Debe Ingresar algún dato telefónico ");
            }
            if (dominio.Direccion == null || dominio.Direccion == "")
            {
                throw new FSOException("Debe Ingresar algún dato de dirección ");
            }

        }
        private void MarcarParaReexportar(Cliente dominio)
        {
            BBDetalleExportacion BBEx = new BBDetalleExportacion();
            BBEx.MarcarParaReexportar(dominio);
        }
        public List<Cliente> GetFiltered(String Documento, int IdTipoDocumento, string Nombre, string Apellido, string RazonSocial, DateTime? FechaNacimientoDesde, DateTime? FechaNacimientoHasta)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();


            string _Documento = Documento.ToUpper().Trim();
            string _Nombre = Nombre.ToUpper().Trim();
            string _Apellido = Apellido.ToUpper().Trim();
            string _RazonSocial = RazonSocial.ToUpper().Trim();
            if (_Documento != "")
            {
                ICriterion f1 = Expression.InsensitiveLike("NumeroDocumento", _Documento, MatchMode.Start);
                filtrosActivos.Add(f1);
            }
            if (_Nombre != "")
            {
                ICriterion f2 = Expression.InsensitiveLike("Nombre", _Nombre, MatchMode.Start);
                filtrosActivos.Add(f2);
            }
            if (_Apellido != "")
            {
                ICriterion f3 = Expression.InsensitiveLike("Apellido", _Apellido, MatchMode.Start);
                filtrosActivos.Add(f3);
            }
            if (_RazonSocial != "")
            {
                ICriterion f4 = Expression.InsensitiveLike("RazonSocial", _RazonSocial, MatchMode.Start);
                
                if (_RazonSocial == "")
                {
                    ICriterion f5 = Expression.Eq("RazonSocial", null);
                    filtrosActivos.Add( Expression.Or(f4,f5) );
                }
                else {
                    filtrosActivos.Add(f4);
                }
            }
            if (IdTipoDocumento > 0)
            {
                ICriterion f5 = Expression.Eq("MiTipoDeDocumento.ID", IdTipoDocumento);
                filtrosActivos.Add(f5);
            }

            filtrosActivos.Add(GetRangoDeFechas("FechaNacimiento",FechaNacimientoDesde, FechaNacimientoHasta));

            try
            {
                return SortCollection(this.GetAll((filtrosActivos)), "NombreCompleto", FSO.NHDATA.SortDirection.Ascending);
            }
            catch(Exception ex)
            {
                FSOLog4Net.LogDebug("Error Al Buscar Cliente: " + ex.Message);
                return SortCollection(this.GetAll(), "NombreCompleto", FSO.NHDATA.SortDirection.Ascending);
            }
        }




        public List<Cliente> GetObjetosAExportar(Exportacion MyObject)
        {

            String ssql;
            String ssqlInner;

            ssql = "IdCliente not in (@InnerSQL)";
            ssqlInner = "Select Identificador from DetalleExportacion where Objeto = '" + typeof(Cliente).ToString() + "'";
            
            String sqlfinal = ssql.Replace("@InnerSQL", ssqlInner);
            return GetAll(null, sqlfinal, null, null, null);
        }

        public Cliente GetByCodigo(Tipo_Documento tipo_Documento, string NumeroDocumento)
        {
            List<ICriterion> filtrosActivos = new List<ICriterion>();
            ICriterion f1 = Expression.Eq("MiTipoDeDocumento", tipo_Documento);
            filtrosActivos.Add(f1);
            ICriterion f2 = Expression.Eq("NumeroDocumento", NumeroDocumento);
            filtrosActivos.Add(f2);
            List<Cliente> det = this.GetAll(filtrosActivos);
            if (det.Count > 0)
                return det[0];
            else
                return null;
        }
    }
}
