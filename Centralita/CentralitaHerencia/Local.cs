using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float _costo;

        //PROPIEDADES
        public override float CostoLlamada { get {return CalcularCosto(); }  }

        //CONSTRUCTORES
        public Local(Llamada unaLlamada,float costo):this(unaLlamada.NroOrigen, unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {

        }
        public Local(string origen, float duracion,string destino,float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        //METODOS
        private float CalcularCosto()
        {
            float total;
            total = this._duracion * this._costo;
            return total;
        }
        protected override string Mostrar ()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0}, Costo de llamada: {1}", base.Mostrar(), this.CostoLlamada);
            return cadena.ToString();

        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public override bool Equals(object obj)
        {

            return obj is Local;
        }
    }
}
