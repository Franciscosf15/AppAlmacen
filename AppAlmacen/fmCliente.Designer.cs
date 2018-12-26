namespace AppAlmacen
{
    partial class fmCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buGuardar = new System.Windows.Forms.Button();
            this.buNuevo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbRuc = new System.Windows.Forms.TextBox();
            this.tbCodClien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 72);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE CLIENTES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buGuardar);
            this.panel2.Controls.Add(this.buNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 72);
            this.panel2.TabIndex = 3;
            // 
            // buGuardar
            // 
            this.buGuardar.Location = new System.Drawing.Point(440, 24);
            this.buGuardar.Name = "buGuardar";
            this.buGuardar.Size = new System.Drawing.Size(75, 23);
            this.buGuardar.TabIndex = 1;
            this.buGuardar.Text = "Guardar";
            this.buGuardar.UseVisualStyleBackColor = true;
            this.buGuardar.Click += new System.EventHandler(this.buGuardar_Click);
            // 
            // buNuevo
            // 
            this.buNuevo.Location = new System.Drawing.Point(123, 24);
            this.buNuevo.Name = "buNuevo";
            this.buNuevo.Size = new System.Drawing.Size(75, 23);
            this.buNuevo.TabIndex = 0;
            this.buNuevo.Text = "Nuevo";
            this.buNuevo.UseVisualStyleBackColor = true;
            this.buNuevo.Click += new System.EventHandler(this.buNuevo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvClientes);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.tbDireccion);
            this.panel3.Controls.Add(this.tbTelefono);
            this.panel3.Controls.Add(this.tbRuc);
            this.panel3.Controls.Add(this.tbCodClien);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 343);
            this.panel3.TabIndex = 4;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(40, 155);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(561, 179);
            this.dgvClientes.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(139, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(282, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(139, 63);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(282, 20);
            this.tbDireccion.TabIndex = 10;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(139, 89);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(282, 20);
            this.tbTelefono.TabIndex = 9;
            // 
            // tbRuc
            // 
            this.tbRuc.Location = new System.Drawing.Point(139, 118);
            this.tbRuc.Name = "tbRuc";
            this.tbRuc.Size = new System.Drawing.Size(282, 20);
            this.tbRuc.TabIndex = 8;
            // 
            // tbCodClien
            // 
            this.tbCodClien.Location = new System.Drawing.Point(139, 11);
            this.tbCodClien.Name = "tbCodClien";
            this.tbCodClien.Size = new System.Drawing.Size(282, 20);
            this.tbCodClien.TabIndex = 6;
            this.tbCodClien.Leave += new System.EventHandler(this.tbCodClien_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Clientes Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC : ";
            // 
            // fmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmCliente";
            this.Text = "fmCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbRuc;
        private System.Windows.Forms.TextBox tbCodClien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}