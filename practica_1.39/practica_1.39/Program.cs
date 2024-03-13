using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un numero para mostrar la tabla de multiplicacion de ese numero
            // multiplicado hasta por 10

            int num = 0,contador = 0, res = 0, multip = 0;
            
            Console.WriteLine("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de veces que desea multiplicar");
            multip = Convert.ToInt32(Console.ReadLine());

            do
            {
                res = num * contador;
                Console.WriteLine("{0} x {1} = {2}", num, contador, res);
                contador++;
            } while (contador <= multip);

            Console.ReadKey();
        }

    }
}
