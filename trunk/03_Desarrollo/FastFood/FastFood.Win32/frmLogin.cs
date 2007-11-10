using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FastFood.Win32
{

    public partial class frmLogin : Form
    {
        private bool cerrar = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !cerrar;
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            cerrar = true;
            this.Close();
        }
    }
}