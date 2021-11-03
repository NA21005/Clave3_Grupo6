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
        public formVentas()
        {
            InitializeComponent();
        }

        string prp;

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            const int limite = 1;
            const double renta = 0.10;
            double bono =0;
            int id =0 ;
            const double pensionEmpleado = 0.0725;
            const double pensionEmpleador = 0.0775;
            const double descuentoSeguro = 0.03;
            double resultadoRenta, resultadoBono, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total;


            //Conversion de valores
            string nombre = Convert.ToString(TxtNombre.Text);
            string cargo = Convert.ToString(TxtCargo.Text);
            double salarioBase = Convert.ToDouble(TxtSalario.Text);
            double ventas = Convert.ToDouble(TxtVentas.Text);

            for (int i = 0; i < limite; i++)
            {
                if (ventas > 25)
                {
                    if (ventas > 50)
                    {
                        if (ventas > 100)
                        {
                            bono = 0.20;
                        }
                    }
                    else
                    {
                        bono = 0.15;
                    }
                }
                else
                {
                    bono = 0.10;
                }
                id++;
            }
            //Calculos matematicos

            resultadoRenta = renta * salarioBase;

            resultadoPensionEmpleado = pensionEmpleado * salarioBase;

            resultadoPensionEmpleador = pensionEmpleador * salarioBase;

            resultadoSeguro = descuentoSeguro * salarioBase;

            resultadoBono = bono * ventas;

            total = salarioBase - resultadoRenta - resultadoPensionEmpleado - resultadoSeguro + resultadoBono;
           

            //Agregar elementos dentro del dgv
            DgvPlanilla.Rows.Add(id, nombre, cargo, salarioBase, ventas, resultadoBono, resultadoRenta, resultadoPensionEmpleado, resultadoPensionEmpleador, resultadoSeguro, total);
        }

    }
}
