using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using System.Collections;
using FastFood.Core.Domain.Consultas;
using FSO.NH.Seguridad.BB;
using ToolBox;

namespace WinFastFood.Reportes
{
    public partial class frmRankingArticulo : Form, PrinteableForm
    {
        public frmRankingArticulo()
        {
            InitializeComponent();
        }

        private void frmRankingArticulo_Load(object sender, EventArgs e)
        {
            cboMesa.SetComboBinding(new BBMesa(), "", "");
            cboMozo.SetComboBinding(new BBUsuario(), "", "");
            dtRange1.Hasta = DateTime.Now;
            dtRange1.Desde = DateTime.Now.AddDays(-30);

        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            BBArticulo bba = new BBArticulo();
            IList<Ranking> lista = bba.GetRanking(dtRange1.Desde.Value, dtRange1.Hasta.Value, cboMesa.IdSelected, cboMozo.IdSelected);
            dgDatos.Rows.Clear();
            foreach (Ranking r in lista)
            {
                object[] rnk = new object[4];
                rnk[0] = r.Codigo;
                rnk[1] = r.Nombre;
                rnk[2] = r.TotalCantidad;
                rnk[3] = r.TotalImporte;
                dgDatos.Rows.Add(rnk);
            }
        }

        #region PrinteableForm Members

        public DataGridView MyDataGrid
        {
            get { return dgDatos; }
        }

        public string TituloImpresion
        {
            get { return "Ranking de Ventas por Articulo"; }
        }

        #endregion
    }
}