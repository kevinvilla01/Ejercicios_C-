using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serie de numeros de 300 al 100 con un decremento que desees
            int num = 0, num_fin = 0, num_desaltos = 0, opcion = 0;


            Console.WriteLine("Escoge de donde comienza la serie:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escoge el numero final de la serie:");
            num_fin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto seran los saltos:");
            num_desaltos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Decremento");
            Console.WriteLine("2. Incremento");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine(num);
                        num = num - num_desaltos;
                    } while (num >= num_fin);
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine(num);
                        num = num + num_desaltos;
                    } while (num <= num_fin);
                    break;

                default:
                    Console.WriteLine("Eres un pendejo.");
                    break;
            }
            

            Console.ReadKey();
        }
    }
}
