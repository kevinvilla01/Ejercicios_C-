using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Preguntar edad y calcular cuantos dias ha vivido
            // edad * 365

            int edad = 0, res = 0;

            Console.WriteLine("Cuantos anios tienes?");
            edad = Convert.ToInt32(Console.ReadLine());

            res = edad * 365;
            Console.WriteLine("Has vivido {0} dias", res);

            Console.ReadKey();
        }
    }
}
