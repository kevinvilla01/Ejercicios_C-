using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convertir galones a litroa
            // 1 = 3.78541
            int gal = 0;
            float lit = 3.785f, res = 0;

            Console.WriteLine("Cuantos galones desea converitr a litros?");
            gal = Convert.ToInt32(Console.ReadLine());

            res = gal * lit;
            Console.WriteLine("{0} equivalen a: {1} litros", gal, res);

            Console.ReadKey();
        }
    }
}
