using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using FSO.NH.ClasesBase.BB;
using FSO.NH.ClasesBase.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.BASE;
using WinFastFood.Modulos.Cliente;


namespace FastFood.ABM.Cliente
{

    public partial class frmClienteAdmin : frmBase
    {
        #region Propiedades
        public Int32 ID;
        private BBCliente MyBB;
        private FastFood.Core.Cliente MyObject;
        #endregion

        public frmClienteAdmin()
        {


            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            MyBB = new BBCliente();
            ControlDeSeguridad("Cliente", cmdGuardar,CmdDelete); 
            Cursor.Current = Cursors.Default;
			
            
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (ID > 0)
            {
                MyObject = MyBB.GetById(ID, false);
            }
            else
            {
                MyObject = new FastFood.Core.Cliente();
            }
            BindearCombos();
            BindearData(); 
            Cursor.Current = Cursors.Default;

        }

        #region DataBinding
        private void BindearCombos()
        {
            BBTipoDeDocumento TDC = new BBTipoDeDocumento();
            List<Tipo_Documento> LstTDoc = TDC.GetAll();
            cboTipoDocumento.DataSource = LstTDoc;
            cboTipoDocumento.DisplayMember = "Codigo";
            cboTipoDocumento.ValueMember = "ID";

        }
        private void BindearData()
        {
            txtApellido.DataBindings.Add("Text", MyObject, "Apellido");
            txtNombre.DataBindings.Add("Text", MyObject, "Nombre");
            TxtNroDoc.DataBindings.Add("Text", MyObject, "NumeroDocumento");
            txtRazonSocial.DataBindings.Add("Text", MyObject, "RazonSocial");
            txtTel.DataBindings.Add("Text", MyObject, "Telefonos");
            txtmail.DataBindings.Add("Text", MyObject, "Email");
            txtDireccion.DataBindings.Add("Text", MyObject, "Direccion");

            
            dtFechaNacimiento.FechaNuleable = MyObject.FechaNacimiento;
            if(MyObject.MiTipoDeDocumento!=null)
                cboTipoDocumento.SelectedValue = MyObject.MiTipoDeDocumento.ID;
        }

        #endregion
        #region Botones
        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            
            try
            {
                GuardarDatos();
                this.Close();

            }
            catch (Exception Ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(Ex.Message);
            } 
            
			
        }
        public void GuardarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;
            BBTipoDeDocumento BBTD = new BBTipoDeDocumento();

            MyObject.FechaNacimiento = dtFechaNacimiento.FechaNuleable;

            MyObject.MiTipoDeDocumento = BBTD.GetById(Convert.ToInt32(cboTipoDocumento.SelectedValue), false);
            Int32 ID = MyBB.Guardar(MyObject);
            MyBB.EvictObject(MyObject);
            MyObject = new FastFood.Core.Cliente();
            MyObject = MyBB.GetById(ID, false);

            Cursor.Current = Cursors.Default;
        }
        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyObject.ID > 0)
                {
                    if (MessageBox.Show("¿Esta Ud. Seguro?", "Eliminación de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MyBB.BorrarDatos(MyObject.ID);
                        this.Close();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        #endregion

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            new BBCliente().CancelarCambios(MyObject);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGoogleEarth f = new frmGoogleEarth();
            f.Desde = System.Configuration.ConfigurationSettings.AppSettings["DomicilioEmpresa"];
            f.Hasta = txtDireccion.Text;
            f.ShowDialog(this);
        }

        



    }
}