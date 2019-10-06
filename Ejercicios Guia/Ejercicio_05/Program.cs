using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio_05";
            Console.ForegroundColor = ConsoleColor.Green;

            int numero;
            Console.Write("Ingrese un Numero: ");
            numero = int.Parse(Console.ReadLine());

            int aumento = 1;
            int i;
            int j;
            int sumaAtras;
            int sumaAdelante;


           
                while(aumento<numero)
                {
                    aumento++;
                    sumaAtras = 0;
                    sumaAdelante = 0;

                    for(i=1;i<aumento;i++)
                    {
                        sumaAtras = sumaAtras + i;
                    }
                    for(j=aumento+1;j<=sumaAtras;j++)
                    {
                        if((sumaAdelante==sumaAtras)||(sumaAdelante>sumaAtras))
                        {
                            break;
                        }
                        sumaAdelante = sumaAdelante + j;
                    }
                    if(sumaAdelante==sumaAtras)
                    {
                        Console.WriteLine(aumento);
                    }
                }
                Console.ReadKey();


            }
        }
    }

