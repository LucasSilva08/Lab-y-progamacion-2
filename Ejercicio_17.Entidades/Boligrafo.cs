using System;

namespace Ejercicio_17.Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            Console.ForegroundColor = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            if (this.tinta < 100 && this.tinta > 0)
            {
                if (tinta > 0)
                {
                    this.tinta += tinta;
                }
                else
                {
                    this.tinta -= tinta;
                }
            }
        }
        public void Recargar()
        {
            while (this.tinta < 100)
            {
                SetTinta(this.tinta);
            }
        }
        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            if (gasto < 100)
            {
                if ((this.tinta - gasto) > 0)
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        dibujo = dibujo + "*";

                    }
                    retorno = true;
                }

            }
            return retorno;
        }
    }
}
