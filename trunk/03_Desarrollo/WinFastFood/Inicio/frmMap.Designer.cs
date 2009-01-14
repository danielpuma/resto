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
            ((System.ComponentModel.ISupportInitialize)(this.dgMap)).BeginInit();
            this.Menu.SuspendLayout();
            this.pnlAddMesa.SuspendLayout();
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
            this.dgMap.Size = new System.Drawing.Size(639, 420);
            this.dgMap.TabIndex = 0;
            this.dgMap.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMap_CellLeave);
            
            this.dgMap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMap_CellClick);
            
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarMesaToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultarPedidosToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(172, 54);
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
            // 
            // pnlAddMesa
            // 
            this.pnlAddMesa.Controls.Add(this.cmdCancelAddMesa);
            this.pnlAddMesa.Controls.Add(this.cmdUbicarMesa);
            this.pnlAddMesa.Controls.Add(this.fsoMesa);
            this.pnlAddMesa.Location = new System.Drawing.Point(44, 57);
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
            this.fsoMesa.Location = new System.Drawing.Point(3, 3);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(480, 21);
            this.fsoMesa.TabIndex = 0;
            this.fsoMesa.Texto = "Mesa:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::WinFastFood.Properties.Resources.Baldosa;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // frmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 420);
            this.Controls.Add(this.pnlAddMesa);
            this.Controls.Add(this.dgMap);
            this.Name = "frmMap";
            this.Text = "Mapa del Local";
            this.Load += new System.EventHandler(this.frmMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMap)).EndInit();
            this.Menu.ResumeLayout(false);
            this.pnlAddMesa.ResumeLayout(false);
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
        
    }
}