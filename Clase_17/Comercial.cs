using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public class Comercial:Avion
    {
        protected int _cantidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros):base(precio,velocidad)
        {
            this._cantidadPasajeros = pasajeros;
        }
    }
}
