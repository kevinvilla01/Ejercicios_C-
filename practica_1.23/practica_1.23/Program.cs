﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Traductor de numeros, ingles y frances
            int num = 0;

            Console.WriteLine("Ingrese un numero del uno al diez: Ej. (8)");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("Zero/Zero");
            }
            else
            if (num == 1)
            {
                Console.WriteLine("One/Un");
            }
            else
            if(num == 2)
            {
                Console.WriteLine("Two/Deux");
            }
            else
            if (num == 3)
            {
                Console.WriteLine("Three/Trois");
            }
            else
            if (num == 4)
            {
                Console.WriteLine("Four/Quatre");
            }
            else
            if (num == 5)
            {
                Console.WriteLine("Five/Cinq");
            }
            else
            if (num == 6)
            {
                Console.WriteLine("Six/Six");
            }
            else
            if (num == 7)
            {
                Console.WriteLine("Seven/Sept");
            }
            else
            if (num == 8)
            {
                Console.WriteLine("Eight/Huit");
            }
            else
            if (num == 9)
            {
                Console.WriteLine("Nine/Neuf");
            }
            else
            if (num == 10)
            {
                Console.WriteLine("Ten/Dix");
            }

            Console.ReadKey();
        }
    }
}
