using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.BB;
using FastFood.BB.CoreExtension;
using FSO.NH.Seguridad.Core;
using FastFood.Core;
using FSO.NH.Auditoria;
using ToolBox;
using WinFastFood.Modulos.Cliente;
using Controles;

namespace WinFastFood.Modulos.Pedido
{
    public partial class frmPedidoList : Form,  PrinteableForm, IfrmLockUp
    {
        List<FastFood.Core.Pedido> LosDatos;
        BBPedido BB;
        public int IdMesa;
        protected string mTituloImpresion;
        public frmPedidoList()
        {
            InitializeComponent();
        }
        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return dgDatos; }
        }

        public string TituloImpresion
        {
            get { return mTituloImpresion; }
        }

        #endregion
        private void BindearFiltros()
        {
            fsoMozo.SetComboBinding(new BBUsuario(), "", "");
            fsoMozo.ObjetoActual = Win32Session.UsuarioActual;            
            fsoMesa.SetComboBinding(new BBMesa(), "", "");
            fsoCliente.SetComboBinding(new BBCliente(), "", "");
        }

        private void VerificarSeguridad()
        {
            BBUsuario BBU = new BBUsuario();
            fsoMozo.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "VerOtrosMozos");
            cmdAnular.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "AnularPedido");
            cmdEliminar.Enabled = BBU.TienePermiso(Win32Session.UsuarioActual, "EliminarPedido");
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void BuscarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;
            LosDatos = BB.GetFiltered((Usuario)fsoMozo.ObjetoActual, (Mesa)fsoMesa.ObjetoActual, (FastFood.Core.Cliente)fsoCliente.ObjetoActual, dtRange1.Desde, dtRange1.Hasta, chkActivos.Checked, chkAnulados.Checked, chkPendientes.Checked, chkCerrados.Checked);
            dgDatos.AutoGenerateColumns = false;
            dgDatos.DataSource = LosDatos;
            dgDatos.Columns[0].DataPropertyName = "ID";
            dgDatos.Columns[1].DataPropertyName = "NumeroInterno";
            dgDatos.Columns[2].DataPropertyName = "FechaContable";
            dgDatos.Columns[3].DataPropertyName = "ClienteNombre";
            dgDatos.Columns[4].DataPropertyName = "UsuarioDescripcion";
            dgDatos.Columns[5].DataPropertyName = "TotalFacturado";
            dgDatos.Columns[6].DataPropertyName = "Pendiente";
            dgDatos.Columns[7].DataPropertyName = "MesaDescripcion";
            dgDatos.Columns[8].DataPropertyName = "EstadoDescripcion";
            Cursor.Current = Cursors.Default;
        }

        private void dgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellDoubleClickDriver(sender, e);
        }
        protected void CellDoubleClickDriver(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                    
                    Int32 Id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                    if (IsCalledFromLockUp)
                    {
                        if (IdSelected != null)
                        {
                            IdSelected(Id);
                        }
                    }
                    else
                    {
                        ShowABMForm(Id);
                    }
            }
        }
        private void ShowABMForm(Int32 ID)
        {
            PedidoAdmin MyFrmAdmin = new PedidoAdmin();
            if(ID>0)
                MyFrmAdmin.MyObject = new BBPedido().GetById(ID,false);
            MyFrmAdmin.ShowDialog(this);
            BuscarDatos();
        }

        private void cmdAnular_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Por favor, confirme la anulación (Esta acción no es recuperable)", "Confirme Acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (dgDatos.SelectedRows.Count > 0)
                    {
                        Int32 Id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                        BB.AnularPedido(Id, Win32Session.UsuarioActual);
                        BuscarDatos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
			
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Por favor, confirme la eliminación (Esta acción no es recuperable)", "Confirme Acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    if (dgDatos.SelectedRows.Count > 0)
                    {
                        Int32 Id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                        BB.EliminarPedido(Id);
                        BuscarDatos();
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
			
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            ShowABMForm(0);
        }

        private void frmPedidoList_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            BB = new BBPedido();
            mTituloImpresion = "Listado de Pedidos";
            VerificarSeguridad();
            BindearFiltros();
            dtRange1.Desde = null;
            dtRange1.Hasta = null;
            if (IdMesa > 0)
            {
                fsoMesa.IdSelected = IdMesa;
            }
            BuscarDatos();
            Cursor.Current = Cursors.Default;

        }

        private void cmdPreview_Click(object sender, EventArgs e)
        {
            try
            {

                    if (dgDatos.SelectedRows.Count > 0)
                    {
                        Int32 Id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                        bool Pendiente = (bool)dgDatos.SelectedRows[0].Cells[6].Value;
                        if (!Pendiente)
                        {
                            frmPreview f = new frmPreview();
                            f.IdPedido = Id;
                            f.Show();
                        }
                        else {
                            MessageBox.Show("Solo puede visualizar impresión de pedidos cerrados.");
                        }
                        
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void cmdLocalizarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgDatos.SelectedRows.Count > 0)
                {
                    Int32 Id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                    FastFood.Core.Pedido p = BB.GetById(Id, false);
                    frmGoogleEarth f = new frmGoogleEarth();
                    f.Desde = System.Configuration.ConfigurationSettings.AppSettings["DomicilioEmpresa"];
                    f.Hasta = p.Cliente.Direccion;
                    f.ShowDialog(this);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
			
        }


        #region IfrmLockUp Members

            public event SeleccionDeID IdSelected;

            public void RefiltrarDatos()
            {
                BuscarDatos();
            }


            private string _MyFiltros;
            public string MyFiltros
            {
                get
                {
                    return _MyFiltros;
                }
                set
                {
                    _MyFiltros = value;
                }
            }
            private bool _IsCalledFromLockUp;
            public bool IsCalledFromLockUp
            {
                get
                {
                    return _IsCalledFromLockUp;
                }
                set
                {
                    _IsCalledFromLockUp = value;
                }
            }

        #endregion
    }
}