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
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosXArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cmdCocina = new System.Windows.Forms.Button();
            this.cmdEstadisticas = new System.Windows.Forms.Button();
            this.cmdNuevoPedido = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.IDMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsoMesa = new Controles.FSOCombo();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.fsoCombo2 = new Controles.FSOCombo();
            this.dgPendientes = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fsoPersonal = new Controles.FSOCombo();
            this.cmdBloquear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
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
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.clientesToolStripMenuItem.Text = "Mesas";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.personalToolStripMenuItem.Text = "Mozos";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.cmdCocina);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cmdNuevoPedido);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(727, 550);
            this.splitContainer1.SplitterDistance = 70;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FastFood 2008";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.cmdBloquear);
            this.splitContainer2.Panel1.Controls.Add(this.cmdEstadisticas);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(725, 474);
            this.splitContainer2.SplitterDistance = 98;
            this.splitContainer2.TabIndex = 1;
            // 
            // cmdCocina
            // 
            this.cmdCocina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmdCocina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCocina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCocina.Location = new System.Drawing.Point(312, 3);
            this.cmdCocina.Name = "cmdCocina";
            this.cmdCocina.Size = new System.Drawing.Size(94, 58);
            this.cmdCocina.TabIndex = 2;
            this.cmdCocina.Text = "Cocina (F12)";
            this.cmdCocina.UseVisualStyleBackColor = false;
            this.cmdCocina.Click += new System.EventHandler(this.cmdCocina_Click);
            // 
            // cmdEstadisticas
            // 
            this.cmdEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdEstadisticas.Enabled = false;
            this.cmdEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEstadisticas.Location = new System.Drawing.Point(3, 3);
            this.cmdEstadisticas.Name = "cmdEstadisticas";
            this.cmdEstadisticas.Size = new System.Drawing.Size(94, 58);
            this.cmdEstadisticas.TabIndex = 1;
            this.cmdEstadisticas.Text = "Estadísticas";
            this.cmdEstadisticas.UseVisualStyleBackColor = false;
            // 
            // cmdNuevoPedido
            // 
            this.cmdNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoPedido.Location = new System.Drawing.Point(212, 3);
            this.cmdNuevoPedido.Name = "cmdNuevoPedido";
            this.cmdNuevoPedido.Size = new System.Drawing.Size(94, 58);
            this.cmdNuevoPedido.TabIndex = 0;
            this.cmdNuevoPedido.Text = "Pedidos (F5)";
            this.cmdNuevoPedido.UseVisualStyleBackColor = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            this.splitContainer3.Panel1.Controls.Add(this.dgDatos);
            this.splitContainer3.Panel1.Controls.Add(this.fsoMesa);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.lblDireccion);
            this.splitContainer3.Panel2.Controls.Add(this.panel2);
            this.splitContainer3.Panel2.Controls.Add(this.fsoCombo2);
            this.splitContainer3.Panel2.Controls.Add(this.dgPendientes);
            this.splitContainer3.Panel2.Controls.Add(this.fsoPersonal);
            this.splitContainer3.Size = new System.Drawing.Size(623, 474);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 35);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesas:";
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMesa,
            this.CodigoMesa,
            this.DescripcionMesa});
            this.dgDatos.Location = new System.Drawing.Point(3, 104);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(289, 367);
            this.dgDatos.StandardTab = true;
            this.dgDatos.TabIndex = 1;
            this.dgDatos.SelectionChanged += new System.EventHandler(this.dgDatos_SelectionChanged);
            this.dgDatos.Click += new System.EventHandler(this.dgDatos_Click);
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
            // fsoMesa
            // 
            this.fsoMesa.AnchoBoton = 20;
            this.fsoMesa.AnchoLabel = 50;
            this.fsoMesa.AnchoTxtCod = 50;
            this.fsoMesa.CodigoActual = "";
            this.fsoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoMesa.FiltrosCampos = "";
            this.fsoMesa.FiltrosValores = "";
            this.fsoMesa.IdSelected = -1;
            this.fsoMesa.Location = new System.Drawing.Point(3, 41);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(295, 24);
            this.fsoMesa.TabIndex = 3;
            this.fsoMesa.Texto = "Mesas: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(64, 88);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(65, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 35);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pedidos Pendientes:";
            // 
            // fsoCombo2
            // 
            this.fsoCombo2.AnchoBoton = 20;
            this.fsoCombo2.AnchoLabel = 50;
            this.fsoCombo2.AnchoTxtCod = 50;
            this.fsoCombo2.CodigoActual = "";
            this.fsoCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoCombo2.FiltrosCampos = "";
            this.fsoCombo2.FiltrosValores = "";
            this.fsoCombo2.IdSelected = -1;
            this.fsoCombo2.Location = new System.Drawing.Point(10, 64);
            this.fsoCombo2.Name = "fsoCombo2";
            this.fsoCombo2.ObjetoActual = null;
            this.fsoCombo2.Size = new System.Drawing.Size(302, 21);
            this.fsoCombo2.TabIndex = 3;
            this.fsoCombo2.Texto = "Cliente: ";
            // 
            // dgPendientes
            // 
            this.dgPendientes.AllowUserToAddRows = false;
            this.dgPendientes.AllowUserToDeleteRows = false;
            this.dgPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPendientes.BackgroundColor = System.Drawing.Color.White;
            this.dgPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.ColMesa,
            this.TiempoEspera});
            this.dgPendientes.Location = new System.Drawing.Point(10, 104);
            this.dgPendientes.Name = "dgPendientes";
            this.dgPendientes.ReadOnly = true;
            this.dgPendientes.RowHeadersVisible = false;
            this.dgPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPendientes.Size = new System.Drawing.Size(302, 367);
            this.dgPendientes.TabIndex = 1;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "Column1";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Visible = false;
            // 
            // ColMesa
            // 
            this.ColMesa.HeaderText = "Mesa";
            this.ColMesa.Name = "ColMesa";
            this.ColMesa.ReadOnly = true;
            // 
            // TiempoEspera
            // 
            this.TiempoEspera.HeaderText = "Espera (Min.)";
            this.TiempoEspera.Name = "TiempoEspera";
            this.TiempoEspera.ReadOnly = true;
            // 
            // fsoPersonal
            // 
            this.fsoPersonal.AnchoBoton = 20;
            this.fsoPersonal.AnchoLabel = 50;
            this.fsoPersonal.AnchoTxtCod = 50;
            this.fsoPersonal.CodigoActual = "";
            this.fsoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoPersonal.FiltrosCampos = "";
            this.fsoPersonal.FiltrosValores = "";
            this.fsoPersonal.IdSelected = -1;
            this.fsoPersonal.Location = new System.Drawing.Point(10, 40);
            this.fsoPersonal.Name = "fsoPersonal";
            this.fsoPersonal.ObjetoActual = null;
            this.fsoPersonal.Size = new System.Drawing.Size(302, 21);
            this.fsoPersonal.TabIndex = 2;
            this.fsoPersonal.Texto = "Mozo: ";
            // 
            // cmdBloquear
            // 
            this.cmdBloquear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBloquear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdBloquear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBloquear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBloquear.Location = new System.Drawing.Point(3, 64);
            this.cmdBloquear.Name = "cmdBloquear";
            this.cmdBloquear.Size = new System.Drawing.Size(94, 58);
            this.cmdBloquear.TabIndex = 2;
            this.cmdBloquear.Text = "Bloquear (FIN)";
            this.cmdBloquear.UseVisualStyleBackColor = false;
            this.cmdBloquear.Click += new System.EventHandler(this.cmdBloquear_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 574);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "GPS FastFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ingreso_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPendientes)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button cmdNuevoPedido;
        private Controles.FSOCombo fsoPersonal;
        private System.Windows.Forms.Button cmdEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Button cmdCocina;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private Controles.FSOCombo fsoMesa;
        private System.Windows.Forms.DataGridView dgPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEspera;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionMesa;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label lblDireccion;
        private Controles.FSOCombo fsoCombo2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBloquear;
    }
}

