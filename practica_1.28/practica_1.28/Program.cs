using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._28
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Promedio alumno que cursa 5 materias 
            // menor de 70 - reprobado
            // mayor q 70 y menor o igual q 80 - regular
            // mayot q 80 y >- 90 - bien
            // mayot 90 < 100 muy bien
            // == 100 excelente

            int mat1 = 0, mat2 = 0, mat3 = 0, mat4 = 0, mat5 = 0;
            float prom = 0;

            Console.WriteLine("Ingrese sus calificaciones: ");
            Console.WriteLine("Materia 1: ");
            mat1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Materia 2: ");
            mat2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Materia 3: ");
            mat3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Materia 4: ");
            mat4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Materia 5: ");
            mat5 = Convert.ToInt32(Console.ReadLine());

            // PROMEDIO
            prom = (mat5 + mat4 + mat3 + mat2 + mat1) / 5;

            if (prom < 70)
            {
                Console.WriteLine("Tu promedio es {0}, Reprobado", prom);
            }
            else
            if (prom >= 70 && prom <= 80)
            {
                Console.WriteLine("Tu promedio es {0}, Regular", prom);
            }
            else
            if (prom > 80 && prom <= 90)
            {
                Console.WriteLine("Tu promedio es {0}, Bien", prom);
            }
            else
            if (prom > 90 && prom < 100)
            {
                Console.WriteLine("Tu promedio es {0], Muy bien", prom);
            }
            else
            if (prom == 100)
            {
                Console.WriteLine("Tu promedio es {0], Excelente", prom);
            }

            Console.ReadKey();

        }
    }
}
