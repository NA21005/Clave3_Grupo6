using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave3_Grupo6
{
    class Estructura
    {
        //Propiedades
        protected double salarioBase;
        protected double ventas;
        protected int horasExtra;

        //Métodos getter and setter
        public double SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }

        public double Ventas
        {
            get { return ventas; }
            set { ventas = value; }
        }

        public int HorasExtra
        {
            get { return horasExtra; }
            set { horasExtra = value; }
        }
    }
}
