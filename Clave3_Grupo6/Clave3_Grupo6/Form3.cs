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
            //Declaracion de variables
            const double renta = 0.10;
            double bono =0;
            int id =0 ;
            const double pensionEmpleado = 0.0725;
            const double pensionEmpleador = 0.0775;
            const double descuentoSeguro = 0.03;
            double resultadoRenta,asignacionBono, resultadoBono, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total;


            //Conversion de valores
            string nombre = Convert.ToString(TxtNombre.Text);
            string cargo = Convert.ToString(TxtCargo.Text);
            double salarioBase = Convert.ToDouble(TxtSalario.Text);
            double ventas = Convert.ToDouble(TxtVentas.Text);

            //[-----asignar valores a los parametros-----]
            op.descuentodeRenta = renta;
            op.salarioNormal = salarioBase;
            op.descuentoPensionEmpleado = pensionEmpleado;
            op.descuentoPensionEmpleador = pensionEmpleador;
            op.descuentoSeguro = descuentoSeguro;
            op.sumaBono = bono;
            op.bonoDeterminado = bono;
            op.venta = ventas;

            //[-----Asignar una variable a los metodos-----]
            //Metodo para calcular el bono
            asignacionBono = op.determinarBono(op.bonoDeterminado, op.venta);

            //metodo para calcular la renta
            resultadoRenta = op.calculoRenta(op.descuentodeRenta,op.salarioNormal);

            //metodo para calcular el descuento de la pension a pagar del empleado 
            resultadoPensionEmpleado = op.calculoPensionEmpleado(op.descuentoPensionEmpleado, op.salarioNormal);

            //metodo para calcular el descuento de la pension a pagar del empleador
            resultadoPensionEmpleador = op.calculoPensionEmpleador(op.descuentoPensionEmpleador, op.salarioNormal);

            //metodo para calcular el descuento del seguro
            resultadoSeguro = op.calculoSeguro(op.descuentoSeguro, op.salarioNormal);

            //metodo para calcular el bono
            resultadoBono = op.calculoBono(asignacionBono, op.salarioNormal);

            total = op.salarioNormal - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro + resultadoBono;

            //Agregar elementos dentro del dgv
            //DgvPlanilla.Rows.Add(id, nombre, cargo, salarioBase, ventas, resultadoBono, resultadoRenta, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total);

            string sql = "INSERT INTO gerencia_ventas (nombre, cargo, salarioBase, ventas, bonoVentas, renta, seguroPensionesEmpleado, seguroPensionesEmpleador, seguroSocial, salarioNeto) VALUES ('" + nombre + "' , '" + cargo + "' , '" + salarioBase + "' , '" + ventas + "' , '" + asignacionBono + "' , '" + resultadoRenta + "' , '" + resultadoPensionEmpleado + "' , '" + resultadoPensionEmpleador + "' , '" + resultadoSeguro + "' , '" + total + "')";

            MySqlConnection conexionBD = CRUD.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Empleado agregado exitosamente!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
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
            //Declaracion de variables
            const double renta = 0.10;
            double bono = 0;
            int id = 0;
            const double pensionEmpleado = 0.0725;
            const double pensionEmpleador = 0.0775;
            const double descuentoSeguro = 0.03;
            double resultadoRenta, asignacionBono, resultadoBono, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total;

            //Conversion de valores
            string nombre = Convert.ToString(TxtNombre.Text);
            string cargo = Convert.ToString(TxtCargo.Text);
            double salarioBase = Convert.ToDouble(TxtSalario.Text);
            double ventas = Convert.ToDouble(TxtVentas.Text);

            //[-----asignar valores a los parametros-----]
            op.descuentodeRenta = renta;
            op.salarioNormal = salarioBase;
            op.descuentoPensionEmpleado = pensionEmpleado;
            op.descuentoPensionEmpleador = pensionEmpleador;
            op.descuentoSeguro = descuentoSeguro;
            op.sumaBono = bono;
            op.bonoDeterminado = bono;
            op.venta = ventas;

            //[-----Asignar una variable a los metodos-----]
            //Metodo para calcular el bono
            asignacionBono = op.determinarBono(op.bonoDeterminado, op.venta);

            //metodo para calcular la renta
            resultadoRenta = op.calculoRenta(op.descuentodeRenta, op.salarioNormal);

            //metodo para calcular el descuento de la pension a pagar del empleado 
            resultadoPensionEmpleado = op.calculoPensionEmpleado(op.descuentoPensionEmpleado, op.salarioNormal);

            //metodo para calcular el descuento de la pension a pagar del empleador
            resultadoPensionEmpleador = op.calculoPensionEmpleador(op.descuentoPensionEmpleador, op.salarioNormal);

            //metodo para calcular el descuento del seguro
            resultadoSeguro = op.calculoSeguro(op.descuentoSeguro, op.salarioNormal);

            //metodo para calcular el bono
            resultadoBono = op.calculoBono(asignacionBono, op.salarioNormal);

            total = op.salarioNormal - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro + resultadoBono;

            string sql = "UPDATE gerencia_ventas SET";
            if (nombre != string.Empty)
            {
                sql = sql + " nombre='" + nombre + "',";
            }

            if (cargo != string.Empty)
            {
                sql = sql + " cargo='" + cargo + "',";
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
