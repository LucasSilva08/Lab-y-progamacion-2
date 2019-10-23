using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
