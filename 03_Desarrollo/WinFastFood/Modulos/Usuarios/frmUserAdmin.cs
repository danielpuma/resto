using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FSO.NH.Seguridad.Core;
using FSO.NH.ClasesBase.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.ClasesBase.BB;
using FSO.NH.Auditoria;
using FastFood.BASE;

namespace ABM.Usuarios.FastFood
{
    public partial class frmUserAdmin : frmBase
    {
        #region Propiedades
            public Int32 ID;
            private BBUsuario MyUserAdmin;
            private Usuario MyUsuario;        
        #endregion

        public frmUserAdmin()
        {
            InitializeComponent();
            MyUserAdmin = new BBUsuario();
            ControlDeSeguridad("User", cmdGuardar, CmdDelete);
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                MyUsuario = MyUserAdmin.GetById(ID,false);
            }
            else {
                MyUsuario = MyUserAdmin.GetNuevo();
            }
            BindearCombos();
            BindearData();
        }

        #region DataBinding
            private void BindearCombos()
            {
                BBTipoDeDocumento TDC = new BBTipoDeDocumento();
                List<Tipo_Documento> LstTDoc = TDC.GetAll();
                cboTipoDocumento.DataSource = LstTDoc;
                cboTipoDocumento.DisplayMember = "Codigo";
                cboTipoDocumento.ValueMember = "ID";
            }
            private void BindearData()
            {
                txtApellido.DataBindings.Add("Text", MyUsuario, "Apellido");
                txtNombre.DataBindings.Add("Text", MyUsuario, "Nombre");
                TxtNroDoc.DataBindings.Add("Text", MyUsuario, "NumeroDocumento");
                txtUserName.DataBindings.Add("Text", MyUsuario, "username");
                txtPassword.DataBindings.Add("Text", MyUsuario, "password");
                cboTipoDocumento.SelectedValue = MyUsuario.MiTipoDeDocumento.ID;
            }
            
        #endregion
        #region Botones
            private void cmdGuardar_Click(object sender, EventArgs e)
            {
                try
                {
                    BBTipoDeDocumento BBTD = new BBTipoDeDocumento();
                    MyUsuario.MiTipoDeDocumento = BBTD.GetById(Convert.ToInt32(cboTipoDocumento.SelectedValue),false);
                    MyUserAdmin.Guardar(MyUsuario);
                    this.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message );
                }
            }
            private void CmdDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    if (MyUsuario.ID > 0)
                    {
                        if (MessageBox.Show("¿Esta Ud. Seguro?", "Eliminación de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            MyUserAdmin.BorrarDatos(MyUsuario.ID);
                            this.Close();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            private void cmdCancel_Click(object sender, EventArgs e)
            {
                new BBUsuario().CancelarCambios(MyUsuario);
                this.Close();
            }
            
        #endregion

    }
}