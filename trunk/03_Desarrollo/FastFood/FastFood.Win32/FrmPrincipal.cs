using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.Core;
using FastFood.Win32.ABM.Mesas;
using FastFood.Win32.Cocina;

namespace FastFood.Win32
{
    public partial class FrmPrincipal : Form
    {
        public FrmSplash FormularioSplash;
        private List<Mesa> LasMesas;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 AC = new AboutBox1();
            AC.ShowDialog(this);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog(this);

            Cursor.Current = Cursors.WaitCursor;
            FormularioSplash.Visible = false;
            BindearLockUp();
            BindearGrilla();
            dgDatos.Focus();
            Cursor.Current = Cursors.Default; 
        }
        private void BindearLockUp()
        {
            fsoPersonal.SetComboBinding(new BBPersonal(), "Baja", "false");                        
        }
        private void BindearGrilla()
        {
            LasMesas = Mesa.GetAllActive();
            dgDatos.AutoGenerateColumns = false;
            dgDatos.DataSource = LasMesas;
            dgDatos.Columns[0].DataPropertyName = "ID";
            dgDatos.Columns[1].DataPropertyName = "Codigo";
            dgDatos.Columns[2].DataPropertyName = "Descripcion";

        }
        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormularioSplash.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametrosList F = new FrmParametrosList(ParametrosSoportados.eMesas);
            F.ShowDialog(this);
            LasMesas = Mesa.GetAllActive();
            BindearGrilla();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametrosList F = new FrmParametrosList(ParametrosSoportados.sPersonal);
            F.ShowDialog(this);
            BindearLockUp();

        }

        private void cmdCocina_Click(object sender, EventArgs e)
        {
            GoToCocina();
        }
        private void GoToCocina()
        {
            frmAdminCocina frm = new frmAdminCocina();
            frm.ShowDialog(this);
        }


        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                GoToCocina();
            }
            if (e.KeyCode == Keys.End)
            {
                frmLogin frm = new frmLogin();
                frm.ShowDialog(this);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDatos_Click(object sender, EventArgs e)
        {

        }

        private void dgDatos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Int32 id = 0;
                id = Convert.ToInt32(dgDatos.SelectedRows[0].Cells[0].Value);
                fsoMesa.ObjetoActual = Mesa.GetById(id);
            }
            catch { } 
        }

        private void cmdBloquear_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog(this);
        }


    }
}