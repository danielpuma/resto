using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.Core;

using System.Collections;
using FSO.NH.Seguridad.BB;

namespace FastFood.ABM.RolesYPermisos
{
    public partial class frmPermisosPorRol : Form
    {
        private Rol MyRol;

        BBPermiso MyPermisoAdmin;
        BBRol MyRolAdmin; 
        List<Permiso> MisPermisos;
        public frmPermisosPorRol(Rol pMyRol)
        {
            InitializeComponent();
            MyRol = pMyRol;

            MyPermisoAdmin = new BBPermiso();
            MyRolAdmin = new BBRol();
        }

        private void frmPermisosPorRol_Load(object sender, EventArgs e)
        {
            label2.Text = label2.Text + " ["+ MyRol.Nombre  + "]";

            RefreshGrillas();
        }
        public void RefreshGrillas()
        {
            BindearGrillas();
        }

        private void BindearGrillas()
        {
            GrillaNo.AutoGenerateColumns = false;
            //GrillaNo.DataSource = null;
            MisPermisos = MyPermisoAdmin.GetAll();
 
            GrillaNo.Columns[0].DataPropertyName = "ID";
            GrillaNo.Columns[1].DataPropertyName = "Nombre";

            GrillaNo.Rows.Clear();
            GrillaSI.Rows.Clear();

            foreach (Permiso p in MisPermisos)
            {
                GrillaNo.Rows.Add(p.ID, p.Nombre);
            }

            if (MyRol.RolPermisoList.Count > 0)
            {
                foreach (Permiso p in MyRol.RolPermisoList)
                {
                    GrillaSI.Rows.Add(p.ID, p.Nombre);
                    foreach (DataGridViewRow r in GrillaNo.Rows)
                    {
                        if (r.Cells[0].Value.ToString() == p.ID.ToString())
                        {
                            GrillaNo.Rows.RemoveAt(r.Index);
                        }
                    }
                }
            }
        }

        private void cmdAddOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrillaNo.SelectedRows.Count > 0)
                {
                    int IdSelected = Convert.ToInt32(GrillaNo.SelectedRows[0].Cells[0].Value);
                    MyRolAdmin.AddPermisoToRol(MyRol, IdSelected);
                    RefreshGrillas();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDelOne_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrillaSI.SelectedRows.Count > 0)
                {
                    int IdSelected = Convert.ToInt32(GrillaSI.SelectedRows[0].Cells[0].Value);
                    MyRolAdmin.DeletePermisoToRol(MyRol, IdSelected);
                    RefreshGrillas();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show (ex.Message );
            }
        }

        private void cmdAddAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in GrillaNo.Rows )
            {
                int Id = Convert.ToInt32(c.Cells[0].Value);
                try
                {
                    MyRolAdmin.AddPermisoToRol(MyRol, Id);
                }
                catch { }
            }
            RefreshGrillas();
        }

        private void cmdDelAll_Click(object sender, EventArgs e)
        {
            GrillaSI.DataSource = null;
            foreach (DataGridViewRow c in GrillaSI.Rows)
            {
                int Id = Convert.ToInt32(c.Cells[0].Value);

                try
                {
                    MyRolAdmin.DeletePermisoToRol(MyRol, Id);
                }
                catch 
                {
                }
            }
            RefreshGrillas();
        }
    }
}