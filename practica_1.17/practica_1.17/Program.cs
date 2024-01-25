using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menor mayor o igual a cero
            int num = 0;

            Console.WriteLine("Escriba un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("El numero {0} es mayor que cero", num);
            }
            else
            if (num < 0)
            {
                Console.WriteLine("El numero {0} es menor que cero", num);
            }

            else
            {
                Console.WriteLine("El numero {0} es igual a cero", num);
            }

            Console.ReadKey();
        }
    }
}
