using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using FastFood.Core;
using FSO.NH.ClasesBase.Core;
using FastFood.BB.CoreExtension;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using FSO.NH.ClasesBase.BB;
using FSO_NH.log4Net;


namespace FastFood.BB.Syncro
{
    public class BBExportadorDeDatos
    {
        BBExportacion BBEX;
        BBDetalleExportacion BBDETEX;
        Exportacion MyObject;
        public BBExportadorDeDatos()
        {
            BBEX = new BBExportacion();
            BBDETEX = new BBDetalleExportacion();
            MyObject = new Exportacion();
        }
        private void GuardarExportacion(ArrayList ListadoExportacion)
        {
            BBEX.Guardar(MyObject);
            BBDETEX.ExportarClientes((List<Cliente>)ListadoExportacion[5], MyObject);
            BBDETEX.ExportarTipoDoc((List<Tipo_Documento>)ListadoExportacion[8], MyObject);
            BBDETEX.ExportarListaDePrecio((List<ListaDePrecio>)ListadoExportacion[11], MyObject);
        }
        public ArrayList Exportar(bool ExportarTodo)
        {
            if (!ExportarTodo)
            {
                BBEX.DeleteAll();
                MyObject = new Exportacion();
                MyObject.FechaCreacion = DateTime.Now;
            }

            ArrayList ListadoExportacion = new ArrayList();
//          BBSucursal BBS = new BBSucursal();

            if (MyObject.ID == 0)
            {
                MyObject.FechaCreacion = DateTime.Today;

            }



            #region Obtener Datos A Exportar
//            Sucursal MySucursal = BBS.GetSucursalActiva();
            //ListadoExportacion.Add(MySucursal);
            ExportCliente(ref ListadoExportacion);
            ExportTipoDocumento(ref ListadoExportacion);
            ExportListaDePrecio(ref ListadoExportacion);
            #endregion




            GuardarExportacion(ListadoExportacion);


            return ListadoExportacion;
        }

        private void ExportCliente(ref ArrayList ListadoExportacion)
        {

            try
            {
                BBCliente BBT = new BBCliente();
                List<Cliente> AExportar = BBT.GetObjetosAExportar(MyObject);
                ListadoExportacion.Add(AExportar);
            }
            catch (Exception ex)
            {
                throw new FSOException(ex);
            }

        }
        private void ExportTipoDocumento(ref ArrayList ListadoExportacion)
        {

            try
            {
                BBTipoDeDocumento BBT = new BBTipoDeDocumento();
                List<Tipo_Documento> AExportar = BBT.GetObjetosAExportar(MyObject);
                ListadoExportacion.Add(AExportar);
            }
            catch (Exception ex)
            {
                throw new FSOException(ex);
            }

        }
        private void ExportListaDePrecio(ref ArrayList ListadoExportacion)
        {
            try
            {
                BBListaDePrecio BBLDP = new BBListaDePrecio();
                List<ListaDePrecio> AExportar = BBLDP.GetObjetosAExportar(MyObject);
                ListadoExportacion.Add(AExportar);
            }
            catch (Exception ex)
            {
                throw new FSOException(ex);
            }
        }
    }
}
