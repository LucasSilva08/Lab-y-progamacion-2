using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta():this(5)
        {
            //this.cantidadMaximaColores = 5;
            
            //this.colores = new Tempera[this.cantidadMaximaColores];
                       
        }
        private Paleta(int CantidadElementos)
        {
            this.colores = new Tempera[CantidadElementos];
            this.cantidadMaximaColores = CantidadElementos;
            
        }
        public static implicit operator Paleta(int cantidad)
        {
            Paleta Pal;
            Pal = new Paleta(cantidad);
            return Pal;
            
        }
        private string Mostrar ()
        {
            string resultado = "";
            for(int i=0;i<this.colores.Length;i++)
            {
                resultado += this.colores[i];
            }


            return resultado+"-Cantidad: "+ this.cantidadMaximaColores; 
        }
        public static explicit operator string (Paleta Pal)
        {
            return Pal.Mostrar();

        }
        public static bool operator == (Paleta Pal, Tempera temp)
        {
            bool retorno = false;
            int largo = Pal.cantidadMaximaColores;
            if( !Object.Equals(Pal,null) && !Object.Equals(temp,null))
            {

                for (int i = 0; i < largo; i++)
                {
                    if (Pal.colores[i] == temp)
                    {
                        retorno = true;
                        break;
                    }
                }

            }
            else
            {
                retorno = Object.Equals(Pal, temp);
            }
            
            return retorno;

        }
        public static bool operator !=(Paleta Pal, Tempera temp)
        {
            return !(Pal == temp);
        }
        private int ObtenerLugarLibre()
        {
            int lugarLibre=-1;
            int i;
            for (i=0;i<this.cantidadMaximaColores;i++)
            {
                if(this.colores[i]==null)
                {
                    lugarLibre = i;
                    break;
                }
            }
            return lugarLibre; 
        }
        private int ObtenerLugarDeTempera(Tempera temp)
        {
            int indice=-1;
            int i;
            for(i=0;i<this.cantidadMaximaColores;i++)
            {
                if(this.colores[i]==temp)
                {
                    indice = i;
                    break;
                }
            }
            return indice;

        }
        public static Paleta operator +(Paleta pal,Tempera temp)
        {
            int index;
            if(!(pal==temp))
            {
                index = pal.ObtenerLugarLibre();
                if(index!=-1)
                {
                    pal.colores[index] = temp;
                }
            }
            else
            {
                index = pal.ObtenerLugarDeTempera(temp);
                if(index!=-1)
                {
                    pal.colores[index] += temp;
                }
            }
            return pal;
        }
        public static int operator |(Paleta pal, Tempera temp)
        {
            int indice=-1;
            int i;
            for(i=0; i<pal.cantidadMaximaColores;i++)
            {
                if(pal==temp)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        
    }
}
