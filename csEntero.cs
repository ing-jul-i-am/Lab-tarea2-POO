using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csEntero
    {
        //1. Atributos
        int numero = 0;

        //2. Constructor
        public csEntero(int n)
        {
            this.numero = n;
        }

        //3. Metodos
        public string calcularPositivo()
        {
            if(numero < 0)
            {
                return "entero negativo.";
            } else if(numero > 0)
            {
                return "entero positivo.";
            } else
            {
                return "neutro/zero.";
            }
        }
    }
}
