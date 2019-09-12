using System;
using System.Collections.Generic;
using System.Text;

namespace Billetes
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar=38.33f;

        }
        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad,float cotizacion):this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
    }
}
