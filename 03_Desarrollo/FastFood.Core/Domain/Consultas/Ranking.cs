using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.Core;

namespace FastFood.Core.Domain.Consultas
{
    public class Ranking:DomainObject
    {
        private string _Codigo;

        public virtual string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        private string _Nombre;

        public virtual string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private decimal _TotalCantidad;

        public virtual decimal TotalCantidad
        {
            get { return _TotalCantidad; }
            set { _TotalCantidad = value; }
        }
        private decimal _TotalImporte;

        public virtual decimal TotalImporte
        {
            get { return _TotalImporte; }
            set { _TotalImporte = value; }
        }

    }
}
