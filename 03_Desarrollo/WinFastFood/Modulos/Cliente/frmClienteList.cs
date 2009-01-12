using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.ABM.GenericParameter;
using ToolBox;
using FastFood.BB.CoreExtension;
using Controles;
using FSO.NH.ClasesBase.BB;
using WinFastFood.Inicio;
using WinFastFood.Modulos.Pedido;
using FSO.NH.CodigoDeSeguridad;

namespace FastFood.ABM.Cliente
{

    public partial class frmClienteList : Form, PrinteableForm
    {
        public event IdSelected_Driver IdSelected;
        protected BBCliente BB;
        protected List<FastFood.Core.Cliente> LosDatos;
        public bool ModoSeleccion;
        protected string mTituloImpresion;
        protected frmClienteAdmin MyFrmAdmin;

        public frmClienteList()
            : base()
        {

            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            ModoSeleccion = false;
            BB = new BBCliente();
            mTituloImpresion = "Listado de Clientes";
            cboTipoDoc.SetComboBinding(new BBTipoDeDocumento(), "", "");
            dtRange1.Desde = null;
            dtRange1.Hasta = null; 
            Cursor.Current = Cursors.Default;
			
        }
        protected void BindearGrilla()
        {
            MyGrillaDatos.AutoGenerateColumns = false;
            MyGrillaDatos.DataSource = LosDatos;
            MyGrillaDatos.Columns[0].DataPropertyName = "ID";
            MyGrillaDatos.Columns[1].DataPropertyName = "NumeroDocumento";
            MyGrillaDatos.Columns[2].DataPropertyName = "NombreCompleto";
            MyGrillaDatos.Columns[3].DataPropertyName = "RazonSocial";
            MyGrillaDatos.Columns[4].DataPropertyName = "Telefonos";
            MyGrillaDatos.Columns[5].DataPropertyName = "Email";
            MyGrillaDatos.Columns[6].DataPropertyName = "FechaNacimiento";


        }
        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return MyGrillaDatos; }
        }

        public string TituloImpresion
        {
            get { return mTituloImpresion; }
        }

        #endregion
        protected void CellDoubleClickDriver(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ModoSeleccion)
                {
                    Int32 Id = Convert.ToInt32(MyGrillaDatos.Rows[e.RowIndex].Cells[0].Value);
                    String Cod = MyGrillaDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (IdSelected != null)
                        IdSelected(Id, Cod);
                    this.Close();
                }
                else
                {
                    Int32 Id = Convert.ToInt32(MyGrillaDatos.SelectedRows[0].Cells[0].Value);
                    ShowABMForm(Id);
                   
                }
            }
        }
        protected void LoadFormDriver()
        {
            BuscarDatos();
        }



        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();

        }
        protected void BuscarDatos()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                dtRange1.ValidarRango();
                LosDatos = BB.GetFiltered(txtCodigo.Text, GetIdSelected(cboTipoDoc), txtNombre.Text, txtApellido.Text, txtRazonSocial.Text, dtRange1.Desde, dtRange1.Hasta);
                BindearGrilla();
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }
        private int GetIdSelected(FSOCombo cbo)
        {
            int Id = 0;

            if (cbo.IdSelected >= 0)
            {
                Id = cbo.IdSelected;
            }

            return Id;
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            GenerarNuevoRegistro();
        }
        private void ShowABMForm(Int32 ID)
        {
            MyFrmAdmin = new frmClienteAdmin();
            MyFrmAdmin.ID = ID;
            MyFrmAdmin.ShowDialog(this);
            BuscarDatos();
        }
        protected void GenerarNuevoRegistro()
        {
            ShowABMForm(0);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellDoubleClickDriver(sender, e);
        }

        private void frmVehiculoList_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void frmClienteList_Load(object sender, EventArgs e)
        {
            LoadFormDriver();
            verificarLimitesDemo();
        }

        private void verificarLimitesDemo()
        {
            ValidadorCodigoSeguridad v = new ValidadorCodigoSeguridad("WIN32PxG");
            if (v.VerificarModoDemo() && MyGrillaDatos.Rows.Count >= 1)
            {
                MessageBox.Show("Se ha alcanzado el límite de Clientes del modo demo (1)");
                cmdNuevo.Enabled = false;
            }
            else
            {
                cmdNuevo.Enabled = true;
            }
        }


        private Int32 getSelectedCliente()
        {
            return  Convert.ToInt32(MyGrillaDatos.SelectedRows[0].Cells[0].Value);
        }

        private void cmdAlertas_Click(object sender, EventArgs e)
        {

        }

        private void cmdNuevoPedido_Click(object sender, EventArgs e)
        {
            PedidoAdmin PA = new PedidoAdmin(getSelectedCliente());
            ((frmInicial)this.Parent).ShowWindows(PA);
            PA.Activate();
        }




    }
}