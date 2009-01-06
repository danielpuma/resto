using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.Core;
using System.Drawing.Printing;
using ToolBox;
using FSO.NH.ClasesBase.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.ClasesBase.BB;
using FastFood.ABM.Usuarios;

namespace ABM.Usuarios.FastFood
{
    public partial class frmUserList : Form, PrinteableForm
    {
        BBUsuario UsuariosAdmin;
        BBTipoDeDocumento TDocAdmin; 
        List<Usuario> MisUsuarios;
        List<Tipo_Documento> MisTiposDoc;
        //DataGridViewPrinter MyDataGridViewPrinter;

        public frmUserList()
        {
            InitializeComponent();
            UsuariosAdmin = new BBUsuario();
            TDocAdmin = new BBTipoDeDocumento();            
            
        }
        private void frmUserList_Load(object sender, EventArgs e)
        {
            MisUsuarios = UsuariosAdmin.GetFiltered("", "", -1, "");
            MisTiposDoc = TDocAdmin.GetAll();
            BindearGrilla();
        }
        private void BindearGrilla()
        {
            GrillaDatos.AutoGenerateColumns = false;
            GrillaDatos.DataSource = MisUsuarios;
            GrillaDatos.Columns[0].DataPropertyName = "ID";
            GrillaDatos.Columns[1].DataPropertyName = "Nombre";
            GrillaDatos.Columns[2].DataPropertyName = "Apellido";
            GrillaDatos.Columns[3].DataPropertyName = "username";
            GrillaDatos.Columns[4].DataPropertyName = "NombreTipoDeDocumento";
            GrillaDatos.Columns[5].DataPropertyName = "NumeroDocumento";
        }
        
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();

        }
        private void BuscarDatos()
        {
            int IdTDoc;
            if (cboTipoDocumento.SelectedIndex >= 0)
            {
                IdTDoc = Convert.ToInt32(cboTipoDocumento.SelectedValue);
            }
            else
            {
                IdTDoc = 0;
            }
            MisUsuarios = UsuariosAdmin.GetFiltered(txtNombre.Text, txtApellido.Text, IdTDoc, txtNroDocumento.Text);
            BindearGrilla();
        }
        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            Int32 Id = Convert.ToInt32(GrillaDatos.SelectedRows[0].Cells[0].Value );            
            ShowABMForm(Id);
            
        }
        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            
            ShowABMForm(0);
           
        }
        private void ShowABMForm(Int32 ID)
        {
            frmUserAdmin FrmABM = new frmUserAdmin();
            FrmABM.ID = ID;
            FrmABM.ShowDialog(this);
            BuscarDatos();
        }

        private void cboTipoDocumento_Enter(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = MisTiposDoc;
            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.ValueMember = "ID";
        }

        private void cmdVerRoles_Click(object sender, EventArgs e)
        {
            frmRolesDelUsuario f = new frmRolesDelUsuario();
            BBUsuario BBU = new BBUsuario();
            Int32 Id = Convert.ToInt32(GrillaDatos.SelectedRows[0].Cells[0].Value );
            f.MyUsuario = BBU.GetById(Id,false);
            f.ShowDialog(this);
        }



        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return GrillaDatos; }
        }

        public string TituloImpresion
        {
            get { return "Usuarios del Sistema"; }
        }

        #endregion
    }
}