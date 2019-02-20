namespace LibFormularios
{
    partial class FrmUsuario
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
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Size = new System.Drawing.Size(558, 47);
            this.label1.Text = "LISTA DE USUARIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.BtnDeshabilitar);
            this.panel2.ForeColor = System.Drawing.Color.Olive;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Size = new System.Drawing.Size(558, 57);
            this.panel2.Controls.SetChildIndex(this.BtnSalir, 0);
            this.panel2.Controls.SetChildIndex(this.BtnGuardar, 0);
            this.panel2.Controls.SetChildIndex(this.BtnEliminar, 0);
            this.panel2.Controls.SetChildIndex(this.BtnNuevo, 0);
            this.panel2.Controls.SetChildIndex(this.BtnImprimir, 0);
            this.panel2.Controls.SetChildIndex(this.BtnDeshabilitar, 0);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(166, 14);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(166, 14);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(166, 14);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvUsuarios);
            this.panel3.Size = new System.Drawing.Size(558, 167);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            this.panel3.Controls.SetChildIndex(this.DgvUsuarios, 0);
            // 
            // PtbImagen
            // 
            this.PtbImagen.Location = new System.Drawing.Point(4, 319);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(4, 3);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.Size = new System.Drawing.Size(550, 158);
            this.DgvUsuarios.TabIndex = 44;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.BackColor = System.Drawing.Color.White;
            this.BtnDeshabilitar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnDeshabilitar.ForeColor = System.Drawing.Color.Olive;
            this.BtnDeshabilitar.Location = new System.Drawing.Point(395, 14);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(151, 31);
            this.BtnDeshabilitar.TabIndex = 9;
            this.BtnDeshabilitar.Text = "DESHABILITAR";
            this.BtnDeshabilitar.UseVisualStyleBackColor = false;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 271);
            this.Name = "FrmUsuario";
            this.Text = "Lista de Usuarios";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnDeshabilitar;
    }
}