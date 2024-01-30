using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math Library
            double n1 = 0, n2 = 0, res = 0;
            char opcion;

            // Suma, resta mult, div, raiz, potencia, sin, cos, tan, factorial

            Console.WriteLine("Que operacion desea realizar: ");
            Console.WriteLine("a. Suma");
            Console.WriteLine("b. Resta");
            Console.WriteLine("c. Multiplicacion");
            Console.WriteLine("d. Division");
            Console.WriteLine("e. Raiz");
            Console.WriteLine("f. Potencia");
            Console.WriteLine("g. Seno");
            Console.WriteLine("h. Coseno");
            Console.WriteLine("i. Tangente");

            opcion = Convert.ToChar(Console.ReadLine());
            
            if (opcion == 'a')
            {
                Console.WriteLine("Ingrese el valor del primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numer0: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = n1 + n2;
                Console.WriteLine("El resultado de las suma es: {0}", res);
            }
            else
            if (opcion == 'b')
            {
                Console.WriteLine("Ingrese el valor del primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numer0: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = n1 - n2;
                Console.WriteLine("El resultado de las resta es: {0}", res);
            }
            else
            if (opcion == 'c')
            {
                Console.WriteLine("Ingrese el valor del primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numer0: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = n1 * n2;
                Console.WriteLine("El resultado de la multiplicacion es: {0}", res);
            }
            else
            if (opcion == 'd')
            {
                Console.WriteLine("Ingrese el valor del primer numero: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numer0: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = n1 / n2;
                Console.WriteLine("El resultado de la division es: {0}", res);
            }
            else
            if (opcion == 'e')
            {
                Console.WriteLine("Ingrese el valor del numero a sacarle raiz: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                res = System.Math.Sqrt(n1);
                Console.WriteLine("El resultado de la raiz es: {0}", res);
            }
            else 
            if (opcion == 'f')
            {
                Console.WriteLine("Ingrese el valor del numero a potenciar: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de la potencia: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = System.Math.Pow(n1,n2);
                Console.WriteLine("El resultado de la potencia es: {0}", res);
            }
            else
            if (opcion == 'g')
            {
                Console.WriteLine("Ingrese el valor del numero a sacarle seno: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                res = System.Math.Asin(n1);
                Console.WriteLine("El seno es: {0}", res);
            }
            else
            if (opcion == 'h')
            {
                Console.WriteLine("Ingrese el valor del numero a sacarle coseno: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del segundo numer0: ");
                n2 = Convert.ToDouble(Console.ReadLine());

                res = System.Math.Acos(n1);
                Console.WriteLine("El coseno es: {0}", res);
            }
            else 
            if (opcion == 'i')
            {
                Console.WriteLine("Ingrese el valor del numero a sacar tangente: ");
                n1 = Convert.ToDouble(Console.ReadLine());

                res = System.Math.Atan(n1);
                Console.WriteLine("La tangente es: {0}", res);
            }
            else
            {
                Console.WriteLine("No sabes leer o q");
            }

            Console.ReadKey();
        }
    }
}
