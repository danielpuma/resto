using System;
using System.Collections.Generic;
using System.Text;
using FSO.NH.UserInterfaz;
using FSO.NHDATA.DataInterfaces;
using FSO.NH.bb;
using FastFood.Core;

namespace FastFood.BB.CoreExtension
{
    public class BBPedido : FNegocio<Pedido>, IGenericDao<Pedido, Int32>, IFSOComboDataSource
    {
        public override void ValidarDatos(Pedido dominio)
        {
            dominio.FechaCarga = DateTime.Now;
        }
        public Pedido getNuevo()
        {
            Pedido p = new Pedido();
            p.FechaContable = DateTime.Now;
            p.Pendiente = true;
            return p;
        }
    }
}
