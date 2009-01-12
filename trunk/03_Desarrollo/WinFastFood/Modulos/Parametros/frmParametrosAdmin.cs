using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FSO.NH.Seguridad.Core;
using FastFood.ABM.RolesYPermisos;
using FSO.NH.ClasesBase.Core;
using FastFood.BB.BaseExtension;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.BASE;
using FastFood.BB.SupportClass;
using FastFood.BB.CoreExtension;
using FastFood.Core;
using FSO_NH.log4Net;

namespace FastFood.ABM.Parametros
{
    public partial class frmParametrosAdmin : frmBase
    {
        public Int32 ID;
        private string SubTipo;
        private BBParametro_FastFood MyParamAdmin;
        private Parametro MyParam;   

        public frmParametrosAdmin(String pSubTipo)
        {

            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            SubTipo = pSubTipo;
            MyParamAdmin = new BBParametro_FastFood(pSubTipo);
            string permiso = "XXXX"; //Por defecto no deja acceder
            switch (SubTipo)
            {
                case "TipoDeDoc":
                    this.Text = "Tipos de Documentos"; permiso = "TipoDoc";
                    break;
                case "Rol": this.Text = "Roles";
                    CmdExtra.Visible = true;
                    CmdExtra.Text = "Consultar Permisos";
                    permiso = "User";
                    break;
                case "Permiso":
                    this.Text = "Permisos";
                    permiso = "User";
                    break;
 
                case "ListaPrecio":
                    permiso = "ListaPrecio";
                    this.Text = "Lista de Precio";
                    chkPredeterminada.Visible = true;
                    break;

                case "GrupoArticulo":
                    permiso = "GrupoArticulo";
                    this.Text = "Marcas de Articulo";
                    break;

                case "Mesa":
                    permiso = "Mesa";
                    this.Text = "Mesas";
                    break;

                case "Comprobante":
                    permiso = "Comprobante";
                    this.Text = "Comprobantes";
                    BBNumerador TDC = new BBNumerador();
                    List<Numerador> LstTDoc = TDC.GetAll();
                    cboNumerador.DataSource = LstTDoc;
                    cboNumerador.DisplayMember = "ID";
                    cboNumerador.ValueMember = "ID";
                    lblComprobante.Visible = true;
                    cboNumerador.Visible = true;
                    break;
            }
            ControlDeSeguridad(permiso, cmdGuardar,CmdDelete); 
            Cursor.Current = Cursors.Default;
			
        }


        private void ControlDeSeguridad(string PermisoSolicitado)
        {
            BBUsuario BBU = new BBUsuario();
            if (!BBU.TienePermiso(Win32Session.UsuarioActual, PermisoSolicitado))
            {
                this.cboExtra.Enabled = false;
            }
        }
        private void frmRolesAdmin_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (ID > 0)
            {
                MyParam = MyParamAdmin.GetById(ID, false);
            }
            else
            {
                MyParam = MyParamAdmin.GetNuevo();
            }
            BindearData(); 
            Cursor.Current = Cursors.Default;
			
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            MyParamAdmin.CancelarCambios(MyParam);
            this.Close();
        }
        private void BindearData()
        {
            txtCodigo.DataBindings.Add("Text", MyParam, "Codigo");
            txtDescripcion.DataBindings.Add("Text", MyParam, "Nombre");
            if (SubTipo == "ListaPrecio")
            {
                chkPredeterminada.DataBindings.Add("Checked", MyParam, "Predeterminado");              
            }
            if (SubTipo == "Comprobante")
            {
                int idNum = 1;
                if (((Comprobante)MyParam).Numerador != null)
                    idNum = ((Comprobante)MyParam).Numerador.ID;
                cboNumerador.SelectedValue = idNum;
            }

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (SubTipo == "Comprobante")
                {
                    
                    int idNum = (int)cboNumerador.SelectedValue ;
                    ((Comprobante)MyParam).Numerador = new BBNumerador().GetById(idNum, false);
                }
                MyParamAdmin.Guardar(MyParam);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            } 
            Cursor.Current = Cursors.Default;
			
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyParam.ID > 0)
                {
                    if (MessageBox.Show("¿Esta Ud. Seguro?", "Eliminación de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MyParamAdmin.BorrarDatos(MyParam.ID);
                        this.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CmdExtra_Click(object sender, EventArgs e)
        {
            switch (SubTipo)
            { 
                case "Rol":
                    frmPermisosPorRol frmPXR = new frmPermisosPorRol((Rol)MyParam );
                    frmPXR.ShowDialog(this);
                    break;
            }
        }

    }
}