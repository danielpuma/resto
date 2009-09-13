namespace WinFastFood.Modulos.Pedido
{
    partial class frmPreview
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
            this.crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv
            // 
            this.crv.ActiveViewIndex = -1;
            this.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv.DisplayGroupTree = false;
            this.crv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv.Location = new System.Drawing.Point(0, 0);
            this.crv.Name = "crv";
            this.crv.SelectionFormula = "";
            this.crv.Size = new System.Drawing.Size(777, 633);
            this.crv.TabIndex = 0;
            this.crv.ViewTimeSelectionFormula = "";
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 633);
            this.Controls.Add(this.crv);
            this.Name = "frmPreview";
            this.Text = "Comprobante de Venta";
            this.Load += new System.EventHandler(this.frmPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv;
    }
}