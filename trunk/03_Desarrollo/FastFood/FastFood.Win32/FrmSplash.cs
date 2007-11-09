using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO_NH.Data;

namespace FastFood.Win32
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            Cursor.Current = Cursors.AppStarting; 
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            T1.Enabled = false;
            
            NHibernateSessionManager.Instance.StartSession();
            NHibernateSessionManager.Instance.CloseSession();
            FrmPrincipal frmi = new FrmPrincipal();
            frmi.FormularioSplash = this;
            frmi.Show();
        }
    }
}