using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clase24
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        // con propiedades
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Dni { get { return this.dni; } }
        //con metodos
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public int GetDni()
        {
            return this.dni;
        }

        //Metodo para encapsular 
        public string ObtenerInfo()
        {
            return String.Format("{0}, {1} - DNI: {2}", this.apellido, this.nombre, this.dni);
        }



    }
}
