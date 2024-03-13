using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1._55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try catch
            int n1 = 0, n2 = 0, res = 0;

            try
            {
                Console.WriteLine("Ingrese num 1:");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese num 2:");
                n2 = Convert.ToInt32(Console.ReadLine());

                res = n1 + n2;

                Console.WriteLine(res);
            }
            catch (FormatException pedo_formato)
            {
                Console.WriteLine($"{pedo_formato.Message}");
            }


            catch (Exception pedo) 
            {
                Console.WriteLine("Hubo un error, el error fue "+ pedo.Message);
            }

            finally 
            {
                Console.WriteLine("Este es el finally");
            }

            Console.ReadKey();
        }

    }
}
