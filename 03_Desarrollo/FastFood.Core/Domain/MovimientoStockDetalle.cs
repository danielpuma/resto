using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.Core;

namespace FastFood.Core
{
    public class MovimientoStockDetalle:DomainObject
    {
        private Articulo _MyArticulo;

        public virtual Articulo MyArticulo
        {
            get { return _MyArticulo; }
            set { _MyArticulo = value; }
        }
        private Articulo _MyArticuloPadre;

        public virtual Articulo MyArticuloPadre
        {
            get { return _MyArticuloPadre; }
            set { _MyArticuloPadre = value; }
        }
        private decimal _Cantidad;

        public virtual decimal Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        private bool _EsComponente;

        public virtual bool EsComponente
        {
            get { return _EsComponente; }
            set { _EsComponente = value; }
        }
        private int _IdMovimientoStock;

        public virtual int IdMovimientoStock
        {
            get { return _IdMovimientoStock; }
            set { _IdMovimientoStock = value; }
        }


    }
}
