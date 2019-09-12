using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_17";
            string DibujoAzul;
            string DibujoRojo;
            Boligrafo Lapicera1 = new Boligrafo(100,ConsoleColor.Blue);
            Lapicera1.Pintar(30,out DibujoAzul);
            Console.WriteLine(DibujoAzul);

            Boligrafo Lapicera2 = new Boligrafo(50, ConsoleColor.Red);
            Lapicera2.Pintar(10, out DibujoRojo);
            Console.WriteLine(DibujoRojo);



            Console.ReadKey();

        }
    }
}
