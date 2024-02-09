using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Obtener un numero entre 1 y siete y mostrar el dia de la senana correspondiente


            int day = 0;
            Console.WriteLine("Escriba un numero entre 1 y 7");
            day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sabado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;


                default:
                    Console.WriteLine("1 al 7 pendejo");
                    break;
            }

            Console.ReadKey();
        }
    }
}
