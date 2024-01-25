using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comparar tres numeros y decir cual es mayor
            int num1 = 0, num2 = 0, num3 =0;

            Console.WriteLine("Escriba el numero 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el numero 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el numero 3:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El nunmero {0} es mayor que todos", num1);
            }
            else
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El numero {0} es mayor que todos", num2);
            }
            else
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El numero {0} es mayor que todos", num3);
            }
            else
            {
                Console.WriteLine("Hay numeros iguales");
            }

            Console.ReadKey();
        }
    }
}
