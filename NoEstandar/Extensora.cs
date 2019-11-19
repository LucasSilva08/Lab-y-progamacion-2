using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase24;
using Entidades.Externa.Sellada;

namespace NoEstandar
{
    public class Extensora
    {
        public static string ObtenerInfo(this PersonaExternaSellada p1)
        {
            return String.Format("{0}, {1} - {2} Anios - {3}", p1.Apellido, p1.Nombre, p1.Edad, p1.Sexo);
        }
        public static bool EsNulo(this Object obj)
        {
            return (obj == null);
        }
        public static List<Persona> ObtenerListado(this Persona)
        {


        }
    }
}
