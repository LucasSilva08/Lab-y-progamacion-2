using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_19";
            Console.ForegroundColor = ConsoleColor.Green;

            long cantidadSuma;
            Sumador prueba = new Sumador(2);
            Console.WriteLine(prueba.Sumar(2,3));
            Console.WriteLine(prueba.Sumar("Lucas", "Hola"));
            

            Sumador prueba2 = new Sumador(2);
            //cantidadSuma = (int)prueba2;
            //Console.WriteLine(cantidadSuma);
            cantidadSuma = prueba + prueba2;
            Console.WriteLine(cantidadSuma);
            Console.WriteLine(prueba | prueba2);



            Console.ReadKey();
        }
    }
}
