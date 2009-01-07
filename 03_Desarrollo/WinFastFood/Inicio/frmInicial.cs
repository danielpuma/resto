using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastFood;
using ToolBox;
using FSO.NH.Seguridad.BB;
using FSO.NH.Auditoria;
using FSO.NH.CodigoDeSeguridad;
using ABM.Usuarios.FastFood;
using System.Drawing.Printing;
using CompletIT.Windows.Forms.Export.Excel;
using FastFood.ABM.Parametros;
using FastFood.ABM.Articulo;

namespace WinFastFood.Inicio
{
    public partial class frmInicial : Form
    {
        public Ingreso MyIngreso;
        private DataGridViewPrinter MyDataGridViewPrinter;

        private void frmInicial_Load(object sender, EventArgs e)
        {
            InicializarSeguridad();
        }

        #region SEGURIDAD
        private void InicializarSeguridad()
        {
            try
            {
                StateUserName.Text = "Usr: " + Win32Session.UsuarioActual.Apellido.ToUpper() + ", " + Win32Session.UsuarioActual.Nombre.ToUpper();
                StateDB.Text = "BD: " + Win32Session.DbServer.ToUpper();
                //HabilitarMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void HabilitarMenu(ToolStripMenuItem mnu)
        {
            string Permiso = mnu.Tag + "List";
            mnu.Enabled = VerificarPermiso(Permiso);
        }
        private void HabilitarMenu(ToolStripButton mnu)
        {
            string Permiso = mnu.Tag + "List";
            mnu.Enabled = VerificarPermiso(Permiso);
        }
        private bool VerificarPermiso(string PermisoSolicitado)
        {
            BBUsuario BBU = new BBUsuario();
            return BBU.TienePermiso(Win32Session.UsuarioActual, PermisoSolicitado);
        }
        
        #endregion

        private void frmInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Realmente desea cerrar la aplicación?", "Confirme su acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No)
            {
                e.Cancel = true;
                MyIngreso.Visible = false;
                this.Visible = true;
            }
        }
        public frmInicial(Ingreso pIngreso)
        {
            InitializeComponent();
            MyIngreso = pIngreso;
            ValidadorCodigoSeguridad validador = new ValidadorCodigoSeguridad();
            if (validador.VerificarModoDemo())
            {
                activarSoftwareToolStripMenuItem.Enabled = true;
            }
            else {
                activarSoftwareToolStripMenuItem.Enabled = false;
            }
        }
        #region Impresion Generica de Grillas
        private bool SetupThePrinting(String Titulo, DataGridView GrillaDatos)
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;

            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            printDocument1.DocumentName = "Customers Report";
            printDocument1.PrinterSettings =
                                MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings =
            MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins =
                             new Margins(40, 40, 40, 40);

            if (MessageBox.Show("Desea Imprimir en el Centro de la Pagina?",
                "InvoiceManager - Center on Page", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                MyDataGridViewPrinter = new DataGridViewPrinter(GrillaDatos,
                printDocument1, true, true, Titulo, new Font("Tahoma", 18,
                FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            else
                MyDataGridViewPrinter = new DataGridViewPrinter(GrillaDatos,
                printDocument1, false, true, Titulo, new Font("Tahoma", 18,
                FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        #endregion
        #region MENU CONTROL

        private void tiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("TipoDeDoc"));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmUserList());
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("Rol"));
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("Permiso"));
        }
        public void ShowWindows(Form myFrm)
        {
            try
            {
                myFrm.WindowState = FormWindowState.Maximized;
                myFrm.MdiParent = this;
                myFrm.Show();
            }
            catch { }
        } 
        #endregion

        #region TAB CONTROL
        private void tabPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((XtabPages.SelectedTab != null) && (XtabPages.SelectedTab.Tag != null))
                (XtabPages.SelectedTab.Tag as Form).Select();
        }
        private void frmInicial_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                XtabPages.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState =
                FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage 
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild
                                             .Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = XtabPages;
                    XtabPages.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed +=
                        new FormClosedEventHandler(
                                        ActiveMdiChild_FormClosed);
                }

                if (!XtabPages.Visible) XtabPages.Visible = true;

            }
        }
        private void ActiveMdiChild_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();

        }
        
        #endregion


        #region TOOLBAR CONROL
        private void cmdSalir_Click(object sender, EventArgs e)
        {
                   
            DialogResult rta = MessageBox.Show("¿Realmente desea cerrar la aplicación?", "Confirme su acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                PrinteableForm ActForm = (PrinteableForm)this.ActiveMdiChild;

                if (SetupThePrinting(ActForm.TituloImpresion, ActForm.MyDataGrid))
                {
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Impresión no está disponible en este momento:" + ex.Message);
            }
        }
        private void cmdExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                PrinteableForm ActForm = (PrinteableForm)this.ActiveMdiChild;
                DGVEExcelExporter exporter = new DGVEExcelExporter();
                CompletIT.Windows.Forms.Export.Excel.DGVEExcelExportSettings Settings = new CompletIT.Windows.Forms.Export.Excel.DGVEExcelExportSettings();
                Settings.ExportColumnHeaders = true;
                Settings.ExportHiddenColumns = false;
                Settings.ExportHiddenRows = false;
                Settings.ExportImages = false;
                Settings.OpenFolderAfterGeneration = false;
                Settings.ExportRowHeaders = false;
                Settings.ExportVisualStyles = false;
                Settings.OpenFileAfterGeneration = true;
                exporter.Export(ActForm.MyDataGrid, Settings);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("La Exportación a Excel no está disponible en este momento: " + ex.Message);
            }
        }
        
        #endregion

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyIngreso.Finalizar = false;
            MyIngreso.Visible = true;
            this.Visible = false;
        }

        private void XlistasDePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("ListaPrecio"));
        }

        private void XgruposDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("GrupoArticulo"));
        }

        private void XmesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmParametrosList("Mesa"));
        }

        private void artìculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindows(new frmArticuloList());
        }

        private void XgestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
