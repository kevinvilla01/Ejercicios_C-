using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch case detector de putos

            char genero;
            Console.WriteLine("Escriba su genero: H = Hombre M = Mujer");
            genero = Convert.ToChar(Console.ReadLine());

            switch (genero)
            {
                case 'h':
                    Console.WriteLine("eres hombre we");
                    break;

                case 'H':
                    Console.WriteLine("Eres hobre we");
                    break;

                case 'm':
                    Console.WriteLine("Eres mujer we");
                    break;

                case 'M': 
                    Console.WriteLine("Eres mujer we");
                    break;

                default:
                    Console.WriteLine("GAY");
                    break;
            }

            Console.ReadKey();

        }
    }
}
