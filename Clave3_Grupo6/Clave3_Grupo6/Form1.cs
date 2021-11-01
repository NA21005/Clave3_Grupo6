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
    public partial class formIniciarSesion : Form
    {
        public formIniciarSesion()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtUsuario, "Ingrese su nombre de usuario");
            this.ttMensaje.SetToolTip(this.txtContraseña, "Ingrese su contraseña");
        }

        public void btnInicioSesion_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            Form Formulario1 = new formIniciarSesion();
            Form Formulario2 = new formGerencia();
            string Cuenta, Contra;

            Cuenta = Convert.ToString(txtUsuario.Text);
            Contra = Convert.ToString(txtContraseña.Text);

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
                    MessageBox.Show("La contraseña ingresada es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario ingresado no es válido");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
