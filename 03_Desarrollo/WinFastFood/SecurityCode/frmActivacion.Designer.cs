using Controles;
namespace FastFood.SecurityCode
{
    partial class frmActivacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivacion));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new Controles.FSOTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoActivacion = new Controles.FSOTextBox();
            this.cmdActivar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Seguridad:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(150, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(402, 20);
            this.txtCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Activación:";
            // 
            // txtCodigoActivacion
            // 
            this.txtCodigoActivacion.Location = new System.Drawing.Point(150, 41);
            this.txtCodigoActivacion.Name = "txtCodigoActivacion";
            this.txtCodigoActivacion.Size = new System.Drawing.Size(402, 20);
            this.txtCodigoActivacion.TabIndex = 1;
            // 
            // cmdActivar
            // 
            this.cmdActivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActivar.Location = new System.Drawing.Point(359, 67);
            this.cmdActivar.Name = "cmdActivar";
            this.cmdActivar.Size = new System.Drawing.Size(193, 23);
            this.cmdActivar.TabIndex = 4;
            this.cmdActivar.Text = "Activar Aplicación";
            this.cmdActivar.UseVisualStyleBackColor = true;
            this.cmdActivar.Click += new System.EventHandler(this.cmdActivar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFastFood.Properties.Resources.package;
            this.pictureBox1.Location = new System.Drawing.Point(15, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 64);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Procedimiento de Activación de Software";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(87, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // cmdDemo
            // 
            this.cmdDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDemo.Location = new System.Drawing.Point(359, 96);
            this.cmdDemo.Name = "cmdDemo";
            this.cmdDemo.Size = new System.Drawing.Size(193, 23);
            this.cmdDemo.TabIndex = 8;
            this.cmdDemo.Text = "Usar Modo Demo por 30 días";
            this.cmdDemo.UseVisualStyleBackColor = true;
            this.cmdDemo.Click += new System.EventHandler(this.cmdDemo_Click);
            // 
            // frmActivacion
            // 
            this.AcceptButton = this.cmdActivar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 211);
            this.Controls.Add(this.cmdDemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdActivar);
            this.Controls.Add(this.txtCodigoActivacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivacion";
            this.Text = "Activación de Software";
            this.Load += new System.EventHandler(this.frmActivacion_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmActivacion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FSOTextBox txtCode;
        private System.Windows.Forms.Label label2;
        private FSOTextBox txtCodigoActivacion;
        private System.Windows.Forms.Button cmdActivar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDemo;
    }
}