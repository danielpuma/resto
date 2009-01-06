using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using FastFood.Core;
using FSO.NH.ClasesBase.Core;
using FastFood.BB.CoreExtension;
using FSO.NH.ClasesBase.BB;
using FSO.NH.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.Seguridad.Core;
using FSO_NH.log4Net;

namespace FastFood.BB.Syncro
{
    public delegate void ProgressController(int CantidadAImportar, int CantidadImportada);
    public class BBImportadorDeDatos
    {
        public event ProgressController ObjetoImportado;

        BBDatosImportacion BBDI;
        private int CantidadDeObjetosAImportar;
        private int CantidadDeObjetosImportados;
        
        public void ImportarDatos(ArrayList DatosAImportar)
        {
            CantidadDeObjetosAImportar = 0;
            CantidadDeObjetosImportados = 0;
            BBDI = new BBDatosImportacion();
            IList<Cliente> _Clientes = new List<Cliente>();
            IList<Tipo_Documento> _TipoDocumento = new List<Tipo_Documento>();
            IList<ListaDePrecio> _ListaDePrecio = new List<ListaDePrecio>();
            
            _Clientes = (IList<Cliente>)DatosAImportar[5];
            _TipoDocumento = (IList<Tipo_Documento>)DatosAImportar[8];
            _ListaDePrecio = (IList<ListaDePrecio>)DatosAImportar[11];
            CantidadDeObjetosAImportar = _Clientes.Count +
                                         _TipoDocumento.Count +
                                         _ListaDePrecio.Count;
            ImportarTiposDocumento(_TipoDocumento);
            ImportarListasDePrecios(_ListaDePrecio);
            ImportarClientes(_Clientes);
            
            
        }
        private void ImportarListasDePrecios(IList<ListaDePrecio> _ListaDePrecio)
        {
            foreach (ListaDePrecio ObjOrigen in _ListaDePrecio)
            {
                ImportarLista(ObjOrigen);
                DisparaEvento();
            } 
        }
        private void ImportarLista(ListaDePrecio ObjOrigen)
        {
            try
            {
                if (ObjOrigen != null)
                {
                    BBListaDePrecio BBO = new BBListaDePrecio();
                    ListaDePrecio Nuevo = BBO.GetByCodigo(ObjOrigen.Codigo);
                    if (Nuevo == null)
                    {
                        Nuevo = new ListaDePrecio();
                        Nuevo.ID = 0;
                    }
                    else
                    {
                        if (Nuevo.FechaGrabacion > ObjOrigen.FechaGrabacion)
                        {
                            return;
                        }
                    }
                    ObjOrigen.CopyTo((Parametro)Nuevo);                    
                    Nuevo.FechaGrabacion = DateTime.Now;
                    int Id = BBO.Guardar(Nuevo);
                    GuardarDatosImportacion(ObjOrigen, Id);
                }
            }
            catch
            {
            }
        }

        private void ImportarUsuario(FSO.NH.Seguridad.Core.Usuario ObjOrigen)
        {
            BBUsuario BBO = new BBUsuario();
            Usuario Nuevo = new BBUsuario().GetByCodigo(ObjOrigen.MiTipoDeDocumento, ObjOrigen.NumeroDocumento);
            if (Nuevo == null)
            {
                Nuevo = new Usuario();
            }
            else
            {
                if (Nuevo.FechaGrabacion > ObjOrigen.FechaGrabacion)
                {
                    return;
                }
            }
            ObjOrigen.MiTipoDeDocumento = new BBTipoDeDocumento().GetByCodigo(ObjOrigen.MiTipoDeDocumento.Codigo);
            ObjOrigen.CopyTo(Nuevo);
            Nuevo.FechaGrabacion = DateTime.Now;
            int Id = BBO.Guardar(Nuevo);
            GuardarDatosImportacion(ObjOrigen, Id);
        }
    
        private void ImportarClientes(IList<Cliente> Listado)
        {
            foreach (Cliente ObjOrigen in Listado)
            {
                ImportarCliente(ObjOrigen);
                DisparaEvento();
            } 
        }
        private void ImportarCliente(Cliente ObjOrigen)
        {
            try
            {
                BBCliente BBO = new BBCliente();
                ImportarTipoDocumento(ObjOrigen.MiTipoDeDocumento);
                ObjOrigen.MiTipoDeDocumento = new BBTipoDeDocumento().GetByCodigo(ObjOrigen.MiTipoDeDocumento.Codigo);
                Cliente Nuevo = BBO.GetByCodigo(ObjOrigen.MiTipoDeDocumento, ObjOrigen.NumeroDocumento);
                if (Nuevo == null)
                {
                    Nuevo = new Cliente();
                    Nuevo.NumeroDocumento = ObjOrigen.NumeroDocumento;
                    Nuevo.MiTipoDeDocumento = ObjOrigen.MiTipoDeDocumento;
                }
                else
                {
                    if (Nuevo.FechaGrabacion > ObjOrigen.FechaGrabacion)
                    {
                        return;
                    }
                }
                ObjOrigen.CopyTo(Nuevo);
                Nuevo.FechaGrabacion = DateTime.Now;
                int Id = BBO.Guardar(Nuevo);
                GuardarDatosImportacion(ObjOrigen, Id);
            }
            catch 
            {
            }
        }

        private void ImportarTiposDocumento(IList<Tipo_Documento> _Listado)
        {
            
            foreach (Tipo_Documento ObjOrigen in _Listado)
            {
                ImportarTipoDocumento(ObjOrigen);
                DisparaEvento();
            }
        }
        private void ImportarTipoDocumento(Tipo_Documento ObjOrigen)
        {
            if (ObjOrigen != null)
            {
                BBTipoDeDocumento BBO = new BBTipoDeDocumento();
                Tipo_Documento Nuevo = BBO.GetByCodigo(ObjOrigen.Codigo);
                if (Nuevo == null)
                {
                    Nuevo = new Tipo_Documento();
                    Nuevo.ID = 0;
                }
                else
                {
                    if (Nuevo.FechaGrabacion > ObjOrigen.FechaGrabacion)
                    {
                        return;
                    }
                }
                ObjOrigen.CopyTo((Parametro)Nuevo);
                Nuevo.FechaGrabacion = DateTime.Now;
                int Id = BBO.Guardar(Nuevo);
                GuardarDatosImportacion(ObjOrigen, Id);
            }
        }

        private void GuardarDatosImportacion(Object objOrigen, Int32 NuevoID)
        {
            
            DatosImportacion DI = new DatosImportacion();
            DI.IdentificadorLocal = NuevoID;
            DI.IdentificadorOrigen = ((DomainObject)objOrigen).ID;
            DI.IdExportacionOrigen = 1;
            //DI.IdSucursalOrigen = _Suc.ID;
            DI.Objeto = objOrigen.GetType().FullName;
            DI.FechaImportacion = DateTime.Now;
            string [] ListaCamposAIgnorar= new string[3];
            List<DatosImportacion> LDI = BBDI.GetBySucursalTipoIdDestino(DI.IdSucursalOrigen, DI.Objeto, DI.IdentificadorLocal);
            if (LDI !=null && LDI.Count == 0)
            {
                BBDI.Guardar(DI);
            }
            else {
                BBDI.EvictObject(DI);
            }
            
        }
        private void DisparaEvento()
        {
            CantidadDeObjetosImportados++;
            if (ObjetoImportado != null)
                ObjetoImportado(CantidadDeObjetosAImportar, CantidadDeObjetosImportados);

        }
    }
}
