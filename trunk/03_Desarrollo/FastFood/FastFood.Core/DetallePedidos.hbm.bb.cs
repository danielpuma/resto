using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.bb;

namespace FastFood.Core
{
    public class BBDetallePedidos: FNegocio<DetallePedidos>, IGenericDao<DetallePedidos, Int32>, IFSOComboDataSource
    {
        public void Guardar(DetallePedidos Obj)
        {
            base.PersistirDatos(Obj);
        }
        public override void  Validar(DetallePedidos dominio)
        {
        }
    }
}
