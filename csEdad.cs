using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csEdad
    {
        //1. Atributos
        string nombre1, nombre2, nombre3;
        int edad1, edad2, edad3;

        //2. Constructor
        public csEdad(string nombre1, int edad1, string nombre2, int edad2, string nombre3, int edad3)
        {
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            this.nombre3 = nombre3;
            this.edad1 = edad1;
            this.edad2 = edad2;
            this.edad3 = edad3;
        }

        //3. Metodos
        public string calcularEdad()
        {
            if(edad1<edad2 && edad1 < edad3)
            {
                return nombre1 + ", " + edad1 + ".";
            } else if (edad2<edad1 && edad2 < edad3)
            {
                return nombre2 + ", " + edad2 + ".";
            } else if (edad3<edad1 && edad3 < edad2)
            {
                return nombre3 + ", " + edad3 + ".";
            } else
            {
                return "indefinido. Hay dos o mas personas con la misma edad.";
            }
        }
    }
}
