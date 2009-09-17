using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.Core;
using FastFood.BB.CoreExtension;

namespace WinFastFood.Modulos.Articulos
{
    public partial class frmComponentes : Form
    {
        public Articulo ArticuloPadre;
        public frmComponentes()
        {
            InitializeComponent();
           
        }

        private void frmComponentes_Load(object sender, EventArgs e)
        {
            if (ArticuloPadre != null && ArticuloPadre.ID > 0)
            {
                label1.Text = "[" + ArticuloPadre.Codigo + "] " + ArticuloPadre.Nombre;
                cboCompo.SetComboBinding(new BBArticulo(), "", "");
                CargarComponentes();
            }
        }

        private void CargarComponentes()
        {
            BBComposicionArticulo BBCA = new BBComposicionArticulo();
            List<ComposicionArticulo> Listado = BBCA.GetByArticulo(ArticuloPadre);
            foreach (ComposicionArticulo componente in Listado)
            {
                string[] valores = new string[6];
                valores[0] = componente.ArticuloComponente.ID.ToString();
                valores[1] = componente.ArticuloComponente.Codigo;
                valores[2] = componente.ArticuloComponente.Nombre;
                valores[3] = componente.Cantidad.ToString("N2");
                valores[4] = componente.ArticuloComponente.EsCompuesto.ToString();
                valores[5] = "Ver Componentes";
                dgDatos.Rows.Add(valores);
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            BBComposicionArticulo BBCA = new BBComposicionArticulo();
            if (cboCompo.ObjetoActual != null)
            {
                Articulo componente = (Articulo)cboCompo.ObjetoActual;
                if (componente.ID != ArticuloPadre.ID)
                {
                    decimal Cant = txtCantidad.DecimalValue;
                    if (Cant > 0)
                    {
                        if (!BBCA.Es_A_PadreDe_B(componente, ArticuloPadre))
                        {
                            string[] valores = new string[6];
                            valores[0] = componente.ID.ToString();
                            valores[1] = componente.Codigo;
                            valores[2] = componente.Nombre;
                            valores[3] = txtCantidad.DecimalValue.ToString("N2");
                            valores[4] = componente.EsCompuesto.ToString();
                            valores[5] = "Ver Componentes";
                            dgDatos.Rows.Add(valores);
                        }
                        else
                        {
                            MessageBox.Show("No puede crear referencias circulares entre articulos componentes");
                        }
                    }
                    else {
                        MessageBox.Show("La Cantidad debe ser mayor a cero.");
                    }
                }
                else {
                    MessageBox.Show("No puede referenciar un articulo como compuesto de si mismo.");
                }
            }
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDatos.SelectedCells[0].ColumnIndex == 5)
            {
                Articulo NuevoPAdre = new Articulo();
                BBArticulo BBA = new BBArticulo();
                int Id = Convert.ToInt32(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[0].Value);
                NuevoPAdre = BBA.GetById(Id, false);
                if(NuevoPAdre.EsCompuesto)
                {
                    frmComponentes NuevoCompo = new frmComponentes();
                    NuevoCompo.ArticuloPadre =  NuevoPAdre;
                    NuevoCompo.ShowDialog(this);
                }
            }
        }



        private void dgDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo CompoActual = new Articulo();
            BBArticulo BBA = new BBArticulo();
            int Id = Convert.ToInt32(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[0].Value);
            CompoActual = BBA.GetById(Id, false);
            cboCompo.ObjetoActual = CompoActual;
            txtCantidad.DecimalValue = Convert.ToDecimal(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[3].Value);
            dgDatos.Rows.RemoveAt(dgDatos.SelectedCells[0].RowIndex);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                BBComposicionArticulo BBCA = new BBComposicionArticulo();
                BBCA.BorrarPorArticulo(ArticuloPadre);
                BBArticulo BBA = new BBArticulo();
                foreach (DataGridViewRow row in dgDatos.Rows)
                {
                    ComposicionArticulo ca = new ComposicionArticulo();
                    ca.ArticuloPadre = ArticuloPadre;
                    ca.Cantidad = Convert.ToDecimal(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[3].Value);
                    int Id = Convert.ToInt32(dgDatos.Rows[dgDatos.SelectedCells[0].RowIndex].Cells[0].Value);
                    ca.ArticuloComponente = BBA.GetById(Id, false);
                    BBCA.Guardar(ca);
                }
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
			
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedCells.Count > 0)
            {

                dgDatos.Rows.RemoveAt(dgDatos.SelectedCells[0].RowIndex);
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}