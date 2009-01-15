namespace WinFastFood.Inicio
{
    partial class frmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMap));
            this.dgMap = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asignarMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAddMesa = new System.Windows.Forms.Panel();
            this.cmdCancelAddMesa = new System.Windows.Forms.Button();
            this.cmdUbicarMesa = new System.Windows.Forms.Button();
            this.fsoMesa = new Controles.FSOCombo();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Contenedor = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblPedPend = new System.Windows.Forms.Label();
            this.LblMesasLibres = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.LblFacturado = new System.Windows.Forms.Label();
            this.LblPorFacturar = new System.Windows.Forms.Label();
            this.LblClientesXMesa = new System.Windows.Forms.Label();
            this.lblNroClientes = new System.Windows.Forms.Label();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMap)).BeginInit();
            this.Menu.SuspendLayout();
            this.pnlAddMesa.SuspendLayout();
            this.Contenedor.Panel1.SuspendLayout();
            this.Contenedor.Panel2.SuspendLayout();
            this.Contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgMap
            // 
            this.dgMap.AllowUserToAddRows = false;
            this.dgMap.AllowUserToDeleteRows = false;
            this.dgMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgMap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMap.ColumnHeadersVisible = false;
            this.dgMap.ContextMenuStrip = this.Menu;
            this.dgMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgMap.Location = new System.Drawing.Point(0, 0);
            this.dgMap.Name = "dgMap";
            this.dgMap.ReadOnly = true;
            this.dgMap.RowHeadersVisible = false;
            this.dgMap.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgMap.RowTemplate.Height = 80;
            this.dgMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMap.Size = new System.Drawing.Size(468, 420);
            this.dgMap.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgMap, resources.GetString("dgMap.ToolTip"));
            this.dgMap.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMap_CellLeave);
            this.dgMap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMap_CellDoubleClick);
            this.dgMap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMap_CellClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarMesaToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultarPedidosToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(172, 76);
            // 
            // asignarMesaToolStripMenuItem
            // 
            this.asignarMesaToolStripMenuItem.Image = global::WinFastFood.Properties.Resources._8add24;
            this.asignarMesaToolStripMenuItem.Name = "asignarMesaToolStripMenuItem";
            this.asignarMesaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.asignarMesaToolStripMenuItem.Text = "Asignar Mesa";
            this.asignarMesaToolStripMenuItem.Click += new System.EventHandler(this.asignarMesaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // consultarPedidosToolStripMenuItem
            // 
            this.consultarPedidosToolStripMenuItem.Image = global::WinFastFood.Properties.Resources.help32;
            this.consultarPedidosToolStripMenuItem.Name = "consultarPedidosToolStripMenuItem";
            this.consultarPedidosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultarPedidosToolStripMenuItem.Text = "Consultar Pedidos";
            this.consultarPedidosToolStripMenuItem.Click += new System.EventHandler(this.consultarPedidosToolStripMenuItem_Click);
            // 
            // pnlAddMesa
            // 
            this.pnlAddMesa.Controls.Add(this.cmdCancelAddMesa);
            this.pnlAddMesa.Controls.Add(this.cmdUbicarMesa);
            this.pnlAddMesa.Controls.Add(this.fsoMesa);
            this.pnlAddMesa.Location = new System.Drawing.Point(3, 82);
            this.pnlAddMesa.Name = "pnlAddMesa";
            this.pnlAddMesa.Size = new System.Drawing.Size(549, 26);
            this.pnlAddMesa.TabIndex = 1;
            this.pnlAddMesa.Visible = false;
            // 
            // cmdCancelAddMesa
            // 
            this.cmdCancelAddMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancelAddMesa.Image = global::WinFastFood.Properties.Resources._8close16;
            this.cmdCancelAddMesa.Location = new System.Drawing.Point(518, 0);
            this.cmdCancelAddMesa.Name = "cmdCancelAddMesa";
            this.cmdCancelAddMesa.Size = new System.Drawing.Size(31, 26);
            this.cmdCancelAddMesa.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cmdCancelAddMesa, "Cancelar Operación");
            this.cmdCancelAddMesa.UseVisualStyleBackColor = true;
            this.cmdCancelAddMesa.Click += new System.EventHandler(this.cmdCancelAddMesa_Click);
            // 
            // cmdUbicarMesa
            // 
            this.cmdUbicarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUbicarMesa.Image = global::WinFastFood.Properties.Resources._8add48;
            this.cmdUbicarMesa.Location = new System.Drawing.Point(489, 0);
            this.cmdUbicarMesa.Name = "cmdUbicarMesa";
            this.cmdUbicarMesa.Size = new System.Drawing.Size(31, 26);
            this.cmdUbicarMesa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdUbicarMesa, "Agregar Mesa Seleccionada");
            this.cmdUbicarMesa.UseVisualStyleBackColor = true;
            this.cmdUbicarMesa.Click += new System.EventHandler(this.cmdUbicarMesa_Click);
            // 
            // fsoMesa
            // 
            this.fsoMesa.AnchoBoton = 20;
            this.fsoMesa.AnchoLabel = 80;
            this.fsoMesa.AnchoTxtCod = 100;
            this.fsoMesa.CodigoActual = "";
            this.fsoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoMesa.FiltrosCampos = "";
            this.fsoMesa.FiltrosValores = "";
            this.fsoMesa.IdSelected = -1;
            this.fsoMesa.Location = new System.Drawing.Point(3, 2);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(480, 21);
            this.fsoMesa.TabIndex = 0;
            this.fsoMesa.Texto = "Mesa:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "FastFood";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::WinFastFood.Properties.Resources.Baldosa;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            // 
            // Contenedor.Panel1
            // 
            this.Contenedor.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.Contenedor.Panel1.Controls.Add(this.panel1);
            this.Contenedor.Panel1.Controls.Add(this.label1);
            // 
            // Contenedor.Panel2
            // 
            this.Contenedor.Panel2.Controls.Add(this.pnlAddMesa);
            this.Contenedor.Panel2.Controls.Add(this.dgMap);
            this.Contenedor.Size = new System.Drawing.Size(697, 420);
            this.Contenedor.SplitterDistance = 225;
            this.Contenedor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblCantClientes);
            this.panel1.Controls.Add(this.lblPedPend);
            this.panel1.Controls.Add(this.LblMesasLibres);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.LblFacturado);
            this.panel1.Controls.Add(this.LblPorFacturar);
            this.panel1.Controls.Add(this.LblClientesXMesa);
            this.panel1.Controls.Add(this.lblNroClientes);
            this.panel1.Controls.Add(this.cmdRefresh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 392);
            this.panel1.TabIndex = 2;
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCantClientes.Location = new System.Drawing.Point(167, 199);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(32, 13);
            this.lblCantClientes.TabIndex = 18;
            this.lblCantClientes.Text = "0.00";
            this.lblCantClientes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPedPend
            // 
            this.lblPedPend.AutoSize = true;
            this.lblPedPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedPend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPedPend.Location = new System.Drawing.Point(167, 174);
            this.lblPedPend.Name = "lblPedPend";
            this.lblPedPend.Size = new System.Drawing.Size(32, 13);
            this.lblPedPend.TabIndex = 17;
            this.lblPedPend.Text = "0.00";
            this.lblPedPend.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblMesasLibres
            // 
            this.LblMesasLibres.AutoSize = true;
            this.LblMesasLibres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMesasLibres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMesasLibres.Location = new System.Drawing.Point(167, 150);
            this.LblMesasLibres.Name = "LblMesasLibres";
            this.LblMesasLibres.Size = new System.Drawing.Size(32, 13);
            this.LblMesasLibres.TabIndex = 16;
            this.LblMesasLibres.Text = "0.00";
            this.LblMesasLibres.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(167, 103);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblFacturado
            // 
            this.LblFacturado.AutoSize = true;
            this.LblFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFacturado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFacturado.Location = new System.Drawing.Point(167, 80);
            this.LblFacturado.Name = "LblFacturado";
            this.LblFacturado.Size = new System.Drawing.Size(32, 13);
            this.LblFacturado.TabIndex = 14;
            this.LblFacturado.Text = "0.00";
            this.LblFacturado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblPorFacturar
            // 
            this.LblPorFacturar.AutoSize = true;
            this.LblPorFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorFacturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblPorFacturar.Location = new System.Drawing.Point(167, 57);
            this.LblPorFacturar.Name = "LblPorFacturar";
            this.LblPorFacturar.Size = new System.Drawing.Size(32, 13);
            this.LblPorFacturar.TabIndex = 13;
            this.LblPorFacturar.Text = "0.00";
            this.LblPorFacturar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LblClientesXMesa
            // 
            this.LblClientesXMesa.AutoSize = true;
            this.LblClientesXMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientesXMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblClientesXMesa.Location = new System.Drawing.Point(167, 34);
            this.LblClientesXMesa.Name = "LblClientesXMesa";
            this.LblClientesXMesa.Size = new System.Drawing.Size(32, 13);
            this.LblClientesXMesa.TabIndex = 12;
            this.LblClientesXMesa.Text = "0.00";
            this.LblClientesXMesa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNroClientes
            // 
            this.lblNroClientes.AutoSize = true;
            this.lblNroClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNroClientes.Location = new System.Drawing.Point(167, 11);
            this.lblNroClientes.Name = "lblNroClientes";
            this.lblNroClientes.Size = new System.Drawing.Size(32, 13);
            this.lblNroClientes.TabIndex = 11;
            this.lblNroClientes.Text = "0.00";
            this.lblNroClientes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdRefresh.Image = global::WinFastFood.Properties.Resources.wizard;
            this.cmdRefresh.Location = new System.Drawing.Point(9, 302);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(113, 81);
            this.cmdRefresh.TabIndex = 10;
            this.cmdRefresh.Text = "Actualizar Datos";
            this.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(8, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "$ Totales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(9, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "# Clientes Ult 6hs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "# Ped. Pend:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "# Mesas Libres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "$ Facturado (6hs):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "$ Por Facturar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes X Mesa:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl1.Location = new System.Drawing.Point(9, 11);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "# Clientes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadísticas:";
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 420);
            this.Controls.Add(this.Contenedor);
            this.Name = "frmMap";
            this.Text = "Mapa del Local";
            this.Load += new System.EventHandler(this.frmMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMap)).EndInit();
            this.Menu.ResumeLayout(false);
            this.pnlAddMesa.ResumeLayout(false);
            this.Contenedor.Panel1.ResumeLayout(false);
            this.Contenedor.Panel1.PerformLayout();
            this.Contenedor.Panel2.ResumeLayout(false);
            this.Contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMap;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlAddMesa;
        private System.Windows.Forms.Button cmdUbicarMesa;
        private Controles.FSOCombo fsoMesa;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem asignarMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultarPedidosToolStripMenuItem;
        private System.Windows.Forms.Button cmdCancelAddMesa;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer Contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNroClientes;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblPedPend;
        private System.Windows.Forms.Label LblMesasLibres;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label LblFacturado;
        private System.Windows.Forms.Label LblPorFacturar;
        private System.Windows.Forms.Label LblClientesXMesa;
        
    }
}