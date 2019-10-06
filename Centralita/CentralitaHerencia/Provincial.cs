using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        //PROPIEDADES

        public override float CostoLlamada { get {return CalcularCosto(); } }

        //CONSTRUCTORES
        public Provincial(Franja miFranja,Llamada unallamada):this(unallamada.NroOrigen,miFranja,unallamada.Duracion,unallamada.NroDestino)
        {

        }
        public Provincial (string origen, Franja miFranja,float duracion,string destino):base(origen,destino,duracion)
        
        {
            this._franjaHoraria = miFranja;

        }

        //METODOS
        private float CalcularCosto()
        {
            float precio=0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    precio = 0.99f;
                    break;
                case Franja.Franja_2:
                    precio = 1.25f;
                    break;
                case Franja.Franja_3:
                    precio = 0.66f;
                    break;
                default:
                    break;
            }

            return base._duracion * precio;
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }
        protected override string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("{0},La Franja Horaria: {1}, El Costo de Llamada: {2}", base.Mostrar(), this._franjaHoraria, this.CostoLlamada);
            return cadena.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
