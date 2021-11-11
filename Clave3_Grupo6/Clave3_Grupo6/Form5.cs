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
    public partial class formTransporte : Form
    {
        public formTransporte()
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

        private void formTransporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de variables
                double resultadoRenta, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, salarioNeto, resultadoBonoHorasExtra;


                //Conversion de valores
                string nombre = TxtNombre.Text;
                string cargo = TxtCargo.Text;
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
                string sql = "INSERT INTO gerencia_transporte (`Nombre`, `Cargo`, `Salario base`, `Horas extra`, `Bono horas extra`, `Renta`, `Seguro de pensiones (Empleado)`, `Seguro de pensiones (Empleador)`, `Seguro social`, `Salario neto`) VALUES ('" + nombre + "' , '" + cargo + "' , '" + salarioBase + "' , '" + horasExtra + "' , '" + resultadoBonoHorasExtra + "' , '" + resultadoRenta + "' , '" + resultadoPensionEmpleado + "' , '" + resultadoPensionEmpleador + "' , '" + resultadoSeguro + "' , '" + salarioNeto + "')";

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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturando id del empleado
                int id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el id del empleado: "));

                string sql = "DELETE FROM gerencia_transporte WHERE id='" + id + "'";

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
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaracion de variables
                double resultadoRenta, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, salarioNeto, resultadoBonoHorasExtra, salarioBase, bonoHorasExtra, renta, pensionEmpleado, seguro;
                string sql = "", nombre, cargo;
                int horasExtra, id;


                //Instanciando clase
                Calcular calcular = new Calcular();

                //Abriendo conexión de base de datos
                MySqlConnection conexionBD = CRUD.conexion();
                conexionBD.Open();

                //Capturando id del empleado
                id = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el id del empleado: "));

                //Recuperando campos de la base de datos
                sql = "SELECT `Salario base`, `Renta`, `Seguro de pensiones (Empleado)`, `Seguro social`, `Horas extra`, `Bono horas extra` FROM gerencia_transporte WHERE `Id`='" + id + "'";
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = null;
                reader = comando.ExecuteReader();
                reader.Read();
                salarioBase = Convert.ToDouble(reader.GetString(0));
                renta = Convert.ToDouble(reader.GetString(1));
                pensionEmpleado = Convert.ToDouble(reader.GetString(2));
                seguro = Convert.ToDouble(reader.GetString(3));
                horasExtra = Convert.ToInt32(reader.GetString(4));
                bonoHorasExtra = Convert.ToDouble(reader.GetString(5));
                conexionBD.Close();
                conexionBD.Open();

                nombre = TxtNombre.Text;
                if (nombre != string.Empty)
                {
                    sql = "UPDATE gerencia_transporte SET `Nombre`='" + nombre + "' WHERE `Id`='" + id + "'";

                    //Guardando información en la base de datos
                    comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                cargo = TxtCargo.Text;
                if (cargo != string.Empty)
                {
                    sql = "UPDATE gerencia_transporte SET `Cargo`='" + cargo + "' WHERE `Id`='" + id + "'";

                    //Guardando información en la base de datos
                    comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                if (TxtSalario.Text != string.Empty)
                {
                    salarioBase = Convert.ToDouble(TxtSalario.Text);

                    //Realizando cálculos actualizados
                    calcular.SalarioBase = salarioBase;
                    calcular.HorasExtra = horasExtra;

                    resultadoRenta = calcular.Renta();
                    resultadoPensionEmpleado = calcular.PensionEmpleado();
                    resultadoPensionEmpleador = calcular.PensionEmpleador();
                    resultadoSeguro = calcular.Seguro();
                    resultadoBonoHorasExtra = calcular.BonoHorasExtra();
                    salarioNeto = salarioBase + resultadoBonoHorasExtra - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro;

                    sql = "UPDATE gerencia_transporte SET `Salario base`='" + salarioBase + "', `Bono horas extra`='" + resultadoBonoHorasExtra + "' , `Renta`='" + resultadoRenta + "', `Seguro de pensiones (Empleado)`='" + resultadoPensionEmpleado + "', `Seguro de pensiones (Empleador)`='" + resultadoPensionEmpleador + "', `Seguro social`='" + resultadoSeguro + "', `Salario neto`='" + salarioNeto + "' WHERE `Id`='" + id + "'";

                    //Guardando información en la base de datos
                    comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                if (txtHorasExtra.Text != string.Empty)
                {
                    horasExtra = Convert.ToInt32(txtHorasExtra.Text);

                    //Realizando cálculos actualizados
                    calcular.HorasExtra = horasExtra;
                    calcular.SalarioBase = salarioBase;
                    resultadoBonoHorasExtra = calcular.BonoHorasExtra();
                    salarioNeto = salarioBase + resultadoBonoHorasExtra - renta - pensionEmpleado - seguro;

                    sql = "UPDATE gerencia_transporte SET `Horas extra`='" + horasExtra + "', `Bono horas extra`='" + resultadoBonoHorasExtra + "', `Salario neto`='" + salarioNeto + "' WHERE id='" + id + "'";

                    //Guardando información en la base de datos
                    comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }

                MessageBox.Show("Datos actualizados exitosamente!");

                //Cerrando conexión a base de datos
                conexionBD.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexionBD = CRUD.conexion();
                conexionBD.Open();

                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conexionBD;
                codigo.CommandText = ("SELECT * FROM gerencia_transporte");
                //string sql = "SELECT * FROM gerencia_ventas";
                MySqlDataAdapter seleccionar = new MySqlDataAdapter();
                seleccionar.SelectCommand = codigo;
                DataTable consulta = new DataTable();
                seleccionar.Fill(consulta);
                BindingSource formulario = new BindingSource();
                formulario.DataSource = consulta;
                DgvPlanilla.DataSource = formulario;
                seleccionar.Update(consulta);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
