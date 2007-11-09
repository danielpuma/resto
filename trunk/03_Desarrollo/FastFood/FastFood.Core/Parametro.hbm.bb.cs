using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.bb;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.Core;

namespace FastFood.Core
{
    public class BBParametro : FNegocio<Parametro>, IGenericDao<Parametro, Int32>, IFSOComboDataSource
    {
        public void Guardar(Parametro Obj)
        {            
            
        }
        public override void Validar(Parametro Obj)
        {
            
            if (Obj.Codigo.Trim() == "")
            {
                throw new Exception("El C�digo no puede estar vac�o");
            }
            if (Obj.Descripcion.Trim() == "")
            {
                throw new Exception("La Descripci�n no puede estar vac�a");
            }
        }
    }
}
