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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Form Formulario4 = new formAdministracion();
            Form Formulario2 = new formGerencia();

            Formulario2.Close();
            Formulario4.Show();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {


            Form Formulario3 = new formVentas();
            Form Formulario2 = new formGerencia();

            Formulario2.Close();
            Formulario3.Show();
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {


            Form Formulario5 = new formTransporte();
            Form Formulario2 = new formGerencia();

            Formulario2.Close();
            Formulario5.Show();
        }
    }
}
