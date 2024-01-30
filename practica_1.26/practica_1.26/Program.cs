using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular velocidad
            int opcion = 0;
            float vel = 0, dist = 0, tiempo = 0;

            Console.WriteLine("Bienvenido al programa, escoja una opcion: ");
            Console.WriteLine("1. Velocidad");
            Console.WriteLine("2. Distancia");
            Console.WriteLine("3. Tiempo");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                // Calcular velocidad

                Console.WriteLine("Ingrese el valor de la distancia (km): ");
                dist = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del tiempo (horas): ");
                tiempo = Convert.ToSingle(Console.ReadLine());

                vel = dist / tiempo;
                Console.WriteLine("La velocidad es {0}", vel);
            }
            else
            if (opcion == 2)
            {
                // Calcular distancia

                Console.WriteLine("Ingrese el valor de la velocidad (km/h): ");
                vel = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del tiempo (horas): ");
                tiempo = Convert.ToSingle(Console.ReadLine());

                dist = vel * tiempo;
                Console.WriteLine("La distancia es {0}", dist);
            }
            else
            if (opcion == 3)
            {
                // Calcular tiempo

                Console.WriteLine("Ingrese el valor de la distancia (km): ");
                dist = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingrese el valor del velocidad (km/h): ");
                vel = Convert.ToSingle(Console.ReadLine());

                tiempo = dist / vel;
                Console.WriteLine("La velocidad es {0}", tiempo);
            }

            else
            {
                Console.WriteLine("Solo hay tres opciones.");
            }

            Console.ReadKey();
        }
    }
}
