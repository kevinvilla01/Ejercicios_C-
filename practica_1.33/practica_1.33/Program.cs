using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Preguntar al usuario de cual de las siguientes figuras obtener el area:
            // triangulo, cubo, circulo y rectangulo

            string fig;

            Console.WriteLine("Que area vas a querer sacar: ");
            Console.WriteLine("Triangulo");
            Console.WriteLine("Prisma cuadrangular");
            Console.WriteLine("Circulo");
            Console.WriteLine("Rectangulo");
            fig = Console.ReadLine();

            switch (fig)
            {
                case "Triangulo":
                    // triangulo
                    int basee = 0, altura = 0, res = 0;
                    Console.WriteLine("Escriba sus pinches numeros: ");
                    Console.WriteLine("Base: ");
                    basee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    altura = Convert.ToInt32(Console.ReadLine());

                    res = (basee * altura) / 2;

                    Console.WriteLine("\nEl resultado es: {0} ", res);
                    break;

                case "Prisma cuadrangular":
                    // triangulo
                    int la1 = 0, largo = 0, la2 = 0, resp = 0;
                    Console.WriteLine("Escriba sus pinches numeros: ");
                    Console.WriteLine("Lado 1: ");
                    la1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Lado 2: ");
                    la2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Largo: ");
                    largo = Convert.ToInt32(Console.ReadLine());

                    resp = la1 * largo * la2;

                    Console.WriteLine("\nEl resultado es: {0} ", resp);
                    break;

                case "Circulo":
                    // triangulo
                    double radio1 = 0, resc = 0, pi = 0;
                    pi = System.Math.PI;
                    Console.WriteLine("Escriba sus pinches numeros: ");
                    Console.WriteLine("radio: ");
                    radio1 = Convert.ToDouble(Console.ReadLine());

                    resc = (radio1 * radio1) * pi;

                    Console.WriteLine("\nEl resultado es: {0} ", resc);
                    break;

                case "Rectangulo":
                    // triangulo
                    int ancho = 0, alto = 0, resr = 0;
                    Console.WriteLine("Escriba sus pinches numeros: ");
                    Console.WriteLine("Ancho: ");
                    ancho = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Alto: ");
                    alto = Convert.ToInt32(Console.ReadLine());

                    resr = ancho * alto;

                    Console.WriteLine("\nEl resultado es: {0} ", resr);
                    break;

                default:
                    Console.WriteLine("NOMAS HAY ESAS OPCIONES WEY");
                    break;
            }

            Console.ReadKey();
        }
    }
}
