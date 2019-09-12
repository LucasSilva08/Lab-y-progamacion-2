using System;
using System.Collections.Generic;
using System.Text;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro ()
        {
            Euro.cotizRespectoDolar = (float)1.16;

        }
        public Euro(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad,float cotizacion):this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
    }
}
