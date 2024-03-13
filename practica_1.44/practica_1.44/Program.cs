using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Juego dw dados entre 2 jugadores

            int points1 = 0, points2 = 0, turn = 1, res_dado;
            string name1 = "", name2 = "";

            Console.WriteLine("Bienvenido al juego de dados c:");
            Console.WriteLine("Ingrese el nombre del jugador 1:");
            name1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2:");
            name2 = Console.ReadLine();

            do
            {
                // Turno jugador 1
                Console.WriteLine("\nEs el turno {0} del jugador {1}.", turn, name1);
                Console.WriteLine("Presione enter para tirar el dado");
                Console.ReadLine();

                // Crear objeto de tipo random
                Random dado = new Random();
                res_dado = dado.Next(1, 6);
                points1 = points1 + (int)res_dado;
                Console.WriteLine("El dado saco {0}", res_dado);
                Console.WriteLine("El jugador {0} lleva {1} puntos", name1, points1);

                // Turno jugador 2
                Console.WriteLine("\nEs el turno {0} del jugador {1}.", turn, name2);
                Console.WriteLine("Presione enter para tirar el dado");
                Console.ReadLine();
                res_dado = dado.Next(1, 6);
                points2 = points2 + (int)res_dado;
                Console.WriteLine("El dado saco {0}", res_dado);
                Console.WriteLine("El jugador {0} lleva {1} puntos", name2, points2);

                turn++;
            } while (turn <= 3);

            if (points1 > points2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl ganador es {0}", name1);
            }

            else if (points2 > points1) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEl jugador es {0}", name2);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEMPATE");
            }

            Console.WriteLine("\nEl puntaje final fue: {0} vs {1}", points1, points2);

            Console.ReadKey();



        }
    }
}
