﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo6
{
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form formularioGerencia = new formGerencia();

            formularioGerencia.Show();
            this.Close();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
