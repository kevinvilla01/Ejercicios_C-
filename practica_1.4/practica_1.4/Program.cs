using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Area de un trapecio = baseM+basem*altura/2
            float area = 0, baseM = 0, basem = 0, altura = 0; // Variables

            // Guardar valores 
            Console.WriteLine("Favor de ingresar el valor de la base mayor: ");
            baseM = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Favor de ingresar el valor de la base menor: ");
            basem = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Favor de ingresar el valor de la altura: ");
            altura = Convert.ToSingle(Console.ReadLine());
            // Resultado del area
            area = ((baseM + basem)*altura)/2;

            //Imprimir resultado
            Console.WriteLine("El area del trapecio es: " + area);

            // Finalizar programa
            Console.ReadKey();
        }
    }
}
