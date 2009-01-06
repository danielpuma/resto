using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.Seguridad.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FSO_NH.log4Net;
using WinFastFood.Inicio;


namespace FastFood
{
    public partial class Ingreso : Form
    {
        private BBUsuario MyUserAdmin;
        public Usuario MyUsuario;
        public bool Finalizar = true;
        public frmSplash FormularioSplash;
        public Ingreso()
        {
            try
            {
                MyUsuario = new Usuario();
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                string msg;
                msg = ex.Message;
                if (ex.InnerException != null)
                {
                    msg += ": " + ex.InnerException.Message;
                }
                MessageBox.Show(msg);
                FSOLog4Net.LogFatal(msg);
            }
        }
        
        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormularioSplash.Close();
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            FormularioSplash.Visible = false;


        }




        private void button1_Click(object sender, EventArgs e)
        {
            FSOLog4Net.LogInfo("Intento de LogIN: " + txtusr.Text);
            MyUserAdmin = new BBUsuario();
            MyUserAdmin.ClearSession();
            ComprobarUsuario();
        }

        private void ComprobarUsuario()
        {
            MyUserAdmin = new BBUsuario();
            try
            {
                MyUsuario = MyUserAdmin.ValidarIngreso(txtusr.Text, txtclave.Text);               
                this.Visible = false;
                frmInicial myFrm = new frmInicial(this);
                Win32Session.UsuarioActual = MyUsuario;
                Win32Session.DbServer = MyUserAdmin.GetDataBaseName();
                myFrm.ShowDialog(this);
                if (Finalizar)
                {
                    this.Close();
                }
                else
                {

                    Finalizar = true;
                }
            }
            catch (Exception ex)
            {

                string ErrorMsg;
                Win32Session.UsuarioActual = null;
                ErrorMsg = ex.Message;
                if (ex.InnerException != null)
                {
                    ErrorMsg = ex.Message +"\n\rInner: " + ex.InnerException.Message;
                }
                FSOLog4Net.LogFatal(ErrorMsg);
              
                MessageBox.Show(ErrorMsg);
                this.Visible = true;
            }
        }

        private void txtusr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComprobarUsuario();
            }
        }

        private void Ingreso_Activated(object sender, EventArgs e)
        {
            txtclave.Text = "";
        }

    }
}