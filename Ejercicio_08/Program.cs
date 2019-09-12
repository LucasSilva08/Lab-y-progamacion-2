using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_08";
            Console.ForegroundColor = ConsoleColor.Green;

            int valorHora;
            string nombre;
            int anioTrabajados;
            int cantHrsTrabajadas;
            int sueldoBruto;
            float descuento;
            float sueldoNeto;
            string seguir;

            do
            {
                Console.Write("Ingrese Nombre del Trabajador: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el Valor de sus Horas Trabajadas: ");
                valorHora = int.Parse(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas en el Mes: ");
                cantHrsTrabajadas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese Anios Trabajados: ");
                anioTrabajados = int.Parse(Console.ReadLine());

                sueldoBruto = (valorHora * cantHrsTrabajadas) + (anioTrabajados * 150);
                descuento = (float)sueldoBruto * 13 / 100;
                sueldoNeto = (float)sueldoBruto - descuento;

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0} Anios", anioTrabajados);
                Console.WriteLine("Valor Hora: $ {0}", valorHora);
                Console.WriteLine("Sueldo Bruto: $ {0}", sueldoBruto);
                Console.WriteLine("Total Descuento: $ {0}",descuento);
                Console.WriteLine("Sueldo Neto: $ {0}", sueldoNeto);

                Console.Write("Desea Cargar Otro Empleado?(s/n): ");
                seguir = Console.ReadLine();



            } while (seguir == "s" || seguir == "S");

            Console.ReadKey();
           
        }
    }
}
