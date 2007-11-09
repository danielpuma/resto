using System;
using System.Collections.Generic;
using System.Text;
using FSO_NH.UserInterfaz;
using FSO_NHDATA.DataInterfaces;
using FSO_NH.bb;

namespace FastFood.Core
{
    public class BBPedido : FNegocio<Pedido>, IGenericDao<Pedido, Int32>, IFSOComboDataSource
    {
        public void Guardar(Pedido Obj)
        {
            base.PersistirDatos(Obj);
        }
        public override void Validar(Pedido dominio)
        {
        }
    }
}
