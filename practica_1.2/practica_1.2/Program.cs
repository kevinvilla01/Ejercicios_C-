using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Area de un trinagulo
            float b = 0, a = 0, area = 0;
            // Escribir el valor de la base
            Console.WriteLine("Favor de introducir el valor de la base: ");
            b = Convert.ToSingle(Console.ReadLine()); // Convertir a tipo float
            // Escribir el valor de altura
            Console.WriteLine("Favor de introducir el valor de la altura: ");
            a = Convert.ToSingle(Console.ReadLine()); // Convertir a tipo float
            // Resultado del area
            area = (b * a) / 2;

            // Imprimir area
            Console.WriteLine("El resultado es: " + area);

            // Finalizar programa
            Console.ReadKey();
        }
    }
}
