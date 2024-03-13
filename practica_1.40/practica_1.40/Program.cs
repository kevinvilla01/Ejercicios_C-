using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Serie de numeros de 300 al 100 con un decremento de 4 en 4
            int num = 300;

            do 
            {
                Console.WriteLine(num);
                num = num - 4;
            } while (num >= 100);

            Console.ReadKey();
        }

        
    }
}
