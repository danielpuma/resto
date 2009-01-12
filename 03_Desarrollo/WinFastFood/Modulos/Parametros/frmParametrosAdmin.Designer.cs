using Controles;
namespace FastFood.ABM.Parametros
{
    partial class frmParametrosAdmin
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
            this.CmdDelete = new System.Windows.Forms.Button();
            this.txtDescripcion = new Controles.FSOTextBox();
            this.txtCodigo = new Controles.FSOTextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CmdExtra = new System.Windows.Forms.Button();
            this.chkPredeterminada = new System.Windows.Forms.CheckBox();
            this.cboExtra = new Controles.FSOCombo();
            this.cboNumerador = new System.Windows.Forms.ComboBox();
            this.lblComprobante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdDelete
            // 
            this.CmdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmdDelete.Location = new System.Drawing.Point(15, 116);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(75, 23);
            this.CmdDelete.TabIndex = 5;
            this.CmdDelete.TabStop = false;
            this.CmdDelete.Text = "Eliminar";
            this.CmdDelete.UseVisualStyleBackColor = false;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 39);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(435, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(134, 11);
            this.txtCodigo.MaxLength = 18;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(494, 116);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 4;
            this.cmdCancel.Text = "&Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(413, 116);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 3;
            this.cmdGuardar.Text = "&Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CmdExtra
            // 
            this.CmdExtra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CmdExtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmdExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdExtra.Location = new System.Drawing.Point(413, 87);
            this.CmdExtra.Name = "CmdExtra";
            this.CmdExtra.Size = new System.Drawing.Size(156, 23);
            this.CmdExtra.TabIndex = 10;
            this.CmdExtra.Text = "Consultar Permisos";
            this.CmdExtra.UseVisualStyleBackColor = false;
            this.CmdExtra.Visible = false;
            this.CmdExtra.Click += new System.EventHandler(this.CmdExtra_Click);
            // 
            // chkPredeterminada
            // 
            this.chkPredeterminada.AutoSize = true;
            this.chkPredeterminada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPredeterminada.Location = new System.Drawing.Point(455, 64);
            this.chkPredeterminada.Name = "chkPredeterminada";
            this.chkPredeterminada.Size = new System.Drawing.Size(114, 17);
            this.chkPredeterminada.TabIndex = 19;
            this.chkPredeterminada.Text = "Predeterminada";
            this.chkPredeterminada.UseVisualStyleBackColor = true;
            this.chkPredeterminada.Visible = false;
            // 
            // cboExtra
            // 
            this.cboExtra.AnchoBoton = 20;
            this.cboExtra.AnchoLabel = 119;
            this.cboExtra.AnchoTxtCod = 100;
            this.cboExtra.CodigoActual = "";
            this.cboExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboExtra.FiltrosCampos = "";
            this.cboExtra.FiltrosValores = "";
            this.cboExtra.IdSelected = -1;
            this.cboExtra.Location = new System.Drawing.Point(12, 65);
            this.cboExtra.Name = "cboExtra";
            this.cboExtra.ObjetoActual = null;
            this.cboExtra.Size = new System.Drawing.Size(564, 21);
            this.cboExtra.TabIndex = 20;
            this.cboExtra.Texto = "Extra";
            this.cboExtra.Visible = false;
            // 
            // cboNumerador
            // 
            this.cboNumerador.FormattingEnabled = true;
            this.cboNumerador.Location = new System.Drawing.Point(134, 65);
            this.cboNumerador.Name = "cboNumerador";
            this.cboNumerador.Size = new System.Drawing.Size(224, 21);
            this.cboNumerador.TabIndex = 21;
            this.cboNumerador.Visible = false;
            // 
            // lblComprobante
            // 
            this.lblComprobante.AutoSize = true;
            this.lblComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComprobante.Location = new System.Drawing.Point(12, 65);
            this.lblComprobante.Name = "lblComprobante";
            this.lblComprobante.Size = new System.Drawing.Size(68, 13);
            this.lblComprobante.TabIndex = 22;
            this.lblComprobante.Text = "Numerador";
            this.lblComprobante.Visible = false;
            // 
            // frmParametrosAdmin
            // 
            this.AcceptButton = this.cmdGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(581, 145);
            this.Controls.Add(this.lblComprobante);
            this.Controls.Add(this.cboNumerador);
            this.Controls.Add(this.cboExtra);
            this.Controls.Add(this.chkPredeterminada);
            this.Controls.Add(this.CmdExtra);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametrosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRolesAdmin";
            this.Load += new System.EventHandler(this.frmRolesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdDelete;
        private FSOTextBox txtDescripcion;
        private FSOTextBox txtCodigo;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button CmdExtra;
        private System.Windows.Forms.CheckBox chkPredeterminada;
        private FSOCombo cboExtra;
        private System.Windows.Forms.Label lblComprobante;
        private System.Windows.Forms.ComboBox cboNumerador;
    }
}