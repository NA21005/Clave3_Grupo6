namespace Clave3_Grupo6
{
    partial class formGerencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnAdministracion = new System.Windows.Forms.Button();
            this.BtnTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la gerencia";
            // 
            // BtnVentas
            // 
            this.BtnVentas.BackColor = System.Drawing.Color.White;
            this.BtnVentas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.Black;
            this.BtnVentas.Location = new System.Drawing.Point(113, 135);
            this.BtnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(159, 34);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = false;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnAdministracion
            // 
            this.BtnAdministracion.BackColor = System.Drawing.Color.White;
            this.BtnAdministracion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministracion.ForeColor = System.Drawing.Color.Black;
            this.BtnAdministracion.Location = new System.Drawing.Point(113, 68);
            this.BtnAdministracion.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdministracion.Name = "BtnAdministracion";
            this.BtnAdministracion.Size = new System.Drawing.Size(159, 34);
            this.BtnAdministracion.TabIndex = 3;
            this.BtnAdministracion.Text = "Administracion";
            this.BtnAdministracion.UseVisualStyleBackColor = false;
            this.BtnAdministracion.Click += new System.EventHandler(this.BtnAdministracion_Click);
            // 
            // BtnTransporte
            // 
            this.BtnTransporte.BackColor = System.Drawing.Color.White;
            this.BtnTransporte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransporte.ForeColor = System.Drawing.Color.Black;
            this.BtnTransporte.Location = new System.Drawing.Point(113, 203);
            this.BtnTransporte.Margin = new System.Windows.Forms.Padding(4);
            this.BtnTransporte.Name = "BtnTransporte";
            this.BtnTransporte.Size = new System.Drawing.Size(159, 34);
            this.BtnTransporte.TabIndex = 4;
            this.BtnTransporte.Text = "Transporte";
            this.BtnTransporte.UseVisualStyleBackColor = false;
            this.BtnTransporte.Click += new System.EventHandler(this.BtnTransporte_Click);
            // 
            // formGerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(379, 278);
            this.Controls.Add(this.BtnTransporte);
            this.Controls.Add(this.BtnAdministracion);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formGerencia";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnAdministracion;
        private System.Windows.Forms.Button BtnTransporte;
    }
}