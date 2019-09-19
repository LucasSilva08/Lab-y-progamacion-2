using System;

namespace Clase_08.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        //PROPIEDADES//
        public int Numero
        { get
            {
                return this.numero ;
            }
        }
        public string Titulo
        { get
            {
                return this.titulo;
            }
        }
        public int Paginas
        {
            get
            {
                return this.paginas;
            }
        }
        //CONSTRUCTORES//
        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }
        private Capitulo(int numero,string titulo,int paginas)
        {
            this.numero = numero;
            this.paginas = paginas;
            this.titulo = titulo;
        }
        //SOBRECARGAS//
        public static implicit operator Capitulo(string str)
        {
            Capitulo cap = new Capitulo(Capitulo.generadorDeNumeros.Next(1,65),str,Capitulo.generadorDePaginas.Next(15,233));
            return cap;
        }
        public static bool operator ==(Capitulo capitulo1,Capitulo capitulo2)
        {
            bool retorno = false;
            if(!Object.Equals(capitulo1,null)&&!Object.Equals(capitulo2,null))
            {
                if(capitulo1.numero==capitulo2.numero&&capitulo1.titulo==capitulo2.titulo)
                {
                    retorno = true;
                }
            }
            else if( Object.Equals(capitulo1,null)&&Object.Equals(capitulo2,null))
            {
                retorno = true;
            }

            return retorno;

        }
        public static bool operator !=(Capitulo capitulo1, Capitulo capitulo2)
        {
            return !(capitulo1 == capitulo2);
        }
    }
}
