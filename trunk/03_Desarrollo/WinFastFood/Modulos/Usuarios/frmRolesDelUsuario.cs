using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.Core;
using FSO.NH.Seguridad.BB;


namespace FastFood.ABM.Usuarios
{
    public partial class frmRolesDelUsuario : Form
    {
        public Usuario MyUsuario;
        public frmRolesDelUsuario()
        {
            InitializeComponent();
            MyUsuario = new Usuario();
        }

        private void frmRolesDelUsuario_Load(object sender, EventArgs e)
        {
            BindearCombo();
            BindearDatos();
        }
        public void BindearCombo()
        {
            BBRol BBR = new BBRol();
            cboRoles.DataSource = BBR.GetAll();
            cboRoles.DisplayMember = "Nombre";
            cboRoles.ValueMember = "ID";
        }

        public void BindearDatos() 
        {
            BBRol BBR = new BBRol();
            GrillaDatos.AutoGenerateColumns = false; 


            GrillaDatos.Rows.Clear();
            foreach (Rol r in MyUsuario.UsuarioRolList)
            {
                GrillaDatos.Rows.Add(r.ID, r.Codigo, r.Nombre);
            }

        }

        private void cmdAddRol_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 Id;
                try
                {
                    Id = Convert.ToInt32(cboRoles.SelectedValue);
                }
                catch
                {
                    Id = ((Rol)cboRoles.SelectedValue).ID;
                }
                BBRol BBR = new BBRol();
                Rol x = BBR.GetById(Id, false);
                MyUsuario.UsuarioRolList.Add(x);
                BBUsuario BBU = new BBUsuario();
                BBU.Save(MyUsuario);
                BBU.Flush();
                
                BindearDatos();
            }
            catch (Exception we)
            {
                MessageBox.Show(we.Message);
            }

        }

        private void GrillaDatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 Id = Convert.ToInt32(GrillaDatos.Rows[e.RowIndex].Cells[0].Value );
            BBRol BBR = new BBRol();
            Rol x = BBR.GetById(Id, false);
            MyUsuario.UsuarioRolList.Remove(x);
            BBUsuario BBU = new BBUsuario();
            BBU.Save(MyUsuario);
            BBU.Flush();
            BindearDatos();
         
        }






    }
}