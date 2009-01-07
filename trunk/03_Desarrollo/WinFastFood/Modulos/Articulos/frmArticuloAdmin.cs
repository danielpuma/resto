using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using FastFood.Core;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FastFood.BASE;
using ToolBox;

namespace FastFood.ABM.Articulo
{
    public partial class frmArticuloAdmin : frmBase
    {
        public Int32 ID;
        private BBArticulo MyBB;
        private FastFood.Core.Articulo MyObject;
        public frmArticuloAdmin()
        {

            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            MyBB = new BBArticulo();
            ControlDeSeguridad("Articulo", cmdGuardar, CmdDelete); 
            Cursor.Current = Cursors.Default;
			
        }
       

        private void frmArticuloAdmin_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            cboGrupoArticulo.SetComboBinding(new BBGrupoArticulo(), "", "");
            
            if (ID > 0)
            {

                MyObject = MyBB.GetById(ID, true);
            }
            else
            {
                MyObject = MyBB.GetNuevo();
            }

            BindearData(); 
            Cursor.Current = Cursors.Default;
			
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            new BBArticulo().CancelarCambios(MyObject);
            this.Close();
        }
        private void BindearData()
        {
            
            txtCodigo.DataBindings.Clear();
            txtNombre.DataBindings.Clear();
            txtDescripcion.DataBindings.Clear();
            chkPermiteStockNeg.DataBindings.Clear();



            chkPermiteStockNeg.DataBindings.Add("Checked", MyObject, "PermiteStockNegativo");
            txtCodigo.DataBindings.Add("Text", MyObject, "Codigo");
            txtDescripcion.DataBindings.Add("Text", MyObject, "Descripcion");
            txtNombre.DataBindings.Add("Text", MyObject, "Nombre");
            if(MyObject.MyGrupoArticulo!=null)
                cboGrupoArticulo.IdSelected = MyObject.MyGrupoArticulo.ID;
            
            BindearPrecios();
            
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                MyObject.MyGrupoArticulo = GetGrupoArticulo();                
                MyBB.Guardar(MyObject);
                GuardarOtrosDatos();
                Cursor.Current = Cursors.Default;
                this.Close();
            }
            catch (Exception Ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(Ex.Message);
            }
        }

        protected void GuardarOtrosDatos()
        {


         
            Int32 IdLista;
            Decimal Neto;
            BBPrecioArticulo pa = new BBPrecioArticulo();
            BBListaDePrecio lp = new BBListaDePrecio();
            foreach (DataGridViewRow row in dgPrecios.Rows)
            {
                IdLista = Convert.ToInt32(row.Cells[0].Value);
                Neto = NumericString.ConvertToDecimal(row.Cells[2].Value.ToString());

                PrecioArticulo x = pa.GetByListaYArticulo(IdLista, MyObject.ID);
                if (x == null)
                {
                    x = new PrecioArticulo();
                    x.Articulo = MyObject;
                    x.ListaDePrecio = lp.GetById(IdLista, true);
                }

                x.Neto = Neto;
                pa.Save(x);
                pa.Flush();
                pa.ResetSession();

            }


        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (MyObject.ID > 0)
                {
                    if (MessageBox.Show("¿Esta Ud. Seguro?", "Eliminación de Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MyBB.BorrarDatos(MyObject.ID);
                        this.Close();
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception Ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(Ex.Message);
            }
        }
        
        private FastFood.Core.GrupoArticulo GetGrupoArticulo()
        {
            return  (FastFood.Core.GrupoArticulo)cboGrupoArticulo.ObjetoActual;
        }


        protected void BindearPrecios()
        {
            BBListaDePrecio LDP = new BBListaDePrecio();
            List<ListaDePrecio> listas = LDP.GetAll();
            BBPrecioArticulo BL = new BBPrecioArticulo();
            decimal Neto = 0;


            dgPrecios.Rows.Clear();
            foreach (ListaDePrecio l in listas)
            {
                if (MyObject.ID > 0)
                {
                    PrecioArticulo pa = BL.GetByListaYArticulo(l.ID, MyObject.ID);
                    if (pa != null)
                    {
                        Neto = pa.Neto;

                    }
                    else
                    {
                        Neto = 0;
                    }
                }
                else
                {
                    Neto = 0;
                }

                dgPrecios.Rows.Add(l.ID, l.MiDescripcion, Neto.ToString("N2"));
            }
        }

        private void dgPrecios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    decimal A = NumericString.ConvertToDecimal(dgPrecios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                }
            }
            catch
            {
                dgPrecios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0.00";
            }
        }


    }
}