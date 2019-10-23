using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_17;

namespace Clase_17.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportivo auto1 = new Deportivo(25000, "IAO PEPE", 55);
            Familiar auto2 = new Familiar(1000, "LALAL", 5);
            Console.WriteLine(Gestion.MostrarImpuestoNacional(auto1));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(auto1));
            auto1.MostrarPatente();

            Console.ReadKey();
        }
    }
}
