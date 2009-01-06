using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ToolBox;
using FSO.NH.ClasesBase.Core;
using FSO.NH.ClasesBase.BB;
using FastFood.BB.BaseExtension;

namespace FastFood.ABM.GenericParameter
{
    public delegate void IdSelected_Driver(Int32 SelectedID, string Codigo);
    public partial class frmParamList : Form, PrinteableForm
    {
        public frmParamList()
        {
            ModoSeleccion = false;
            InitializeComponent();
        }
        public event IdSelected_Driver IdSelected;
        protected BBParametro_FastFood BB;
        protected List<Parametro> LosDatos;
        public bool ModoSeleccion;
        protected string mTituloImpresion;
        protected DataGridView MyGrillaDatos;
        protected frmParamAdmin MyFrmAdmin;
        protected TextBox MyTextBoxCod;
        protected TextBox MyTextBoxDesc;
        protected void LoadFormDriver()
        {
            Cursor.Current = Cursors.WaitCursor;
            BuscarDatos();
            BindearGrilla();
            Cursor.Current = Cursors.Default; 
        }
        protected virtual void BindearGrilla()
        {
            MyGrillaDatos.AutoGenerateColumns = false;
            MyGrillaDatos.DataSource = LosDatos;
            MyGrillaDatos.Columns[0].DataPropertyName = "ID";
            MyGrillaDatos.Columns[1].DataPropertyName = "Codigo";
            MyGrillaDatos.Columns[2].DataPropertyName = "Nombre";

        }
 
        protected virtual void BuscarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;
            LosDatos = BB.GetFiltered(MyTextBoxCod.Text, MyTextBoxDesc.Text);
            BindearGrilla();
            Cursor.Current = Cursors.Default;

        }
        private void ShowABMForm(Int32 ID)
        {
            MyFrmAdmin.ID = ID;
            MyFrmAdmin.ShowDialog(this);
            BuscarDatos();
        }
        protected void GenerarNuevoRegistro()
        {
            ShowABMForm(0);
          
        }
        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return MyGrillaDatos; }
        }

        public string TituloImpresion
        {
            get { return mTituloImpresion; }
        }
        protected void CellDoubleClickDriver(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ModoSeleccion)
                {
                    Int32 Id = Convert.ToInt32(MyGrillaDatos.Rows[e.RowIndex].Cells[0].Value);
                    String Cod = MyGrillaDatos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (IdSelected != null)
                        IdSelected(Id, Cod);
                    this.Close();
                }
                else
                {
                    Int32 Id = Convert.ToInt32(MyGrillaDatos.SelectedRows[0].Cells[0].Value);
                    ShowABMForm(Id);
                    BuscarDatos();
                }
            }
        }
        #endregion
    }
}