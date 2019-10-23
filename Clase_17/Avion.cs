using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public class Avion:Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;

        public Avion (double precio,double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;

        }

         double IAFIP.CalcularImpuesto()
        {
            double impuesto;
            impuesto = (base._precio * 33) / 100;
            return impuesto;
        }

        double IARBA.CalcularImpuesto()
        {
            double impuesto;
            impuesto = (base._precio * 27) / 100;
            return impuesto;
        }
    }
}
