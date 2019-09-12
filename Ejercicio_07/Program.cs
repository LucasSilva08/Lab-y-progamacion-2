using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_07";
            Console.ForegroundColor = ConsoleColor.Green;

            DateTime fechaNacimiento;
            DateTime fechaActual;
            TimeSpan diferencia;

            Console.Write("Ingrese Fecha de nacimiento(dd/mm/aaaa): ");
            fechaNacimiento = DateTime.Parse(Console.ReadLine());
            fechaActual = DateTime.Now;
            diferencia = fechaActual - fechaNacimiento;
            Console.WriteLine("Los dias vividos hasta la fecha es: {0}", diferencia.Days);
            Console.ReadKey();
        }
    }
}
