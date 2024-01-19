using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Grados centigrados a farenheit
            // 1 = 32

            float cent = 0, res = 0, far = 32;

            Console.WriteLine("Cuantos centigrados quiere converir");
            cent = Convert.ToSingle(Console.ReadLine());

            res = (cent * 9/5) + far;
            Console.WriteLine("{0} centigrados equivalen a: {1} farenheit", cent, res);

            Console.ReadKey();
        }
    }
}
