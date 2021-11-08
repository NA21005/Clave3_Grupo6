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
    public partial class formVentas : Form
    {

        Calcular op = new Calcular();

        public formVentas()
        {
            InitializeComponent();
        }

       

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form formularioGerencia = new formGerencia();

            formularioGerencia.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
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
                double ventas = Convert.ToDouble(TxtVentas.Text);
                int horasExtra = Convert.ToInt32(txtHorasExtra.Text);

                //Instanciando clase
                Calcular calcular = new Calcular();

                //Realizando los cálculos necesarios 
                calcular.SalarioBase = salarioBase;
                calcular.Ventas = ventas;
                calcular.HorasExtra = horasExtra;
                resultadoBonoVentas = calcular.BonoVentas();
                resultadoRenta = calcular.Renta();
                resultadoPensionEmpleado = calcular.PensionEmpleado();
                resultadoPensionEmpleador = calcular.PensionEmpleador();
                resultadoSeguro = calcular.Seguro();
                resultadoBonoHorasExtra = calcular.BonoHorasExtra();
                salarioNeto = salarioBase + resultadoBonoVentas + resultadoBonoHorasExtra - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro;

                //Creando comando para guardar la información del empleado
                string sql = "INSERT INTO gerencia_ventas (nombre, cargo, salarioBase, ventas, bonoVentas, horasExtra, bonoHorasExtra, renta, seguroPensionesEmpleado, seguroPensionesEmpleador, seguroSocial, salarioNeto) VALUES ('" + nombre + "' , '" + cargo + "' , '" + salarioBase + "' , '" + ventas + "' , '" + resultadoBonoVentas + "' , '" + horasExtra + "' , '" + resultadoBonoHorasExtra + "' , '" + resultadoRenta + "' , '" + resultadoPensionEmpleado + "' , '" + resultadoPensionEmpleador + "' , '" + resultadoSeguro + "' , '" + salarioNeto + "')";

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

            //Agregar elementos dentro del dgv
            //DgvPlanilla.Rows.Add(id, nombre, cargo, salarioBase, ventas, resultadoBono, resultadoRenta, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total);
        }

        private void formVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de variables
                double resultadoRenta, resultadoBonoVentas, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, salarioNeto, resultadoBonoHorasExtra, ventas, salarioBase;
                string sql = "", nombre, cargo;
                int horasExtra, id;

                //Instanciando clase
                Calcular calcular = new Calcular();

                //Abriendo conexión de base de datos
                MySqlConnection conexionBD = CRUD.conexion();
                conexionBD.Open();

                id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el id del empleado: "));

                //Conversion de valores
                nombre = TxtNombre.Text;
                if (nombre != string.Empty)
                {
                    sql = "UPDATE gerencia_ventas SET nombre='" + nombre + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                cargo = TxtCargo.Text;
                if (cargo != string.Empty)
                {
                    sql = "UPDATE gerencia_ventas SET cargo='" + cargo + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                if (TxtSalario.Text != string.Empty)
                {
                    salarioBase = Convert.ToDouble(TxtSalario.Text);

                    calcular.SalarioBase = salarioBase;
                    resultadoRenta = calcular.Renta();
                    resultadoPensionEmpleado = calcular.PensionEmpleado();
                    resultadoPensionEmpleador = calcular.PensionEmpleador();
                    resultadoSeguro = calcular.Seguro();


                    sql = "UPDATE gerencia_ventas SET salarioBase='" + salarioBase + "' , renta='" + resultadoRenta + "', seguroPensionesEmpleado='" + resultadoPensionEmpleado + "', seguroPensionesEmpleador='" + resultadoPensionEmpleador + "', seguroSocial='" + resultadoSeguro + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                if (TxtVentas.Text != string.Empty)
                {
                    ventas = Convert.ToDouble(TxtVentas.Text);

                    calcular.Ventas = ventas;
                    resultadoBonoVentas = calcular.BonoVentas();

                    sql = "UPDATE gerencia_ventas SET ventas='" + ventas + "', bonoVentas='" + resultadoBonoVentas + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                if (txtHorasExtra.Text != string.Empty)
                {
                    horasExtra = Convert.ToInt32(txtHorasExtra.Text);
                    sql = "SELECT salarioBase FROM gerencia_ventas WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    MySqlDataReader reader = null;
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    reader = comando.ExecuteReader();

                    MessageBox.Show(Convert.ToString(reader));
                    //MessageBox.Show(Convert.ToString(reader.GetString(0)));

                    //calcular.SalarioBase = Convert.ToDouble(reader.GetString(0));
                    calcular.HorasExtra = horasExtra;
                    resultadoBonoHorasExtra = calcular.BonoHorasExtra();

                    sql = "UPDATE gerencia_ventas SET horasExtra='" + horasExtra + "',bonoHorasExtra='" + resultadoBonoHorasExtra + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Datos actualizados exitosamente!");
                //Realizando los cálculos necesarios 
                //salarioNeto = salarioBase + resultadoBonoVentas + resultadoBonoHorasExtra - resultadoBonoVentas - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro;

                //Cerrando conexión a base de datos
                conexionBD.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string sql = "DELETE FROM gerencia_ventas WHERE nombre='" + nombre + "'";

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
    }
}
