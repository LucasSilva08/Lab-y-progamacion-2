using System;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera (ConsoleColor c, string m,int cant)
        {
            this.color = c;
            this.marca = m;
            this.cantidad = cant;
        }

        public string propTemperaMarca { get { return this.marca; } }
        public int propTemperaCant { get { return this.cantidad; } }
        public ConsoleColor propTemperaColor { get { return this.color; } }

        private string Mostrar ()
        {
            return "Marca: " + this.marca + "- Color: " + this.color + "-Cantidad: " + this.cantidad;
        }
        public static implicit operator string (Tempera temp)
        {
            return temp.Mostrar();
        }
        public static bool operator == (Tempera tem1, Tempera tem2)
        {
            bool retorno = false;
            if (!Object.Equals(tem1, null) && !Object.Equals(tem2, null))
            {
                if (tem1.color == tem2.color && tem1.marca == tem2.marca)
                {
                    retorno = true;

                }
            }
            else if (Object.Equals(tem1, null) && Object.Equals(tem2, null))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Tempera tem1, Tempera tem2)
        {
            
            return !(tem1 == tem2);
        }
        public static Tempera operator +(Tempera temp,int cant)
        {
            if(!Object.Equals(temp,null))
            {
              temp.cantidad +=   cant;
              
            }
            return temp;
        }
        public static Tempera operator +(Tempera temp1,Tempera temp2)
        {
            if(temp1==temp2)
            {
                temp1 = temp1 + temp2.cantidad;
            }
            return temp1;
        }
        public static Tempera operator -(Tempera temp1, int cant)
        {
            if(!Object.Equals(temp1,null))
            {
                if(cant>0)
                {
                    temp1.cantidad -= cant;
                    if(temp1.cantidad<=0)
                    {
                        temp1 = null;
                    }
                }
            }
            return temp1;
        }
        public static Tempera operator - (Tempera temp1,Tempera temp2)
        {
            if(temp1==temp2)
            {
                temp1 = temp1 - temp2.cantidad;
            }
            return temp1;

        }
          

    }
}
