using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamada;
        protected string _razonSocial;

        //METODOS
        private void AgregarLLamada(Llamada nuevaLLamada)
        {
            this._listaDeLlamada.Add(nuevaLLamada);

        }
        public void OrdenarLLamadas()
        {
            this._listaDeLlamada.Sort(Llamada.OrdenarPorDuracion);
        }
        public float CalcularGanancia(TipoLLamada tipo)
        {
            float contador = 0;
            foreach(Llamada item in this._listaDeLlamada)
            {
                if (tipo==TipoLLamada.Local && item is Local)
                {
                    contador += ((Local)item).CostoLlamada;
                }
                else if (tipo==TipoLLamada.Provincial && item is Provincial)
                {
                    contador += ((Provincial)item).CostoLlamada;
                }
                else if ( tipo == TipoLLamada.Todas)
                {
                    if (item is Local)
                        contador += ((Local)item).CostoLlamada;
                    else if ( item is Provincial)
                        contador += ((Provincial)item).CostoLlamada;
                }
            }
            return contador;
        }
        //CONSTRUCTORES
        public Centralita ()
        {
            this._listaDeLlamada = new List<Llamada>();
        }
        public Centralita (string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }
        //SOBRECARGAS
        public static Centralita operator +(Centralita central, Llamada nuevaLLamada)
        {
            if(central!=nuevaLLamada)
            {
                central.AgregarLLamada(nuevaLLamada);
            }
            else
            {
                Console.WriteLine("La Llamada ya esta en la lista!!!");
            }
            return central;
        }
        public static bool operator ==(Centralita central, Llamada nuevaLLamada)
        {
            bool retorno = false;
            foreach(Llamada item in central._listaDeLlamada)
            {
                if(item==nuevaLLamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Centralita central, Llamada nuevaLLamada)
        {
            return !(central == nuevaLLamada);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Llamada item in this._listaDeLlamada)
            {
                if(item is  Local)
                {
                    sb.AppendLine(((Local)item).ToString());
                }
                else if (item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).ToString());
                }
            }
            return sb.ToString();
        }
        //PROPIEDADES
        public float GananciaPorLocal { get { return CalcularGanancia(TipoLLamada.Local); }  }
        public float GananciaPorProvincial { get {return CalcularGanancia(TipoLLamada.Provincial); } }
        public float GananciaTotal { get {return CalcularGanancia(TipoLLamada.Todas); } }
        public List<Llamada> LLamadas { get {return this._listaDeLlamada; } }

    }
}
