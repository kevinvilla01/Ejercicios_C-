using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Area de un circulo = pi*radioal cuadrado
            float area = 0, pi = 3.1416f, radio = 0; // Variables

            // Guardar valores 
            Console.WriteLine("Favor de ingresar el valor del radio: ");
            radio = Convert.ToSingle(Console.ReadLine());
            // Resultado del area
            area = pi * (radio * radio);

            //Imprimir resultado
            Console.WriteLine("El area del circulo es: " + area);

            // Finalizar programa
            Console.ReadKey();

        }
    }
}
