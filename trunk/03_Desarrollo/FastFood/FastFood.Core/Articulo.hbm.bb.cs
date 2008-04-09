using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.bb;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;

namespace FastFood.Core
{
    public class BBArticulo : FNegocio<Articulo>, IGenericDao<Articulo, Int32>, IFSOComboDataSource
    {
        public void Guardar(Articulo Obj)
        {
            Obj.SubTipo = "Articulo";
            base.PersistirDatos(Obj);
        }
        public override void Validar(Articulo Obj)
        {
            BBParametro BBP = new BBParametro("Articulo");
            BBP.Validar((Parametro)Obj);
        }
    }
}
