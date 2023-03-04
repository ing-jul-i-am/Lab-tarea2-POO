using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csPagoAutobus
    {
        //1. Atributos
        private int n = 0; //Numero de alumnos

        //2. Constructor
        public csPagoAutobus (int n)
        {
            this.n = n;
        }

        //3. Metodos
        public double calcularPagoAutobus()
        {
            if (n >= 100)
            {
                return 65*n;
            }
            else if (n >= 50 && n <= 99)
            {
                return 70*n;
            }
            else if (n >= 30 && n <= 49)
            {
                return 95*n;
            }
            else if (n > 0 && n < 30)
            {
                return 4000;
            }
            else
            {
                return 99999.999;
            }
        }

        public double calcularPagoIndividual()
        {
            if (n >= 100)
            {
                return 65;
            } else if(n >= 50 && n<= 99)
            {
                return 70;
            } else if( n >= 30 && n<= 49)
            {
                return 95;
            } else if (n>0 && n<30)
            {
                return 4000 / n;
            } else
            {
                return 99999.999;
            }
        }
    }
}
