using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.ClasesBase.Core;

using System.Drawing.Printing;
using ToolBox;
using FastFood.BB.BaseExtension;
using FSO.NH.CodigoDeSeguridad;

namespace FastFood.ABM.Parametros
{
    public partial class frmParametrosList : Form, PrinteableForm
    {
        BBParametro_FastFood ParamAdmin;
        List<Parametro> LstParams;

        private string SubTipo;
        public frmParametrosList(string pSubTipo)
        {
            InitializeComponent();
            SubTipo = pSubTipo;
        }

        private void frmRolesList_Load(object sender, EventArgs e)
        {
            switch (SubTipo)
            {
                case "TipoDeDoc": 
                        label2.Text = "Administración de Tipos De Documentos";
                        this.Text = "Tipos de Documento";
                        ParamAdmin = new BBParametro_FastFood("TipoDeDoc");
                        break;
                case "Rol":
                        label2.Text = "Administración de Roles de FastFood";
                        this.Text = "Roles";
                        ParamAdmin = new BBParametro_FastFood("Rol");
                        break;
                case "Permiso":
                        label2.Text = "Administración de Permisos de FastFood";
                        this.Text = "Permisos";
                        ParamAdmin = new BBParametro_FastFood("Permiso");
                        break;
                case "ListaPrecio":
                    label2.Text = "Administración de Lista de Precios";
                    this.Text = "Listas de Precios";
                    ParamAdmin = new BBParametro_FastFood("ListaPrecio");
                    break;
                case "Mesa":
                    label2.Text = "Administración de Mesas";
                    this.Text = "Mesas";
                    ParamAdmin = new BBParametro_FastFood("Mesa");
                    break;
                case "GrupoArticulo":
                    label2.Text = "Administración de Grupos de Artículos";
                    this.Text = "Grupos de Artículos";
                    ParamAdmin = new BBParametro_FastFood("GrupoArticulo");
                    break;
                case "Comprobante":
                    label2.Text = "Administración de Comprobantes";
                    this.Text = "Comprobantes";
                    ParamAdmin = new BBParametro_FastFood("Comprobante");
                    break;
            }
            
            LstParams = ParamAdmin.GetAll();
            BindearGrilla();

        }
        private void BindearGrilla()
        {

            Cursor.Current = Cursors.WaitCursor;
            GrillaDatos.AutoGenerateColumns = false;
            GrillaDatos.DataSource = LstParams;
            GrillaDatos.Columns[0].DataPropertyName = "ID";
            GrillaDatos.Columns[1].DataPropertyName = "Codigo";
            GrillaDatos.Columns[2].DataPropertyName = "Nombre";
            verificarLimitesDemo(); 
            Cursor.Current = Cursors.Default;
			
        }
        private void BuscarDatos()
        {
            LstParams = ParamAdmin.GetFiltered(txtCodigo.Text, txtDescripcion.Text );
            BindearGrilla();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }
        private void ShowABMForm(Int32 ID)
        {
            frmParametrosAdmin FrmABM = new frmParametrosAdmin(SubTipo);
            FrmABM.ID = ID;
            FrmABM.ShowDialog(this);
            BuscarDatos();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            ShowABMForm(0);
          
        }

        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 Id = Convert.ToInt32(GrillaDatos.SelectedRows[0].Cells[0].Value);
            ShowABMForm(Id);
        
        }



  
        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return GrillaDatos; }
        }

        public string TituloImpresion
        {
            get { return "FastFood - " + SubTipo.ToString(); }
        }

        private void verificarLimitesDemo()
        {
            int max = 0;
            switch (SubTipo)
            {
                case "Mesa":
                    max = 5; break;
                case "GrupoArticulo":
                    max = 2; break;
                case "ListaPrecio":
                    max = 2; break;
            }
            ValidadorCodigoSeguridad v = new ValidadorCodigoSeguridad("WIN32PxG");
            if (max > 0 && v.VerificarModoDemo() && MyDataGrid.Rows.Count >= max)
            {
                MessageBox.Show("Se ha alcanzado el límite de " + this.Text  + " del modo demo ("+ max.ToString()+")");
                cmdNuevo.Enabled = false;
            }
            else
            {
                cmdNuevo.Enabled = true;
            }
        }


        #endregion
    }
}