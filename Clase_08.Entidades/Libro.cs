using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_08.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        //PROPIEDADES//
        public string TITULO { get {return this.titulo; } }
        public string AUTOR { get {return this.autor; } }
        public int CantidadPagina
        {
            get
            {
                int cantidad = 0;
                foreach (Capitulo c in capitulos)
                {
                    cantidad += c.Paginas;
                }
                return cantidad;
            }
        }
        public int CantidadDeCapitulos { get {return this.capitulos.Count; } }
        //CONSTRUCTOR//
        public Libro(string titulo,string autor)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.capitulos = new List<Capitulo>();
        }
        //INDEXADOR EN LIRBO
        public Capitulo this[int index]
        {
            get
            {
                Capitulo cap = null;
                if(index>0||index<this.capitulos.Count+1)
                {
                    cap = this.capitulos[index];
                }
                return cap;

            }
            set
            {
                if(index>0)
                {
                    if(index<this.capitulos.Count+1)
                    {
                        this.capitulos[index] = value;
                    }
                    else
                    {
                        this.capitulos.Add(value);
                    }

                }

            }
        }
    }
    

}
