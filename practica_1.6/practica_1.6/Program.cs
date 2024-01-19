using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener el cuadrado y el cubo de un numero entero positivo.
            uint num = 0, res = 0;

            Console.WriteLine("Escribe un numero entero positivo"); // Solicitar al usuario numero entero positivo
            num = Convert.ToUInt32(Console.ReadLine()); // Guardar el numero en num y conventirlo en UInt

            res = num * num; // Calcular cuadrado
            Console.WriteLine("El cuadrado del numero {0} es: {1}", num, res); // Imprimir en pantalla

            res = num * num * num; // Calcular cubo
            Console.WriteLine("El cubo del numero {0} es: {1}", num, res);

            Console.ReadKey(); // Fin del programa
        }
    }
}
