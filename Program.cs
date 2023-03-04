using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_tarea2_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu principal:");
            Console.WriteLine("1. Pago de Autobus");
            Console.WriteLine("2. Calcular billetes");
            Console.WriteLine("3. Numero perfecto");
            Console.WriteLine("4. Persona de menor edad");
            Console.WriteLine("5. Entero positivo o negativo");
            Console.WriteLine("6. Volumen de un cilindro");
            Console.WriteLine("7. Equipo ganador");
            Console.WriteLine("8. Maximo Comun Divisor - MCD");
            Console.WriteLine("9. Serie de Fibonacci");
            Console.WriteLine("10. Tablas de multiplicar");
            Console.WriteLine("\n0. Salir");
            Console.WriteLine("Elija una opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: PagoAutobus(); Menu(); break;
                case 2: CalcularBilletes(); Menu(); break;
                case 3: Perfecto(); Menu(); break;
                case 4: PersonaDeMenorEdad(); Menu(); break;
                case 5: PositivoNegativo(); Menu(); break;
                case 6: Volumen(); Menu(); break;
                case 7: EquipoGanador(); Menu(); break;
                case 8: MaximoComunDivisor(); Menu(); break;
                case 9: SerieDeFibonacci(); Menu(); break;
                case 10: TablasDeMultiplicar(); Menu(); break;
                case 0: 
                    Console.WriteLine("\nGracias por usar mi sistema.");
                    Console.WriteLine("\nIng. Julian Andres Barrera Garcia.");
                    Console.ReadKey(); 
                    break;

                default:
                    Console.WriteLine("\nOpcion incorrecta. Vuelva a elegir.");
                    Console.ReadKey();
                    Menu();
                    break;
            }

        }

        static void FIN()
        {
            Console.WriteLine("\nPresione cualquier tecla para regresar al menu principal.");
            Console.ReadKey();
        }

        //Opcion 1
        static void PagoAutobus()
        {
            Console.Clear();
            Console.WriteLine("Calculo del pago de un autobus");
            Console.WriteLine("Ingrese la cantidad de alumnos que viajaran: ");
            int n = Convert.ToInt32(Console.ReadLine());

            csPagoAutobus bus = new csPagoAutobus(n);
            Console.WriteLine("\nCada Alumno debe pagar: " + bus.calcularPagoIndividual());
            Console.WriteLine("\nSe debe pagar un total por el bus de: " + bus.calcularPagoAutobus());
            FIN();
        }

        //Opcion 2
        static void CalcularBilletes()
        {
            Console.Clear();
            Console.WriteLine("Calculo de billetes");
            Console.WriteLine("Ingrese la cantidad de Q en numeros enteros: ");
            int n = Convert.ToInt32(Console.ReadLine());

            csDinero dinero = new csDinero(n);

            Console.WriteLine(dinero.calcularBilletes());
            FIN();
        }

        //Opcion 3
        static void Perfecto()
        {
            Console.Clear();
            Console.WriteLine("Numero perfecto");
            Console.WriteLine("Ingrese un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            csPerfecto perfecto = new csPerfecto(n);

            Console.WriteLine($"El numero {n} es un numero {perfecto.calcularPerfecto()}");
            FIN();

        }

        //Opcion 4
        static void PersonaDeMenorEdad()
        {
            Console.Clear();
            Console.WriteLine("Calculo de la persona de menor edad");

            Console.WriteLine("Nombre de 1era persona: ");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Edad de 1era persona: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre de 2da persona: ");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Edad de 2da persona: ");
            int edad2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre de 3era persona: ");
            string nombre3 = Console.ReadLine();
            Console.WriteLine("Edad de 3era persona: ");
            int edad3 = Convert.ToInt32(Console.ReadLine());

            csEdad personas = new csEdad(nombre1, edad1, nombre2, edad2, nombre3, edad3);

            Console.WriteLine($"La persona con menor edad es {personas.calcularEdad()}\n");
            FIN();
        }

        //Opcion 5
        static void PositivoNegativo()
        {
            Console.Clear();
            Console.WriteLine("Numero entero negativo o positivo");
            Console.WriteLine("Ingrese un numero entero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            csEntero numero = new csEntero(n);

            Console.WriteLine($"El numero {n} es {numero.calcularPositivo()}");
            FIN();
        }

        //Opcion 6
        static void Volumen()
        {
            Console.Clear();
            Console.WriteLine("Volumen de un cilindro");
            Console.WriteLine("Ingrese r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            csVolumen cilindro = new csVolumen(r, h);

            Console.WriteLine("El volumen del cilindro es: " + cilindro.calcularVolumen());
            FIN();
        }

        //Opcion 7
        static void EquipoGanador()
        {
            Console.Clear();
            Console.WriteLine("Equipo ganador");

            Console.WriteLine("Nombre de 1er equipo: ");
            string equipo1 = Console.ReadLine();
            Console.WriteLine("Marcador 1er equipo: ");
            int goles1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de 2do equipo: ");
            string equipo2 = Console.ReadLine();
            Console.WriteLine("Marcador 2do equipo: ");
            int goles2 = Convert.ToInt32(Console.ReadLine());

            csEquipo equipo = new csEquipo(equipo1, goles1, equipo2, goles2);
            Console.WriteLine(equipo.calcularMarcador());
            FIN();
        }

        //Opcion 8
        static void MaximoComunDivisor()
        {
            Console.Clear();
            Console.WriteLine("Maximo Comun Divisor - MCD\n");
            Console.WriteLine("Ingrese un entero positivo: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            csMCD numero = new csMCD(n);

            Console.WriteLine($"El MCD de {n} es {numero.calcularMCD()}.");
            FIN();
        }

        //Opcion 9
        static void SerieDeFibonacci()
        {
            Console.Clear();
            Console.WriteLine("Serie o numeros de Fibonacci\n");
            Console.WriteLine("¿Cuantos numeros de la serie desea ver?");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            csFibonacci numero = new csFibonacci(n);

            List<int> numeros = new List<int>();
            numeros = numero.fibonacci();

            Console.WriteLine($"Los {n} numeros de fibonacci son: ");
            if (numeros.Count == 1)
            {
                Console.WriteLine(numeros[0]);
            }
            else if (numeros.Count == 2)
            {
                Console.WriteLine(numeros[0]);
                Console.WriteLine(numeros[1]);
            }
            else
            {
                foreach (int x in numeros)
                {
                    Console.WriteLine(x);
                }
            }
            FIN();
        }

        //Opcion 10
        static void TablasDeMultiplicar()
        {
            Console.Clear();
            Console.WriteLine("Tablas de multiplicar\n");
            Console.WriteLine("Presione cualquier tecla para comenzar.\n");
            Console.ReadKey();
            Console.WriteLine("\n\n");

            csTabla tabla = new csTabla();

            Console.WriteLine(tabla.generarTablas());
            FIN();
        }
    }
}
