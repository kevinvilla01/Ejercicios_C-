using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci
            int num1 = 0, num2 = 1, control = 0;

            do
            {
                control = num2 + num1;
                Console.WriteLine("{0}", control);
                num1 = num2;
                num2 = control;

            } while (control <= 100);

            Console.ReadKey();
        }
    }
}
