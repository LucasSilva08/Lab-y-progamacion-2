using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            Console.ForegroundColor = ConsoleColor.Green;

            int num;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un Numero Mayor a 0: ");
            num = int.Parse(Console.ReadLine());
             while (num <= 0)
            {
                Console.Write("EROOR!! Reingrese un Numero mayor a 0: ");
                num = int.Parse(Console.ReadLine());

            }

            cuadrado =  Math.Pow(num,2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine("El cuadrado de {0} es {1}", num, cuadrado);
            Console.WriteLine("El cubo de {0} es {1}", num, cubo);
            Console.ReadLine();
            
                

            


        }
    }
}
