namespace WinFastFood.Modulos.Pedido
{
    partial class frmPedidoList
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
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAnular = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.chkPendientes = new System.Windows.Forms.CheckBox();
            this.chkCerrados = new System.Windows.Forms.CheckBox();
            this.chkActivos = new System.Windows.Forms.CheckBox();
            this.chkAnulados = new System.Windows.Forms.CheckBox();
            this.dtRange1 = new Controles.dtRange();
            this.fsoCliente = new Controles.FSOCombo();
            this.fsoMesa = new Controles.FSOCombo();
            this.fsoMozo = new Controles.FSOCombo();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroInt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMozo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPdte = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
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
            this.ColID,
            this.ColNroInt,
            this.colfecha,
            this.ColCliente,
            this.ColMozo,
            this.ColTot,
            this.ColPdte,
            this.ColMesa,
            this.ColEstado});
            this.dgDatos.Location = new System.Drawing.Point(1, 140);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(834, 377);
            this.dgDatos.TabIndex = 7;
            this.dgDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellDoubleClick);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(107, 105);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(91, 24);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdAnular
            // 
            this.cmdAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnular.Location = new System.Drawing.Point(12, 105);
            this.cmdAnular.Name = "cmdAnular";
            this.cmdAnular.Size = new System.Drawing.Size(89, 24);
            this.cmdAnular.TabIndex = 13;
            this.cmdAnular.Text = "Anular";
            this.cmdAnular.UseVisualStyleBackColor = false;
            this.cmdAnular.Click += new System.EventHandler(this.cmdAnular_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Location = new System.Drawing.Point(783, 102);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(36, 31);
            this.cmdNuevo.TabIndex = 12;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(742, 102);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(35, 31);
            this.cmdBuscar.TabIndex = 11;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // chkPendientes
            // 
            this.chkPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPendientes.AutoSize = true;
            this.chkPendientes.Checked = true;
            this.chkPendientes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPendientes.Location = new System.Drawing.Point(654, 43);
            this.chkPendientes.Name = "chkPendientes";
            this.chkPendientes.Size = new System.Drawing.Size(89, 17);
            this.chkPendientes.TabIndex = 15;
            this.chkPendientes.Text = "Pendientes";
            this.chkPendientes.UseVisualStyleBackColor = true;
            // 
            // chkCerrados
            // 
            this.chkCerrados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCerrados.AutoSize = true;
            this.chkCerrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCerrados.Location = new System.Drawing.Point(749, 43);
            this.chkCerrados.Name = "chkCerrados";
            this.chkCerrados.Size = new System.Drawing.Size(76, 17);
            this.chkCerrados.TabIndex = 16;
            this.chkCerrados.Text = "Cerrados";
            this.chkCerrados.UseVisualStyleBackColor = true;
            // 
            // chkActivos
            // 
            this.chkActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActivos.AutoSize = true;
            this.chkActivos.Checked = true;
            this.chkActivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivos.Location = new System.Drawing.Point(654, 67);
            this.chkActivos.Name = "chkActivos";
            this.chkActivos.Size = new System.Drawing.Size(68, 17);
            this.chkActivos.TabIndex = 17;
            this.chkActivos.Text = "Activos";
            this.chkActivos.UseVisualStyleBackColor = true;
            // 
            // chkAnulados
            // 
            this.chkAnulados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAnulados.AutoSize = true;
            this.chkAnulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnulados.Location = new System.Drawing.Point(749, 67);
            this.chkAnulados.Name = "chkAnulados";
            this.chkAnulados.Size = new System.Drawing.Size(78, 17);
            this.chkAnulados.TabIndex = 18;
            this.chkAnulados.Text = "Anulados";
            this.chkAnulados.UseVisualStyleBackColor = true;
            // 
            // dtRange1
            // 
            this.dtRange1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtRange1.Desde = new System.DateTime(2008, 4, 10, 0, 0, 0, 0);
            this.dtRange1.Hasta = new System.DateTime(2008, 4, 10, 23, 59, 59, 0);
            this.dtRange1.Location = new System.Drawing.Point(522, 13);
            this.dtRange1.Name = "dtRange1";
            this.dtRange1.RequiereDesde = false;
            this.dtRange1.RequiereHasta = false;
            this.dtRange1.Size = new System.Drawing.Size(297, 20);
            this.dtRange1.TabIndex = 6;
            // 
            // fsoCliente
            // 
            this.fsoCliente.AnchoBoton = 20;
            this.fsoCliente.AnchoLabel = 50;
            this.fsoCliente.AnchoTxtCod = 100;
            this.fsoCliente.CodigoActual = "";
            this.fsoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoCliente.FiltrosCampos = "";
            this.fsoCliente.FiltrosValores = "";
            this.fsoCliente.IdSelected = -1;
            this.fsoCliente.Location = new System.Drawing.Point(12, 12);
            this.fsoCliente.Name = "fsoCliente";
            this.fsoCliente.ObjetoActual = null;
            this.fsoCliente.Size = new System.Drawing.Size(544, 21);
            this.fsoCliente.TabIndex = 3;
            this.fsoCliente.Texto = "Cliente";
            // 
            // fsoMesa
            // 
            this.fsoMesa.AnchoBoton = 20;
            this.fsoMesa.AnchoLabel = 50;
            this.fsoMesa.AnchoTxtCod = 100;
            this.fsoMesa.CodigoActual = "";
            this.fsoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoMesa.FiltrosCampos = "";
            this.fsoMesa.FiltrosValores = "";
            this.fsoMesa.IdSelected = -1;
            this.fsoMesa.Location = new System.Drawing.Point(12, 39);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(544, 21);
            this.fsoMesa.TabIndex = 4;
            this.fsoMesa.Texto = "Mesa";
            // 
            // fsoMozo
            // 
            this.fsoMozo.AnchoBoton = 20;
            this.fsoMozo.AnchoLabel = 50;
            this.fsoMozo.AnchoTxtCod = 100;
            this.fsoMozo.CodigoActual = "";
            this.fsoMozo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoMozo.Enabled = false;
            this.fsoMozo.FiltrosCampos = "";
            this.fsoMozo.FiltrosValores = "";
            this.fsoMozo.IdSelected = -1;
            this.fsoMozo.Location = new System.Drawing.Point(12, 66);
            this.fsoMozo.Name = "fsoMozo";
            this.fsoMozo.ObjetoActual = null;
            this.fsoMozo.Size = new System.Drawing.Size(362, 21);
            this.fsoMozo.TabIndex = 5;
            this.fsoMozo.TabStop = false;
            this.fsoMozo.Texto = "Mozo";
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColNroInt
            // 
            this.ColNroInt.HeaderText = "Nro. Interno";
            this.ColNroInt.Name = "ColNroInt";
            this.ColNroInt.ReadOnly = true;
            // 
            // colfecha
            // 
            this.colfecha.HeaderText = "Fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 200;
            // 
            // ColMozo
            // 
            this.ColMozo.HeaderText = "Mozo";
            this.ColMozo.Name = "ColMozo";
            this.ColMozo.ReadOnly = true;
            // 
            // ColTot
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.ColTot.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColTot.HeaderText = "Total";
            this.ColTot.Name = "ColTot";
            this.ColTot.ReadOnly = true;
            // 
            // ColPdte
            // 
            this.ColPdte.HeaderText = "Pendiente";
            this.ColPdte.Name = "ColPdte";
            this.ColPdte.ReadOnly = true;
            // 
            // ColMesa
            // 
            this.ColMesa.HeaderText = "Mesa";
            this.ColMesa.Name = "ColMesa";
            this.ColMesa.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // frmPedidoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(831, 520);
            this.Controls.Add(this.chkAnulados);
            this.Controls.Add(this.chkActivos);
            this.Controls.Add(this.chkCerrados);
            this.Controls.Add(this.chkPendientes);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdAnular);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.dtRange1);
            this.Controls.Add(this.fsoCliente);
            this.Controls.Add(this.fsoMesa);
            this.Controls.Add(this.fsoMozo);
            this.Name = "frmPedidoList";
            this.Text = "Listado de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.FSOCombo fsoCliente;
        private Controles.FSOCombo fsoMesa;
        private Controles.FSOCombo fsoMozo;
        private Controles.dtRange dtRange1;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAnular;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.CheckBox chkPendientes;
        private System.Windows.Forms.CheckBox chkCerrados;
        private System.Windows.Forms.CheckBox chkActivos;
        private System.Windows.Forms.CheckBox chkAnulados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroInt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTot;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColPdte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
    }
}