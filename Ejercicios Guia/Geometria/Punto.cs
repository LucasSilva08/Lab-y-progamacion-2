using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x,int y)
        {
            this.y = y;
            this.x = x;
        }
    }
}
