namespace AppAlmacen
{
    partial class fmProducto
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
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.cbCodTipoPro = new System.Windows.Forms.ComboBox();
            this.tbCodTipPro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProduc = new System.Windows.Forms.DataGridView();
            this.tbProd = new System.Windows.Forms.TextBox();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbUnidMed = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPU = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 48);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buGuardar);
            this.panel2.Controls.Add(this.buNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 72);
            this.panel2.TabIndex = 4;
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
            this.buNuevo.Click += new System.EventHandler(this.buNuevo_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbPU);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbUnidadMedida);
            this.panel3.Controls.Add(this.cbCodTipoPro);
            this.panel3.Controls.Add(this.tbCodTipPro);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dgvProduc);
            this.panel3.Controls.Add(this.tbProd);
            this.panel3.Controls.Add(this.tbMarca);
            this.panel3.Controls.Add(this.tbUnidMed);
            this.panel3.Controls.Add(this.tbStock);
            this.panel3.Controls.Add(this.tbCod);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(632, 405);
            this.panel3.TabIndex = 5;
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(311, 89);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(121, 21);
            this.cbUnidadMedida.TabIndex = 16;
            // 
            // cbCodTipoPro
            // 
            this.cbCodTipoPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodTipoPro.FormattingEnabled = true;
            this.cbCodTipoPro.Location = new System.Drawing.Point(311, 147);
            this.cbCodTipoPro.Name = "cbCodTipoPro";
            this.cbCodTipoPro.Size = new System.Drawing.Size(121, 21);
            this.cbCodTipoPro.TabIndex = 15;
            this.cbCodTipoPro.DropDown += new System.EventHandler(this.cbCodTipoPro_DropDown);
            // 
            // tbCodTipPro
            // 
            this.tbCodTipPro.Enabled = false;
            this.tbCodTipPro.Location = new System.Drawing.Point(150, 147);
            this.tbCodTipPro.Name = "tbCodTipPro";
            this.tbCodTipPro.Size = new System.Drawing.Size(155, 20);
            this.tbCodTipPro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cod tipo producto : ";
            // 
            // dgvProduc
            // 
            this.dgvProduc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduc.Location = new System.Drawing.Point(41, 203);
            this.dgvProduc.Name = "dgvProduc";
            this.dgvProduc.Size = new System.Drawing.Size(561, 196);
            this.dgvProduc.TabIndex = 12;
            // 
            // tbProd
            // 
            this.tbProd.Location = new System.Drawing.Point(150, 37);
            this.tbProd.Name = "tbProd";
            this.tbProd.Size = new System.Drawing.Size(282, 20);
            this.tbProd.TabIndex = 11;
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(150, 63);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(282, 20);
            this.tbMarca.TabIndex = 10;
            // 
            // tbUnidMed
            // 
            this.tbUnidMed.Enabled = false;
            this.tbUnidMed.Location = new System.Drawing.Point(150, 89);
            this.tbUnidMed.Name = "tbUnidMed";
            this.tbUnidMed.Size = new System.Drawing.Size(155, 20);
            this.tbUnidMed.TabIndex = 9;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(150, 118);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(155, 20);
            this.tbStock.TabIndex = 8;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(150, 11);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(282, 20);
            this.tbCod.TabIndex = 6;
            this.tbCod.Leave += new System.EventHandler(this.tbCod_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código Producto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidad Medida: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "PU : ";
            // 
            // tbPU
            // 
            this.tbPU.Location = new System.Drawing.Point(348, 118);
            this.tbPU.Name = "tbPU";
            this.tbPU.Size = new System.Drawing.Size(84, 20);
            this.tbPU.TabIndex = 18;
            // 
            // fmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 525);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmProducto";
            this.Text = "fmProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbCodTipPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvProduc;
        private System.Windows.Forms.TextBox tbProd;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbUnidMed;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCodTipoPro;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.TextBox tbPU;
        private System.Windows.Forms.Label label8;
    }
}