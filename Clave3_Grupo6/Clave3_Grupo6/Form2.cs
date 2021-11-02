using System;
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
    public partial class formGerencia : Form
    {
        public formGerencia()
        {
            InitializeComponent();        
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            Form formularioAdministracion = new formAdministracion();

            formularioAdministracion.Show();
            this.Hide();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            Form formularioVentas = new formVentas();

            formularioVentas.Show();
            this.Hide();
        }

        private void BtnTransporte_Click(object sender, EventArgs e)
        {
            Form formularioTransporte = new formTransporte();

            formularioTransporte.Show();
            this.Hide();

        }
    }
}
