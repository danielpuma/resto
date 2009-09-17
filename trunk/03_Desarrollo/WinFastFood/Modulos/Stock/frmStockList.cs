using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using FastFood.Core;
using ToolBox;
using WinFastFood.Modulos.Pedido;

namespace WinFastFood.Modulos.Stock
{
    public partial class frmStockList : Form, PrinteableForm
    {
        public frmStockList()
        {
            InitializeComponent();
        }

        private void frmStockList_Load(object sender, EventArgs e)
        {
            cboArticulo.SetComboBinding(new BBArticulo(), "", "");
            
            dtR.Hasta = DateTime.Now;
            dtR.Desde = DateTime.Now.AddDays(-30);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void BuscarDatos()
        {
            BBMovimientoStockDetalle BBMSD = new BBMovimientoStockDetalle();
            BBPedido BBP = new BBPedido();
            BBArticulo BBA = new BBArticulo();
            decimal SaldoStock = 0;
            dgDatos.Rows.Clear();

            if (cboArticulo.IdSelected > 0)
            {
                Articulo art = (Articulo)cboArticulo.ObjetoActual;
                if (!art.ManejaStock)
                {
                    MessageBox.Show("El Articulo seleccionado no maneja Stock");
                    return;
                }
                SaldoStock = BBA.GetStockCantidad(art, dtR.Desde.Value);
                lblStkIni.Text = SaldoStock.ToString("N2");
                lblStkFinal.Text = BBA.GetStockCantidad(art, dtR.Hasta.Value).ToString("N2");
                lblPDP.Text = art.PuntoDePedido.ToString("N2");
                IList<MovimientoStockDetalle> datos = BBMSD.GetByArticuloFecha(art.ID, dtR.Desde.Value, dtR.Hasta.Value);
                foreach (MovimientoStockDetalle msd in datos)
                {

                    Object[] MyDatos = new Object[8];
                    MyDatos[0] = msd.MyMovimientoStock.ID;
                    MyDatos[1] = msd.MyMovimientoStock.IdMovimientoExterno;
                    MyDatos[2] = msd.MyMovimientoStock.Ingreso ? "Ingreso" : "Egreso";
                    MyDatos[3] = msd.MyMovimientoStock.Fecha.ToString("dd/MM/yyyy");
                    if (msd.MyMovimientoStock.IdMovimientoExterno != 0)
                    {
                        MyDatos[4] = BBP.GetById(msd.MyMovimientoStock.IdMovimientoExterno, false).NumeroInterno.ToString();
                    }
                    else
                    {
                        MyDatos[4] = "N/A";
                    }
                    MyDatos[5] = msd.MyArticulo.Nombre;
                    MyDatos[6] = msd.Cantidad.ToString("N2");
                    if (msd.MyMovimientoStock.Ingreso)
                        SaldoStock += msd.Cantidad;
                    else
                        SaldoStock -= msd.Cantidad;
                    MyDatos[7] = SaldoStock.ToString("N2");
                    dgDatos.Rows.Add(MyDatos);

                }
            }
        }

        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return dgDatos; }
        }

        public string TituloImpresion
        {
            get { return "Movimientos de Stock"; }
        }

        #endregion

        private void dgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdMov = Convert.ToInt32(dgDatos.Rows[e.RowIndex].Cells[0].Value);
            frmStockAdmin f = new frmStockAdmin();
            f.IdMovimientoStock = IdMov;
            f.ShowDialog(this);
            BuscarDatos();
        }

        private void cmdEgresos_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedCells.Count > 0)
            {
                int IdMov = 0;
                frmStockAdmin f = new frmStockAdmin();
                f.IdMovimientoStock = IdMov;
                f.EsIngreso = false;
                f.ShowDialog(this);
                BuscarDatos();
            }
        }

        private void cmdIngresos_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedCells.Count > 0)
            {
                int IdMov = 0;
                frmStockAdmin f = new frmStockAdmin();
                f.IdMovimientoStock = IdMov;
                f.EsIngreso = true;
                f.ShowDialog(this);
                BuscarDatos();
            }
        }

        private void cmdVerPedido_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedCells.Count > 0)
            {
                int IdMov = Convert.ToInt32(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[0].Value);
                BBMovimientoStock BBMS = new BBMovimientoStock();
                MovimientoStock ms = BBMS.GetById(IdMov, false);
                if (ms.IdMovimientoExterno > 0)
                {
                    BBPedido BBP = new BBPedido();
                    FastFood.Core.Pedido p = BBP.GetById(ms.IdMovimientoExterno, false);
                    PedidoAdmin frmPed = new PedidoAdmin();
                    frmPed.MyObject = p;
                    frmPed.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("No existe un pedido asociado");
                }
            }
        }
    }
}