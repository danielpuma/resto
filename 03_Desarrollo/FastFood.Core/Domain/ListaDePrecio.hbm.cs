﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.Collections.Generic;
using FSO.NH.ClasesBase.Core;
namespace FastFood.Core {
    
    
    [System.SerializableAttribute()]
    public class AbstractListaDePrecio : Parametro {

        private bool _Predeterminado;

        public virtual bool Predeterminado
        {
            get { return _Predeterminado; }
            set { _Predeterminado = value; }
        }


        private IList<PrecioArticulo> precioArticulo;
        public virtual IList<PrecioArticulo> PrecioArticulo
        {
            get
            {
                return this.precioArticulo;
            }
            set
            {
                this.precioArticulo = value;
            }
        }
    }
    
    [System.SerializableAttribute()]
    public partial class ListaDePrecio : AbstractListaDePrecio {
    }
}
