using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char y strings
            string nombre = "";
            int pos = 0;
            bool res;
            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Tu nombre es: {0}", nombre);
            Console.WriteLine("Tu nombre tiene {0} letras.", nombre.Length);
            Console.WriteLine("Tu nombre en mayusculas es: {0}", nombre.ToUpper());
            Console.WriteLine("Tu nombre en minisculas es: {0}", nombre.ToLower());

            res = nombre.Contains('n');
            Console.WriteLine(res);

            pos = nombre.IndexOf('n'); // Posicion de un caracter dentro de un string
            Console.WriteLine("El caraacter se encuentra en la posicion {0}", pos);
            pos = nombre.LastIndexOf('n');
            Console.WriteLine("La ultima posicion del caracter es {0}", pos);

            nombre = nombre.Replace('e', 'v'); // Reemplazar caracteres
            Console.WriteLine(nombre);

            nombre = nombre.Remove(1,1);
            Console.WriteLine(nombre);


            Console.ReadKey();
        }
    }
}
