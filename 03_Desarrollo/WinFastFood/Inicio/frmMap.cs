using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood.BB.CoreExtension;
using FastFood.Core;
using WinFastFood.Modulos.Pedido;

namespace WinFastFood.Inicio
{
    public partial class frmMap : Form
    {
        private int[,] MesasMapeadas = new int[50, 50];
        private bool CambiarImagenDeCelda = true;
        public frmMap()
        {
            InitializeComponent();
            

        }

        private void dgMap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            redibujarcelda(dgMap.Rows[e.RowIndex].Cells[e.ColumnIndex],true);
        }

        private void dgMap_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            redibujarcelda(dgMap.Rows[e.RowIndex].Cells[e.ColumnIndex],false);
           
        }

        private void redibujarcelda(DataGridViewCell dataGridViewCell, bool Seleccionada)
        {
            if (CambiarImagenDeCelda)
            {

                if (dataGridViewCell.Tag == null)
                {
                    dataGridViewCell.Tag = "Libre";
                }
                switch (dataGridViewCell.Tag.ToString())
                {
                    case "Libre": 
                        dataGridViewCell.Value = Seleccionada? 
                            global::WinFastFood.Properties.Resources.BaldosaSeleccion:
                                global::WinFastFood.Properties.Resources.Baldosa; break;
                    case "MesaLibre": 
                            dataGridViewCell.Value = Seleccionada? 
                                global::WinFastFood.Properties.Resources.BaldosaSeleccionMesaLibre:
                                   global::WinFastFood.Properties.Resources.BaldosaConMesaLibre; break;
                    case "MesaOcupada": 
                        dataGridViewCell.Value = Seleccionada? 
                            global::WinFastFood.Properties.Resources.BaldosaSeleccionMesaOcupada:
                                global::WinFastFood.Properties.Resources.BaldosaConMesaOcupada; break;
                }

            }
        }
        

        private void asignarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarImagenDeCelda = false;
            dgMap.Enabled = false;
            pnlAddMesa.Visible = true;
            pnlAddMesa.Top = dgMap.Top;
            pnlAddMesa.Left = dgMap.Left;
            fsoMesa.Focus();
        }

 

        private void cmdCancelAddMesa_Click(object sender, EventArgs e)
        {

                dgMap.Enabled = true;
                pnlAddMesa.Visible = false;
                CambiarImagenDeCelda = true;
        }

        private void cmdUbicarMesa_Click(object sender, EventArgs e)
        {
                CambiarImagenDeCelda = true;
                dgMap.Enabled = true;
                pnlAddMesa.Visible = false;
                int _Fila = dgMap.SelectedCells[0].RowIndex;
                int _Columna = dgMap.SelectedCells[0].ColumnIndex;
                BBMesa BBM = new BBMesa();
                Mesa M = (Mesa)fsoMesa.ObjetoActual;
                if (M != null)
                {
                    //Debo Buscar si aqui habia una mesa antes.
                    if (MesasMapeadas[_Fila, _Columna] > 0)
                    {
                        int IdMesaAnterior = MesasMapeadas[_Fila, _Columna];
                        Mesa MesaAnterior = BBM.GetById(IdMesaAnterior, false);
                        MesaAnterior.Fila = -1;
                        MesaAnterior.Columna = -1;
                        BBM.Guardar(MesaAnterior);
                    }
                    else
                    
                    if (M.Fila >= 0) //Esta Ubicada, redibujo la ubicacion anterior como libre
                    {
                        dgMap.Rows[M.Fila].Cells[M.Columna].Tag = "Libre";
                        redibujarcelda(dgMap.Rows[M.Fila].Cells[M.Columna],false);
                    }
                                    

                    M.Fila = _Fila;
                    M.Columna = _Columna;
                    BBM.Guardar(M);

                    DibujarMesa(M,true);
                }
                else {
                    //Buscar si habia una mesa aqui.
                    if (MesasMapeadas[_Fila, _Columna] != 0)
                    {
                        int idMesa = MesasMapeadas[_Fila, _Columna];
                        M = BBM.GetById(idMesa, false);
                        M.Fila = -1;
                        M.Columna = -1;
                        BBM.Guardar(M);
                    }
                    dgMap.SelectedCells[0].Tag = "Libre";
                    redibujarcelda(dgMap.SelectedCells[0], true);
                }
                
          

        }

        private void DibujarMesa(Mesa M, bool DibujarConSeleccion)
        {


            MesasMapeadas[M.Fila, M.Columna] = M.ID;
            dgMap.Rows[M.Fila].Cells[M.Columna].Tag = M.Ocupada ? "MesaOcupada" : "MesaLibre";
            string sToolTip = "Mesa: " + M.MiDescripcion;
            if (M.Ocupada)
            {
                BBPedido BBP = new BBPedido();
                Pedido PedActual = BBP.GetPedidoPendientePorMesa(M.ID);
                if (PedActual != null)
                {
                    sToolTip += " - Mozo: " + PedActual.Usuario.Nombre;
                    if (PedActual.Ocupantes > 0)
                    {
                        sToolTip += " - Ocup: " + PedActual.Ocupantes;
                    }
                }
                sToolTip += " - Facturación Actual: " + PedActual.TotalFacturado.ToString("N2");
            }

            dgMap.Rows[M.Fila].Cells[M.Columna].ToolTipText = sToolTip;
            redibujarcelda(dgMap.Rows[M.Fila].Cells[M.Columna], DibujarConSeleccion);
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void InicializarGrilla()
        {
            MesasMapeadas = new int[50, 50];
            dgMap.Rows.Clear();
            dgMap.Columns.Clear();
            for (int i = 0; i <= 49; i++)
            {
                System.Windows.Forms.DataGridViewImageColumn C;
                C = new System.Windows.Forms.DataGridViewImageColumn();
                C.HeaderText = "Column1";
                C.Name = "Column1";
                C.ReadOnly = true;
                C.Image = global::WinFastFood.Properties.Resources.Baldosa;
                
                dgMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { C });
                fsoMesa.SetComboBinding(new BBMesa(), "", "");
            }

            
            for (int i = 1; i <= 50; i++)
            {
                dgMap.Rows.Add();
            }
            dibujarMesas();
        }

        private void dibujarMesas()
        {
            List<Mesa> Mesas = new BBMesa().GetAll();
            foreach(Mesa mesa in Mesas)
            {
                if (mesa.Fila >= 0)
                {
                    DibujarMesa(mesa,false);
                }            
            }
        }



        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void dgMap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int _Fila = dgMap.SelectedCells[0].RowIndex;
            int _Columna = dgMap.SelectedCells[0].ColumnIndex;
            if (MesasMapeadas[_Fila, _Columna] > 0)
            {
                int IdMesa = MesasMapeadas[_Fila, _Columna];
                BBPedido BP = new BBPedido();
                Pedido p = BP.GetPedidoPendientePorMesa(IdMesa);
                PedidoAdmin frmPed = new PedidoAdmin();
                if(p!=null)
                    frmPed.MyObject=p;
                frmPed.ShowDialog(this);
                InicializarGrilla();
                
            }
        }

        private void consultarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int _Fila = dgMap.SelectedCells[0].RowIndex;
            int _Columna = dgMap.SelectedCells[0].ColumnIndex;
            if (MesasMapeadas[_Fila, _Columna] > 0)
            {
                int IdMesa = MesasMapeadas[_Fila, _Columna];
                frmPedidoList f = new frmPedidoList();
                f.WindowState = FormWindowState.Maximized;
                f.MdiParent = this.ParentForm;
                f.IdMesa = IdMesa;
                f.Show();
            }

        }

    }
}