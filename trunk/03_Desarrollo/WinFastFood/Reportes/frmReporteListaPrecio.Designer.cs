namespace WinFastFood.Reportes
{
    partial class frmReporteListaPrecio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboLDP = new Controles.FSOCombo();
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cboLDP
            // 
            this.cboLDP.AnchoBoton = 20;
            this.cboLDP.AnchoLabel = 190;
            this.cboLDP.AnchoTxtCod = 100;
            this.cboLDP.CodigoActual = "";
            this.cboLDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLDP.FiltrosCampos = "";
            this.cboLDP.FiltrosValores = "";
            this.cboLDP.IdSelected = -1;
            this.cboLDP.Location = new System.Drawing.Point(13, 2);
            this.cboLDP.Name = "cboLDP";
            this.cboLDP.ObjetoActual = null;
            this.cboLDP.Size = new System.Drawing.Size(860, 21);
            this.cboLDP.TabIndex = 0;
            this.cboLDP.Texto = "Lista de Precio";
            this.cboLDP.ObjetoSeleccionado += new Controles.SeleccionDeObjeto(this.cboLDP_ObjetoSeleccionado);
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.DisplayGroupTree = false;
            this.crv.Location = new System.Drawing.Point(0, 29);
            this.crv.Name = "crv";
            this.crv.SelectionFormula = "";
            this.crv.ShowGroupTreeButton = false;
            this.crv.Size = new System.Drawing.Size(901, 462);
            this.crv.TabIndex = 1;
            this.crv.ViewTimeSelectionFormula = "";
            // 
            // frmReporteListaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.crv);
            this.Controls.Add(this.cboLDP);
            this.Name = "frmReporteListaPrecio";
            this.Text = "Reporte de Precios";
            this.Load += new System.EventHandler(this.frmReporteListaPrecio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.FSOCombo cboLDP;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}