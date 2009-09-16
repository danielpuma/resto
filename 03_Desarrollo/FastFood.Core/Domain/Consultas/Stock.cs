using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.Core;

namespace FastFood.Core.Domain.Consultas
{
    public class Stock:DomainObject
    {
        private decimal _Stock;

        public virtual decimal MyStock
        {
            get { return _Stock; }
            set { _Stock = value; }
        }
    }
}
