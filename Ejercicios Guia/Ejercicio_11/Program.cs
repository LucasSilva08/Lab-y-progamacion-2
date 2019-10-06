using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_11";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero;
            int maximo=0;
            int minimo=0;
            int suma = 0;
            float promedio;
            bool flag = true;
            int i;

            for(i=0;i<10;i++)
            {

                Console.Write("Ingrese un numero entre -100 y 100: ");
                numero = int.Parse(Console.ReadLine());

                while (Validacion.Validar(numero, -100, 100) == false)
                {
                    Console.Write("ERROR, ingrese un numero entre -100 y 100: ");
                    numero = int.Parse(Console.ReadLine());

                }
                suma = suma + numero;
                if(flag==true||numero>maximo)
                {
                    maximo = numero;
                }
                if(flag==true||numero<minimo)
                {
                    minimo = numero;
                    flag = false;
                }
                
            }
            promedio = (float)suma / 10;
            Console.WriteLine("Valor Minimo: {0}", minimo);
            Console.WriteLine("Valor Maximo: {0}", maximo);
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ReadKey();




        }
    }
}
