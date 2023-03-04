using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csTabla
    {
        //1. Atributos
            //*Esta clase no lo requiere

        //2. Constructor
        public csTabla()
        {

        }

        //3. Metodos
        public string generarTablas()
        {
            int m, n;
            string resultado = "";

            for (m = 1; m <= 10; m++)
            {
                for (n = 1; n <= 10; n++)
                {
                    resultado += m + "X" + n + "=" + (m * n) + "\n";
                }
                resultado += "\n";
            }
            
            return resultado;
        }
    }
}
