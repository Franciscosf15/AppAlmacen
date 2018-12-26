namespace AppAlmacen
{
    partial class fmConsultaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsultaFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTotaL = new System.Windows.Forms.TextBox();
            this.tbIGV = new System.Windows.Forms.TextBox();
            this.tbSuTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSon = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.tbNroDo = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 38);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Factura";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 35);
            this.panel2.TabIndex = 3;
            // 
            // buSalir
            // 
            this.buSalir.Location = new System.Drawing.Point(336, 6);
            this.buSalir.Name = "buSalir";
            this.buSalir.Size = new System.Drawing.Size(75, 23);
            this.buSalir.TabIndex = 1;
            this.buSalir.Text = "Salir";
            this.buSalir.UseVisualStyleBackColor = true;
            this.buSalir.Click += new System.EventHandler(this.buSalir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTipo);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.tbFecha);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tbTotaL);
            this.panel3.Controls.Add(this.tbIGV);
            this.panel3.Controls.Add(this.tbSuTotal);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbSon);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dgvDetalleVenta);
            this.panel3.Controls.Add(this.tbNroDo);
            this.panel3.Controls.Add(this.gbCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(726, 462);
            this.panel3.TabIndex = 4;
            // 
            // cbTipo
            // 
            this.cbTipo.Enabled = false;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cbTipo.Location = new System.Drawing.Point(476, 71);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 21);
            this.cbTipo.TabIndex = 22;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(410, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Tipo:";
            // 
            // tbFecha
            // 
            this.tbFecha.Enabled = false;
            this.tbFecha.Location = new System.Drawing.Point(476, 45);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(200, 20);
            this.tbFecha.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(537, 442);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total:";
            // 
            // tbTotaL
            // 
            this.tbTotaL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTotaL.Enabled = false;
            this.tbTotaL.Location = new System.Drawing.Point(599, 439);
            this.tbTotaL.Name = "tbTotaL";
            this.tbTotaL.Size = new System.Drawing.Size(101, 20);
            this.tbTotaL.TabIndex = 16;
            // 
            // tbIGV
            // 
            this.tbIGV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbIGV.Enabled = false;
            this.tbIGV.Location = new System.Drawing.Point(599, 413);
            this.tbIGV.Name = "tbIGV";
            this.tbIGV.Size = new System.Drawing.Size(101, 20);
            this.tbIGV.TabIndex = 15;
            // 
            // tbSuTotal
            // 
            this.tbSuTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSuTotal.Enabled = false;
            this.tbSuTotal.Location = new System.Drawing.Point(599, 387);
            this.tbSuTotal.Name = "tbSuTotal";
            this.tbSuTotal.Size = new System.Drawing.Size(101, 20);
            this.tbSuTotal.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(537, 416);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "IGV:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(537, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Sub Total:";
            // 
            // tbSon
            // 
            this.tbSon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbSon.Enabled = false;
            this.tbSon.Location = new System.Drawing.Point(61, 387);
            this.tbSon.Name = "tbSon";
            this.tbSon.Size = new System.Drawing.Size(442, 20);
            this.tbSon.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Son:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Detalle de Ventas:";
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleVenta.Enabled = false;
            this.dgvDetalleVenta.Location = new System.Drawing.Point(12, 217);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.Size = new System.Drawing.Size(711, 164);
            this.dgvDetalleVenta.TabIndex = 8;
            // 
            // tbNroDo
            // 
            this.tbNroDo.Enabled = false;
            this.tbNroDo.Location = new System.Drawing.Point(476, 19);
            this.tbNroDo.Name = "tbNroDo";
            this.tbNroDo.Size = new System.Drawing.Size(200, 20);
            this.tbNroDo.TabIndex = 5;
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
            this.gbCliente.Enabled = false;
            this.gbCliente.Location = new System.Drawing.Point(16, 117);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(701, 81);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // tbRuc
            // 
            this.tbRuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbNombre.Location = new System.Drawing.Point(116, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(151, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbTelefono.Location = new System.Drawing.Point(331, 39);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(132, 20);
            this.tbTelefono.TabIndex = 7;
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label3.Location = new System.Drawing.Point(410, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro:";
            // 
            // fmConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultaFactura";
            this.Text = "fmConsultaFactura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buConsultarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbNroDo;
        public System.Windows.Forms.ComboBox cbTipo;
        public System.Windows.Forms.DateTimePicker tbFecha;
        public System.Windows.Forms.DataGridView dgvDetalleVenta;
        public System.Windows.Forms.TextBox tbRuc;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbTelefono;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbCodCliente;
        public System.Windows.Forms.TextBox tbTotaL;
        public System.Windows.Forms.TextBox tbIGV;
        public System.Windows.Forms.TextBox tbSuTotal;
        public System.Windows.Forms.TextBox tbSon;
    }
}