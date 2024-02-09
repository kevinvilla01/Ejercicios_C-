using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar un tipo de empleado entre, asistente , administrstivo, chofer y gerente
            // solicitar horas laboradas, asistente 45 x hora, administrstivo 60 x hr, chofer 50 x hr
            // gerente 75 xhr

            int opcion = 0, horas = 0, sueldo = 0;

            Console.WriteLine("Ingrese su chamba");
            Console.WriteLine("1. Asistente");
            Console.WriteLine("2. Administrativo");
            Console.WriteLine("3. Chofer");
            Console.WriteLine("4. Gerente");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese las horas trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());

                    sueldo = horas * 45;
                    Console.WriteLine("Usted gano: {0} pesos", sueldo);
                    break;

                case 2:
                    Console.WriteLine("Ingrese las horas trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());

                    sueldo = horas * 60;
                    Console.WriteLine("Usted gano: {0} pesos", sueldo);
                    break;

                case 3:
                    Console.WriteLine("Ingrese las horas trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());

                    sueldo = horas * 50;
                    Console.WriteLine("Usted gano: {0} pesos", sueldo);
                    break;

                case 4:
                    Console.WriteLine("Ingrese las horas trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());

                    sueldo = horas * 75;
                    Console.WriteLine("Usted gano: {0} pesos", sueldo);
                    break;

                default:
                    Console.WriteLine("No existe esa opcion");
                    break;
            }

            Console.ReadKey();

        }
    }
}
