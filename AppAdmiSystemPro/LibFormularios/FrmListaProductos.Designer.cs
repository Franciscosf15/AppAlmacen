namespace LibFormularios
{
    partial class FrmListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaProductos));
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Text = "LISTADO DE PRODUCTOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.ForeColor = System.Drawing.Color.DarkGreen;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.DgvProductos);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            this.panel3.Controls.SetChildIndex(this.DgvProductos, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(12, 14);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.Size = new System.Drawing.Size(612, 340);
            this.DgvProductos.TabIndex = 43;
            this.DgvProductos.DoubleClick += new System.EventHandler(this.DgvProductos_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para seleccionar un producto haga doble click sobre él :";
            // 
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 474);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaProductos";
            this.Text = "Lista de Productos";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label label2;
    }
}