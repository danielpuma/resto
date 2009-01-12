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
using FSO.NH.Seguridad.Core;

namespace WinFastFood.Modulos.Pedido
{
    public partial class PedidoAdmin : frmBase
    {
        public FastFood.Core.Pedido MyObject;
        private BBPedido MyBB;
        private ListaDePrecio LDPPredeterminada;
        public PedidoAdmin()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            InicilizarLockUp();
            ControlDeSeguridad("Pedido", cmdGuardar, null);
            ControlDeSeguridadLocal();
            Cursor.Current = Cursors.Default;
        }
        private void ControlDeSeguridadLocal()
        {
            BBUsuario BBU = new BBUsuario();
            fsoListaPrecio.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "CambiaLDP");
            txtPU.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "CambiaPU");
            dtFecha.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "CambiaFechaPedido");
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
            LDPPredeterminada = (ListaDePrecio)fsoListaPrecio.ObjetoActual;
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
            if (MyObject.ID!=0)
            { 

            }
        }



        private void chkCerrado_CheckedChanged(object sender, EventArgs e)
        {
            ManejarControles(chkCerrado.Checked);
        }

        private void ManejarControles(bool bCerrado)
        {
            txtDescRec.Enabled = !bCerrado;
            txtPagaCon.Enabled = !bCerrado;
            pblBody.Enabled = !bCerrado;
            chkImprimir.Enabled = bCerrado;
            chkImprimir.Checked = bCerrado;
            pnlHead.Enabled = !bCerrado;
        }



        private void AgregarArticuloActual()
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                if (fsoArticulo.ObjetoActual == null)
                    throw new Exception("Debe seleccionar un artículo para incluir en el pedido");

                BBUsuario BBU = new BBUsuario();
                if (!BBU.TienePermiso(Win32Session.UsuarioActual, "AddNeg") && Convert.ToDecimal(txtTotalLinea.Text)<0)
                {
                    throw new Exception("Disculpe, Ud. no puede cargar artículos en negativo");
                }

                if (!BBU.TienePermiso(Win32Session.UsuarioActual, "AddCero") && Convert.ToDecimal(txtTotalLinea.Text) <= 0)
                {
                    throw new Exception("Disculpe, Ud. no puede cargar artículos en negativo ni en cero");
                }

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
                Valores[9] = global::WinFastFood.Properties.Resources._8printer24;
                Valores[10] = "1";
                dgCuerpo.Rows.Add(Valores);
                PrepararNuevoArticulo();
                CalcularTotalesPedido();
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
        }
        
        private void PrepararNuevoArticulo()
        {
            fsoArticulo.ObjetoActual = null;
            txtCant.DecimalValue = 1;
            fsoListaPrecio.ObjetoActual = LDPPredeterminada;

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
            if (e.KeyCode == Keys.Enter && !txtPU.Enabled)
            {
                AgregarArticuloActual();
            }
            else {
                txtPU.Focus();
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
        private bool Preguntar = true;
        private void PedidoAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

                if (Preguntar && MessageBox.Show("Está seguro?", "Confirme Acción", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                MyBB.EvictObject(MyObject);
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public void Guardar()
        {

            try
            {

                Cursor.Current = Cursors.WaitCursor;
                GetDatosFromScreen();
                MyBB.Guardar(MyObject);
                Preguntar = false;
                this.Close();
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally {
                Cursor.Current = Cursors.Default;
            }
			
        }
        private void GetDatosFromScreen()
        {
            MyObject.Cliente = (Cliente)fsoCliente.ObjetoActual;
            MyObject.Activo = true;
            MyObject.Usuario = (Usuario)fsoMozo.ObjetoActual;
            MyObject.Mesa = (Mesa)fsoMesa.ObjetoActual;
            MyObject.NumeroInterno = 0;
            MyObject.PagaCon = Convert.ToDecimal(txtPagaCon.Text);
            MyObject.Pendiente = !chkCerrado.Checked;
            MyObject.TotalFacturado = Convert.ToDecimal(txtTotalFacturado.Text);
            MyObject.Vuelto = Convert.ToDecimal(TxtVuelto.Text);
            MyObject.DescuentoRecargo = Convert.ToDecimal(txtDescRec.Text);
            MyObject.FechaAnulacion = null;
            MyObject.FechaCarga = DateTime.Now;
            MyObject.FechaContable = dtFecha.Fecha;
            MyObject.UsuarioAnulacion = null;

            
            GetCuerpoFromScreen();

            
        }
        private void GetCuerpoFromScreen()
        {
            if (MyObject.CuerpoPedido != null)
                MyObject.CuerpoPedido.Clear();
            else
                MyObject.CuerpoPedido = new List<CuerpoPedido>();
            CuerpoPedido cp;
            BBArticulo BBA = new BBArticulo();
            BBListaDePrecio BBL = new BBListaDePrecio();
            foreach (DataGridViewRow dr in dgCuerpo.Rows)
            {
                cp = new CuerpoPedido();
                cp.Articulo = BBA.GetById((int)dr.Cells[1].Value,false);
                cp.Cantidad = Convert.ToDecimal(dr.Cells[7].Value);
                cp.Pedido= MyObject; 
                cp.ListaDePrecio = BBL.GetById((int)dr.Cells[2].Value, false);
                cp.PrecioUnitario = Convert.ToDecimal(dr.Cells[6].Value);
                cp.TotalLinea = Convert.ToDecimal(dr.Cells[8].Value);
                MyObject.CuerpoPedido.Add(cp);
            }
        }

        private void txtPU_Leave(object sender, EventArgs e)
        {
            CalularTotalLinea();
        }

        private void txtPU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalularTotalLinea();
                AgregarArticuloActual();
            }

        }






    }

}