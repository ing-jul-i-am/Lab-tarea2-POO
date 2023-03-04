using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csFibonacci
    {
        //1. Atributos
        int n = 0;

        //2. Constructor
        public csFibonacci(int n)
        {
            this.n = n;
        }

        //3. Metodos
        public List<int> fibonacci()
        {
            List<int> serie = new List<int>();
            if (n <= 1)
            {
                serie.Add(0);
            }
            else if (n <= 2)
            {
                serie.Add(0);
                serie.Add(1);
            }
            else
            {
                serie.Add(0);
                serie.Add(1);
                for (int i = 3; i <= n; i++)
                {
                    serie.Add(serie[i - 2] + serie[i - 3]);
                }
            }
            return serie;
        }
    }
}
