using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.Core;

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
            

            Cursor.Current = Cursors.WaitCursor;
            FormularioSplash.Visible = false;
            LasMesas = Mesa.GetAll();
            fsoPersonal.SetComboBinding(new BBPersonal(), "", "");
            BindearGrilla();
            dgDatos.Focus();
            Cursor.Current = Cursors.Default; 
        }
        private void BindearGrilla()
        {
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


    }
}