using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FSO.NH.ClasesBase.Core;
using FastFood.BB.BaseExtension;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.BASE;

namespace FastFood.ABM.GenericParameter
{
    public partial class frmParamAdmin : frmBase
    {
        public bool CancelClose = false;
        public Int32 ID;
        protected BBParametro_FastFood MyParamAdmin;
        protected Parametro MyParam;
        protected TextBox MyTxtCod;
        protected TextBox MyTxtDesc;
        public frmParamAdmin()
        {

            InitializeComponent();
        }

        protected void LoadFormDriver()
        {

            Cursor.Current = Cursors.WaitCursor;
            if (ID > 0)
            {
                MyParam = MyParamAdmin.GetById(ID, false);
            }
            else
            {
                MyParam = MyParamAdmin.GetNuevo();
            }
            BindearData(); 
            Cursor.Current = Cursors.Default;
			
        }
        protected void BindearData()
        {
            MyTxtCod.DataBindings.Clear();
            MyTxtDesc.DataBindings.Clear();
            MyTxtCod.DataBindings.Add("Text", MyParam, "Codigo");
            MyTxtDesc.DataBindings.Add("Text", MyParam, "Nombre");
            BindearOtrosDatos();
        }
        protected virtual void BindearOtrosDatos()
        { 
        }
        protected void GuardarDatos()
        {

            Cursor.Current = Cursors.WaitCursor;
            MyParamAdmin.Guardar(MyParam);                        
            GuardarOtrosDatos();
            Cursor.Current = Cursors.Default;
            this.Close(); 
        }
        protected virtual void GuardarOtrosDatos()
        {
        }
        protected void EliminarDatos()
        {

            Cursor.Current = Cursors.WaitCursor;
            if (MyParam.ID > 0)
            {
                if (MessageBox.Show("¿Esta Ud. Seguro?", "Eliminación de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MyParamAdmin.BorrarDatos(MyParam.ID);
                    this.Close();
                }
            } 
            Cursor.Current = Cursors.Default;
			
        }

        private void frmParamAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}