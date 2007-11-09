using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using FSO_NH.Core;


namespace FSO_NH.UserInterfaz
{
    public interface IFSOComboDataSource
    {                
        IList GetDataSource(string Filtros);
    }
}
