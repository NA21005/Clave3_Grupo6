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

        //Obtencion de variables para realizar el calculo
        //public double bonodeterminado { get; set; }
        //public double venta { get; set; }
        //public double descuentoderenta { get; set; }
        //public double salarionormal { get; set; }
        //public double descuentopensionempleado { get; set; }
        //public double descuentopensionempleador { get; set; }
        //public double descuentoseguro { get; set; }
        //public double sumabono { get; set; }


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
            //if (ventas > 25)
            //{
            //    if (ventas > 50)
            //    {
            //        if (ventas > 100)
            //        {
            //            bono = 0.20;
            //        }
            //    }
            //    else
            //    {
            //        bono = 0.15;
            //    }
            //}
            //else
            //{
            //    bono = 0.10;
            //}
            //bonosdeterminados = bono;

            return bono;
        }

        public double Renta ()
        {
            double descuentoRenta = renta * salarioBase;
            return descuentoRenta;
        }

        public double PensionEmpleado ()

        {
            double descuentoPensionEmpleado = pensionEmpleado * salarioBase;
            return descuentoPensionEmpleado;
        }

        public double PensionEmpleador()

        {
            double descuentoPensionEmpleador = pensionEmpleador * salarioBase;
            return descuentoPensionEmpleador;
        }

        public double Seguro ()
        {
            double descuentoSeguro = seguro * salarioBase;
            return descuentoSeguro;
        }

        //public double Bono()
        //{
        //    double Bonificacion = bonoVentas * salarioBase;
        //    return Bonificacion;
        //}

        public double BonoHorasExtra ()
        {
            double bonoHorasExtra;

            bonoHorasExtra = ((salarioBase / 22) / 8) * horasExtra * 2;

            return bonoHorasExtra;
        }
    }
    }


