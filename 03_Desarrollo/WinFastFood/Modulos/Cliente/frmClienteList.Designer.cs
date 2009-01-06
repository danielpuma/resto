using Controles;
namespace FastFood.ABM.Cliente
{
    partial class frmClienteList
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
            this.txtNombre = new FSOTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new FSOTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MyGrillaDatos = new System.Windows.Forms.DataGridView();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtApellido = new FSOTextBox();
            this.txtRazonSocial = new FSOTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAlertas = new System.Windows.Forms.Button();
            this.cmdTrabajos = new System.Windows.Forms.Button();
            this.cmdVehiculos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new Controles.FSOCombo();
            this.dtRange1 = new Controles.dtRange();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrillaDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(426, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Apellido:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(122, 68);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Documento:";
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
            this.Documento,
            this.NombreCompleto,
            this.RazonSocial,
            this.Telefono,
            this.Mail,
            this.FechaNac});
            this.MyGrillaDatos.Location = new System.Drawing.Point(0, 195);
            this.MyGrillaDatos.Name = "MyGrillaDatos";
            this.MyGrillaDatos.ReadOnly = true;
            this.MyGrillaDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MyGrillaDatos.Size = new System.Drawing.Size(811, 325);
            this.MyGrillaDatos.TabIndex = 8;
            this.MyGrillaDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cmdNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevo.Location = new System.Drawing.Point(747, 158);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(36, 31);
            this.cmdNuevo.TabIndex = 7;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(706, 158);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(35, 31);
            this.cmdBuscar.TabIndex = 6;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(122, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(238, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(122, 127);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(238, 20);
            this.txtRazonSocial.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Razon Social:";
            // 
            // cmdAlertas
            // 
            this.cmdAlertas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdAlertas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAlertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAlertas.Location = new System.Drawing.Point(7, 161);
            this.cmdAlertas.Name = "cmdAlertas";
            this.cmdAlertas.Size = new System.Drawing.Size(75, 24);
            this.cmdAlertas.TabIndex = 9;
            this.cmdAlertas.Text = "Alertas";
            this.cmdAlertas.UseVisualStyleBackColor = false;
            // 
            // cmdTrabajos
            // 
            this.cmdTrabajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdTrabajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTrabajos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTrabajos.Location = new System.Drawing.Point(88, 161);
            this.cmdTrabajos.Name = "cmdTrabajos";
            this.cmdTrabajos.Size = new System.Drawing.Size(75, 24);
            this.cmdTrabajos.TabIndex = 10;
            this.cmdTrabajos.Text = "Trabajos";
            this.cmdTrabajos.UseVisualStyleBackColor = false;

            // 
            // cmdVehiculos
            // 
            this.cmdVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVehiculos.Location = new System.Drawing.Point(169, 161);
            this.cmdVehiculos.Name = "cmdVehiculos";
            this.cmdVehiculos.Size = new System.Drawing.Size(90, 24);
            this.cmdVehiculos.TabIndex = 11;
            this.cmdVehiculos.Text = "Vehiculos";
            this.cmdVehiculos.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Administración de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 47);
            this.panel1.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "fecha Nacimiento:";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.AnchoBoton = 20;
            this.cboTipoDoc.AnchoLabel = 120;
            this.cboTipoDoc.AnchoTxtCod = 100;
            this.cboTipoDoc.CodigoActual = "";
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboTipoDoc.FiltrosCampos = "";
            this.cboTipoDoc.FiltrosValores = "";
            this.cboTipoDoc.IdSelected = -1;
            this.cboTipoDoc.Location = new System.Drawing.Point(369, 68);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.ObjetoActual = null;
            this.cboTipoDoc.Size = new System.Drawing.Size(394, 21);
            this.cboTipoDoc.TabIndex = 1;
            this.cboTipoDoc.Texto = "Tipo de Doc.:";
            // 
            // dtRange1
            // 
            this.dtRange1.Desde = null;
            this.dtRange1.Hasta = null;
            this.dtRange1.Location = new System.Drawing.Point(483, 127);
            this.dtRange1.Name = "dtRange1";
            this.dtRange1.RequiereDesde = false;
            this.dtRange1.RequiereHasta = false;
            this.dtRange1.Size = new System.Drawing.Size(297, 20);
            this.dtRange1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 250;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            this.RazonSocial.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha de Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // frmClienteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 532);
            this.Controls.Add(this.dtRange1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdVehiculos);
            this.Controls.Add(this.cmdTrabajos);
            this.Controls.Add(this.cmdAlertas);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyGrillaDatos);
            this.Name = "frmClienteList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.frmClienteList_Load);
            this.SizeChanged += new System.EventHandler(this.frmVehiculoList_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrillaDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FSOTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private Controles.FSOCombo cboTipoDoc;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Label label3;
        private FSOTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MyGrillaDatos;
        private FSOTextBox txtApellido;
        private FSOTextBox txtRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAlertas;
        private System.Windows.Forms.Button cmdTrabajos;
        private System.Windows.Forms.Button cmdVehiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Controles.dtRange dtRange1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
    }
}