using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace Clase_20.Test
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Empleado))]
    public class Persona:IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;
        public Persona()//siempre las colecciones \ array se inicializan en los constructores por defecto 
        {
            this.apodos = new List<string>();
        }
        public Persona(string nombre, string apellido,int edad):this()
        {
            
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }
        public override string ToString()
        {
            return this.nombre + " " + this.apellido +" Edad: " +this.edad;
        }

        public bool Guardar(string path)
        {
            bool retorno = false;
            try
            {
                XmlSerializer miXml = new XmlSerializer(typeof(Persona));
                StreamWriter tw = new StreamWriter(path);
                miXml.Serialize(tw, this);
                tw.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = false;
            }
            return retorno;
        }

        public bool Leer(string path, out object obj)
        {
            obj = null;
            bool retorno = false;
            try
            {


                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader(path);
                obj = (Persona)xml.Deserialize(sr);
                sr.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = false;
            }
            return retorno;
        }

        public int Edad { get {return this.edad; } set {this.edad=value; } }
        public List<string> ListaApodos { get {return this.apodos; } }

    }
}
