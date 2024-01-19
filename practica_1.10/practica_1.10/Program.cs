using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convertir kilos a libras
            // 1 = 2.20462

            int kil = 0;
            float libras = 2.20462f, conver = 0;

            Console.WriteLine("Cuantos kilos desea convertir a libras?");
            kil = Convert.ToInt32(Console.ReadLine());

            conver = kil * libras;
            Console.WriteLine("{0} equivalen a: {1} libras", km, conver);

            Console.ReadKey();
        }
    }
}
