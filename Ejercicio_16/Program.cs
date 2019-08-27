using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1;
            alumno1 = new Alumno();
            Alumno alumno2;
            alumno2 = new Alumno();
            Alumno alumno3;
            alumno3 = new Alumno();

            alumno1.apellido = "Lopez";
            alumno1.legajo = 108580;
            alumno1.nombre = "Martin";

            alumno2.apellido = "Argento";
            alumno2.legajo = 186968;
            alumno2.nombre = "Jorge";

            alumno3.apellido = "koko";
            alumno3.legajo = 180589;
            alumno3.nombre = "Pedro";


        }
    }
}
