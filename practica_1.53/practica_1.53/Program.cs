using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa q solicite num alumnos, num_ materias, solicitenombre de cada alumno, mostrar promedio de cada alumno,
            // y promedio grupal

            int num_alumnos = 0, num_materias = 0;
            float promedio_g = 0, prom_alumno = 0;

            Console.WriteLine("Ingrese el numero de alumnos: ");
            num_alumnos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas materias llevan");
            num_materias = Convert.ToInt32(Console.ReadLine());

            string[] nombres_a = new string[num_alumnos];
            float[] cal_materias = new float[num_materias];

            for (int pos = 0; pos < nombres_a.Length; pos++)
            {
                prom_alumno = 0;
                Console.WriteLine("Escriba el nombre del alumno");
                nombres_a[pos] = Console.ReadLine();

                for (int pos2 = 0; pos2 < cal_materias.Length; pos2++)
                {
                    Console.WriteLine("Escriba la calificacion de la materia {0} que saco {1]", pos2+1, nombres_a[pos]);
                    cal_materias[pos2] = Convert.ToSingle(Console.ReadLine());
                    prom_alumno = prom_alumno + cal_materias[pos2];
                }

                prom_alumno = prom_alumno / num_materias;
                Console.WriteLine("El promedio del alumno {0} es {1}", nombres_a[pos], prom_alumno);
                promedio_g = promedio_g + prom_alumno;
            }

            promedio_g = promedio_g / num_alumnos;
            Console.WriteLine("El promedio grupal es: {0}", promedio_g);

            Console.ReadKey();
        }
    }
}
