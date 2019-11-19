using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase24;
//using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace TestClase24
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Lucas", "Silva", 37180858);
            //Extencion p2 = new Extencion("Lucas", "Silva", 26, ESexo.Masculino);
            PersonaExternaSellada p2 = new PersonaExternaSellada("Lucas", "Silva", 26, ESexo.Masculino);
            
            Console.WriteLine( p2.ObtenerInfo());

            //Console.WriteLine("{0}, {1} - {2} Años, {3}", p2.Apelldio, p2.Nombre, p2.Edad, p2.Sexo);
            Console.WriteLine(p1.ObtenerInfo());
            Console.ReadKey();
        }
    }
}
