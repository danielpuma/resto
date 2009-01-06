using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FastFood.ABM.GenericParameter
{
    public delegate void Click_Driver();
    public delegate void CellDoubleClick_Driver (object sender, DataGridViewCellEventArgs e);
    public partial class ListUserControl : UserControl
    {
        public event Click_Driver BuscarClick;
        public event Click_Driver NuevoClick;
        public event CellDoubleClick_Driver CellDoubleClick;

        public int TopPositionDataGrid
        {
            get { return GrillaDatos.Top; }
            set { 
                    GrillaDatos.Top = value;
                    cmdBuscar.Top = GrillaDatos.Top - cmdBuscar.Width;
                    cmdNuevo.Top = GrillaDatos.Top - cmdNuevo.Width;
                    GrillaDatos.Height = this.Height - (GrillaDatos.Top + 20);
                }
        }

        public ListUserControl()
        {
            InitializeComponent();
        }
        public TextBox GetCodeTextBox
        {
            get { return txtCodigo; }
        }
        public TextBox GetDescTextBox
        {
            get { return txtDescripcion; }
        }
        public DataGridView GetGrillaDatos
        {
            get { return GrillaDatos; }
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            if (BuscarClick != null)
                BuscarClick();
        }
        public string Titulo
        {
            set { label5.Text = value; this.Refresh(); }
            get { return label5.Text; }
        }
        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            if (NuevoClick != null)
                NuevoClick();
        }

        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CellDoubleClick != null)
                CellDoubleClick(sender,e);
        }
    }
}
