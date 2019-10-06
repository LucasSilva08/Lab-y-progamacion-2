using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        //PROPIEDADES//
        public List<Alumno> Alumnos { get {return this.alumnos; } }

        //CONSTRUCTOR//
        public Catedra ()
        {
            this.alumnos = new List<Alumno>();
        }
        
        //SOBRECARGAS//
        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno item in c.alumnos)
            {
                if (item == a)
                {
                    retorno= true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c==a);
        }
        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;
            if(c!=a)
            {
                c.alumnos.Add(a);
                retorno = true;
            }

            return retorno;
        }
        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = false;
            if(c==a)
            {
                c.alumnos.RemoveAt(a | c);
                retorno = true;
            }
            return retorno;
        }
        public static int operator |(Alumno a, Catedra c)
        {
            int i = -1;

            foreach (Alumno item in c.alumnos)
            {
                i++;
                if (item == a)
                {
                    return i;
                }
            }
            return -1;
        } 
    }
}
