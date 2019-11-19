using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Externa;

namespace Entidades.Clase24
{
    public class Extencion : PersonaExterna
    {
        public Extencion(string nombre,string apellido, int edad,ESexo sexo):base(nombre,apellido,edad,sexo)
        {

        }
        public string Nombre { get {return base._nombre; } }
        public  string Apelldio { get {return base._apellido; } }
        public int Edad { get {return base._edad; } }
        public ESexo Sexo { get {return base._sexo; } }

    }
}
