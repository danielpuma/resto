namespace FastFood.ABM.Usuarios
{
    partial class frmRolesDelUsuario
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
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.cmdAddRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaDatos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(77, 12);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(300, 21);
            this.cboRoles.TabIndex = 0;
            // 
            // cmdAddRol
            // 
            this.cmdAddRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddRol.Location = new System.Drawing.Point(394, 12);
            this.cmdAddRol.Name = "cmdAddRol";
            this.cmdAddRol.Size = new System.Drawing.Size(97, 21);
            this.cmdAddRol.TabIndex = 1;
            this.cmdAddRol.Text = "Agregar Rol";
            this.cmdAddRol.UseVisualStyleBackColor = true;
            this.cmdAddRol.Click += new System.EventHandler(this.cmdAddRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Roles:";
            // 
            // GrillaDatos
            // 
            this.GrillaDatos.AllowUserToAddRows = false;
            this.GrillaDatos.AllowUserToDeleteRows = false;
            this.GrillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Codigo,
            this.Nombre});
            this.GrillaDatos.Location = new System.Drawing.Point(1, 53);
            this.GrillaDatos.Name = "GrillaDatos";
            this.GrillaDatos.ReadOnly = true;
            this.GrillaDatos.RowHeadersVisible = false;
            this.GrillaDatos.Size = new System.Drawing.Size(623, 404);
            this.GrillaDatos.TabIndex = 3;
            this.GrillaDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaDatos_CellDoubleClick);
            this.GrillaDatos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrillaDatos_DataError);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 400;
            // 
            // frmRolesDelUsuario
            // 
            this.AcceptButton = this.cmdAddRol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 458);
            this.Controls.Add(this.GrillaDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAddRol);
            this.Controls.Add(this.cboRoles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRolesDelUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles del Usuario";
            this.Load += new System.EventHandler(this.frmRolesDelUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Button cmdAddRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}