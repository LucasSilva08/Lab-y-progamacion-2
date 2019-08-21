using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MiClase.edad = 26;
            MiClase.nombre = "Lucas";
            MiClase.MostrarEdad();
            Console.WriteLine("Nombre: {0}", MiClase.RetornarNombre());
            if(MiClase.CompararNombres("Pedro")==true)
            {
                Console.WriteLine("Son iguales");

            }
            else
            {
                Console.WriteLine("Son Distintos");
            }
            Console.WriteLine(MiLibreria.MiClase.MostrarNombre());*/
            Sello.mensaje = "HOLA MUNDO";
            
            Console.WriteLine(Sello.imprimir());
            Sello.borrar();
            Console.WriteLine(Sello.imprimir());
            Sello.mensaje = "Holas Como estas?";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            
            
            Console.ReadLine();
        }
    }
}
