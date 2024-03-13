using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que simule un juego de apuestas, el que hay que
            // seleccionar un numero entre 1 y 10, usando la funcion random, por
            // cada turno jugado y perdido aumentar en 1 el premio.

            int elecc_human = 0, elecc_machine = 0, winpot = 1;
            char option;

            do
            {
                Console.Clear();
                Console.WriteLine("A que numero le apuestas?");
                elecc_human = Convert.ToInt32(Console.ReadLine());

                Random x = new Random();
                elecc_machine = x.Next(1, 10);

                if (elecc_human == elecc_machine)
                {
                    Console.WriteLine("Ganador!!!");
                    Console.WriteLine("Te llevaste: {0}", winpot);

                    winpot = 1;
                }

                else
                {
                    Console.WriteLine("PERDEDOR");
                    Console.WriteLine("Salio el numero: {0}", elecc_machine);
                    winpot++;
                }

                Console.WriteLine("\nQuieres volver a jugar?");
                Console.WriteLine("(Y - yes / N - No)");
                option = Convert.ToChar(Console.ReadLine());

            } while (option == 'y' || option == 'Y');

            Console.ReadKey();
            


        }
    }
}
