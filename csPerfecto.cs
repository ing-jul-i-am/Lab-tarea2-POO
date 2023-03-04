using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csPerfecto
    {
        //1. Atributos
        int num = 0;

        //2. Constructor
        public csPerfecto(int n)
        {
            this.num = n;
        }

        //3. Metodos
        public string calcularPerfecto()
        {
            List<int> divisores = new List<int>();
            int n = this.num;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    divisores.Add(i);
                }
            }

            if (divisores.Sum() == n)
            {
                return "Perfecto";
            }
            else
            {
                return "Imperfecto";
            }
        }
    }
}
