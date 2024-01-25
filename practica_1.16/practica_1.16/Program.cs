using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            int edad = 0;

            Console.WriteLine("Escriba su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18) 
            {
                Console.WriteLine("Eres mayor de edad");
            }

            else
            {
                Console.WriteLine("Tas morrillo todavia");
            }

            Console.ReadKey();
        }
    }
}
