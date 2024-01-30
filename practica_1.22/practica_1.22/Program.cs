using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IMC
            float kg = 0, altura = 0, imc = 0;

            Console.WriteLine("Ingrese su altura: Ej. (1.70)");
            altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese su peso en kg: Ej. (48.5)");
            kg = Convert.ToSingle(Console.ReadLine());

            imc = (kg / (altura * altura));
            if (imc < 18.5)
            {
                Console.WriteLine("Tu IMC es: {0}", imc);
                Console.WriteLine("Estas bajo de peso");
            }
            else
            if (imc > 18.5 && imc < 24.9)
            {
                Console.WriteLine("Tu IMC es: {0}", imc);
                Console.WriteLine("Estas en peso normal");
            }
            else
            if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Tu IMC es: {0}", imc);
                Console.WriteLine("Estas en sobrepeso");
            }
            else
            if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine("Tu IMC es: {0}", imc);
                Console.WriteLine("Estas en obesidad tipo 1");
            }
            else
            if (imc >= 25 && imc > 39.9)
            {
                Console.WriteLine("Tu IMC es: {0}", imc);
                Console.WriteLine("Estas en obesidad tipo 2");
            }
            else
            {
                Console.WriteLine("tu IMC es: {0}", imc);
                Console.WriteLine("Estas en obesidad tipo 3");
            }

            Console.ReadKey();
        }
    }
}
