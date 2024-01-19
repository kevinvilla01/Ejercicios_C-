using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desglosar IVA de una cantidad 16%

            float cant = 0, res = 0;

            Console.WriteLine("Escriba la cantidad a desglorsarle el IVA.");
            cant = Convert.ToSingle(Console.ReadLine());

            res = cant * 0.16f;
            cant = cant - res;

            Console.WriteLine("La cantidad ya sin IVA es {0}", cant);

            Console.ReadKey();
        }
    }
}
