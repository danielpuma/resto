using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using ToolBox;
using FastFood.SecurityCode;
using FSO.NH.CodigoDeSeguridad;

namespace FastFood
{
    static class Program
    {
        private static ValidadorCodigoSeguridad validator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                validator = new ValidadorCodigoSeguridad();
                validator.RegisterExecutionTime();
                
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (validator.PuedoEjecutar())
                    Application.Run(new frmSplash());
                else
                {
                    Application.Run(new frmActivacion());
                    //Vuelvo a preguntar por si lo active.
                    if (validator.PuedoEjecutar())
                        Application.Run(new frmSplash());
                }
            }
            catch (Exception ex)
            {
                string MasDatos = "";
                if (ex.InnerException != null)
                {
                    MasDatos = ": " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                    {
                        MasDatos = ": " + ex.InnerException.InnerException.Message;

                    }
                }
                MessageBox.Show("ERROR: " + ex.Message + MasDatos);
                Application.Exit();
            }
        }
        public static void run()
        {
            if (validator.PuedoEjecutar())
            {
                Application.Run(new frmSplash());
            }
        }








    }
}