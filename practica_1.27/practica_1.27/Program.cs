using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo de trinagulo
            // Solicitar cuanto mide cada lado del triangulo 
            // Equilatero - todos lados iguales, Isoceles - 2 iguales y 1 diferente, Escaleno - todos diferentes

            float lado1 = 0, lado2 = 0, lado3 = 0;
            int opcion = 0;

            Console.WriteLine("Bienvenido al programa, Ingrese los valores de los lados de un triangulo: ");
            Console.WriteLine("Lado 1: ");
            lado1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Lado 2:");
            lado2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Lado 3:");
            lado3 = Convert.ToSingle(Console.ReadLine());

            if (lado1 == lado2 && lado3 == lado1)
            {
                Console.WriteLine("Tu triangulo es un triangulo equilatero");
            }
            else 
            if (lado3 != lado1 && lado3 != lado2) 
            {
                Console.WriteLine("Tu triangulo es escaleno");
            }
            else
            {
                Console.WriteLine("Tu triangulo es un isoceles");
            }

            Console.ReadKey();
        }
    }
}
