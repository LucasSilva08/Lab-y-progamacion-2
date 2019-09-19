using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_05.Entitades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma ()
        {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidad = 0;

        }
        public Pluma (string marca):this()
        {
            this.marca = marca;
        }
        public Pluma (string marca, Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad):this (marca,tinta)
        {
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "Marca: " + this.marca + Tinta.Mostrar(this.tinta) + "Cantidad: " + this.cantidad;

        }
        public static implicit operator string (Pluma total)
        {
            return total.Mostrar();
        }
        public static bool operator == (Pluma c, Tinta tinta)
        {
            return (c.tinta == tinta);             
        }
        public static bool operator !=(Pluma c, Tinta tinta)
        {
            return !(c == tinta);
        }
        public static Pluma operator + (Pluma c, Tinta tinta)
        {
            if (c.tinta==tinta && c.cantidad<=100)
            {
                c.cantidad++;
            }
            return c;
        }

    }
}
