using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Categorizar pesos de boxeo
            float kg = 0;

            Console.WriteLine("Ingrese su peso:");
            kg = Convert.ToSingle(Console.ReadLine());

            if (kg < 56.7) 
            {
                Console.WriteLine("Entras al peso mosca");
            }
            else
            if (kg >= 56.7 && kg < 61.2)
            {
                Console.WriteLine("Entras al peso gallo");
            }
            else
            if (kg >= 61.2 && kg < 65.7)
            {
                Console.WriteLine("Entras al peso pluma");
            }
            else
            if (kg >= 65.7 && kg < 70.3)
            {
                Console.WriteLine("Entras al peso ligero");
            }
            else
            if (kg >= 70.3 && kg < 77.1)
            {
                Console.WriteLine("Entras al peso welter");
            }
            else
            if (kg >= 77.1 && kg < 83.9)
            {
                Console.WriteLine("Entras al peso medio");
            }
            else
            if (kg >= 83.9 && kg < 92.9)
            {
                Console.WriteLine("Entras al peso semicompleto");
            }
            else
            if (kg >= 92.9 && kg < 120.2)
            {
                Console.WriteLine("Entras al peso pesado");
            }
            else
            {
                Console.WriteLine("Eres peso super pesado");
            }

            Console.ReadKey();
        }
    }
}
