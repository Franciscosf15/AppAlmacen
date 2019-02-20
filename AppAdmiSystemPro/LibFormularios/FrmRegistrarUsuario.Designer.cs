namespace LibFormularios
{
    partial class FrmRegistrarUsuario
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
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtVerificarContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIdUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Text = "REGISTRO DE USUARIOS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnImprimir.Location = new System.Drawing.Point(282, 14);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.ForeColor = System.Drawing.Color.Maroon;
            this.BtnNuevo.Location = new System.Drawing.Point(128, 14);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.ForeColor = System.Drawing.Color.Maroon;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ForeColor = System.Drawing.Color.Maroon;
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCheck);
            this.panel3.Controls.Add(this.TxtNombres);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TxtContraseña);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtVerificarContraseña);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.TxtIdUsuario);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Size = new System.Drawing.Size(636, 318);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.TxtIdUsuario, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.TxtVerificarContraseña, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            this.panel3.Controls.SetChildIndex(this.TxtContraseña, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.TxtNombres, 0);
            this.panel3.Controls.SetChildIndex(this.lblCheck, 0);
            // 
            // PtbImagen
            // 
            this.PtbImagen.Image = global::LibFormularios.Properties.Resources.Logo_parado;
            this.PtbImagen.Location = new System.Drawing.Point(412, 3);
            this.PtbImagen.Size = new System.Drawing.Size(221, 309);
            this.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.Maroon;
            this.TxtContraseña.Location = new System.Drawing.Point(16, 198);
            this.TxtContraseña.MaxLength = 50;
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(260, 22);
            this.TxtContraseña.TabIndex = 37;
            this.TxtContraseña.UseSystemPasswordChar = true;
            this.TxtContraseña.TextChanged += new System.EventHandler(this.TxtContraseña_TextChanged);
            this.TxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContraseña_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Crea una contraseña (min. 8 dígitos y un número) :";
            // 
            // TxtVerificarContraseña
            // 
            this.TxtVerificarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVerificarContraseña.ForeColor = System.Drawing.Color.Maroon;
            this.TxtVerificarContraseña.Location = new System.Drawing.Point(16, 273);
            this.TxtVerificarContraseña.MaxLength = 20;
            this.TxtVerificarContraseña.Name = "TxtVerificarContraseña";
            this.TxtVerificarContraseña.Size = new System.Drawing.Size(260, 22);
            this.TxtVerificarContraseña.TabIndex = 38;
            this.TxtVerificarContraseña.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vuelve a ingresar la contraseña :";
            // 
            // TxtIdUsuario
            // 
            this.TxtIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.TxtIdUsuario.Location = new System.Drawing.Point(16, 46);
            this.TxtIdUsuario.MaxLength = 10;
            this.TxtIdUsuario.Name = "TxtIdUsuario";
            this.TxtIdUsuario.Size = new System.Drawing.Size(260, 22);
            this.TxtIdUsuario.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Crea una cuenta de usuario :";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNombres.Location = new System.Drawing.Point(16, 122);
            this.TxtNombres.MaxLength = 10;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(260, 22);
            this.TxtNombres.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ingrese nombres y apellidos del usuario :";
            // 
            // lblCheck
            // 
            this.lblCheck.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheck.Location = new System.Drawing.Point(282, 196);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(131, 25);
            this.lblCheck.TabIndex = 41;
            this.lblCheck.Text = "X";
            this.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "Registro de Usuarios";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtVerificarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIdUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCheck;
    }
}