using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa quee saque el factorial de un numero

            int num = 0, res = 0, sum = 0;
            Console.WriteLine("Ingrese un numero para sacar factorial");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = num - 1; i >= 1; i--) 
            {
                
                res = num * i;
                num = res;

            }

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
