using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Figuras
            int lineas = 7;
            string cruz = "+++++++";

            for (int lines = 1; lines <= lineas; lines++)
            {
                Console.WriteLine(cruz);
                cruz = cruz.Remove(0,1);
            }


            Console.ReadKey();
        }
    }
}
