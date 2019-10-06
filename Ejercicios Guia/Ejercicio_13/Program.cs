using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_13";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero;
            string cadena;

            Console.Write("Ingrese un numero decimal: ");
            numero = int.Parse(Console.ReadLine());


            Console.WriteLine(Conversor.DecimalBinario(numero));

            Console.Write("Ingrese un numero Binario: ");
            cadena = Console.ReadLine();
            Console.WriteLine(Conversor.BinarioDecimal(cadena));

  

            Console.ReadKey();
                
          
        }
    }
}
