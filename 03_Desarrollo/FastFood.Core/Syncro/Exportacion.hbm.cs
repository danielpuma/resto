﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FSO.NH.Core;
using System.Collections.Generic;
namespace FastFood.Core {
    
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FastFood.Core.DetalleExportacion))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(FastFood.Core.DetalleExportacion))]
    public class AbstractExportacion:DomainObject {
        

        private System.DateTime fechaCreacion;

        private IList<DetalleExportacion> detalleExportacion;
        

        
        public virtual System.DateTime FechaCreacion {
            get {
                return this.fechaCreacion;
            }
            set {
                this.fechaCreacion = value;
            }
        }

        public virtual IList<DetalleExportacion> DetalleExportacion
        {
            get {
                return this.detalleExportacion;
            }
            set {
                this.detalleExportacion = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public partial class Exportacion : AbstractExportacion {
    }
}
