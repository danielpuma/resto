using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToolBox;
using Microsoft.Win32;
using FSO.NH.CodigoDeSeguridad;

namespace FastFood.SecurityCode
{
    public partial class frmActivacion : Form
    {
        ValidadorCodigoSeguridad Validator;  
        public frmActivacion()
        {
            InitializeComponent();
            Validator = new ValidadorCodigoSeguridad("WIN32PxG");
        }

        private void frmActivacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Validator.AplicacionActivada)
            {
               MessageBox.Show ("La aplicaci�n no ha sido activada comunique esta situaci�n a Fernando Sosa (fjsosa@gmail.com) � a Javier San Mart�n (javosm79@hotmail.com)");
            }
        }

        private void frmActivacion_Load(object sender, EventArgs e)
        {
            txtCode.Text = Validator.GetCodigoSeguridad();
            if (Validator.VerificarActivacion())
            {                
                txtCodigoActivacion.Text = Validator.GetCodigoActivacionCorrecto();
                cmdActivar.Enabled = false;
                label3.Text = "Aplicaci�n Activada";
                label4.Text = "La aplicaci�n ya se encuentra activada";
            }
      
        }

        private void cmdActivar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoActivacion.Text.Trim();
            if (Validator.ValidarCodigo(codigo))
            {
                Validator.ActivarAplicacion();
                MessageBox.Show("Aplicaci�n Activada correctamente");                                
            }
            this.Close();
        }

        private void cmdDemo_Click(object sender, EventArgs e)
        {
            Validator.ActivarDemoAplicacion();
            if (Validator.EsDemoVencida())
            {
                MessageBox.Show("La Versi�n Demo del sistema est� vencida.");
            }
            else {
                MessageBox.Show("La Versi�n Demo del sistema est� activada hasta el D�a: " + DateTime.Today.AddDays(30).ToString("dd/MM/yyyy"));
            }
            this.Close();
        }
    }
}