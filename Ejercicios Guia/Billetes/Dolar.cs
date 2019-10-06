using System;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad,float cotizacion ):this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        public static explicit operator Euro (Dolar d)
        {
            Euro moneda = new Euro(d.cantidad / Euro.GetCotizacion());
            return moneda;
        }
    }
}
