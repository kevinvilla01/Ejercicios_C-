using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays dinamicos
            int webos = 0;
            Console.WriteLine("Cuantos webos vas a registrar");
            webos = Convert.ToInt32(Console.ReadLine());

            int[] weboss = new int[webos];

            for (int pos = 0; pos < weboss.Length; pos++)
            {
                Console.WriteLine("Escribe tu edad");
                weboss[pos] = Convert.ToInt32(Console.ReadLine());
            }

            for (int pos = 0; pos < weboss.Length; pos++)
            {
                Console.Write(weboss[pos] + ", ");
            }

            Console.ReadKey();
        }
    }
}
