using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona miPersona;
            miPersona = new Persona("Matias","Silva",37180858);
            //miPersona.nombre = "Lucas";
            //miPersona.apellido = "Silva";
            //miPersona.dni = 37180858;

            Persona otraPersona;
            otraPersona = new Persona("Pedro","Perez",27856967);
            //otraPersona.nombre = "Pedro";
            //otraPersona.apellido = "Perez";
            //otraPersona.dni = 27856967;

            Console.WriteLine(miPersona.Mostrar());
            Console.WriteLine(otraPersona.Mostrar());   
            Console.ReadKey();
        }
    }
}
