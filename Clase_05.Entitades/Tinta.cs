using System;

namespace Clase_05.Entitades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            _tipo = ETipoTinta.comun;
        }
        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }

        private string Mostrar()
        {
            return "El color: " + this._color + "-tipo: " + this._tipo;
        }
        public static string Mostrar(Tinta laTinta)
        {
            return laTinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1,Tinta tinta2)

            {
              bool retorno = false;
              if (Object.Equals(tinta1,null)&&(Object.Equals(tinta2,null)))
            {
                if((tinta1._color==tinta2._color)&&(tinta1._tipo==tinta2._tipo))
                {
                retorno = true;

                }
            }
              else
            {

            }
               return retorno;
              

            }
        public static bool operator !=(Tinta tinta1,Tinta tinta2)
        {
            return !(tinta1 == tinta2);

        }
        public static bool operator ==(Tinta tinta,ConsoleColor color)
        {
            bool retorno = false;
            if(tinta._color==color)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Tinta tinta,ConsoleColor color)
        {
            return !(tinta == color);
        }
        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }
            

         
    }
}
