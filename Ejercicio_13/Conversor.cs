using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            string cadena="";
            if(numero>0)
            {
                

                while(numero>0)
                {
                    if(numero%2==0)
                    {
                        cadena = "0" + cadena;

                    }
                    else
                    {
                        cadena = "1" + cadena;

                    }
                    numero = (int)(numero / 2);
                }
            }
            else if (numero==0)
            {
                cadena = "0";
            }
            return cadena;
            

          
        }
        public static int BinarioDecimal(string cadena)
        {
            int exponente = cadena.Length - 1;
            int numero = 0;
            int i;
            
            for (i=0;i<cadena.Length;i++)
            {
                if(int.Parse(cadena.Substring(i,1))==1)
                {
                    numero = numero + int.Parse(Math.Pow(2, double.Parse(exponente.ToString())).ToString());
                }
                exponente--;
            }

            return numero;
        }
    }
}
