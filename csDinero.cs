using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class csDinero
    {
        //1. Atributos
        int cantidad = 0;

        //2. Constructor
        public csDinero(int cant)
        {
            this.cantidad = cant;
        }

        //3. Metodos
        public string calcularBilletes()
        {
            string resultado = "\n";

            resultado = Billete100(cantidad) + " billetes de Q100.\n";
            resultado += Billete50(cantidad) + " billetes de Q50.\n";
            resultado += Billete20(cantidad) + " billetes de Q20.\n";
            resultado += Billete10(cantidad) + " billetes de Q10.\n";
            resultado += Billete5(cantidad) + " billetes de Q5.\n";
            resultado += Billete1(cantidad) + " billetes de Q1.\n";

            return resultado;
        }

        static int Billete100(int cant)
        {
            int resultado;
            if (cant >= 100)
            {
                resultado = Convert.ToInt32(cant / 100);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete50(int cant)
        {
            int numero = cant - Billete100(cant) * 100;
            int resultado;

            if (numero >= 50)
            {
                resultado = Convert.ToInt32(numero / 50);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete20(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50;
            int resultado;

            if (numero >= 20)
            {
                resultado = Convert.ToInt32(numero / 20);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete10(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20;
            int resultado;

            if (numero >= 10)
            {
                resultado = Convert.ToInt32(numero / 10);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete5(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20 - Billete10(cant) * 10;
            int resultado;

            if (numero >= 5)
            {
                resultado = Convert.ToInt32(numero / 5);
            }
            else
            {
                resultado = 0;
            }
            return resultado;
        }

        static int Billete1(int cant)
        {
            int numero = cant - Billete100(cant) * 100 - Billete50(cant) * 50 - Billete20(cant) * 20 - Billete10(cant) * 10 - Billete5(cant) * 5;

            return numero;
        }
    }
}
