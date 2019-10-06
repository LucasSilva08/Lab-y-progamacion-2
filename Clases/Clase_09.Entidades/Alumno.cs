using System;

namespace Clase_09.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected string nombre;
        protected int legajo;
        protected ETipoExamen examen;

        //PROPIEDADES//
        public string Apellido { get {return this.apellido; } }
        public string Nombre { get {return this.nombre; } }
        public int Legajo { get {return this.legajo; } }
        public ETipoExamen Examen { get {return this.examen; } }
        
        //CONSTRUCTORES//
        public Alumno(string nombre,string apellido,int legajo,ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }
        //METODOS//
        public static string Mostrar(Alumno a)
        {
            return "Nombre: " + a.nombre+ " Apellido: "+ a.apellido+ " Legajo: "+a.legajo+" Examen: "+a.examen;
        }
        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {

            return String.Compare(a.apellido, b.apellido);
        }
        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorApellidoAsc(a, b);
        }
        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            int retorno = -1;
            if(a.legajo>b.legajo)
            {
                retorno = 1;
            }
            else if( a.legajo==b.legajo)
            {
                retorno = 0;
            }
            return retorno;

        }
        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return -1*OrdenarPorLegajoAsc(a,b);
        }
        //SOBRECARGAS//
        public static bool operator ==(Alumno a,Alumno b)
        {
            bool retorno = false;
            if(!Object.Equals(a,null)&&!Object.Equals(b,null))
            {
                if(a.legajo==b.legajo)
                {
                    retorno = true;
                }
            }
            else if(Object.Equals(a, null) && Object.Equals(b, null))
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }
    }
}
