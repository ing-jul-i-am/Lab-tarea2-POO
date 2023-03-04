using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csVolumen
    {
        //1. Atributos
        double r=0, h=0;

        //2. Constructor
        public csVolumen(double r, double h)
        {
            this.r = r;
            this.h = h;
        }

        //3. Metodos
        public double calcularVolumen()
        {
            return Math.PI*r*r*h;
        }
    }
}
