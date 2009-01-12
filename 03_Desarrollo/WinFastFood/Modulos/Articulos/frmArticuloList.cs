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
using FSO.NH.CodigoDeSeguridad;

namespace FastFood.ABM.Articulo
{
    public partial class frmArticuloList : Form, PrinteableForm
    {
        public event IdSelected_Driver IdSelected;
        protected BBArticulo BB;
        protected List<FastFood.Core.Articulo> LosDatos;
        public bool ModoSeleccion;
        protected string mTituloImpresion;
        protected frmArticuloAdmin MyFrmAdmin;
        public int MyIDCliente;

        public frmArticuloList():base()
        {
            InitializeComponent();
            ModoSeleccion = false;
            BB = new BBArticulo();
            mTituloImpresion = "Listado de Articulos";
            cboGrupoArticulo.SetComboBinding(new BBGrupoArticulo(), "", "");
            MyFrmAdmin = new frmArticuloAdmin();
        }
        protected  void BindearGrilla()
        {
            MyGrillaDatos.AutoGenerateColumns = false;
            MyGrillaDatos.DataSource = LosDatos;
            MyGrillaDatos.Columns[0].DataPropertyName = "ID";
            MyGrillaDatos.Columns[1].DataPropertyName = "Codigo";
            MyGrillaDatos.Columns[2].DataPropertyName = "Nombre";
            MyGrillaDatos.Columns[3].DataPropertyName = "GrupoNombre";
     
            
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

        private void verificarLimitesDemo()
        {
            ValidadorCodigoSeguridad v = new ValidadorCodigoSeguridad("WIN32PxG");
            if (v.VerificarModoDemo() && MyGrillaDatos.Rows.Count >= 10)
            {
                MessageBox.Show("Se ha alcanzado el límite de Artículos del modo demo (10)");
                cmdNuevo.Enabled = false;
            }
            else {
                cmdNuevo.Enabled = true;
            }
        }



        private void cmdBuscar_Click(object sender, EventArgs e)
        {            
            BuscarDatos();
            
        }
        protected void BuscarDatos()
        {

            Cursor.Current = Cursors.WaitCursor;
            LosDatos = BB.GetFiltered(txtCodigo.Text , txtNombre.Text, GetIdSelected(cboGrupoArticulo));
            BindearGrilla();
            verificarLimitesDemo();
            Cursor.Current = Cursors.Default;

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
            MyFrmAdmin = new frmArticuloAdmin();
            MyFrmAdmin.ID = ID;
            MyFrmAdmin.ShowDialog(this);
            BuscarDatos();
        }
        protected void GenerarNuevoRegistro()
        {
            ShowABMForm(0);
            BuscarDatos();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CellDoubleClickDriver(sender, e);
        }

        private void frmArticuloList_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void frmArticuloList_Load(object sender, EventArgs e)
        {
            LoadFormDriver();
        }


        private int getSelectedArticulo()
        {
            if (MyGrillaDatos.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(MyGrillaDatos.SelectedRows[0].Cells[0].Value);
            }
            else {
                throw new Exception("Seleccione un registro");
            }
        }



    }
}