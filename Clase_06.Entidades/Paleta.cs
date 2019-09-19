using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        public int CantidadMaxima
        {
            get
            {
                return this.cantidadMaximaColores;
            }
        }


        private Paleta() : this(5)
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
        private string Mostrar()
        {
            string resultado = "";
            for (int i = 0; i < this.colores.Length; i++)
            {
                if (!Object.Equals(this.colores[i], null))
                {
                    resultado += this.colores[i];
                }

            }


            return resultado;  //"-Cantidad: " + this.cantidadMaximaColores;
        }
        public static explicit operator string(Paleta Pal)
        {
            return Pal.Mostrar();

        }
        public static bool operator ==(Paleta Pal, Tempera temp)
        {
            bool retorno = false;
            
            if (!Object.Equals(Pal, null) && !Object.Equals(temp, null))
            {

                for (int i = 0; i < Pal.colores.Length; i++)
                {
                    if (Pal.colores[i] == temp)
                    {
                        retorno = true;
                        break;
                    }
                }

            }
            else if (Object.Equals(Pal, null) && Object.Equals(temp, null))
            {
                retorno = true;
            }

            return retorno;

        }
        public static bool operator !=(Paleta Pal, Tempera temp)
        {
            return !(Pal == temp);
        }
        private int ObtenerLugarLibre()
        {
            int lugarLibre = -1;
            int i;
            for (i = 0; i < this.colores.Length; i++)
            {
                if (this.colores[i] == null)
                {
                    lugarLibre = i;
                    break;
                }
            }
            return lugarLibre;
        }
        
        public static Paleta operator +(Paleta pal, Tempera temp)
        {
            int index;
            if (pal == temp)
            {
                index = pal | temp;
                if (index != -1)
                {
                    pal.colores[index] += temp;
                }
            }
            else
            {
                index = pal.ObtenerLugarLibre();
                if (index != -1)
                {
                    pal.colores[index] = temp;
                }
            }
            return pal;
        }
        public static int operator |(Paleta pal, Tempera temp)
        {
            int indice = -1;
            int i;
            for (i = 0; i < pal.colores.Length; i++)
            {
                if (pal == temp)
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        public static Paleta operator -(Paleta pal, Tempera temp)
        {
            int indice = -1;
            if (pal == temp)
            {
                indice = pal | temp;
                {
                    if (indice != -1)
                    {
                        pal.colores[indice] -= temp;
                    }
                }
            }
            return pal;
        }
        public Tempera this[int index]
        {
            get
            {
                return this.colores[index];
            }

            set
            {
                this.colores[index] = value;
            }
        }
    }
}
