using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if para menus
            // crear un programa que resuelva la ley de ohm
            // Voltaje = I * R
            int opcion = 0;
            float v = 0, i = 0, r = 0;

            Console.WriteLine("Bienvenido al sistema, seleccione una de las siguientes opciones:");
            Console.WriteLine("1. Calcular voltaje");
            Console.WriteLine("2. Calcular corriente");
            Console.WriteLine("3. Calcular resistencia");

            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                // Calcular el voltaje 
                Console.WriteLine("Ingrese el valor de la corriente: ");
                i = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la resistencia: ");
                r = Convert.ToSingle(Console.ReadLine());

                v = i * r;
                Console.WriteLine("El voltaje es igual a {0}", v);
            }
            else
            if (opcion == 2)
            {
                // Calcular el corriente
                // v / r
                Console.WriteLine("Ingrese el valor del voltaje: ");
                v = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese el valor de la resistencia: ");
                r = Convert.ToSingle(Console.ReadLine());

                i = v / r;
                Console.WriteLine("La corriente es igual a {0}", i);
            }
            else
            if (opcion == 3)
            {
                // Calcular la resistencia
                Console.WriteLine("Ingrese los valores de la corriente: ");
                i = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del voltaje: ");
                v = Convert.ToSingle(Console.ReadLine());

                r = v / i;
                Console.WriteLine("La resistencia es igual a {0}", r);
            }

            else
            {
                Console.WriteLine("Nomas hay 3 we");
            }

            Console.ReadKey();
        }
    }
}
