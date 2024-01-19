using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener el area y perimetro de un rectangulo
            // area = b*a, per = (a+b)*2

            float a = 0, b = 0, res=0;

            Console.WriteLine("Esriba el valor de la base: "); // Guardar valor base
            b = Convert.ToSingle(Console.ReadLine()); // Guardar base en variable b

            Console.WriteLine("Escriba el valor de la altura: "); // Guardar valor  altura
            a = Convert.ToSingle(Console.ReadLine()); // Guardar altura en variable a

            res = a * b; //Calcular area
            Console.WriteLine("El area del rectangulo es: {0}", res);

            res = (a + b) * 2;
            Console.WriteLine("El perimetro de a base es: {0}", res);

            Console.ReadKey(); //Final programa
        }
    }
}
