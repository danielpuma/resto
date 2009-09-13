namespace WinFastFood.Reportes
{
    partial class frmRankingArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtRange1 = new Controles.dtRange();
            this.cboMesa = new Controles.FSOCombo();
            this.cboMozo = new Controles.FSOCombo();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRange1
            // 
            this.dtRange1.Desde = new System.DateTime(2008, 4, 10, 0, 0, 0, 0);
            this.dtRange1.Hasta = new System.DateTime(2008, 4, 10, 23, 59, 59, 0);
            this.dtRange1.Location = new System.Drawing.Point(12, 12);
            this.dtRange1.Name = "dtRange1";
            this.dtRange1.RequiereDesde = false;
            this.dtRange1.RequiereHasta = false;
            this.dtRange1.Size = new System.Drawing.Size(297, 20);
            this.dtRange1.TabIndex = 0;
            // 
            // cboMesa
            // 
            this.cboMesa.AnchoBoton = 20;
            this.cboMesa.AnchoLabel = 50;
            this.cboMesa.AnchoTxtCod = 100;
            this.cboMesa.CodigoActual = "";
            this.cboMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMesa.FiltrosCampos = "";
            this.cboMesa.FiltrosValores = "";
            this.cboMesa.IdSelected = -1;
            this.cboMesa.Location = new System.Drawing.Point(13, 39);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.ObjetoActual = null;
            this.cboMesa.Size = new System.Drawing.Size(564, 21);
            this.cboMesa.TabIndex = 1;
            this.cboMesa.Texto = "Mesa";
            // 
            // cboMozo
            // 
            this.cboMozo.AnchoBoton = 20;
            this.cboMozo.AnchoLabel = 50;
            this.cboMozo.AnchoTxtCod = 100;
            this.cboMozo.CodigoActual = "";
            this.cboMozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMozo.FiltrosCampos = "";
            this.cboMozo.FiltrosValores = "";
            this.cboMozo.IdSelected = -1;
            this.cboMozo.Location = new System.Drawing.Point(12, 67);
            this.cboMozo.Name = "cboMozo";
            this.cboMozo.ObjetoActual = null;
            this.cboMozo.Size = new System.Drawing.Size(564, 21);
            this.cboMozo.TabIndex = 2;
            this.cboMozo.Texto = "Mozo:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConsultar.Location = new System.Drawing.Point(639, 67);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgDatos.Location = new System.Drawing.Point(4, 94);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.Size = new System.Drawing.Size(710, 284);
            this.dgDatos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Monto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmRankingArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 380);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cboMozo);
            this.Controls.Add(this.cboMesa);
            this.Controls.Add(this.dtRange1);
            this.Name = "frmRankingArticulo";
            this.Text = "Ranking de Ventas Por Articulo";
            this.Load += new System.EventHandler(this.frmRankingArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.dtRange dtRange1;
        private Controles.FSOCombo cboMesa;
        private Controles.FSOCombo cboMozo;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}