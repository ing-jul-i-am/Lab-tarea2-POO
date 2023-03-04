using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csMCD
    {
        //1. Atributos
        int num = 0;

        //2. constructor
        public csMCD(int n)
        {
            this.num = n;
        }

        //3. Metodos
        public int calcularMCD()
        {
            int resultado = 1;

            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    resultado = i;
                }
            }
            return resultado;
        }
    }
}
