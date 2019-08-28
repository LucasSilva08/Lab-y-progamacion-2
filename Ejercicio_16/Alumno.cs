using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            Random r = new Random();
            notaFinal = -1;
            if (nota1>=4 && nota2>=4)
            {
                notaFinal = (float)r.Next(1, 10);
                
            }

        }
        public void Estudiar (byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }
        public string Mostrar()
        {
            if (notaFinal!=-1)
            {
                return this.nombre + "-" + this.apellido + "-" + this.legajo + " - Nota Final: " + this.notaFinal;

            }
            else
            {
                return this.nombre + "-" + this.apellido + "-" + this.legajo + " - Alumno Desaprobado";
            }
        }
            
    }
}
