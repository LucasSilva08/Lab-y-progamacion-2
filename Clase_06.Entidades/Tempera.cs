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
            if (!tem1.Equals(null) && !tem2.Equals(null))
            {
                if (tem1.color == tem2.color && tem1.marca == tem2.marca)
                {
                    retorno = true;

                }
            }
            return retorno;
        }
        public static bool operator !=(Tempera tem1, Tempera tem2)
        {
            
            return !(tem1 == tem2);
        }
        public static Tempera operator +(Tempera temp,int cant)
        {
            if(!temp.Equals(null))
            {
              temp.cantidad = temp.cantidad + cant;
              
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
            

    }
}
