using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una serie de numeros del 1 al 100
            int num = 1;

            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 100);

            Console.ReadKey();
        }

    }
}
