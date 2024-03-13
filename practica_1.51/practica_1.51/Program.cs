using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays fijo
            int[] edades = new int[5];

            for (int pos = 0; pos < edades.Length; pos++)
            {
                Console.WriteLine("Escribe tu edad");
                edades[pos] = Convert.ToInt32(Console.ReadLine());
            }

            for (int pos = 0;pos < edades.Length; pos++)
            {
                Console.Write(edades[pos] + ", ");
            }

            Console.ReadKey();
        }
    }
}
