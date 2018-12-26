namespace AppAlmacen
{
    partial class fmTipoProducto
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
            this.dgvTipoProducto = new System.Windows.Forms.DataGridView();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 72);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE TIPO PRODUCTO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buGuardar);
            this.panel2.Controls.Add(this.buNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 72);
            this.panel2.TabIndex = 4;
            // 
            // buGuardar
            // 
            this.buGuardar.Location = new System.Drawing.Point(308, 24);
            this.buGuardar.Name = "buGuardar";
            this.buGuardar.Size = new System.Drawing.Size(75, 23);
            this.buGuardar.TabIndex = 1;
            this.buGuardar.Text = "Guardar";
            this.buGuardar.UseVisualStyleBackColor = true;
            this.buGuardar.Click += new System.EventHandler(this.buGuardar_Click);
            // 
            // buNuevo
            // 
            this.buNuevo.Location = new System.Drawing.Point(30, 24);
            this.buNuevo.Name = "buNuevo";
            this.buNuevo.Size = new System.Drawing.Size(75, 23);
            this.buNuevo.TabIndex = 0;
            this.buNuevo.Text = "Nuevo";
            this.buNuevo.UseVisualStyleBackColor = true;
            this.buNuevo.Click += new System.EventHandler(this.buNuevo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvTipoProducto);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.tbCod);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 306);
            this.panel3.TabIndex = 5;
            // 
            // dgvTipoProducto
            // 
            this.dgvTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProducto.Location = new System.Drawing.Point(28, 80);
            this.dgvTipoProducto.Name = "dgvTipoProducto";
            this.dgvTipoProducto.Size = new System.Drawing.Size(372, 205);
            this.dgvTipoProducto.TabIndex = 12;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(175, 37);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(176, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(175, 11);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(176, 20);
            this.tbCod.TabIndex = 6;
            this.tbCod.Leave += new System.EventHandler(this.tbCod_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código Tipo Producto: ";
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
            // fmTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmTipoProducto";
            this.Text = "fmTipoProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buGuardar;
        private System.Windows.Forms.Button buNuevo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTipoProducto;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}