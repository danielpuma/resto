using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.bb;
using FastFood.Core;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.UserInterfaz;

namespace FastFood.BB.CoreExtension
{
    public class BBGrupoArticulo : FNegocio<GrupoArticulo>, IGenericDao<GrupoArticulo, Int32>, IFSOComboDataSource
    {
    }
}
