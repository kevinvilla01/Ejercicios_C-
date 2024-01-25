using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un numero y saber si este es par o impar
            int num = 0;

            Console.WriteLine("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num%2 == 0)
            {
                Console.WriteLine("El numero {0} es par", num);
            }
            else
            if (num%2 != 0)
            {
                Console.WriteLine("El numero {0} es impar", num);
            }

            Console.ReadKey();
        }
    }
}
