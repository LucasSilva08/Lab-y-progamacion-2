using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_09";
            Console.ForegroundColor = ConsoleColor.Green;

            int altura;
            string piramide = "*";

            Console.Write("Ingrese la altura de la piramide: ");
            altura = int.Parse(Console.ReadLine());

            int i;
            for(i=0;i<altura;i++)
            {
                Console.WriteLine(piramide);
                piramide = piramide + "**";
            }
            Console.ReadKey();
        }
    }
}
