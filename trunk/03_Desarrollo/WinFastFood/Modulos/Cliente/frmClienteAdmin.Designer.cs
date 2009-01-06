using Controles;
namespace FastFood.ABM.Cliente
{
    partial class frmClienteAdmin
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
            this.CmdDelete = new System.Windows.Forms.Button();
            this.txtRazonSocial = new Controles.FSOTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtApellido = new Controles.FSOTextBox();
            this.txtNombre = new Controles.FSOTextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new Controles.FSOTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTel = new Controles.FSOTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new Controles.FSOTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdConsultarVehiculo = new System.Windows.Forms.Button();
            this.cmdCrearVehiculo = new System.Windows.Forms.Button();
            this.TxtNroDoc = new Shorty.Windows.Forms.NumericTextBox();
            this.dtFechaNacimiento = new Controles.DateTimeInputBox();
            this.SuspendLayout();
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmdDelete.Location = new System.Drawing.Point(11, 204);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 11;
            this.CmdDelete.TabStop = false;
            this.CmdDelete.Text = "Eliminar";
            this.CmdDelete.UseVisualStyleBackColor = false;
            this.CmdDelete.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(455, 34);
            this.txtRazonSocial.MaxLength = 80;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(222, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Razón Social";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(157, 62);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(258, 21);
            this.cboTipoDocumento.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(157, 34);
            this.txtApellido.MaxLength = 18;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(157, 6);
            this.txtNombre.MaxLength = 18;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(590, 204);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "&Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(509, 204);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 9;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Número de Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // txtmail
            // 
            this.txtmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmail.Location = new System.Drawing.Point(157, 114);
            this.txtmail.MaxLength = 255;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(414, 20);
            this.txtmail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "E-Mail:";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(157, 89);
            this.txtTel.MaxLength = 255;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(414, 20);
            this.txtTel.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Teléfonos:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(157, 140);
            this.txtDireccion.MaxLength = 255;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(414, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Fecha Nacimiento:";
            // 
            // cmdConsultarVehiculo
            // 
            this.cmdConsultarVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdConsultarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsultarVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdConsultarVehiculo.Location = new System.Drawing.Point(181, 204);
            this.cmdConsultarVehiculo.Name = "cmdConsultarVehiculo";
            this.cmdConsultarVehiculo.Size = new System.Drawing.Size(127, 23);
            this.cmdConsultarVehiculo.TabIndex = 33;
            this.cmdConsultarVehiculo.TabStop = false;
            this.cmdConsultarVehiculo.Text = "Consultar Vehiculo";
            this.cmdConsultarVehiculo.UseVisualStyleBackColor = false;
            // 
            // cmdCrearVehiculo
            // 
            this.cmdCrearVehiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cmdCrearVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCrearVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrearVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdCrearVehiculo.Location = new System.Drawing.Point(314, 204);
            this.cmdCrearVehiculo.Name = "cmdCrearVehiculo";
            this.cmdCrearVehiculo.Size = new System.Drawing.Size(125, 23);
            this.cmdCrearVehiculo.TabIndex = 34;
            this.cmdCrearVehiculo.TabStop = false;
            this.cmdCrearVehiculo.Text = "Crear Vehiculo";
            this.cmdCrearVehiculo.UseVisualStyleBackColor = false;
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.AcceptsReturn = true;
            this.TxtNroDoc.AcceptsTab = true;
            this.TxtNroDoc.AllowNegative = false;
            this.TxtNroDoc.ApplyFormat = false;
            this.TxtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroDoc.Location = new System.Drawing.Point(577, 62);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.NumericPrecision = 11;
            this.TxtNroDoc.NumericScaleOnFocus = 0;
            this.TxtNroDoc.NumericScaleOnLostFocus = 0;
            this.TxtNroDoc.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.TxtNroDoc.TabIndex = 4;
            this.TxtNroDoc.Text = "0";
            this.TxtNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroDoc.ZeroIsValid = true;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.FechaNuleable = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(157, 166);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(102, 20);
            this.dtFechaNacimiento.TabIndex = 8;
            // 
            // frmClienteAdmin
            // 
            this.AcceptButton = this.cmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(686, 239);
            this.Controls.Add(this.TxtNroDoc);
            this.Controls.Add(this.cmdCrearVehiculo);
            this.Controls.Add(this.cmdConsultarVehiculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClienteAdmin";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdDelete;
        private FSOTextBox txtRazonSocial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private FSOTextBox txtApellido;
        private FSOTextBox txtNombre;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FSOTextBox txtmail;
        private System.Windows.Forms.Label label6;
        private FSOTextBox txtTel;
        private System.Windows.Forms.Label label7;
        private FSOTextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private Controles.DateTimeInputBox dtFechaNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdConsultarVehiculo;
        private System.Windows.Forms.Button cmdCrearVehiculo;
        private Shorty.Windows.Forms.NumericTextBox TxtNroDoc;
    }
}