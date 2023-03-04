using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csEquipo
    {
        //1. Atributos
        string equipo1 = "", equipo2 = "";
        int goles1=0, goles2=0;

        //2. Constructor
        public csEquipo(string eq1, int gl1, string eq2, int gl2)
        {
            this.equipo1 = eq1;
            this.equipo2 = eq2;
            this.goles1=gl1;
            this.goles2=gl2;
        }

        //3. Metodos
        public string calcularMarcador()
        {
            if(goles1 > goles2)
            {
                return "El equipo " + equipo1 + " es el ganador.\n";
            } else if(goles2 > goles1)
            {
                return "El equipo " + equipo2 + " es el ganador.\n";
            } else
            {
                return "Los equipos estan en empate.\n";
            }
        }
    }
}
