using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            Console.ForegroundColor = ConsoleColor.Green;

            int num;
            int i;
            int j;
            int contador = 0;

            Console.Write("Ingrese un numero mayor a 0: ");
            num = int.Parse( Console.ReadLine());

            while (num <= 0)
            {
                Console.Write("EROOR!! Reingrese un Numero mayor a 0: ");
                num = int.Parse(Console.ReadLine());

            }

            for(i=0;i<=num;i++)
            {
                for(j=1;j<=i;j++)
                {
                    if(i>0 && i%j==0)
                    {
                        contador++;
                    }
                }
                if(contador==2)
                {
                    Console.WriteLine("{0}", i);
                    contador = 0;
                }

            }



            Console.ReadLine();
        }
    }
}
