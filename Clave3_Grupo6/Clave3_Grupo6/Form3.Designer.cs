﻿namespace Clave3_Grupo6
{
    partial class formVentas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtVentas = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.DgvPlanilla = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ventas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguroPensionesEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguroPensionesEmpleador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguroSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 61);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(274, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gerencia de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(356, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 45);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(320, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 45);
            this.label1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(338, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ventas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(338, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salario:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(120, 98);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(151, 23);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtCargo
            // 
            this.TxtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargo.Location = new System.Drawing.Point(120, 146);
            this.TxtCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(151, 23);
            this.TxtCargo.TabIndex = 6;
            // 
            // TxtVentas
            // 
            this.TxtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVentas.Location = new System.Drawing.Point(420, 146);
            this.TxtVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtVentas.Name = "TxtVentas";
            this.TxtVentas.Size = new System.Drawing.Size(151, 23);
            this.TxtVentas.TabIndex = 8;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalario.Location = new System.Drawing.Point(420, 98);
            this.TxtSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(151, 23);
            this.TxtSalario.TabIndex = 7;
            // 
            // DgvPlanilla
            // 
            this.DgvPlanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlanilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Cargo,
            this.SalarioBase,
            this.Ventas,
            this.BonoVenta,
            this.Renta,
            this.SeguroPensionesEmpleado,
            this.SeguroPensionesEmpleador,
            this.SeguroSocial,
            this.SalarioNeto});
            this.DgvPlanilla.Location = new System.Drawing.Point(34, 191);
            this.DgvPlanilla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvPlanilla.Name = "DgvPlanilla";
            this.DgvPlanilla.RowTemplate.Height = 24;
            this.DgvPlanilla.Size = new System.Drawing.Size(630, 249);
            this.DgvPlanilla.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "Salario Base";
            this.SalarioBase.Name = "SalarioBase";
            // 
            // Ventas
            // 
            this.Ventas.HeaderText = "Ventas";
            this.Ventas.Name = "Ventas";
            // 
            // BonoVenta
            // 
            this.BonoVenta.HeaderText = "Bono por venta";
            this.BonoVenta.Name = "BonoVenta";
            // 
            // Renta
            // 
            this.Renta.HeaderText = "Renta";
            this.Renta.Name = "Renta";
            // 
            // SeguroPensionesEmpleado
            // 
            this.SeguroPensionesEmpleado.HeaderText = "Seguro de pensiones (empleado)";
            this.SeguroPensionesEmpleado.Name = "SeguroPensionesEmpleado";
            // 
            // SeguroPensionesEmpleador
            // 
            this.SeguroPensionesEmpleador.HeaderText = "Seguro de pensiones (empleador)";
            this.SeguroPensionesEmpleador.Name = "SeguroPensionesEmpleador";
            // 
            // SeguroSocial
            // 
            this.SeguroSocial.HeaderText = "Seguro social";
            this.SeguroSocial.Name = "SeguroSocial";
            // 
            // SalarioNeto
            // 
            this.SalarioNeto.HeaderText = "Salario neto";
            this.SalarioNeto.Name = "SalarioNeto";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnRegresar.Location = new System.Drawing.Point(698, 366);
            this.BtnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(112, 23);
            this.BtnRegresar.TabIndex = 14;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnAgregar.Location = new System.Drawing.Point(698, 122);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(112, 23);
            this.BtnAgregar.TabIndex = 13;
            this.BtnAgregar.Text = "Agregar empleado";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnLimpiar.Location = new System.Drawing.Point(698, 317);
            this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar campos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnMostrar.Location = new System.Drawing.Point(698, 171);
            this.BtnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(112, 23);
            this.BtnMostrar.TabIndex = 11;
            this.BtnMostrar.Text = "Mostrar planillas";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnEliminar.Location = new System.Drawing.Point(698, 268);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 23);
            this.BtnEliminar.TabIndex = 10;
            this.BtnEliminar.Text = "Eliminar empleado";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnActualizar.Location = new System.Drawing.Point(698, 219);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(112, 23);
            this.BtnActualizar.TabIndex = 9;
            this.BtnActualizar.Text = "Actualizar datos";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::Clave3_Grupo6.Properties.Resources.btn;
            this.BtnSalir.Location = new System.Drawing.Point(698, 414);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(112, 23);
            this.BtnSalir.TabIndex = 33;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(75)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(842, 466);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.DgvPlanilla);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtVentas);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.TxtCargo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerencia de ventas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtVentas;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.DataGridView DgvPlanilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeguroPensionesEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeguroPensionesEmpleador;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeguroSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioNeto;
        private System.Windows.Forms.Button BtnSalir;
    }
}