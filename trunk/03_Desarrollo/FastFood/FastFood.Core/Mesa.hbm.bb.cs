using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.bb;

namespace FastFood.Core
{
    public class BBMesa : FNegocio<Mesa>, IGenericDao<Mesa, Int32>, IFSOComboDataSource
    {
        public void Guardar(Mesa Obj)
        {
            Obj.SubTipo = "Mesa";
            base.PersistirDatos(Obj);
        }
        public override void Validar(Mesa dominio)
        {
            BBParametro BBP = new BBParametro();
            BBP.Validar((Parametro)dominio);
        }




    }
}
