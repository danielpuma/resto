using Controles;
namespace FastFood.ABM.Articulo
{
    partial class frmArticuloList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MyGrillaDatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new Controles.FSOTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboGrupoArticulo = new Controles.FSOCombo();
            this.txtNombre = new Controles.FSOTextBox();
            this.chkSoloStock = new System.Windows.Forms.CheckBox();
            this.chkStockCritico = new System.Windows.Forms.CheckBox();
            this.chkMostrarStock = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrillaDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyGrillaDatos
            // 
            this.MyGrillaDatos.AllowUserToAddRows = false;
            this.MyGrillaDatos.AllowUserToDeleteRows = false;
            this.MyGrillaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MyGrillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGrillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Col1,
            this.Col2,
            this.Col3,
            this.Column1,
            this.Column3,
            this.Column2});
            this.MyGrillaDatos.Location = new System.Drawing.Point(0, 141);
            this.MyGrillaDatos.Name = "MyGrillaDatos";
            this.MyGrillaDatos.ReadOnly = true;
            this.MyGrillaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGrillaDatos.Size = new System.Drawing.Size(844, 379);
            this.MyGrillaDatos.TabIndex = 8;
            this.MyGrillaDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Código";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Width = 80;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Nombre";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Width = 250;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Grupo de Artículo";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Width = 250;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Controla Stock";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "P. de Pedido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Stock Actual";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Location = new System.Drawing.Point(759, 115);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(73, 23);
            this.cmdNuevo.TabIndex = 7;
            this.cmdNuevo.Text = "Nuevo";
            this.toolTip1.SetToolTip(this.cmdNuevo, "Crear Nuevo Articulo");
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(681, 115);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(72, 23);
            this.cmdBuscar.TabIndex = 6;
            this.cmdBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.cmdBuscar, "Buscar Articulos");
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(125, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCodigo, "Seleccione el Dominio (Patente)  del Articulo a buscar");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Administración de Artículos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 47);
            this.panel1.TabIndex = 78;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipTitle = "FastFood";
            // 
            // cboGrupoArticulo
            // 
            this.cboGrupoArticulo.AnchoBoton = 20;
            this.cboGrupoArticulo.AnchoLabel = 150;
            this.cboGrupoArticulo.AnchoTxtCod = 100;
            this.cboGrupoArticulo.CodigoActual = "";
            this.cboGrupoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboGrupoArticulo.FiltrosCampos = "";
            this.cboGrupoArticulo.FiltrosValores = "";
            this.cboGrupoArticulo.IdSelected = -1;
            this.cboGrupoArticulo.Location = new System.Drawing.Point(19, 87);
            this.cboGrupoArticulo.Name = "cboGrupoArticulo";
            this.cboGrupoArticulo.ObjetoActual = null;
            this.cboGrupoArticulo.Size = new System.Drawing.Size(596, 21);
            this.cboGrupoArticulo.TabIndex = 3;
            this.cboGrupoArticulo.Texto = "Grupo de Artículo:";
            this.toolTip1.SetToolTip(this.cboGrupoArticulo, "Seleccione aquí la marca de los Articulos a buscar");
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(320, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(295, 20);
            this.txtNombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNombre, "Seleccione el Nombre del Artículo");
            // 
            // chkSoloStock
            // 
            this.chkSoloStock.AutoSize = true;
            this.chkSoloStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloStock.Location = new System.Drawing.Point(19, 115);
            this.chkSoloStock.Name = "chkSoloStock";
            this.chkSoloStock.Size = new System.Drawing.Size(168, 17);
            this.chkSoloStock.TabIndex = 4;
            this.chkSoloStock.Text = "Solo Artículos con Stock";
            this.toolTip1.SetToolTip(this.chkSoloStock, "Muestra solo artículos que manejan Stock");
            this.chkSoloStock.UseVisualStyleBackColor = true;
            this.chkSoloStock.CheckedChanged += new System.EventHandler(this.chkSoloStock_CheckedChanged);
            // 
            // chkStockCritico
            // 
            this.chkStockCritico.AutoSize = true;
            this.chkStockCritico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStockCritico.Location = new System.Drawing.Point(207, 115);
            this.chkStockCritico.Name = "chkStockCritico";
            this.chkStockCritico.Size = new System.Drawing.Size(210, 17);
            this.chkStockCritico.TabIndex = 5;
            this.chkStockCritico.Text = "Solo Artículos con Stock Crítico";
            this.toolTip1.SetToolTip(this.chkStockCritico, "Muestra solo los artículos con stock por debajo del punto de pedido");
            this.chkStockCritico.UseVisualStyleBackColor = true;
            this.chkStockCritico.CheckedChanged += new System.EventHandler(this.chkStockCritico_CheckedChanged);
            // 
            // chkMostrarStock
            // 
            this.chkMostrarStock.AutoSize = true;
            this.chkMostrarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarStock.Location = new System.Drawing.Point(655, 61);
            this.chkMostrarStock.Name = "chkMostrarStock";
            this.chkMostrarStock.Size = new System.Drawing.Size(149, 17);
            this.chkMostrarStock.TabIndex = 2;
            this.chkMostrarStock.Text = "Calcular Stock Actual";
            this.toolTip1.SetToolTip(this.chkMostrarStock, "Incluye en el Listado los Valores actuales de Stock por cada articulo.");
            this.chkMostrarStock.UseVisualStyleBackColor = true;
            this.chkMostrarStock.CheckedChanged += new System.EventHandler(this.chkMostrarStock_CheckedChanged);
            // 
            // frmArticuloList
            // 
            this.AcceptButton = this.cmdBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
            this.Controls.Add(this.chkMostrarStock);
            this.Controls.Add(this.chkStockCritico);
            this.Controls.Add(this.chkSoloStock);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboGrupoArticulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyGrillaDatos);
            this.KeyPreview = true;
            this.Name = "frmArticuloList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.frmArticuloList_Load);
            this.SizeChanged += new System.EventHandler(this.frmArticuloList_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrillaDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyGrillaDatos;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label label3;
        private FSOTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private Controles.FSOCombo cboGrupoArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private FSOTextBox txtNombre;
        private System.Windows.Forms.CheckBox chkSoloStock;
        private System.Windows.Forms.CheckBox chkStockCritico;
        private System.Windows.Forms.CheckBox chkMostrarStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}