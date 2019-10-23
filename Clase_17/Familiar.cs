using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public class Familiar: Auto
    {
        protected int _cantAsientos;

        public Familiar(double precio, string patente,int cantidadAsientos):base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;

        }
    }
}
