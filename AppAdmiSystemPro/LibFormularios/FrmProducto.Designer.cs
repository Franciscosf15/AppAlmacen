namespace LibFormularios
{
    partial class FrmProducto
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
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUnidad = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Size = new System.Drawing.Size(516, 47);
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Size = new System.Drawing.Size(516, 57);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(88, 14);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.Color.Teal;
            this.BtnNuevo.Location = new System.Drawing.Point(162, 14);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ForeColor = System.Drawing.Color.Teal;
            this.BtnEliminar.Location = new System.Drawing.Point(278, 14);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ForeColor = System.Drawing.Color.Teal;
            this.BtnGuardar.Location = new System.Drawing.Point(394, 14);
            this.BtnGuardar.TabIndex = 36;
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.Color.Teal;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TxtUnidad);
            this.panel3.Controls.Add(this.TxtStock);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TxtPrecio);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtDescripcion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtMarca);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtCodProducto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Size = new System.Drawing.Size(516, 181);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.TxtCodProducto, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.TxtMarca, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            this.panel3.Controls.SetChildIndex(this.TxtDescripcion, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.TxtPrecio, 0);
            this.panel3.Controls.SetChildIndex(this.label6, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.TxtStock, 0);
            this.panel3.Controls.SetChildIndex(this.TxtUnidad, 0);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            // 
            // PtbImagen
            // 
            this.PtbImagen.Image = global::LibFormularios.Properties.Resources.logo_2;
            this.PtbImagen.Location = new System.Drawing.Point(12, 9);
            this.PtbImagen.Size = new System.Drawing.Size(194, 164);
            this.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.ForeColor = System.Drawing.Color.Teal;
            this.TxtStock.Location = new System.Drawing.Point(319, 146);
            this.TxtStock.MaxLength = 4;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(185, 22);
            this.TxtStock.TabIndex = 35;
            this.TxtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(217, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Stock :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(217, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Unidad :";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.ForeColor = System.Drawing.Color.Teal;
            this.TxtPrecio.Location = new System.Drawing.Point(319, 118);
            this.TxtPrecio.MaxLength = 8;
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(185, 22);
            this.TxtPrecio.TabIndex = 34;
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(217, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio (S/.) :";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.ForeColor = System.Drawing.Color.Teal;
            this.TxtDescripcion.Location = new System.Drawing.Point(319, 34);
            this.TxtDescripcion.MaxLength = 50;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(185, 22);
            this.TxtDescripcion.TabIndex = 30;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(217, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Descripción :";
            // 
            // TxtMarca
            // 
            this.TxtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMarca.ForeColor = System.Drawing.Color.Teal;
            this.TxtMarca.Location = new System.Drawing.Point(319, 62);
            this.TxtMarca.MaxLength = 20;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(185, 22);
            this.TxtMarca.TabIndex = 31;
            this.TxtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(217, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Marca :";
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodProducto.ForeColor = System.Drawing.Color.Teal;
            this.TxtCodProducto.Location = new System.Drawing.Point(319, 6);
            this.TxtCodProducto.MaxLength = 10;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(185, 22);
            this.TxtCodProducto.TabIndex = 29;
            this.TxtCodProducto.Leave += new System.EventHandler(this.TxtCodProducto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(217, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código :";
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnidad.ForeColor = System.Drawing.Color.Teal;
            this.TxtUnidad.Location = new System.Drawing.Point(319, 90);
            this.TxtUnidad.MaxLength = 20;
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.Size = new System.Drawing.Size(185, 22);
            this.TxtUnidad.TabIndex = 32;
            this.TxtUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcion_KeyPress);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 285);
            this.Name = "FrmProducto";
            this.Text = "Registro de Productos";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUnidad;
    }
}