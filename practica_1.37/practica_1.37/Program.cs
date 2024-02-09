using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se necesita un sistema para calcular el costo por paciente en un hospital,
            // tomando en cuenta que por dia, si tiene la enfermadad uno el costo es de 
            //1200, enfermedad 2 1500, enfermedad 3 1700 y enfermedad 4 2100

            int opcion = 0, dia = 0, gasto = 0;

            Console.WriteLine("Que enfermedad tienes?");
            Console.WriteLine("1. Tuberculosis");
            Console.WriteLine("2. Apendisitis");
            Console.WriteLine("3. Trauma craneoencefalico");
            Console.WriteLine("4. Pancreatitis");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Cuantos dias estuviste internado?");
                    dia = Convert.ToInt32(Console.ReadLine());

                    gasto = dia * 1200;
                    Console.WriteLine("En total su deuda es de: {0}", gasto); 
                    break;

                case 2:
                    Console.WriteLine("Cuantos dias estuviste internado?");
                    dia = Convert.ToInt32(Console.ReadLine());

                    gasto = dia * 1500;
                    Console.WriteLine("En total su deuda es de: {0}", gasto);
                    break;

                case 3:
                    Console.WriteLine("Cuantos dias estuviste internado?");
                    dia = Convert.ToInt32(Console.ReadLine());

                    gasto = dia * 1700;
                    Console.WriteLine("En total su deuda es de: {0}", gasto);
                    break;

                case 4:
                    Console.WriteLine("Cuantos dias estuviste internado?");
                    dia = Convert.ToInt32(Console.ReadLine());

                    gasto = dia * 2100;
                    Console.WriteLine("En total su deuda es de: {0}", gasto);
                    break;

                default:
                    Console.WriteLine("Esquizofrenia");
                    break;
            }

            Console.ReadKey();
        }
    }
}
