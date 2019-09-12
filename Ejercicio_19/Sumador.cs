using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int CantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.CantidadSumas = cantidadSumas;
        }
        public Sumador():this(0)
        {

        }
        public long Sumar(long a, long b)
        {
            
            this.CantidadSumas+=1;
            return a+b;
        }
        public string Sumar (string a, string b)
        {
            
            this.CantidadSumas+=1;
            return (a+b);
        }
        public static explicit operator int(Sumador s)
        {
            return s.CantidadSumas;
        }
        public static long operator +(Sumador s1,Sumador s2)
        {
            
            return s1.CantidadSumas+s2.CantidadSumas;
        }
        public static bool operator |(Sumador s1,Sumador s2)
        {
            bool retorno=false;
            if(s1.CantidadSumas==s2.CantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
