using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays matrices

            int[,] matriz = new int[3, 3];

            for (int posx = 0; posx < 3; posx++)
            {
                for (int posy = 0; posy < 3; posy++)
                {
                    Console.Write("{0},{1} ", posx, posy);
                }
                Console.WriteLine();
            }

            Console.WriteLine(matriz.Length);

            Console.ReadKey();
        }

    }
}
