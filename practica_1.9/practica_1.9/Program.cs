using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vender articulos con valor de 20 pesos, solicitar cantidad de articulos a vender,
            // mostrar total, solicitar pago y mostrar cambio

            int cantArt = 0;
            float total = 0, pago = 0, cambio = 0;

            Console.WriteLine("Bievenido a la tiendita el kevin");
            Console.WriteLine("Cuantos articulos vas a llevar? ");
            cantArt = Convert.ToInt32(Console.ReadLine());

            total = cantArt * 30;
            Console.WriteLine("El total es de: {0}", total);

            Console.WriteLine("Con cuanto pagaras?");
            pago = Convert.ToInt32(Console.ReadLine());

            cambio = pago - total;
            Console.WriteLine("Su cambio es de: {0}", cambio);

            Console.ReadKey();
        }
    }
}
