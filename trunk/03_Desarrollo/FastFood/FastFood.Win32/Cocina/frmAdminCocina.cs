using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FastFood.Win32.Cocina
{
    public partial class frmAdminCocina : Form
    {
        public frmAdminCocina()
        {
            InitializeComponent();
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void RefreshData()
        { 
        }
    }
}