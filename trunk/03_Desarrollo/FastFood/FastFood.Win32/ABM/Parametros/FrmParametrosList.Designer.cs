namespace FastFood.Win32.ABM.Mesas
{
    partial class FrmParametrosList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametrosList));
            this.fsoSimpleParameterABMList1 = new Controles.FSOSimpleParameterABMList();
            this.SuspendLayout();
            // 
            // fsoSimpleParameterABMList1
            // 
            this.fsoSimpleParameterABMList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fsoSimpleParameterABMList1.DS = null;
            this.fsoSimpleParameterABMList1.Location = new System.Drawing.Point(0, 0);
            this.fsoSimpleParameterABMList1.Name = "fsoSimpleParameterABMList1";
            this.fsoSimpleParameterABMList1.PreFiltroCampos = "";
            this.fsoSimpleParameterABMList1.PreFiltroValores = "";
            this.fsoSimpleParameterABMList1.Size = new System.Drawing.Size(639, 508);
            this.fsoSimpleParameterABMList1.TabIndex = 0;
            this.fsoSimpleParameterABMList1.Titulo = "Administración de Mesas";
            this.fsoSimpleParameterABMList1.EliminarRegistro += new Controles._EliminarRegistro(this.fsoSimpleParameterABMList1_EliminarRegistro);
            this.fsoSimpleParameterABMList1.ActualizacionDeDatosRequerida += new Controles._ActualizacionDeDatosRequerida(this.fsoSimpleParameterABMList1_ActualizacionDeDatosRequerida);
            // 
            // FrmParametrosList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 508);
            this.Controls.Add(this.fsoSimpleParameterABMList1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmParametrosList";
            this.Text = "FastFood 2008";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmParametrosList_KeyDown);
            this.Load += new System.EventHandler(this.FrmParametrosList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.FSOSimpleParameterABMList fsoSimpleParameterABMList1;

    }
}