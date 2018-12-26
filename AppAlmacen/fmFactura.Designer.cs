namespace AppAlmacen
{
    partial class fmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.buGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buGo = new System.Windows.Forms.Button();
            this.tbFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbIGV = new System.Windows.Forms.TextBox();
            this.tbSubTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
            this.cCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInsercionPro = new System.Windows.Forms.GroupBox();
            this.tbTipoProducto = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buConsultarProductos = new System.Windows.Forms.Button();
            this.buAgregar = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPU = new System.Windows.Forms.TextBox();
            this.tbUnidad = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbCodProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNroDoc = new System.Windows.Forms.TextBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.tbRuc = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.buConsultarCliente = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCodCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
            this.gbInsercionPro.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento Venta";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Controls.Add(this.buGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 35);
            this.panel2.TabIndex = 2;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(81, 6);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // buGuardar
            // 
            this.buGuardar.Location = new System.Drawing.Point(606, 6);
            this.buGuardar.Name = "buGuardar";
            this.buGuardar.Size = new System.Drawing.Size(75, 23);
            this.buGuardar.TabIndex = 0;
            this.buGuardar.Text = "Guardar";
            this.buGuardar.UseVisualStyleBackColor = true;
            this.buGuardar.Click += new System.EventHandler(this.buGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTipo);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.buGo);
            this.panel3.Controls.Add(this.tbFecha);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tbTotal);
            this.panel3.Controls.Add(this.tbIGV);
            this.panel3.Controls.Add(this.tbSubTotal);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbSon);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dgvDetalleVentas);
            this.panel3.Controls.Add(this.gbInsercionPro);
            this.panel3.Controls.Add(this.tbNroDoc);
            this.panel3.Controls.Add(this.gbCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 549);
            this.panel3.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbTipo.Location = new System.Drawing.Point(481, 71);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 22;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(411, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Tipo:";
            // 
            // buGo
            // 
            this.buGo.Location = new System.Drawing.Point(606, 8);
            this.buGo.Name = "buGo";
            this.buGo.Size = new System.Drawing.Size(75, 23);
            this.buGo.TabIndex = 20;
            this.buGo.Text = "Go";
            this.buGo.UseVisualStyleBackColor = true;
            this.buGo.Click += new System.EventHandler(this.buGo_Click);
            // 
            // tbFecha
            // 
            this.tbFecha.Enabled = false;
            this.tbFecha.Location = new System.Drawing.Point(481, 43);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(200, 20);
            this.tbFecha.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(524, 528);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total:";
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(587, 525);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(101, 20);
            this.tbTotal.TabIndex = 16;
            // 
            // tbIGV
            // 
            this.tbIGV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbIGV.Enabled = false;
            this.tbIGV.Location = new System.Drawing.Point(587, 499);
            this.tbIGV.Name = "tbIGV";
            this.tbIGV.Size = new System.Drawing.Size(101, 20);
            this.tbIGV.TabIndex = 15;
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSubTotal.Enabled = false;
            this.tbSubTotal.Location = new System.Drawing.Point(587, 473);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Size = new System.Drawing.Size(101, 20);
            this.tbSubTotal.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(524, 502);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "IGV:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(524, 476);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Sub Total:";
            // 
            // tbSon
            // 
            this.tbSon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSon.Enabled = false;
            this.tbSon.Location = new System.Drawing.Point(48, 476);
            this.tbSon.Name = "tbSon";
            this.tbSon.Size = new System.Drawing.Size(442, 20);
            this.tbSon.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 479);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Son:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Detalle de Ventas:";
            // 
            // dgvDetalleVentas
            // 
            this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCod,
            this.cCantidad,
            this.cUnidad,
            this.cMarca,
            this.cDescripcion,
            this.cPu,
            this.cSubTotal});
            this.dgvDetalleVentas.Enabled = false;
            this.dgvDetalleVentas.Location = new System.Drawing.Point(12, 294);
            this.dgvDetalleVentas.Name = "dgvDetalleVentas";
            this.dgvDetalleVentas.Size = new System.Drawing.Size(701, 164);
            this.dgvDetalleVentas.TabIndex = 8;
            // 
            // cCod
            // 
            this.cCod.HeaderText = "Cod";
            this.cCod.Name = "cCod";
            this.cCod.Width = 80;
            // 
            // cCantidad
            // 
            this.cCantidad.HeaderText = "Cantidad";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.Width = 70;
            // 
            // cUnidad
            // 
            this.cUnidad.HeaderText = "Unidad";
            this.cUnidad.Name = "cUnidad";
            // 
            // cMarca
            // 
            this.cMarca.HeaderText = "Marca";
            this.cMarca.Name = "cMarca";
            this.cMarca.Width = 70;
            // 
            // cDescripcion
            // 
            this.cDescripcion.HeaderText = "Descripión";
            this.cDescripcion.Name = "cDescripcion";
            this.cDescripcion.Width = 140;
            // 
            // cPu
            // 
            this.cPu.HeaderText = "P. U.";
            this.cPu.Name = "cPu";
            this.cPu.Width = 60;
            // 
            // cSubTotal
            // 
            this.cSubTotal.HeaderText = "Sub Total";
            this.cSubTotal.Name = "cSubTotal";
            // 
            // gbInsercionPro
            // 
            this.gbInsercionPro.Controls.Add(this.tbTipoProducto);
            this.gbInsercionPro.Controls.Add(this.label21);
            this.gbInsercionPro.Controls.Add(this.buConsultarProductos);
            this.gbInsercionPro.Controls.Add(this.buAgregar);
            this.gbInsercionPro.Controls.Add(this.tbCantidad);
            this.gbInsercionPro.Controls.Add(this.label13);
            this.gbInsercionPro.Controls.Add(this.tbStock);
            this.gbInsercionPro.Controls.Add(this.label12);
            this.gbInsercionPro.Controls.Add(this.tbPU);
            this.gbInsercionPro.Controls.Add(this.tbUnidad);
            this.gbInsercionPro.Controls.Add(this.tbProducto);
            this.gbInsercionPro.Controls.Add(this.tbCodProducto);
            this.gbInsercionPro.Controls.Add(this.label8);
            this.gbInsercionPro.Controls.Add(this.label9);
            this.gbInsercionPro.Controls.Add(this.label10);
            this.gbInsercionPro.Controls.Add(this.label11);
            this.gbInsercionPro.Location = new System.Drawing.Point(12, 177);
            this.gbInsercionPro.Name = "gbInsercionPro";
            this.gbInsercionPro.Size = new System.Drawing.Size(701, 97);
            this.gbInsercionPro.TabIndex = 7;
            this.gbInsercionPro.TabStop = false;
            this.gbInsercionPro.Text = "Inserción de productos";
            // 
            // tbTipoProducto
            // 
            this.tbTipoProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTipoProducto.Enabled = false;
            this.tbTipoProducto.Location = new System.Drawing.Point(449, 38);
            this.tbTipoProducto.Name = "tbTipoProducto";
            this.tbTipoProducto.Size = new System.Drawing.Size(230, 20);
            this.tbTipoProducto.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(366, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "Tipo Producto:";
            // 
            // buConsultarProductos
            // 
            this.buConsultarProductos.Location = new System.Drawing.Point(272, 11);
            this.buConsultarProductos.Name = "buConsultarProductos";
            this.buConsultarProductos.Size = new System.Drawing.Size(75, 23);
            this.buConsultarProductos.TabIndex = 21;
            this.buConsultarProductos.Text = "Consultar";
            this.buConsultarProductos.UseVisualStyleBackColor = true;
            this.buConsultarProductos.Click += new System.EventHandler(this.buConsultarProductos_Click);
            // 
            // buAgregar
            // 
            this.buAgregar.Location = new System.Drawing.Point(600, 64);
            this.buAgregar.Name = "buAgregar";
            this.buAgregar.Size = new System.Drawing.Size(75, 23);
            this.buAgregar.TabIndex = 12;
            this.buAgregar.Text = "Agregar";
            this.buAgregar.UseVisualStyleBackColor = true;
            this.buAgregar.Click += new System.EventHandler(this.buAgregar_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbCantidad.Location = new System.Drawing.Point(449, 65);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(133, 20);
            this.tbCantidad.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(369, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Cantidad:";
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbStock.Enabled = false;
            this.tbStock.Location = new System.Drawing.Point(116, 65);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(67, 20);
            this.tbStock.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Stock:";
            // 
            // tbPU
            // 
            this.tbPU.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPU.Enabled = false;
            this.tbPU.Location = new System.Drawing.Point(239, 64);
            this.tbPU.Name = "tbPU";
            this.tbPU.Size = new System.Drawing.Size(79, 20);
            this.tbPU.TabIndex = 7;
            // 
            // tbUnidad
            // 
            this.tbUnidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbUnidad.Enabled = false;
            this.tbUnidad.Location = new System.Drawing.Point(449, 12);
            this.tbUnidad.Name = "tbUnidad";
            this.tbUnidad.Size = new System.Drawing.Size(230, 20);
            this.tbUnidad.TabIndex = 6;
            // 
            // tbProducto
            // 
            this.tbProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbProducto.Enabled = false;
            this.tbProducto.Location = new System.Drawing.Point(116, 38);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(231, 20);
            this.tbProducto.TabIndex = 5;
            // 
            // tbCodProducto
            // 
            this.tbCodProducto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbCodProducto.Location = new System.Drawing.Point(116, 12);
            this.tbCodProducto.Name = "tbCodProducto";
            this.tbCodProducto.Size = new System.Drawing.Size(151, 20);
            this.tbCodProducto.TabIndex = 4;
            this.tbCodProducto.Leave += new System.EventHandler(this.tbCodProducto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "P. U.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Unidad:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Codigo:";
            // 
            // tbNroDoc
            // 
            this.tbNroDoc.Location = new System.Drawing.Point(481, 10);
            this.tbNroDoc.Name = "tbNroDoc";
            this.tbNroDoc.Size = new System.Drawing.Size(99, 20);
            this.tbNroDoc.TabIndex = 5;
            this.tbNroDoc.Leave += new System.EventHandler(this.tbNroDoc_Leave);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbRuc);
            this.gbCliente.Controls.Add(this.label20);
            this.gbCliente.Controls.Add(this.buConsultarCliente);
            this.gbCliente.Controls.Add(this.tbNombre);
            this.gbCliente.Controls.Add(this.tbTelefono);
            this.gbCliente.Controls.Add(this.tbDireccion);
            this.gbCliente.Controls.Add(this.tbCodCliente);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label5);
            this.gbCliente.Controls.Add(this.label4);
            this.gbCliente.Location = new System.Drawing.Point(12, 90);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(701, 81);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbRuc
            // 
            this.tbRuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbRuc.Enabled = false;
            this.tbRuc.Location = new System.Drawing.Point(523, 39);
            this.tbRuc.Name = "tbRuc";
            this.tbRuc.Size = new System.Drawing.Size(156, 20);
            this.tbRuc.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(484, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "RUC:";
            // 
            // buConsultarCliente
            // 
            this.buConsultarCliente.Location = new System.Drawing.Point(272, 11);
            this.buConsultarCliente.Name = "buConsultarCliente";
            this.buConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.buConsultarCliente.TabIndex = 21;
            this.buConsultarCliente.Text = "Consultar";
            this.buConsultarCliente.UseVisualStyleBackColor = true;
            this.buConsultarCliente.Click += new System.EventHandler(this.buConsultarCliente_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(116, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(151, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTelefono.Enabled = false;
            this.tbTelefono.Location = new System.Drawing.Point(331, 39);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(132, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDireccion.Enabled = false;
            this.tbDireccion.Location = new System.Drawing.Point(427, 13);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(252, 20);
            this.tbDireccion.TabIndex = 6;
            // 
            // tbCodCliente
            // 
            this.tbCodCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbCodCliente.Location = new System.Drawing.Point(116, 13);
            this.tbCodCliente.Name = "tbCodCliente";
            this.tbCodCliente.Size = new System.Drawing.Size(151, 20);
            this.tbCodCliente.TabIndex = 4;
            this.tbCodCliente.Leave += new System.EventHandler(this.tbCodCliente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro:";
            // 
            // fmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 622);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmFactura";
            this.Text = "fmFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
            this.gbInsercionPro.ResumeLayout(false);
            this.gbInsercionPro.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buGo;
        private System.Windows.Forms.DateTimePicker tbFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbIGV;
        private System.Windows.Forms.TextBox tbSubTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvDetalleVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubTotal;
        private System.Windows.Forms.GroupBox gbInsercionPro;
        private System.Windows.Forms.Button buConsultarProductos;
        private System.Windows.Forms.Button buAgregar;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPU;
        private System.Windows.Forms.TextBox tbUnidad;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbCodProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button buConsultarCliente;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCodCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbRuc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTipoProducto;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox tbNroDoc;
    }
}