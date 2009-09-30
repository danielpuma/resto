using Controles;
namespace FastFood.ABM.Articulo
{
    partial class frmArticuloAdmin
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
            this.cboGrupoArticulo = new Controles.FSOCombo();
            this.txtCodigo = new Controles.FSOTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new Controles.FSOTextBox();
            this.chkPermiteStockNeg = new System.Windows.Forms.CheckBox();
            this.txtNombre = new Controles.FSOTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPrecios = new System.Windows.Forms.DataGridView();
            this.IdPrecioTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColListaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkStock = new System.Windows.Forms.CheckBox();
            this.chkCompuesto = new System.Windows.Forms.CheckBox();
            this.lnkVerComp = new System.Windows.Forms.LinkLabel();
            this.txtPDP = new Controles.NumericTextBox.DecimalTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGrupoArticulo
            // 
            this.cboGrupoArticulo.AnchoBoton = 20;
            this.cboGrupoArticulo.AnchoLabel = 105;
            this.cboGrupoArticulo.AnchoTxtCod = 100;
            this.cboGrupoArticulo.CodigoActual = "";
            this.cboGrupoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboGrupoArticulo.FiltrosCampos = "";
            this.cboGrupoArticulo.FiltrosValores = "";
            this.cboGrupoArticulo.IdSelected = -1;
            this.cboGrupoArticulo.Location = new System.Drawing.Point(12, 65);
            this.cboGrupoArticulo.Name = "cboGrupoArticulo";
            this.cboGrupoArticulo.ObjetoActual = null;
            this.cboGrupoArticulo.Size = new System.Drawing.Size(494, 21);
            this.cboGrupoArticulo.TabIndex = 2;
            this.cboGrupoArticulo.Texto = "Grupo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(121, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Código:";
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmdDelete.Location = new System.Drawing.Point(12, 460);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 12;
            this.CmdDelete.TabStop = false;
            this.CmdDelete.Text = "Eliminar";
            this.CmdDelete.UseVisualStyleBackColor = false;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(617, 460);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 11;
            this.cmdCancel.Text = "&Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(536, 460);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 10;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Observación:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 113);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(264, 243);
            this.txtDescripcion.TabIndex = 3;
            // 
            // chkPermiteStockNeg
            // 
            this.chkPermiteStockNeg.AutoSize = true;
            this.chkPermiteStockNeg.Enabled = false;
            this.chkPermiteStockNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPermiteStockNeg.Location = new System.Drawing.Point(12, 396);
            this.chkPermiteStockNeg.Name = "chkPermiteStockNeg";
            this.chkPermiteStockNeg.Size = new System.Drawing.Size(178, 17);
            this.chkPermiteStockNeg.TabIndex = 7;
            this.chkPermiteStockNeg.Text = "Permite Stock en Negativo";
            this.chkPermiteStockNeg.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(121, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(445, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Precios del Articulo";
            // 
            // dgPrecios
            // 
            this.dgPrecios.AllowUserToAddRows = false;
            this.dgPrecios.AllowUserToDeleteRows = false;
            this.dgPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPrecioTarea,
            this.ColListaPrecio,
            this.colNeto});
            this.dgPrecios.Location = new System.Drawing.Point(285, 113);
            this.dgPrecios.Name = "dgPrecios";
            this.dgPrecios.RowHeadersVisible = false;
            this.dgPrecios.Size = new System.Drawing.Size(407, 243);
            this.dgPrecios.TabIndex = 4;
            this.dgPrecios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPrecios_CellValueChanged);
            // 
            // IdPrecioTarea
            // 
            this.IdPrecioTarea.HeaderText = "IdPrecioTarea";
            this.IdPrecioTarea.Name = "IdPrecioTarea";
            this.IdPrecioTarea.Visible = false;
            // 
            // ColListaPrecio
            // 
            this.ColListaPrecio.HeaderText = "Lista de Precio";
            this.ColListaPrecio.Name = "ColListaPrecio";
            this.ColListaPrecio.ReadOnly = true;
            this.ColListaPrecio.Width = 200;
            // 
            // colNeto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.colNeto.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNeto.HeaderText = "Neto";
            this.colNeto.Name = "colNeto";
            // 
            // chkStock
            // 
            this.chkStock.AutoSize = true;
            this.chkStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStock.Location = new System.Drawing.Point(12, 373);
            this.chkStock.Name = "chkStock";
            this.chkStock.Size = new System.Drawing.Size(104, 17);
            this.chkStock.TabIndex = 5;
            this.chkStock.Text = "Maneja Stock";
            this.chkStock.UseVisualStyleBackColor = true;
            this.chkStock.CheckedChanged += new System.EventHandler(this.chkStock_CheckedChanged);
            // 
            // chkCompuesto
            // 
            this.chkCompuesto.AutoSize = true;
            this.chkCompuesto.Enabled = false;
            this.chkCompuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompuesto.Location = new System.Drawing.Point(12, 419);
            this.chkCompuesto.Name = "chkCompuesto";
            this.chkCompuesto.Size = new System.Drawing.Size(106, 17);
            this.chkCompuesto.TabIndex = 8;
            this.chkCompuesto.Text = "Es Compuesto";
            this.chkCompuesto.UseVisualStyleBackColor = true;
            this.chkCompuesto.CheckedChanged += new System.EventHandler(this.chkCompuesto_CheckedChanged);
            // 
            // lnkVerComp
            // 
            this.lnkVerComp.AutoSize = true;
            this.lnkVerComp.Enabled = false;
            this.lnkVerComp.Location = new System.Drawing.Point(135, 419);
            this.lnkVerComp.Name = "lnkVerComp";
            this.lnkVerComp.Size = new System.Drawing.Size(91, 13);
            this.lnkVerComp.TabIndex = 9;
            this.lnkVerComp.TabStop = true;
            this.lnkVerComp.Text = "Ver Componentes";
            this.lnkVerComp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerComp_LinkClicked);
            // 
            // txtPDP
            // 
            this.txtPDP.AllowSpace = false;
            this.txtPDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPDP.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPDP.Enabled = false;
            this.txtPDP.Location = new System.Drawing.Point(454, 371);
            this.txtPDP.Name = "txtPDP";
            this.txtPDP.Size = new System.Drawing.Size(100, 20);
            this.txtPDP.TabIndex = 6;
            this.txtPDP.Text = "0";
            this.txtPDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Punto de Pedido";
            // 
            // frmArticuloAdmin
            // 
            this.AcceptButton = this.cmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(695, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPDP);
            this.Controls.Add(this.lnkVerComp);
            this.Controls.Add(this.chkCompuesto);
            this.Controls.Add(this.chkStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPrecios);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPermiteStockNeg);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cboGrupoArticulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticuloAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Articulo";
            this.Load += new System.EventHandler(this.frmArticuloAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.FSOCombo cboGrupoArticulo;
        private FSOTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label4;
        private FSOTextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkPermiteStockNeg;
        private FSOTextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrecioTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColListaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeto;
        private System.Windows.Forms.CheckBox chkStock;
        private System.Windows.Forms.CheckBox chkCompuesto;
        private System.Windows.Forms.LinkLabel lnkVerComp;
        private Controles.NumericTextBox.DecimalTextBox txtPDP;
        private System.Windows.Forms.Label label2;
    }
}