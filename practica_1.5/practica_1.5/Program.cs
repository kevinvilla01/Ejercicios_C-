using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Promedio de 5 materias

            // Variables
            int m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0;
            float prom = 0; 

            // Guardar valores 
            Console.WriteLine("Favor de ingresar la calificacion de la materia 1: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Favor de ingresar la calificacion de la materia 2: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Favor de ingresar la calficacion de la materia 3: ");
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Favor de ingresar la calficacion de la materia 4: ");
            m4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Favor de ingresar la calficacion de la materia 5: ");
            m5 = Convert.ToInt32(Console.ReadLine());
            // Resultado del promedio
            prom = (m1 + m2 + m3 + m4 + m5) / 5;

            //Imprimir resultado
            Console.WriteLine("El promedio es: " + prom);

            // Finalizar programa
            Console.ReadKey();
        }
    }
}
