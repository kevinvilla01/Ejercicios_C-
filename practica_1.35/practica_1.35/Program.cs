using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que regunte si desea convertir de grados
            // C a F, o de F a C

            int opcion = 0;
            float c = 0, f = 0; 

            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1. De centigrados a farenheit");
            Console.WriteLine("2. De farenheit a centigrados");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Esxriba los grados a convertir.");
                    c = Convert.ToSingle(Console.ReadLine());

                    f = c * 1.8f + 32;
                    Console.WriteLine("{0} grados celsius equivalen a {1} farenheit", c, f);
                    break;

                case 2:

                    Console.WriteLine("Esxriba los grados a convertir.");
                    f = Convert.ToSingle(Console.ReadLine());

                    c = (f - 32) / 1.8f;
                    Console.WriteLine("{0} grados farenheit equivalen a {1} celsius", f, c);
                    break;

                default:
                    Console.WriteLine("NO le sobas");
                    break;
            }

            Console.ReadKey();
        }
    }
}
