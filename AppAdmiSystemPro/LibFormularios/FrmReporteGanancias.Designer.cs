namespace LibFormularios
{
    partial class FrmReporteGanancias
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
            this.DgvGanancias = new System.Windows.Forms.DataGridView();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGanancias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Size = new System.Drawing.Size(317, 47);
            this.label1.Text = "REPORTE DE GANANCIAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Size = new System.Drawing.Size(317, 57);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblTotal);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.DtpFecha);
            this.panel3.Controls.Add(this.DgvGanancias);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Size = new System.Drawing.Size(317, 370);
            this.panel3.Controls.SetChildIndex(this.PtbImagen, 0);
            this.panel3.Controls.SetChildIndex(this.DgvGanancias, 0);
            this.panel3.Controls.SetChildIndex(this.DtpFecha, 0);
            this.panel3.Controls.SetChildIndex(this.label14, 0);
            this.panel3.Controls.SetChildIndex(this.label18, 0);
            this.panel3.Controls.SetChildIndex(this.LblTotal, 0);
            // 
            // PtbImagen
            // 
            this.PtbImagen.Location = new System.Drawing.Point(48, 44);
            // 
            // DgvGanancias
            // 
            this.DgvGanancias.AllowUserToAddRows = false;
            this.DgvGanancias.AllowUserToDeleteRows = false;
            this.DgvGanancias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DgvGanancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGanancias.Location = new System.Drawing.Point(4, 39);
            this.DgvGanancias.Name = "DgvGanancias";
            this.DgvGanancias.ReadOnly = true;
            this.DgvGanancias.Size = new System.Drawing.Size(308, 277);
            this.DgvGanancias.TabIndex = 45;
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.CalendarForeColor = System.Drawing.Color.MidnightBlue;
            this.DtpFecha.CalendarTitleForeColor = System.Drawing.Color.MidnightBlue;
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(77, 7);
            this.DtpFecha.MinDate = new System.DateTime(1899, 11, 17, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(224, 26);
            this.DtpFecha.TabIndex = 83;
            this.DtpFecha.Value = new System.DateTime(2018, 10, 20, 0, 0, 0, 0);
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(12, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 18);
            this.label14.TabIndex = 84;
            this.label14.Text = "Fecha:";
            // 
            // LblTotal
            // 
            this.LblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblTotal.Location = new System.Drawing.Point(147, 330);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(84, 24);
            this.LblTotal.TabIndex = 90;
            this.LblTotal.Text = "0";
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(90, 336);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 89;
            this.label18.Text = "TOTAL:";
            // 
            // FrmReporteGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 474);
            this.Name = "FrmReporteGanancias";
            this.Text = "Reporte Ganancias";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGanancias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvGanancias;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label18;
    }
}