using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public class Deportivo : Auto,IAFIP,IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio,string patente,int hp):base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

         double IAFIP.CalcularImpuesto()
        {
            double impuesto;
            impuesto = (base._precio * 28) / 100;
            return impuesto;
        }

        double IARBA.CalcularImpuesto()
        {
            double impuesto;
            impuesto = (base._precio * 23) / 100;
            return impuesto;
        }
    }
}
