using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_06";
            Console.ForegroundColor = ConsoleColor.Green;

            int anioInicio;
            int anioFinal;

            Console.Write("Ingrese Anio de Inicio: ");
            anioInicio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Anio de Fin: ");
            anioFinal = int.Parse(Console.ReadLine());

            int i;
            for(i=anioInicio;i<=anioFinal;i++)
            {
                if((i%4==0 && i%100!=0)||(i%400==0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}
