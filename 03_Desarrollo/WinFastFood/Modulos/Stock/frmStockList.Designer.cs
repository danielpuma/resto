namespace WinFastFood.Modulos.Stock
{
    partial class frmStockList
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
            this.cboArticulo = new Controles.FSOCombo();
            this.dtR = new Controles.dtRange();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdIngresos = new System.Windows.Forms.Button();
            this.cmdEgresos = new System.Windows.Forms.Button();
            this.cmdVerPedido = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStkIni = new System.Windows.Forms.Label();
            this.lblStkFinal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPDP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboArticulo
            // 
            this.cboArticulo.AnchoBoton = 20;
            this.cboArticulo.AnchoLabel = 80;
            this.cboArticulo.AnchoTxtCod = 100;
            this.cboArticulo.CodigoActual = "";
            this.cboArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboArticulo.FiltrosCampos = "";
            this.cboArticulo.FiltrosValores = "";
            this.cboArticulo.IdSelected = -1;
            this.cboArticulo.Location = new System.Drawing.Point(12, 12);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.ObjetoActual = null;
            this.cboArticulo.Size = new System.Drawing.Size(564, 21);
            this.cboArticulo.TabIndex = 0;
            this.cboArticulo.Texto = "Artículo:";
            // 
            // dtR
            // 
            this.dtR.Desde = new System.DateTime(2008, 4, 10, 0, 0, 0, 0);
            this.dtR.Hasta = new System.DateTime(2008, 4, 10, 23, 59, 59, 0);
            this.dtR.Location = new System.Drawing.Point(13, 40);
            this.dtR.Name = "dtR";
            this.dtR.RequiereDesde = false;
            this.dtR.RequiereHasta = false;
            this.dtR.Size = new System.Drawing.Size(297, 20);
            this.dtR.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(904, 52);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdIngresos
            // 
            this.cmdIngresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresos.Location = new System.Drawing.Point(823, 52);
            this.cmdIngresos.Name = "cmdIngresos";
            this.cmdIngresos.Size = new System.Drawing.Size(75, 23);
            this.cmdIngresos.TabIndex = 3;
            this.cmdIngresos.Text = "Ingresos";
            this.cmdIngresos.UseVisualStyleBackColor = true;
            // 
            // cmdEgresos
            // 
            this.cmdEgresos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEgresos.Location = new System.Drawing.Point(742, 52);
            this.cmdEgresos.Name = "cmdEgresos";
            this.cmdEgresos.Size = new System.Drawing.Size(75, 23);
            this.cmdEgresos.TabIndex = 4;
            this.cmdEgresos.Text = "Egresos";
            this.cmdEgresos.UseVisualStyleBackColor = true;
            // 
            // cmdVerPedido
            // 
            this.cmdVerPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerPedido.Location = new System.Drawing.Point(652, 52);
            this.cmdVerPedido.Name = "cmdVerPedido";
            this.cmdVerPedido.Size = new System.Drawing.Size(84, 23);
            this.cmdVerPedido.TabIndex = 5;
            this.cmdVerPedido.Text = "Ver Pedido";
            this.cmdVerPedido.UseVisualStyleBackColor = true;
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
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgDatos.Location = new System.Drawing.Point(12, 101);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.Size = new System.Drawing.Size(979, 557);
            this.dgDatos.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdPedido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "IdExterno";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Nro. Pedido";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Articulo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stock";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(654, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock Inicial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStkIni
            // 
            this.lblStkIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStkIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStkIni.Location = new System.Drawing.Point(735, 78);
            this.lblStkIni.Name = "lblStkIni";
            this.lblStkIni.Size = new System.Drawing.Size(82, 20);
            this.lblStkIni.TabIndex = 8;
            this.lblStkIni.Text = "0.00";
            this.lblStkIni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStkFinal
            // 
            this.lblStkFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStkFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStkFinal.Location = new System.Drawing.Point(897, 78);
            this.lblStkFinal.Name = "lblStkFinal";
            this.lblStkFinal.Size = new System.Drawing.Size(82, 20);
            this.lblStkFinal.TabIndex = 10;
            this.lblStkFinal.Text = "0.00";
            this.lblStkFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(823, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock Final:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPDP
            // 
            this.lblPDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDP.Location = new System.Drawing.Point(560, 78);
            this.lblPDP.Name = "lblPDP";
            this.lblPDP.Size = new System.Drawing.Size(82, 20);
            this.lblPDP.TabIndex = 12;
            this.lblPDP.Text = "0.00";
            this.lblPDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "P. de Pedido:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 657);
            this.Controls.Add(this.lblPDP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStkFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStkIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.cmdVerPedido);
            this.Controls.Add(this.cmdEgresos);
            this.Controls.Add(this.cmdIngresos);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.dtR);
            this.Controls.Add(this.cboArticulo);
            this.Name = "frmStockList";
            this.Text = "Consultas detalladas de Stock";
            this.Load += new System.EventHandler(this.frmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.FSOCombo cboArticulo;
        private Controles.dtRange dtR;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdIngresos;
        private System.Windows.Forms.Button cmdEgresos;
        private System.Windows.Forms.Button cmdVerPedido;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStkIni;
        private System.Windows.Forms.Label lblStkFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPDP;
        private System.Windows.Forms.Label label6;
    }
}