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
namespace FastFood.Core {
    
    
    [System.SerializableAttribute()]
    public class AbstractDetalleExportacion:DomainObject {
        

        
        private string objeto;
        
        private int identificador;
        
        private FastFood.Core.Exportacion exportacion;
        

        
        public virtual string Objeto {
            get {
                return this.objeto;
            }
            set {
                this.objeto = value;
            }
        }
        
        public virtual int Identificador {
            get {
                return this.identificador;
            }
            set {
                this.identificador = value;
            }
        }
        
        public virtual FastFood.Core.Exportacion Exportacion {
            get {
                return this.exportacion;
            }
            set {
                this.exportacion = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public partial class DetalleExportacion : AbstractDetalleExportacion {
    }
}