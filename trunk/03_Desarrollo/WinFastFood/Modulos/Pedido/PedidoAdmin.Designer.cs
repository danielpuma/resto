namespace WinFastFood.Modulos.Pedido
{
    partial class PedidoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoAdmin));
            this.chkCerrado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.lblAnulación = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.TxtVuelto = new System.Windows.Forms.Label();
            this.txtTotalFacturado = new System.Windows.Forms.Label();
            this.txtPagaCon = new Controles.NumericTextBox.DecimalTextBox();
            this.fsoMozo = new Controles.FSOCombo();
            this.fsoListaPrecio = new Controles.FSOCombo();
            this.txtDescRec = new Controles.NumericTextBox.DecimalTextBox();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblNro = new System.Windows.Forms.Label();
            this.lblOcupantes = new System.Windows.Forms.Label();
            this.txtOcupantes = new Controles.NumericTextBox.DecimalTextBox();
            this.fsoCliente = new Controles.FSOCombo();
            this.fsoMesa = new Controles.FSOCombo();
            this.dtFecha = new Controles.DateTimeInputBox();
            this.dgCuerpo = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdLDP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdPUOriginal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colCheck = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pblBody = new System.Windows.Forms.Panel();
            this.txtTotalLinea = new Controles.NumericTextBox.DecimalTextBox();
            this.txtPU = new Controles.NumericTextBox.DecimalTextBox();
            this.txtCant = new Controles.NumericTextBox.DecimalTextBox();
            this.cmdAddLinea = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fsoArticulo = new Controles.FSOCombo();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblPedNro = new System.Windows.Forms.Label();
            this.pnlFoot.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuerpo)).BeginInit();
            this.pblBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCerrado
            // 
            this.chkCerrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCerrado.AutoSize = true;
            this.chkCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCerrado.Location = new System.Drawing.Point(388, 58);
            this.chkCerrado.Name = "chkCerrado";
            this.chkCerrado.Size = new System.Drawing.Size(113, 17);
            this.chkCerrado.TabIndex = 3;
            this.chkCerrado.TabStop = false;
            this.chkCerrado.Text = "Pedido Cerrado";
            this.chkCerrado.UseVisualStyleBackColor = true;
            this.chkCerrado.CheckedChanged += new System.EventHandler(this.chkCerrado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha:";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGuardar.Location = new System.Drawing.Point(608, 95);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(95, 23);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // chkImprimir
            // 
            this.chkImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Enabled = false;
            this.chkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimir.Location = new System.Drawing.Point(528, 58);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(69, 17);
            this.chkImprimir.TabIndex = 4;
            this.chkImprimir.Text = "Imprimir";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(709, 94);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(91, 23);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancelar";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // lblAnulación
            // 
            this.lblAnulación.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnulación.BackColor = System.Drawing.Color.Red;
            this.lblAnulación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulación.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAnulación.Location = new System.Drawing.Point(11, 3);
            this.lblAnulación.Name = "lblAnulación";
            this.lblAnulación.Size = new System.Drawing.Size(790, 23);
            this.lblAnulación.TabIndex = 9;
            this.lblAnulación.Text = "Datos Anulación";
            this.lblAnulación.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Facturado:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Desc. - Rec.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Paga con:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Vuelto:";
            // 
            // pnlFoot
            // 
            this.pnlFoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFoot.BackColor = System.Drawing.Color.LightGray;
            this.pnlFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoot.Controls.Add(this.TxtVuelto);
            this.pnlFoot.Controls.Add(this.cmdCancel);
            this.pnlFoot.Controls.Add(this.txtTotalFacturado);
            this.pnlFoot.Controls.Add(this.cmdGuardar);
            this.pnlFoot.Controls.Add(this.txtPagaCon);
            this.pnlFoot.Controls.Add(this.fsoMozo);
            this.pnlFoot.Controls.Add(this.fsoListaPrecio);
            this.pnlFoot.Controls.Add(this.txtDescRec);
            this.pnlFoot.Controls.Add(this.label5);
            this.pnlFoot.Controls.Add(this.chkImprimir);
            this.pnlFoot.Controls.Add(this.label2);
            this.pnlFoot.Controls.Add(this.chkCerrado);
            this.pnlFoot.Controls.Add(this.label4);
            this.pnlFoot.Controls.Add(this.label3);
            this.pnlFoot.Location = new System.Drawing.Point(1, 339);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(810, 123);
            this.pnlFoot.TabIndex = 19;
            // 
            // TxtVuelto
            // 
            this.TxtVuelto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtVuelto.BackColor = System.Drawing.Color.Gainsboro;
            this.TxtVuelto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVuelto.ForeColor = System.Drawing.Color.Blue;
            this.TxtVuelto.Location = new System.Drawing.Point(616, 32);
            this.TxtVuelto.Name = "TxtVuelto";
            this.TxtVuelto.Size = new System.Drawing.Size(183, 43);
            this.TxtVuelto.TabIndex = 19;
            this.TxtVuelto.Text = "0.00";
            this.TxtVuelto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalFacturado
            // 
            this.txtTotalFacturado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalFacturado.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTotalFacturado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFacturado.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalFacturado.Location = new System.Drawing.Point(3, 19);
            this.txtTotalFacturado.Name = "txtTotalFacturado";
            this.txtTotalFacturado.Size = new System.Drawing.Size(179, 43);
            this.txtTotalFacturado.TabIndex = 18;
            this.txtTotalFacturado.Text = "0.00";
            this.txtTotalFacturado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.AllowSpace = false;
            this.txtPagaCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPagaCon.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.Location = new System.Drawing.Point(496, 32);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(100, 20);
            this.txtPagaCon.TabIndex = 2;
            this.txtPagaCon.Text = "0.00";
            this.txtPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagaCon.Leave += new System.EventHandler(this.txtPagaCon_Leave);
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
            this.fsoMozo.Location = new System.Drawing.Point(3, 69);
            this.fsoMozo.Name = "fsoMozo";
            this.fsoMozo.ObjetoActual = null;
            this.fsoMozo.Size = new System.Drawing.Size(362, 21);
            this.fsoMozo.TabIndex = 2;
            this.fsoMozo.TabStop = false;
            this.fsoMozo.Texto = "Mozo";
            // 
            // fsoListaPrecio
            // 
            this.fsoListaPrecio.AnchoBoton = 20;
            this.fsoListaPrecio.AnchoLabel = 50;
            this.fsoListaPrecio.AnchoTxtCod = 100;
            this.fsoListaPrecio.CodigoActual = "";
            this.fsoListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoListaPrecio.FiltrosCampos = "";
            this.fsoListaPrecio.FiltrosValores = "";
            this.fsoListaPrecio.IdSelected = -1;
            this.fsoListaPrecio.Location = new System.Drawing.Point(3, 96);
            this.fsoListaPrecio.Name = "fsoListaPrecio";
            this.fsoListaPrecio.ObjetoActual = null;
            this.fsoListaPrecio.Size = new System.Drawing.Size(340, 21);
            this.fsoListaPrecio.TabIndex = 5;
            this.fsoListaPrecio.TabStop = false;
            this.fsoListaPrecio.Texto = "LDP";
            this.fsoListaPrecio.ObjetoSeleccionado += new Controles.SeleccionDeObjeto(this.fsoListaPrecio_ObjetoSeleccionado);
            // 
            // txtDescRec
            // 
            this.txtDescRec.AllowSpace = false;
            this.txtDescRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescRec.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtDescRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescRec.Location = new System.Drawing.Point(388, 32);
            this.txtDescRec.Name = "txtDescRec";
            this.txtDescRec.Size = new System.Drawing.Size(85, 20);
            this.txtDescRec.TabIndex = 1;
            this.txtDescRec.TabStop = false;
            this.txtDescRec.Text = "0.00";
            this.txtDescRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescRec.Leave += new System.EventHandler(this.txtDescRec_Leave);
            // 
            // pnlHead
            // 
            this.pnlHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHead.BackColor = System.Drawing.Color.LightGray;
            this.pnlHead.Controls.Add(this.lblPedNro);
            this.pnlHead.Controls.Add(this.lblNro);
            this.pnlHead.Controls.Add(this.lblOcupantes);
            this.pnlHead.Controls.Add(this.txtOcupantes);
            this.pnlHead.Controls.Add(this.fsoCliente);
            this.pnlHead.Controls.Add(this.fsoMesa);
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Controls.Add(this.dtFecha);
            this.pnlHead.Location = new System.Drawing.Point(1, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(810, 75);
            this.pnlHead.TabIndex = 2;
            // 
            // lblNro
            // 
            this.lblNro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.Location = new System.Drawing.Point(634, 19);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(70, 13);
            this.lblNro.TabIndex = 13;
            this.lblNro.Text = "Comp. Nro:";
            // 
            // lblOcupantes
            // 
            this.lblOcupantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOcupantes.AutoSize = true;
            this.lblOcupantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupantes.Location = new System.Drawing.Point(477, 44);
            this.lblOcupantes.Name = "lblOcupantes";
            this.lblOcupantes.Size = new System.Drawing.Size(72, 13);
            this.lblOcupantes.TabIndex = 11;
            this.lblOcupantes.Text = "Ocupantes:";
            this.lblOcupantes.Visible = false;
            // 
            // txtOcupantes
            // 
            this.txtOcupantes.AllowSpace = false;
            this.txtOcupantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOcupantes.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtOcupantes.Location = new System.Drawing.Point(560, 41);
            this.txtOcupantes.Name = "txtOcupantes";
            this.txtOcupantes.Size = new System.Drawing.Size(92, 20);
            this.txtOcupantes.TabIndex = 10;
            this.txtOcupantes.Text = "0";
            this.txtOcupantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOcupantes.Visible = false;
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
            this.fsoCliente.Location = new System.Drawing.Point(13, 16);
            this.fsoCliente.Name = "fsoCliente";
            this.fsoCliente.ObjetoActual = null;
            this.fsoCliente.Size = new System.Drawing.Size(506, 21);
            this.fsoCliente.TabIndex = 0;
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
            this.fsoMesa.Location = new System.Drawing.Point(13, 43);
            this.fsoMesa.Name = "fsoMesa";
            this.fsoMesa.ObjetoActual = null;
            this.fsoMesa.Size = new System.Drawing.Size(436, 21);
            this.fsoMesa.TabIndex = 1;
            this.fsoMesa.Texto = "Mesa";
            this.fsoMesa.ObjetoSeleccionado += new Controles.SeleccionDeObjeto(this.fsoMesa_ObjetoSeleccionado);
            // 
            // dtFecha
            // 
            this.dtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFecha.Fecha = new System.DateTime(2009, 1, 10, 0, 0, 0, 0);
            this.dtFecha.FechaNuleable = new System.DateTime(2009, 1, 10, 0, 0, 0, 0);
            this.dtFecha.Location = new System.Drawing.Point(710, 41);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(92, 20);
            this.dtFecha.TabIndex = 4;
            this.dtFecha.TabStop = false;
            // 
            // dgCuerpo
            // 
            this.dgCuerpo.AllowUserToAddRows = false;
            this.dgCuerpo.AllowUserToDeleteRows = false;
            this.dgCuerpo.AllowUserToResizeRows = false;
            this.dgCuerpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCuerpo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgCuerpo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCuerpo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCuerpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCuerpo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColIdArticulo,
            this.ColIdLDP,
            this.ColIdPUOriginal,
            this.ColCodArt,
            this.ColDescArt,
            this.ColPU,
            this.colCantidad,
            this.ColTotalLinea,
            this.Column1,
            this.colCheck});
            this.dgCuerpo.Location = new System.Drawing.Point(1, 120);
            this.dgCuerpo.Name = "dgCuerpo";
            this.dgCuerpo.RowHeadersVisible = false;
            this.dgCuerpo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCuerpo.Size = new System.Drawing.Size(810, 213);
            this.dgCuerpo.TabIndex = 21;
            this.dgCuerpo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuerpo_CellDoubleClick);
            this.dgCuerpo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCuerpo_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColIdArticulo
            // 
            this.ColIdArticulo.HeaderText = "ColIdArticulo";
            this.ColIdArticulo.Name = "ColIdArticulo";
            this.ColIdArticulo.ReadOnly = true;
            this.ColIdArticulo.Visible = false;
            // 
            // ColIdLDP
            // 
            this.ColIdLDP.HeaderText = "IDLDP";
            this.ColIdLDP.Name = "ColIdLDP";
            this.ColIdLDP.ReadOnly = true;
            this.ColIdLDP.Visible = false;
            // 
            // ColIdPUOriginal
            // 
            this.ColIdPUOriginal.HeaderText = "ColIdPUOriginal";
            this.ColIdPUOriginal.Name = "ColIdPUOriginal";
            this.ColIdPUOriginal.ReadOnly = true;
            this.ColIdPUOriginal.Visible = false;
            // 
            // ColCodArt
            // 
            this.ColCodArt.HeaderText = "Codigo";
            this.ColCodArt.Name = "ColCodArt";
            this.ColCodArt.ReadOnly = true;
            // 
            // ColDescArt
            // 
            this.ColDescArt.HeaderText = "Artículo";
            this.ColDescArt.Name = "ColDescArt";
            this.ColDescArt.ReadOnly = true;
            this.ColDescArt.Width = 300;
            // 
            // ColPU
            // 
            this.ColPU.HeaderText = "Precio Unitario";
            this.ColPU.Name = "ColPU";
            this.ColPU.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // ColTotalLinea
            // 
            this.ColTotalLinea.HeaderText = "Total Linea";
            this.ColTotalLinea.Name = "ColTotalLinea";
            this.ColTotalLinea.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imprime";
            this.Column1.Image = global::WinFastFood.Properties.Resources._8close16;
            this.Column1.Name = "Column1";
            // 
            // colCheck
            // 
            this.colCheck.HeaderText = "colCheck";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = false;
            // 
            // pblBody
            // 
            this.pblBody.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pblBody.BackColor = System.Drawing.Color.LightGray;
            this.pblBody.Controls.Add(this.lblAnulación);
            this.pblBody.Controls.Add(this.txtTotalLinea);
            this.pblBody.Controls.Add(this.txtPU);
            this.pblBody.Controls.Add(this.txtCant);
            this.pblBody.Controls.Add(this.cmdAddLinea);
            this.pblBody.Controls.Add(this.label8);
            this.pblBody.Controls.Add(this.label7);
            this.pblBody.Controls.Add(this.label6);
            this.pblBody.Controls.Add(this.fsoArticulo);
            this.pblBody.Location = new System.Drawing.Point(1, 81);
            this.pblBody.Name = "pblBody";
            this.pblBody.Size = new System.Drawing.Size(810, 33);
            this.pblBody.TabIndex = 3;
            // 
            // txtTotalLinea
            // 
            this.txtTotalLinea.AllowSpace = false;
            this.txtTotalLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalLinea.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtTotalLinea.Enabled = false;
            this.txtTotalLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLinea.Location = new System.Drawing.Point(679, 3);
            this.txtTotalLinea.Name = "txtTotalLinea";
            this.txtTotalLinea.Size = new System.Drawing.Size(55, 20);
            this.txtTotalLinea.TabIndex = 3;
            this.txtTotalLinea.Text = "0.00";
            this.txtTotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPU
            // 
            this.txtPU.AllowSpace = false;
            this.txtPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPU.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtPU.Enabled = false;
            this.txtPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPU.Location = new System.Drawing.Point(576, 3);
            this.txtPU.Name = "txtPU";
            this.txtPU.Size = new System.Drawing.Size(55, 20);
            this.txtPU.TabIndex = 2;
            this.txtPU.Text = "0.00";
            this.txtPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPU_KeyDown);
            this.txtPU.Leave += new System.EventHandler(this.txtPU_Leave);
            // 
            // txtCant
            // 
            this.txtCant.AllowSpace = false;
            this.txtCant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCant.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(479, 3);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(55, 20);
            this.txtCant.TabIndex = 1;
            this.txtCant.Text = "0.00";
            this.txtCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCant_KeyDown);
            this.txtCant.Leave += new System.EventHandler(this.txtCant_Leave);
            // 
            // cmdAddLinea
            // 
            this.cmdAddLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddLinea.Image = global::WinFastFood.Properties.Resources._8add48;
            this.cmdAddLinea.Location = new System.Drawing.Point(774, 3);
            this.cmdAddLinea.Name = "cmdAddLinea";
            this.cmdAddLinea.Size = new System.Drawing.Size(24, 19);
            this.cmdAddLinea.TabIndex = 4;
            this.cmdAddLinea.UseVisualStyleBackColor = true;
            this.cmdAddLinea.Click += new System.EventHandler(this.cmdAddLinea_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(540, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "PU:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(433, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cant:";
            // 
            // fsoArticulo
            // 
            this.fsoArticulo.AnchoBoton = 20;
            this.fsoArticulo.AnchoLabel = 25;
            this.fsoArticulo.AnchoTxtCod = 100;
            this.fsoArticulo.CodigoActual = "";
            this.fsoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fsoArticulo.FiltrosCampos = "";
            this.fsoArticulo.FiltrosValores = "";
            this.fsoArticulo.IdSelected = -1;
            this.fsoArticulo.Location = new System.Drawing.Point(10, 4);
            this.fsoArticulo.Name = "fsoArticulo";
            this.fsoArticulo.ObjetoActual = null;
            this.fsoArticulo.Size = new System.Drawing.Size(409, 21);
            this.fsoArticulo.TabIndex = 0;
            this.fsoArticulo.Texto = "Articulo:";
            this.fsoArticulo.ObjetoSeleccionado += new Controles.SeleccionDeObjeto(this.fsoArticulo_ObjetoSeleccionado);
            this.fsoArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fsoArticulo_KeyDown);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Imprime";
            this.dataGridViewImageColumn1.Image = global::WinFastFood.Properties.Resources._8close16;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // lblPedNro
            // 
            this.lblPedNro.AutoSize = true;
            this.lblPedNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedNro.Location = new System.Drawing.Point(710, 19);
            this.lblPedNro.Name = "lblPedNro";
            this.lblPedNro.Size = new System.Drawing.Size(77, 13);
            this.lblPedNro.TabIndex = 14;
            this.lblPedNro.Text = "0000000000";
            // 
            // PedidoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(811, 470);
            this.Controls.Add(this.dgCuerpo);
            this.Controls.Add(this.pnlFoot);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.pblBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PedidoAdmin";
            this.Text = "Carga de Pedidos";
            this.Load += new System.EventHandler(this.PedidoAdmin_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PedidoAdmin_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PedidoAdmin_KeyDown);
            this.pnlFoot.ResumeLayout(false);
            this.pnlFoot.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCuerpo)).EndInit();
            this.pblBody.ResumeLayout(false);
            this.pblBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.FSOCombo fsoCliente;
        private Controles.FSOCombo fsoMesa;
        private Controles.FSOCombo fsoMozo;
        private System.Windows.Forms.CheckBox chkCerrado;
        private Controles.DateTimeInputBox dtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label lblAnulación;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Controles.FSOCombo fsoListaPrecio;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.DataGridView dgCuerpo;
        private Controles.FSOCombo fsoArticulo;
        private System.Windows.Forms.Panel pblBody;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAddLinea;
        private Controles.NumericTextBox.DecimalTextBox txtCant;
        private Controles.NumericTextBox.DecimalTextBox txtPagaCon;
        private Controles.NumericTextBox.DecimalTextBox txtDescRec;
        private Controles.NumericTextBox.DecimalTextBox txtTotalLinea;
        private Controles.NumericTextBox.DecimalTextBox txtPU;
        private System.Windows.Forms.Label TxtVuelto;
        private System.Windows.Forms.Label txtTotalFacturado;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdLDP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdPUOriginal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalLinea;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheck;
        private System.Windows.Forms.Label lblOcupantes;
        private Controles.NumericTextBox.DecimalTextBox txtOcupantes;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label lblPedNro;
    }
}