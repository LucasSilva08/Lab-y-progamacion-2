using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class AlumnoCalificado : Alumno
    {
        protected double nota;

        //PROPIEDADES//
        public double Nota { get {return this.nota; } }

        //CONSTRUCTORES//
        public AlumnoCalificado(Alumno a, double nota):this(a.Nombre,a.Apellido,a.Legajo,a.Examen,nota)
        {

        }
        public AlumnoCalificado(string nombre,string apellido,int legajo,ETipoExamen examen,double nota) : base(nombre,apellido,legajo,examen)
        {
            this.nota = nota;

        }
        //METODO//
        public string Mostrar()
        {
            return Alumno.Mostrar(this) + " Nota: " + this.nota;
        }
    }
}
