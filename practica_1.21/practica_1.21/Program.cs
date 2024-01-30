using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener el valor absoluto de un numero
            int num = 0;

            Console.WriteLine("Escribe un numero:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                num = num * -1;
            }

            Console.WriteLine("El valor absoluto es {0}", num);

            Console.ReadKey();
        }
    }
}
