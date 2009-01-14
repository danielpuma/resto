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
        public Mesa GetNuevo()
        {
            Mesa m = new Mesa();
            m.Ocupada = false;
            m.SolicitarCantidadOcupantes = false;
            m.Fila = -1;
            m.Columna = -1;
            return m;
        }
        public static bool EstaOcupada(Int32 IdMesa)
        {
            BBPedido BBP = new BBPedido();
            if (BBP.GetPedidoPendientePorMesa(IdMesa) != null)
                return true;
            else
                return false;
        }
    }
}
