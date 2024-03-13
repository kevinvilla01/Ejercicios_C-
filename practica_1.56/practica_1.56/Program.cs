using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metodos o funciones

            sumar();
            restar();
            Console.WriteLine(sumar2(2,3));

            Console.ReadKey();
        }

        static void sumar()
        {
            int n1 = 5, n2 = 10, res = n1 + n2;
            Console.WriteLine(res);
        }

        static void restar()
        {
            int n1 = 5, n2 = 10, res = n1 - n2;
            Console.WriteLine(res);
        }

        static int sumar2(int n1, int n2)
        {
            
            int res = n1 + n2;
            return(res);
        }
    }
}
