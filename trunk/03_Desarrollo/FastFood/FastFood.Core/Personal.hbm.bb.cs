using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.bb;

namespace FastFood.Core
{
    public class BBPersonal : FNegocio<Personal>, IGenericDao<Personal, Int32>, IFSOComboDataSource
    {
        public void Guardar(Personal Obj)
        {
            Obj.SubTipo = "Personal";
            base.PersistirDatos(Obj);
        }
        public override void Validar(Personal dominio)
        {
            BBParametro BBP = new BBParametro("Personal");
            BBP.Validar((Parametro)dominio);
        }

    }
}
