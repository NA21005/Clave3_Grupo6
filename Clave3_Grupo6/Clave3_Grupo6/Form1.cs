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
        /// <summary>
        /// Autores:
        ///     - Emerson Alexander Cueva Carbajal (CC21045)
        ///     - Cristian Armando Navarro Aguilar (NA21005)
        /// Fecha: 12/11/2021
        /// </summary>
        public formIniciarSesion()
        {
            InitializeComponent();
            this.TtMensaje.SetToolTip(this.TxtUsuario, "Ingrese su nombre de usuario");
            this.TtMensaje.SetToolTip(this.TxtContraseña, "Ingrese su contraseña");
        }

        private void BtnInicioSesion_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            Form formularioGerencia = new formGerencia();
            string cuenta, contra;

            cuenta = Convert.ToString(TxtUsuario.Text);
            contra = Convert.ToString(TxtContraseña.Text);

            // Validar si el usuario y contraseña son Correctos
            if (cuenta == "prn115")
            {
                if (contra == "prn115")
                {
                    formularioGerencia.Show();
                    this.Hide();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
