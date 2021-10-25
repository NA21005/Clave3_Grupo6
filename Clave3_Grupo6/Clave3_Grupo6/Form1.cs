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
    public partial class iniciarSecion : Form
    {
        public iniciarSecion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inicioSesion_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            Form Formulario1 = new iniciarSecion();
            Form Formulario2 = new Seleccion();
            string Cuenta, Contra;

            Cuenta = Convert.ToString(Usuario.Text);
            Contra = Convert.ToString(Contraseña.Text);

            // Validar si el usuario y contraseña son Correctos
            if (Cuenta == "prn115")
            {
                if (Contra == "prn115")
                {
                    Formulario1.Close();
                    Formulario2.Show();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("La cuenta es incorrecta");
            }

        }
    }
}
