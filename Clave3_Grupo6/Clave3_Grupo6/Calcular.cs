using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo6
{
    class Calcular
    {
        //Obtencion de variables para realizar el calculo
        public double bonoDeterminado { get; set; }
        public double venta { get; set; }
        public double descuentodeRenta { get; set; }
        public double salarioNormal { get; set; }
        public double descuentoPensionEmpleado { get; set; }
        public double descuentoPensionEmpleador { get; set; }
        public double descuentoSeguro { get; set; }
        public double sumaBono { get; set; }
     
        
        public double determinarBono(double bono, double ventas)
        {
            double bonosDeterminados;
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
            bonosDeterminados = bono;

            return bonosDeterminados;
        }

        public double calculoRenta (double renta, double salarioBase)
        {
            double descuentoRenta = renta * salarioBase;
            return descuentoRenta;
        }

        public double calculoPensionEmpleado (double pensionEmpleado, double salarioBase)

        {
            double descuentoPensionEmpleado = pensionEmpleado * salarioBase;
            return descuentoPensionEmpleado;
        }

        public double calculoPensionEmpleador(double pensionEmpleador, double salarioBase)

        {
            double descuentoPensionEmpleador = pensionEmpleador * salarioBase;
            return descuentoPensionEmpleador;
        }

        public double calculoSeguro (double seguro, double salarioBase)
        {
            double descuentoSeguro = seguro * salarioBase;
            return descuentoSeguro;
        }

        public double calculoBono (double bono, double salarioBase)
        {
            double Bonificacion = bono * salarioBase;
            return Bonificacion;
        }

    }
    }


