using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase4.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cosa obj1 = new Cosa();
            DateTime f = new DateTime(2018, 05, 23);
            DateTime f2 = new DateTime(1993, 02, 23);
            //Objeto.EstablecerValor("Hola");
            //Objeto.EstablecerValor(2);
            //Objeto.EstablecerValor(DateTime.Now);
            
            Console.WriteLine(obj1.Mostrar());

            Cosa obj2 = new Cosa("Lucas");
            Console.WriteLine(obj2.Mostrar());

            Cosa obj3 = new Cosa("Pedro",f);
            Console.WriteLine(obj3.Mostrar());

            Cosa obj4 = new Cosa("Julio", f2, 4);
            Console.WriteLine(obj4.Mostrar());
            Console.ReadKey();

            
        }
    }
}
