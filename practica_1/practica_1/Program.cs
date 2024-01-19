using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Este es un Comentario de linea
            /* Este 
             * es
             * un 
             * comentario
             * de
             * bloque */

            // Suma de dos numeros
            int num1 = 10, num2 = 4, res = 0;
            // Sumar ambos numeros y guardar en variable res
            res = num1 + num2;
            // Resta
            int res1 = num1 - num2;
            // Multiplicar
            int res2 = num1 * num2;
            // Dividir
            int res3 = num1 / num2;
            // Imprimir en pantalla el resultado
            Console.WriteLine("El resultado de la suma es " + res);
            // Salto de linea
            Console.WriteLine();
            // Hola mundo
            Console.WriteLine("Hola mundo");
            // Format en imprimir multiplicacion
            Console.WriteLine("El resultado de la multiplacion de {0} por {1} es: {2}", num1,num2,res2);
            // Division
            Console.WriteLine("El resultado de la division de {0} entre {1} es: {2}",num1,num2,res3);
            // Imprimir resultado resta
            Console.WriteLine("El resultado de la resta es " + res1);
            // Finalizar  el programa
            Console.ReadKey();

        }
    }
}
