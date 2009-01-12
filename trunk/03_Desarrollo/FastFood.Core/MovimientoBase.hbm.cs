﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FastFood.Core {
    
    
    [System.SerializableAttribute()]
    public class AbstractMovimientoBase {
        
        private int idMovimiento;
        
        private int numeroInterno;
        
        private bool activo;
        
        private System.DateTime fechaCarga;
        
        private System.DateTime fechaContable;
        
        private decimal totalFacturado;
        
        private System.DateTime? fechaAnulacion;
        
        private System.Int32? idUsuarioAnulacion;
        
        private FastFood.Core.Cliente cliente;
        
        private FastFood.Core.Comprobante comprobante;
        
        public virtual int IdMovimiento {
            get {
                return this.idMovimiento;
            }
            set {
                this.idMovimiento = value;
            }
        }
        
        public virtual int NumeroInterno {
            get {
                return this.numeroInterno;
            }
            set {
                this.numeroInterno = value;
            }
        }
        
        public virtual bool Activo {
            get {
                return this.activo;
            }
            set {
                this.activo = value;
            }
        }
        
        public virtual System.DateTime FechaCarga {
            get {
                return this.fechaCarga;
            }
            set {
                this.fechaCarga = value;
            }
        }
        
        public virtual System.DateTime FechaContable {
            get {
                return this.fechaContable;
            }
            set {
                this.fechaContable = value;
            }
        }
        
        public virtual decimal TotalFacturado {
            get {
                return this.totalFacturado;
            }
            set {
                this.totalFacturado = value;
            }
        }
        
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public virtual System.DateTime? FechaAnulacion {
            get {
                return this.fechaAnulacion;
            }
            set {
                this.fechaAnulacion = value;
            }
        }
        
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public virtual System.Int32? IdUsuarioAnulacion {
            get {
                return this.idUsuarioAnulacion;
            }
            set {
                this.idUsuarioAnulacion = value;
            }
        }
        
        public virtual FastFood.Core.Cliente Cliente {
            get {
                return this.cliente;
            }
            set {
                this.cliente = value;
            }
        }
        
        public virtual FastFood.Core.Comprobante Comprobante {
            get {
                return this.comprobante;
            }
            set {
                this.comprobante = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public partial class MovimientoBase : AbstractMovimientoBase {
    }
}