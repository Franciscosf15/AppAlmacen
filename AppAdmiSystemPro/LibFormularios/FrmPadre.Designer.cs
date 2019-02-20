namespace LibFormularios
{
    partial class FrmPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadre));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PtbImagen = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "TITULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnImprimir);
            this.panel2.Controls.Add(this.BtnNuevo);
            this.panel2.Controls.Add(this.BtnEliminar);
            this.panel2.Controls.Add(this.BtnGuardar);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(636, 57);
            this.panel2.TabIndex = 2;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.White;
            this.BtnImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnImprimir.Location = new System.Drawing.Point(166, 14);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(110, 31);
            this.BtnImprimir.TabIndex = 7;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.White;
            this.BtnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnNuevo.Location = new System.Drawing.Point(282, 14);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(110, 31);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.White;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnEliminar.Location = new System.Drawing.Point(398, 14);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(110, 31);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.White;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnGuardar.Location = new System.Drawing.Point(514, 14);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(110, 31);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.BtnSalir.Location = new System.Drawing.Point(12, 14);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 31);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PtbImagen);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 370);
            this.panel3.TabIndex = 3;
            // 
            // PtbImagen
            // 
            this.PtbImagen.Location = new System.Drawing.Point(12, 14);
            this.PtbImagen.Name = "PtbImagen";
            this.PtbImagen.Size = new System.Drawing.Size(237, 164);
            this.PtbImagen.TabIndex = 8;
            this.PtbImagen.TabStop = false;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 474);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button BtnImprimir;
        protected System.Windows.Forms.Button BtnNuevo;
        protected System.Windows.Forms.Button BtnEliminar;
        protected System.Windows.Forms.Button BtnGuardar;
        protected System.Windows.Forms.Button BtnSalir;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.PictureBox PtbImagen;
    }
}