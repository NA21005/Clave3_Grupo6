using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo6
{
    class Calcular : Estructura
    {
        //Propiedades
        private const double renta = 0.10;
        private const double pensionEmpleado = 0.0725;
        private const double pensionEmpleador = 0.0775;
        private const double seguro = 0.03;
        private double bonoVentas;

        /// <summary>
        /// Este método se encarga de calcular el bono en base a la cantidad de ventas de cada empleado
        /// </summary>
        /// <returns></returns>
        public double BonoVentas()
        {
            double bono = 0;
            if (Ventas >= 700)
            {
                bono = SalarioBase * 0.20;
            }
            else if (Ventas >= 600)
            {
                bono = SalarioBase * 0.15;
            }
            else if (Ventas >= 500)
            {
                bono = SalarioBase * 0.10;
            }
            else if (Ventas >= 400)
            {
                bono = SalarioBase * 0.05;
            }
            else
            {
                bono = 0;
            }

            bonoVentas = bono;

            return bono;
        }

        /// <summary>
        /// Método encargado de calcular la renta que deberá pagar el empleado
        /// </summary>
        /// <returns></returns>
        public double Renta ()
        {
            double descuentoRenta = renta * salarioBase;
            return descuentoRenta;
        }

        /// <summary>
        /// Se encarga de establecer la cantidad de pensión a cancelar
        /// </summary>
        /// <returns></returns>
        public double PensionEmpleado ()
        {
            double descuentoPensionEmpleado = pensionEmpleado * salarioBase;
            return descuentoPensionEmpleado;
        }

        /// <summary>
        /// Método que se encarga de calcular la pensión por parte del empleador
        /// </summary>
        /// <returns></returns>
        public double PensionEmpleador()
        {
            double descuentoPensionEmpleador = pensionEmpleador * salarioBase;
            return descuentoPensionEmpleador;
        }

        /// <summary>
        /// Este método calcula el seguro a cancelar
        /// </summary>
        /// <returns></returns>
        public double Seguro ()
        {
            double descuentoSeguro = seguro * salarioBase;
            return descuentoSeguro;
        }

        /// <summary>
        /// Se encarga de calcular el bono a pagar por la horas extras trabajadas
        /// </summary>
        /// <returns></returns>
        public double BonoHorasExtra ()
        {
            double bonoHorasExtra;

            bonoHorasExtra = ((salarioBase / 22) / 8) * horasExtra * 2;

            return bonoHorasExtra;
        }
    }
    }


