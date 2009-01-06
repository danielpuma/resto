namespace FastFood.ABM.RolesYPermisos
{
    partial class frmPermisosPorRol
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
            this.GrillaNo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAddAll = new System.Windows.Forms.Button();
            this.cmdAddOne = new System.Windows.Forms.Button();
            this.cmdDelOne = new System.Windows.Forms.Button();
            this.cmdDelAll = new System.Windows.Forms.Button();
            this.GrillaSI = new System.Windows.Forms.DataGridView();
            this.IDSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaNo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSI)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaNo
            // 
            this.GrillaNo.AllowUserToAddRows = false;
            this.GrillaNo.AllowUserToDeleteRows = false;
            this.GrillaNo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrillaNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NoNombre});
            this.GrillaNo.Location = new System.Drawing.Point(3, 70);
            this.GrillaNo.Name = "GrillaNo";
            this.GrillaNo.ReadOnly = true;
            this.GrillaNo.RowHeadersVisible = false;
            this.GrillaNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaNo.Size = new System.Drawing.Size(336, 520);
            this.GrillaNo.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NoNombre
            // 
            this.NoNombre.HeaderText = "Nombre";
            this.NoNombre.Name = "NoNombre";
            this.NoNombre.ReadOnly = true;
            this.NoNombre.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 47);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Permisos del Rol: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Permisos No Asignados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Permisos Asignados";
            // 
            // cmdAddAll
            // 
            this.cmdAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddAll.Location = new System.Drawing.Point(345, 70);
            this.cmdAddAll.Name = "cmdAddAll";
            this.cmdAddAll.Size = new System.Drawing.Size(71, 21);
            this.cmdAddAll.TabIndex = 32;
            this.cmdAddAll.Text = ">>";
            this.cmdAddAll.UseVisualStyleBackColor = true;
            this.cmdAddAll.Click += new System.EventHandler(this.cmdAddAll_Click);
            // 
            // cmdAddOne
            // 
            this.cmdAddOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddOne.Location = new System.Drawing.Point(345, 98);
            this.cmdAddOne.Name = "cmdAddOne";
            this.cmdAddOne.Size = new System.Drawing.Size(71, 23);
            this.cmdAddOne.TabIndex = 33;
            this.cmdAddOne.Text = ">";
            this.cmdAddOne.UseVisualStyleBackColor = true;
            this.cmdAddOne.Click += new System.EventHandler(this.cmdAddOne_Click);
            // 
            // cmdDelOne
            // 
            this.cmdDelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelOne.Location = new System.Drawing.Point(345, 525);
            this.cmdDelOne.Name = "cmdDelOne";
            this.cmdDelOne.Size = new System.Drawing.Size(70, 23);
            this.cmdDelOne.TabIndex = 34;
            this.cmdDelOne.Text = "<";
            this.cmdDelOne.UseVisualStyleBackColor = true;
            this.cmdDelOne.Click += new System.EventHandler(this.cmdDelOne_Click);
            // 
            // cmdDelAll
            // 
            this.cmdDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelAll.Location = new System.Drawing.Point(345, 554);
            this.cmdDelAll.Name = "cmdDelAll";
            this.cmdDelAll.Size = new System.Drawing.Size(70, 23);
            this.cmdDelAll.TabIndex = 36;
            this.cmdDelAll.Text = "<<";
            this.cmdDelAll.UseVisualStyleBackColor = true;
            this.cmdDelAll.Click += new System.EventHandler(this.cmdDelAll_Click);
            // 
            // GrillaSI
            // 
            this.GrillaSI.AllowUserToAddRows = false;
            this.GrillaSI.AllowUserToDeleteRows = false;
            this.GrillaSI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaSI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSi,
            this.Nombre});
            this.GrillaSI.Location = new System.Drawing.Point(429, 71);
            this.GrillaSI.Name = "GrillaSI";
            this.GrillaSI.ReadOnly = true;
            this.GrillaSI.RowHeadersVisible = false;
            this.GrillaSI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaSI.Size = new System.Drawing.Size(308, 519);
            this.GrillaSI.TabIndex = 37;
            // 
            // IDSi
            // 
            this.IDSi.HeaderText = "IDSi";
            this.IDSi.Name = "IDSi";
            this.IDSi.ReadOnly = true;
            this.IDSi.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // frmPermisosPorRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 589);
            this.Controls.Add(this.GrillaSI);
            this.Controls.Add(this.cmdDelAll);
            this.Controls.Add(this.cmdDelOne);
            this.Controls.Add(this.cmdAddOne);
            this.Controls.Add(this.cmdAddAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrillaNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPermisosPorRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación de Permisos a Roles";
            this.Load += new System.EventHandler(this.frmPermisosPorRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaNo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAddAll;
        private System.Windows.Forms.Button cmdAddOne;
        private System.Windows.Forms.Button cmdDelOne;
        private System.Windows.Forms.Button cmdDelAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoNombre;
        private System.Windows.Forms.DataGridView GrillaSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}