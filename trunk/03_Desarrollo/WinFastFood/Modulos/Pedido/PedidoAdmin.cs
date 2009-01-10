using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BASE;
using FastFood.BB.CoreExtension;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.Core;

namespace WinFastFood.Modulos.Pedido
{
    public partial class PedidoAdmin : frmBase
    {
        public FastFood.Core.Pedido MyObject;
        public BBPedido MyBB;
        
        public PedidoAdmin()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            InicilizarLockUp();
            ControlDeSeguridad("Pedido", cmdGuardar, cmdGuardar);
            Cursor.Current = Cursors.Default;
        }
        public PedidoAdmin(Int32 IdCliente)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            InicilizarLockUp();
            fsoCliente.IdSelected = IdCliente;
            fsoCliente.Enabled = false;
            ControlDeSeguridad("Pedido", cmdGuardar, cmdGuardar);
            Cursor.Current = Cursors.Default;
        }
        private void InicilizarLockUp()
        {
            fsoArticulo.SetComboBinding(new BBArticulo(), "", "");
            fsoMozo.SetComboBinding(new BBUsuario(), "", "");
            fsoMozo.ObjetoActual = Win32Session.UsuarioActual;
            fsoListaPrecio.SetComboBinding(new BBListaDePrecio(), "", "");
            fsoMesa.SetComboBinding(new BBMesa(), "Ocupada", "False");
            fsoCliente.SetComboBinding(new BBCliente(), "", "");
            MyBB = new BBPedido();
            BBListaDePrecio BBL = new BBListaDePrecio();
            fsoListaPrecio.ObjetoActual = BBL.GetPredeterminada();
            txtCant.DecimalValue = 1;
        }

        private void PedidoAdmin_Load(object sender, EventArgs e)
        {

           if(MyObject==null)
               MyObject = MyBB.getNuevo();
            BindearDatos();
        }

            private void BindearDatos()
            {
 	            
            }



        private void chkCerrado_CheckedChanged(object sender, EventArgs e)
        {
            ManejarControles(chkCerrado.Checked);
        }

        private void ManejarControles(bool bCerrado)
        {
            txtPagaCon.Enabled = bCerrado;
            pblBody.Enabled = !bCerrado;
            chkImprimir.Enabled = bCerrado;
            chkImprimir.Checked = bCerrado;
            pnlHead.Enabled = !bCerrado;
        }



        private void AgregarArticuloActual()
        {
            try{
                DataGridViewRow dr = new DataGridViewRow();
                object[] Valores = new object[11];
                Valores[0] = 0;
                Valores[1] = fsoArticulo.IdSelected;
                Valores[2] = fsoListaPrecio.IdSelected;
                Valores[3] = txtPU.DecimalValue;
                Valores[4] = ((Articulo)fsoArticulo.ObjetoActual).MiCodigo;
                Valores[5] = ((Articulo)fsoArticulo.ObjetoActual).MiDescripcion;
                Valores[6] = txtPU.DecimalValue;
                Valores[7] = txtCant.Text;
                Valores[8] = txtTotalLinea.Text;
                Valores[9] =  global::WinFastFood.Properties.Resources._8printer24;
                Valores[10] = "1";
                dgCuerpo.Rows.Add(Valores);
                PrepararNuevoArticulo();
                CalcularTotalesPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void PrepararNuevoArticulo()
        {
            fsoArticulo.ObjetoActual = null;
            txtCant.DecimalValue = 1;
        }

        private void CalcularTotalesPedido()
        {
            decimal TotalNeto = 0;
            foreach (DataGridViewRow dr in dgCuerpo.Rows)
            {
                TotalNeto += Convert.ToDecimal(dr.Cells[8].Value.ToString());
            }
            txtTotalFacturado.Text = TotalNeto.ToString("N2");
            CalculaVuelto();
            fsoArticulo.Focus();
        }
        private void CalculaVuelto()
        {
            decimal TotalFacturado = Convert.ToDecimal(txtTotalFacturado.Text);
            decimal ACobrar = TotalFacturado + txtDescRec.DecimalValue;
            if (txtPagaCon.DecimalValue < ACobrar)
            {
                txtPagaCon.DecimalValue = ACobrar;
            }
            decimal Vuelto = txtPagaCon.DecimalValue - ACobrar;
            TxtVuelto.Text = Vuelto.ToString("N2");
        }

        private void cmdAddLinea_Click(object sender, EventArgs e)
        {
            AgregarArticuloActual();
        }

        private void dgCuerpo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (MyObject.Pendiente)
             {
                 DataGridViewRow dr = dgCuerpo.Rows[e.RowIndex];
                 fsoArticulo.IdSelected = Convert.ToInt32(dr.Cells[1].Value);
                 fsoListaPrecio.IdSelected = Convert.ToInt32(dr.Cells[2].Value);
                 txtCant.DecimalValue = Convert.ToDecimal(dr.Cells[7].Value);
                 ActualizarPrecioUnitario();
                 dgCuerpo.Rows.RemoveAt(e.RowIndex);
             }
        }
        private void txtCant_Leave(object sender, EventArgs e)
        {
            CalularTotalLinea();
        }
        private void CalularTotalLinea()
        {
            txtTotalLinea.DecimalValue = txtCant.DecimalValue * txtPU.DecimalValue;
        }
        private void ActualizarPrecioUnitario()
        {
            if (fsoListaPrecio.ObjetoActual != null && fsoArticulo.ObjetoActual != null)
            {
                BBPrecioArticulo BBPA = new BBPrecioArticulo();
                txtPU.DecimalValue = BBPA.GetByListaYArticulo(fsoListaPrecio.IdSelected, fsoArticulo.IdSelected).Neto;
            }
            else {
                txtPU.DecimalValue = 0;
            }
            CalularTotalLinea();
        }

        private void fsoArticulo_ObjetoSeleccionado(object ObjetoSeleccionado)
        {
            ActualizarPrecioUnitario();
        }

        private void fsoListaPrecio_ObjetoSeleccionado(object ObjetoSeleccionado)
        {
            ActualizarPrecioUnitario();
        }

        private void txtCant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarArticuloActual();
            }
        }

        private void txtDescRec_Leave(object sender, EventArgs e)
        {
            CalculaVuelto();
        }

        private void txtPagaCon_Leave(object sender, EventArgs e)
        {
            CalculaVuelto();
        }

        private void fsoArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                txtPagaCon.Focus();
            }

        }

        private void PedidoAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.ActiveControl.Name == "txtCant")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AgregarArticuloActual();
                }
            }

            if (this.ActiveControl.Name == "fsoArticulo")
            {
                if (e.KeyCode == Keys.End)
                {
                    txtPagaCon.Focus();
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void PedidoAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

                if (MessageBox.Show("Está seguro?", "Confirme Acción", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }

        private void dgCuerpo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                DataGridViewImageCell dr = (DataGridViewImageCell)dgCuerpo.Rows[e.RowIndex].Cells[9];
                if (dgCuerpo.Rows[e.RowIndex].Cells[10].Value.ToString() == "1")
                {
                    dgCuerpo.Rows[e.RowIndex].Cells[10].Value = "0";
                    dr.Value = global::WinFastFood.Properties.Resources._8close16;
                }
                else {
                    dgCuerpo.Rows[e.RowIndex].Cells[10].Value = "1";
                    dr.Value = global::WinFastFood.Properties.Resources._8printer24;
                }
            }
        }






    }

}