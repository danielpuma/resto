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
    public class AbstractNumerador {
        
        private int idNumerador;
        
        private int proximoNumero;
        
        public virtual int IdNumerador {
            get {
                return this.idNumerador;
            }
            set {
                this.idNumerador = value;
            }
        }
        
        public virtual int ProximoNumero {
            get {
                return this.proximoNumero;
            }
            set {
                this.proximoNumero = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public partial class Numerador : AbstractNumerador {
    }
}
