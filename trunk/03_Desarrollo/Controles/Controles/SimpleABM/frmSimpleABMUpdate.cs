using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public delegate void _ActualizacionDeDatosRequerida(SimpleABMStruct DatosFinales);
    public partial class frmSimpleABMUpdate : Form
    {
        public SimpleABMStruct DatosOriginales;
        public event _ActualizacionDeDatosRequerida ActualizacionDeDatosRequerida;

        public frmSimpleABMUpdate()
        {
            DatosOriginales = new SimpleABMStruct();
            InitializeComponent();
        }
        public frmSimpleABMUpdate(SimpleABMStruct DatosAModificar)
        {
            InitializeComponent();
            DatosOriginales = DatosAModificar;
            txtCodigo.Text = DatosOriginales.Codigo;
            txtDescripcion.Text = DatosOriginales.Descripcion;
            chkInactivo.Checked = DatosAModificar.Baja;
            this.Text = "Modificar Registro";
            
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if(!DatosOriginales.Equals(GetDataFromScreen()))
            {
                if (MessageBox.Show(this, "Los datos han sido modificados, si cierra la ventana sin guardar perderá los cambios. ¿Desea cerrar la ventana ahora?", "Advertencia: Posible pérdida de datos!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
            }

            this.Close();
        }
        public SimpleABMStruct GetDataFromScreen()
        {
            SimpleABMStruct Datos = new SimpleABMStruct();
            Datos.ID = DatosOriginales.ID;
            Datos.Descripcion = txtDescripcion.Text.Trim();
            Datos.Codigo = txtCodigo.Text.Trim();
            Datos.Baja = chkInactivo.Checked;
            this.Text = "Crear Nuevo Registro";
            return Datos;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleABMStruct Datos = GetDataFromScreen();
                Datos.Validar();
                if (ActualizacionDeDatosRequerida != null)
                    ActualizacionDeDatosRequerida(Datos);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class SimpleABMStruct
    {
        public Int32 ID = 0;
        public String Codigo = "";
        public String Descripcion = "";
        public bool Baja;
        public override bool Equals(object obj)
        {
            try
            {
                if (obj != null)
                {
                    SimpleABMStruct ElOtro = (SimpleABMStruct)obj;
                    if (ElOtro.ID == ID && ElOtro.Codigo == Codigo && ElOtro.Descripcion ==  Descripcion && ElOtro.Baja == Baja)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else {
                    return false;
                }
            }
            catch {
                return false;
            }

            
        }
        public void Validar()
        {
            if (Codigo.Trim() == "")
            {
                throw new Exception("El Código no puede estar vacio!");
            }
        }
    }

}