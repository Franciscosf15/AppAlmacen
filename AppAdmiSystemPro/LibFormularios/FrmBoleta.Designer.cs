namespace LibFormularios
{
    partial class FrmBoleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBoleta));
            this.TxtNroBoleta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.GrbProducto = new System.Windows.Forms.GroupBox();
            this.BtnCodProducto = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LblTotalEnLetras = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DgvAux = new System.Windows.Forms.DataGridView();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvVenta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.GrbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Size = new System.Drawing.Size(635, 47);
            this.label1.Text = "BOLETA DE VENTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.BtnGrabar);
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Size = new System.Drawing.Size(635, 57);
            this.panel2.Controls.SetChildIndex(this.BtnSalir, 0);
            this.panel2.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.panel2.Controls.SetChildIndex(this.BtnEliminar, 0);
            this.panel2.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.panel2.Controls.SetChildIndex(this.BtnImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.BtnGrabar, 0);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(269, 14);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnNuevo.Location = new System.Drawing.Point(128, 14);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(166, 14);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(166, 14);
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DgvVenta);
            this.panel3.Controls.Add(this.TxtCliente);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DgvAux);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.LblTotalEnLetras);
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.GrbProducto);
            this.panel3.Controls.Add(this.DtpFecha);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.TxtNroBoleta);
            this.panel3.Size = new System.Drawing.Size(635, 471);
            this.panel3.Controls.SetChildIndex(this.TxtNroBoleta, 0);
            this.panel3.Controls.SetChildIndex(this.label14, 0);
            this.panel3.Controls.SetChildIndex(this.DtpFecha, 0);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            this.panel3.Controls.SetChildIndex(this.GrbProducto, 0);
            this.panel3.Controls.SetChildIndex(this.label21, 0);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.LblTotal, 0);
            this.panel3.Controls.SetChildIndex(this.LblTotalEnLetras, 0);
            this.panel3.Controls.SetChildIndex(this.label17, 0);
            this.panel3.Controls.SetChildIndex(this.DgvAux, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.TxtCliente, 0);
            this.panel3.Controls.SetChildIndex(this.DgvVenta, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            // 
            // PtbImagen
            // 
            this.PtbImagen.Image = global::LibFormularios.Properties.Resources.Logo;
            this.PtbImagen.Size = new System.Drawing.Size(367, 109);
            this.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // TxtNroBoleta
            // 
            this.TxtNroBoleta.Enabled = false;
            this.TxtNroBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroBoleta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtNroBoleta.Location = new System.Drawing.Point(398, 35);
            this.TxtNroBoleta.Name = "TxtNroBoleta";
            this.TxtNroBoleta.Size = new System.Drawing.Size(185, 26);
            this.TxtNroBoleta.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(396, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 18);
            this.label14.TabIndex = 81;
            this.label14.Text = "Fecha:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.DtpFecha.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(399, 97);
            this.DtpFecha.MinDate = new System.DateTime(1899, 11, 17, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(224, 26);
            this.DtpFecha.TabIndex = 82;
            this.DtpFecha.Value = new System.DateTime(2018, 10, 20, 0, 0, 0, 0);
            // 
            // GrbProducto
            // 
            this.GrbProducto.Controls.Add(this.BtnCodProducto);
            this.GrbProducto.Controls.Add(this.BtnAgregar);
            this.GrbProducto.Controls.Add(this.TxtCantidad);
            this.GrbProducto.Controls.Add(this.label11);
            this.GrbProducto.Controls.Add(this.TxtPrecio);
            this.GrbProducto.Controls.Add(this.label10);
            this.GrbProducto.Controls.Add(this.TxtStock);
            this.GrbProducto.Controls.Add(this.TxtUnidadMedida);
            this.GrbProducto.Controls.Add(this.label8);
            this.GrbProducto.Controls.Add(this.label9);
            this.GrbProducto.Controls.Add(this.TxtMarca);
            this.GrbProducto.Controls.Add(this.label7);
            this.GrbProducto.Controls.Add(this.TxtDescripcion);
            this.GrbProducto.Controls.Add(this.label6);
            this.GrbProducto.Controls.Add(this.TxtCodProducto);
            this.GrbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbProducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GrbProducto.Location = new System.Drawing.Point(13, 161);
            this.GrbProducto.Name = "GrbProducto";
            this.GrbProducto.Size = new System.Drawing.Size(611, 111);
            this.GrbProducto.TabIndex = 84;
            this.GrbProducto.TabStop = false;
            this.GrbProducto.Text = "Producto";
            // 
            // BtnCodProducto
            // 
            this.BtnCodProducto.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.BtnCodProducto.ForeColor = System.Drawing.Color.White;
            this.BtnCodProducto.Location = new System.Drawing.Point(8, 19);
            this.BtnCodProducto.Name = "BtnCodProducto";
            this.BtnCodProducto.Size = new System.Drawing.Size(77, 26);
            this.BtnCodProducto.TabIndex = 21;
            this.BtnCodProducto.Text = "Codigo :";
            this.BtnCodProducto.UseVisualStyleBackColor = false;
            this.BtnCodProducto.Click += new System.EventHandler(this.BtnCodProducto_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(502, 77);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(101, 30);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtCantidad.Location = new System.Drawing.Point(408, 78);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(65, 22);
            this.TxtCantidad.TabIndex = 15;
            this.TxtCantidad.Text = "1";
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(332, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Cantidad:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtPrecio.Location = new System.Drawing.Point(111, 78);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(79, 22);
            this.TxtPrecio.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Precio Unitario:";
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtStock.Location = new System.Drawing.Point(255, 78);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(65, 22);
            this.TxtStock.TabIndex = 11;
            // 
            // TxtUnidadMedida
            // 
            this.TxtUnidadMedida.Enabled = false;
            this.TxtUnidadMedida.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtUnidadMedida.Location = new System.Drawing.Point(480, 50);
            this.TxtUnidadMedida.Name = "TxtUnidadMedida";
            this.TxtUnidadMedida.Size = new System.Drawing.Size(123, 22);
            this.TxtUnidadMedida.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unidad de Medida:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Stock:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Enabled = false;
            this.TxtMarca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtMarca.Location = new System.Drawing.Point(65, 50);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(271, 22);
            this.TxtMarca.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Marca:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Enabled = false;
            this.TxtDescripcion.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtDescripcion.Location = new System.Drawing.Point(311, 21);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(292, 22);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion:";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Enabled = false;
            this.TxtCodProducto.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtCodProducto.Location = new System.Drawing.Point(104, 21);
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(102, 22);
            this.TxtCodProducto.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label21.Location = new System.Drawing.Point(21, 275);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(164, 20);
            this.label21.TabIndex = 85;
            this.label21.Text = "Detalle de la venta:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label17.Location = new System.Drawing.Point(380, 443);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 90;
            this.label17.Text = "soles.";
            // 
            // LblTotalEnLetras
            // 
            this.LblTotalEnLetras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotalEnLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalEnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalEnLetras.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblTotalEnLetras.Location = new System.Drawing.Point(22, 438);
            this.LblTotalEnLetras.Name = "LblTotalEnLetras";
            this.LblTotalEnLetras.Size = new System.Drawing.Size(352, 24);
            this.LblTotalEnLetras.TabIndex = 89;
            this.LblTotalEnLetras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LblTotal.Location = new System.Drawing.Point(500, 439);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(84, 24);
            this.LblTotal.TabIndex = 88;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(443, 445);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 87;
            this.label18.Text = "TOTAL:";
            // 
            // DgvAux
            // 
            this.DgvAux.AllowUserToAddRows = false;
            this.DgvAux.AllowUserToDeleteRows = false;
            this.DgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAux.Location = new System.Drawing.Point(657, 18);
            this.DgvAux.Name = "DgvAux";
            this.DgvAux.ReadOnly = true;
            this.DgvAux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvAux.Size = new System.Drawing.Size(660, 151);
            this.DgvAux.TabIndex = 91;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TxtCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TxtCliente.Location = new System.Drawing.Point(82, 133);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(534, 22);
            this.TxtCliente.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "Cliente:";
            // 
            // DgvVenta
            // 
            this.DgvVenta.AllowUserToAddRows = false;
            this.DgvVenta.AllowUserToDeleteRows = false;
            this.DgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colCantidad,
            this.colUnidad,
            this.colMarca,
            this.colDescripcion,
            this.colPrecio,
            this.colSubTotal,
            this.colBorrar});
            this.DgvVenta.Location = new System.Drawing.Point(13, 298);
            this.DgvVenta.Name = "DgvVenta";
            this.DgvVenta.ReadOnly = true;
            this.DgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvVenta.Size = new System.Drawing.Size(603, 137);
            this.DgvVenta.TabIndex = 94;
            this.DgvVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVenta_CellClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 50;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 40;
            // 
            // colUnidad
            // 
            this.colUnidad.HeaderText = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.ReadOnly = true;
            this.colUnidad.Width = 50;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            this.colMarca.Width = 80;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 175;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "P.U.";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 50;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Sub Total";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 80;
            // 
            // colBorrar
            // 
            this.colBorrar.HeaderText = "";
            this.colBorrar.Name = "colBorrar";
            this.colBorrar.ReadOnly = true;
            this.colBorrar.Text = "x";
            this.colBorrar.ToolTipText = "x";
            this.colBorrar.UseColumnTextForButtonValue = true;
            this.colBorrar.Width = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(395, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "NUMERO DE BOLETA:";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.Color.White;
            this.BtnGrabar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnGrabar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.BtnGrabar.Location = new System.Drawing.Point(506, 15);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(110, 31);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "GUARDAR";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // FrmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 575);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBoleta";
            this.Text = "Boleta de Venta";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.GrbProducto.ResumeLayout(false);
            this.GrbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtNroBoleta;
        private System.Windows.Forms.GroupBox GrbProducto;
        private System.Windows.Forms.Button BtnCodProducto;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtUnidadMedida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LblTotalEnLetras;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView DgvAux;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn colBorrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGrabar;
    }
}