using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // km a millas
            // km = 0.621371 millas

            int km = 0;
            float mill = 0.621371f, res = 0;

            Console.WriteLine("Cuantos km quiere convertir a millas");
            km = Convert.ToInt32(Console.ReadLine());

            res = km * mill;
            Console.WriteLine("{0} km equivalen a: {1} millas", km, res);

            Console.ReadKey();
        }
    }
}
