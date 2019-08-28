using System;

namespace Clase4.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;


        public string Mostrar()
        {
            return this.entero + "-" + this.cadena + "-" + this.fecha;
        }
        //metodos de instancia sobrecargados
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin Valor";
            this.fecha = DateTime.Now;

        }
        // constuctores sobrecargados
        public Cosa(string cadena):this()
        {
            this.cadena = cadena;  
        }
        public Cosa(string cadena,DateTime fecha):this(cadena)
        {
            this.fecha = fecha;
        }
        public Cosa(string cadena, DateTime fecha, int entero):this(cadena,fecha)
        {
            this.entero = entero;
        }


    }
}
