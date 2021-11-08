using MySql.Data.MySqlClient;
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
    public partial class formAdministracion : Form
    {
        public formAdministracion()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form formularioGerencia = new formGerencia();

            formularioGerencia.Show();
            this.Hide();
        }

        private void formAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string sql = "DELETE FROM gerencia_administracion WHERE nombre='" + nombre + "'";

            MySqlConnection conexionBD = CRUD.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado eliminado exitosamente!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formAdministracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de variables
                double resultadoRenta, resultadoBonoVentas, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, salarioNeto, resultadoBonoHorasExtra;


                //Conversion de valores
                string nombre = TxtNombre.Text;
                string cargo = TxtNombre.Text;
                double salarioBase = Convert.ToDouble(TxtSalario.Text);
                int horasExtra = Convert.ToInt32(txtHorasExtra.Text);

                //Instanciando clase
                Calcular calcular = new Calcular();

                //Realizando los cálculos necesarios 
                calcular.SalarioBase = salarioBase;
                calcular.HorasExtra = horasExtra;
                resultadoRenta = calcular.Renta();
                resultadoPensionEmpleado = calcular.PensionEmpleado();
                resultadoPensionEmpleador = calcular.PensionEmpleador();
                resultadoSeguro = calcular.Seguro();
                resultadoBonoHorasExtra = calcular.BonoHorasExtra();
                salarioNeto = salarioBase + resultadoBonoHorasExtra - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro;

                //Creando comando para guardar la información del empleado
                string sql = "INSERT INTO gerencia_administracion (nombre, cargo, salarioBase, horasExtra, bonoHorasExtra, renta, seguroPensionesEmpleado, seguroPensionesEmpleador, seguroSocial, salarioNeto) VALUES ('" + nombre + "' , '" + cargo + "' , '" + salarioBase + "' , '" + horasExtra + "' , '" + resultadoBonoHorasExtra + "' , '" + resultadoRenta + "' , '" + resultadoPensionEmpleado + "' , '" + resultadoPensionEmpleador + "' , '" + resultadoSeguro + "' , '" + salarioNeto + "')";

                //Abriendo conexión de base de datos
                MySqlConnection conexionBD = CRUD.conexion();
                conexionBD.Open();

                try
                {
                    //Guardando información en la base de datos
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado exitosamente!");
                }
                catch (MySqlException ex)
                {
                    //Manejando excepciones
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
                finally
                {
                    //Cerrando conexión a base de datos
                    conexionBD.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
