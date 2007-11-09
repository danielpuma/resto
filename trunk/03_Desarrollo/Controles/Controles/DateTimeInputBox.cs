using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class DateTimeInputBox : UserControl
    {
        public DateTime dtNullValue;
        public DateTime Fecha
        {
            set {
                if (value == dtNullValue)
                {
                    txtFecha.Text = "";
                }
                else {
                    txtFecha.Text = value.ToString("dd/MM/yyyy");
                }
            }
        }
        public override string Text
        {
            get
            {
                return txtFecha.Text;
            }
            set
            {
                if (ValidarFecha(value))
                {
                    if (StringToFecha(value) == dtNullValue)
                    {
                        txtFecha.Text = "";
                    }
                    else
                    {
                        txtFecha.Text = value;
                    }
                }
                else {
                    txtFecha.Text = "";
                }
            }
        }
        public DateTimeInputBox()
        {
            dtNullValue = new DateTime(1900, 1, 1);
            InitializeComponent();
        }

        private void txtFecha_Leave(object sender, EventArgs e)
        {
            String d = txtFecha.Text.Trim();

            if (d.Length == 2)
            {
                d = d.Substring(0, 2) + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            }
            if (d.Length == 4)
            {
                d = d.Substring(0, 2) + "/" + d.Substring(2, 2) + "/" + DateTime.Now.Year.ToString();
            }
            if (d.Length == 5)
            {
                d = d.Substring(0, 5) + "/" + DateTime.Now.Year.ToString();
            }
            if (d.Length == 8)
            {
                d = d.Substring(0, 2) + "/" + d.Substring(2, 2) + "/" + d.Substring(4, 4);
            }
            if (d.Length == 10)
            {
                d = d.Replace('-', '/');
            }
            if (ValidarFecha(d))
            {
                txtFecha.Text = d;
            }
            else {
                txtFecha.Text = "";
            }
            
        }
        public bool ValidarFecha(string Fecha)
        {
            try
            {
                StringToFecha(Fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DateTime StringToFecha(string Fecha)
        {
            string[] f = Fecha.Split('/');
            DateTime t = new DateTime(Convert.ToInt32(f[2]), Convert.ToInt32(f[1]), Convert.ToInt32(f[0]));
            return t;
        }

        private void txtFecha_Enter(object sender, EventArgs e)
        {
                txtFecha.SelectAll();
        }







 
    }
}
