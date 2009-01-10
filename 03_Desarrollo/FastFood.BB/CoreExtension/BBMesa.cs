using System;
using System.Collections.Generic;
using System.Text;
using FastFood.Core;
using FSO.NH.bb;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;

namespace FastFood.BB.CoreExtension
{
    public class BBMesa : FNegocio<Mesa>, IGenericDao<Mesa, Int32>, IFSOComboDataSource
    {
    }
}
