using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercici_12";
            Console.ForegroundColor = ConsoleColor.Green;
            int num1;
            int num2;
            int suma;
            char respuesta;

            do
            {
                Console.Write("Ingrese el primer numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());

                suma = num1 + num2;

                Console.WriteLine("La suma es: {0}", suma);

                Console.Write("Desea seguir sumando numeros?(s/n): ");
                respuesta = char.Parse(Console.ReadLine());

            }
            while (ValidarRespuesta.ValidarS_N(respuesta) == true);

            Console.ReadKey();

        }
    }
}
