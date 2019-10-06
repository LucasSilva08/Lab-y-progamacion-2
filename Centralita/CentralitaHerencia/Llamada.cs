using System;
using System.Text;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        //PROPIEDADES
        public abstract float CostoLlamada { get; }
        public float Duracion { get {return this._duracion; } }
        public string NroDestino { get {return this._nroDestino; }  }
        public string NroOrigen { get {return this._nroOrigen; }  }

        //CONSTRUCTOR
        public Llamada (string origen,string destino,float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        //METODOS
        protected virtual string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Duracion de la llamada:  {0}, Nro de Origen: {1},Nro de Destino: {2}", this._duracion, this._nroOrigen, this._nroDestino);
            return cadena.ToString();

        }

        //SOBRECARGAS
        public static bool operator ==(Llamada uno,Llamada dos)
        {
            bool retorno = false;
            if(uno.Equals(dos))
            {
                if(uno._nroDestino==dos._nroDestino&&uno._nroOrigen==dos._nroOrigen)
                {
                    retorno = true;
                }
            }
            
            return retorno;
        }
        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }
        public static int OrdenarPorDuracionAscendente(Llamada uno, Llamada dos)
        {
            int retorno = -1;
            if(uno._duracion>dos._duracion)
            {
                retorno = 1;
            }
            else if(uno._duracion==dos._duracion)
            {
                retorno = 0;
            }
            return retorno;
        }
        public static int OrdenarPorDuracionDescendente(Llamada uno, Llamada dos)
        {
            return -1 * OrdenarPorDuracionAscendente(uno, dos);
        }


    }
}
