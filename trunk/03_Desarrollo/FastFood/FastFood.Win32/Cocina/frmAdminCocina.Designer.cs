namespace FastFood.Win32.Cocina
{
    partial class frmAdminCocina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminCocina));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fsoMesa = new Controles.FSOCombo();
            this.fsoPersonal = new Controles.FSOCombo();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.fsoArticulo = new Controles.FSOCombo();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.IdDetallePedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Espera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PedidoNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fsoMesa);
            this.splitContainer1.Panel1.Controls.Add(this.fsoPersonal);
            this.splitContainer1.Panel1.Controls.Add(this.cmdFiltrar);
            this.splitContainer1.Panel1.Controls.Add(this.fsoArticulo);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(830, 440);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 0;
            // 
            // fsoMesa
            // 
            this.fsoMesa.AnchoBoton = 20;
            this.fsoMesa.AnchoLabel = 100;
            this.fsoMesa.AnchoTxtCod = 100;
            this.fsoMesa.CodigoActual = "";
            this.fsoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoMesa.FiltrosCampos = "";
            this.fsoMesa.FiltrosValores = "";
            this.fsoMesa.IdSelected = -1;
            this.fsoMesa.Location = new System.Drawing.Point(16, 92);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(476, 21);
            this.fsoMesa.TabIndex = 5;
            this.fsoMesa.Texto = "Mesa:";
            // 
            // fsoPersonal
            // 
            this.fsoPersonal.AnchoBoton = 20;
            this.fsoPersonal.AnchoLabel = 100;
            this.fsoPersonal.AnchoTxtCod = 100;
            this.fsoPersonal.CodigoActual = "";
            this.fsoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoPersonal.FiltrosCampos = "";
            this.fsoPersonal.FiltrosValores = "";
            this.fsoPersonal.IdSelected = -1;
            this.fsoPersonal.Location = new System.Drawing.Point(16, 65);
            this.fsoPersonal.Name = "fsoPersonal";
            this.fsoPersonal.ObjetoActual = null;
            this.fsoPersonal.Size = new System.Drawing.Size(476, 21);
            this.fsoPersonal.TabIndex = 4;
            this.fsoPersonal.Texto = "Mozo:";
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdFiltrar.Location = new System.Drawing.Point(558, 38);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(129, 48);
            this.cmdFiltrar.TabIndex = 3;
            this.cmdFiltrar.Text = "FILTRAR !";
            this.cmdFiltrar.UseVisualStyleBackColor = false;
            // 
            // fsoArticulo
            // 
            this.fsoArticulo.AnchoBoton = 20;
            this.fsoArticulo.AnchoLabel = 100;
            this.fsoArticulo.AnchoTxtCod = 100;
            this.fsoArticulo.CodigoActual = "";
            this.fsoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoArticulo.FiltrosCampos = "";
            this.fsoArticulo.FiltrosValores = "";
            this.fsoArticulo.IdSelected = -1;
            this.fsoArticulo.Location = new System.Drawing.Point(16, 38);
            this.fsoArticulo.Name = "fsoArticulo";
            this.fsoArticulo.ObjetoActual = null;
            this.fsoArticulo.Size = new System.Drawing.Size(476, 21);
            this.fsoArticulo.TabIndex = 2;
            this.fsoArticulo.Texto = "Artículo:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(693, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENTREGAR PEDIDO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración de la Cocina";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgDatos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtComentario);
            this.splitContainer2.Size = new System.Drawing.Size(830, 319);
            this.splitContainer2.SplitterDistance = 655;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetallePedido,
            this.IdPedido,
            this.Fecha,
            this.Espera,
            this.Articulo,
            this.Cantidad,
            this.Mesa,
            this.Mozo,
            this.PedidoNro});
            this.dgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDatos.Location = new System.Drawing.Point(0, 0);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowTemplate.Height = 42;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(655, 319);
            this.dgDatos.TabIndex = 0;
            // 
            // IdDetallePedido
            // 
            this.IdDetallePedido.HeaderText = "Column1";
            this.IdDetallePedido.Name = "IdDetallePedido";
            this.IdDetallePedido.Visible = false;
            this.IdDetallePedido.Width = 250;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "IdPedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Visible = false;
            // 
            // Fecha
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "Fecha y Hora de Ingreso";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 120;
            // 
            // Espera
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "N0";
            this.Espera.DefaultCellStyle = dataGridViewCellStyle2;
            this.Espera.HeaderText = "Espera (Min.)";
            this.Espera.Name = "Espera";
            this.Espera.Width = 80;
            // 
            // Articulo
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            this.Articulo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Width = 300;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.Format = "N2";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Mesa
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Mesa.DefaultCellStyle = dataGridViewCellStyle5;
            this.Mesa.HeaderText = "Mesa";
            this.Mesa.Name = "Mesa";
            // 
            // Mozo
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            this.Mozo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Mozo.HeaderText = "Mozo";
            this.Mozo.Name = "Mozo";
            // 
            // PedidoNro
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PedidoNro.DefaultCellStyle = dataGridViewCellStyle7;
            this.PedidoNro.HeaderText = "Nro. de Pedido";
            this.PedidoNro.Name = "PedidoNro";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(0, 0);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.Size = new System.Drawing.Size(171, 319);
            this.txtComentario.TabIndex = 0;
            // 
            // T1
            // 
            this.T1.Enabled = true;
            this.T1.Interval = 5000;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // frmAdminCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 440);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminCocina";
            this.Text = "FastFood 2008";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.Button button1;
        private Controles.FSOCombo fsoArticulo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtComentario;
        private Controles.FSOCombo fsoPersonal;
        private System.Windows.Forms.Button cmdFiltrar;
        private Controles.FSOCombo fsoMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetallePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Espera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoNro;
    }
}