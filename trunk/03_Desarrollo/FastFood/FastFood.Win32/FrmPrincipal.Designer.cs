namespace FastFood.Win32
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosXArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IDMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmdNuevoPedido = new System.Windows.Forms.Button();
            this.chkOpenMesas = new System.Windows.Forms.CheckBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.fsoPersonal = new Controles.FSOCombo();
            this.cmdEstadisticas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.pedidosXArticuloToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // pedidosXArticuloToolStripMenuItem
            // 
            this.pedidosXArticuloToolStripMenuItem.Name = "pedidosXArticuloToolStripMenuItem";
            this.pedidosXArticuloToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pedidosXArticuloToolStripMenuItem.Text = "Pedidos X Artìculo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.fsoPersonal);
            this.splitContainer1.Panel1.Controls.Add(this.chkOpenMesas);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(721, 550);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMesa,
            this.CodigoMesa,
            this.DescripcionMesa});
            this.dgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDatos.Location = new System.Drawing.Point(0, 0);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(617, 475);
            this.dgDatos.StandardTab = true;
            this.dgDatos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FASTFOOD 2008";
            // 
            // IDMesa
            // 
            this.IDMesa.HeaderText = "Column1";
            this.IDMesa.Name = "IDMesa";
            this.IDMesa.ReadOnly = true;
            this.IDMesa.Visible = false;
            // 
            // CodigoMesa
            // 
            this.CodigoMesa.HeaderText = "Código";
            this.CodigoMesa.Name = "CodigoMesa";
            this.CodigoMesa.ReadOnly = true;
            // 
            // DescripcionMesa
            // 
            this.DescripcionMesa.HeaderText = "Descripción Mesa";
            this.DescripcionMesa.Name = "DescripcionMesa";
            this.DescripcionMesa.ReadOnly = true;
            this.DescripcionMesa.Width = 200;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmdEstadisticas);
            this.splitContainer2.Panel1.Controls.Add(this.cmdNuevoPedido);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgDatos);
            this.splitContainer2.Size = new System.Drawing.Size(719, 475);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 1;
            // 
            // cmdNuevoPedido
            // 
            this.cmdNuevoPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoPedido.Location = new System.Drawing.Point(3, 3);
            this.cmdNuevoPedido.Name = "cmdNuevoPedido";
            this.cmdNuevoPedido.Size = new System.Drawing.Size(94, 58);
            this.cmdNuevoPedido.TabIndex = 0;
            this.cmdNuevoPedido.Text = "Pedidos (F5)";
            this.cmdNuevoPedido.UseVisualStyleBackColor = false;
            // 
            // chkOpenMesas
            // 
            this.chkOpenMesas.AutoSize = true;
            this.chkOpenMesas.Checked = true;
            this.chkOpenMesas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenMesas.Enabled = false;
            this.chkOpenMesas.Location = new System.Drawing.Point(17, 40);
            this.chkOpenMesas.Name = "chkOpenMesas";
            this.chkOpenMesas.Size = new System.Drawing.Size(141, 17);
            this.chkOpenMesas.TabIndex = 1;
            this.chkOpenMesas.Text = "Ver Solo Mesas Abiertas";
            this.chkOpenMesas.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmdBuscar.Location = new System.Drawing.Point(384, 43);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = false;
            // 
            // fsoPersonal
            // 
            this.fsoPersonal.AnchoBoton = 20;
            this.fsoPersonal.AnchoLabel = 120;
            this.fsoPersonal.AnchoTxtCod = 50;
            this.fsoPersonal.CodigoActual = "";
            this.fsoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoPersonal.FiltrosCampos = "";
            this.fsoPersonal.FiltrosValores = "";
            this.fsoPersonal.IdSelected = -1;
            this.fsoPersonal.Location = new System.Drawing.Point(258, 16);
            this.fsoPersonal.Name = "fsoPersonal";
            this.fsoPersonal.ObjetoActual = null;
            this.fsoPersonal.Size = new System.Drawing.Size(368, 21);
            this.fsoPersonal.TabIndex = 2;
            this.fsoPersonal.Texto = "Incluir Mesas de: ";
            // 
            // cmdEstadisticas
            // 
            this.cmdEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdEstadisticas.Enabled = false;
            this.cmdEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEstadisticas.Location = new System.Drawing.Point(3, 67);
            this.cmdEstadisticas.Name = "cmdEstadisticas";
            this.cmdEstadisticas.Size = new System.Drawing.Size(94, 58);
            this.cmdEstadisticas.TabIndex = 1;
            this.cmdEstadisticas.Text = "Estadísticas";
            this.cmdEstadisticas.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(721, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "GPS FastFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ingreso_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosXArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button cmdNuevoPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMesa;
        private System.Windows.Forms.CheckBox chkOpenMesas;
        private System.Windows.Forms.Button cmdBuscar;
        private Controles.FSOCombo fsoPersonal;
        private System.Windows.Forms.Button cmdEstadisticas;
    }
}

