using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.Core;

namespace FastFood.Core
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FastFood.Core.ComposicionArticulo))]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(FastFood.Core.ComposicionArticulo))]
    public class ComposicionArticulo:DomainObject
    {
        private Articulo _ArticuloPadre;
        public virtual Articulo ArticuloPadre
        {
            get { return _ArticuloPadre; }
            set { _ArticuloPadre = value; }
        }

        private Articulo _ArticuloComponente;
        public virtual Articulo ArticuloComponente
        {
            get { return _ArticuloComponente; }
            set { _ArticuloComponente = value; }
        }

        private decimal _Cantidad;
        public virtual decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

    }
}
