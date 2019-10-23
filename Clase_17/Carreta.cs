using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio):base(precio)
        {

        }

        public double CalcularImpuesto()
        {
            double impuesto;
            impuesto = (base._precio * 18) / 100;
            return impuesto;
        }
    }
}
