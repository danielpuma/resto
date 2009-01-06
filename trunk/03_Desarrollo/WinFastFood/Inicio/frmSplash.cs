using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Data;

namespace FastFood
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            Cursor.Current = Cursors.AppStarting; 
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo ci = (System.Globalization.CultureInfo)Application.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";
                ci.NumberFormat.CurrencyGroupSeparator = "";
                ci.NumberFormat.NumberGroupSeparator = "";
                ci.NumberFormat.NumberDecimalSeparator = ".";
                Application.CurrentCulture = ci;

                T1.Enabled = false;
                HNSesion.AbrirSesion();
                Ingreso frmi = new Ingreso();
                frmi.FormularioSplash = this;
                frmi.Show();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "\n\r" + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                    msg += "\n\r" + ex.InnerException.InnerException.Message;
                MessageBox.Show(msg);
                Application.Exit();
            }
        }
    }
}