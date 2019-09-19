using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio de Bienvenida";
            Console.ForegroundColor = ConsoleColor.Green;
            int numero;
            int maximo=0;
            int minimo=0;
            int suma=0;
            float promedio;
            bool flag = true;
            int i;
            for(i=0;i<5;i++)
            {
               Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero; 
                if(flag==true|| (maximo < numero))
                {
                    maximo = numero;
                }
                if(flag==true||(minimo > numero))
                {
                    minimo = numero;
                    flag = false;
                }
                

            }
            promedio = (float)suma / i;
            Console.Write("el maximo es: {0}, el minimo es: {1}, y el promedio es: {2}", maximo, minimo, promedio);
            

            Console.ReadLine();

        }
    }
}
