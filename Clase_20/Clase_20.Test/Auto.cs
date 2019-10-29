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
    public class Auto: IXML
    {
        public string marca;
        public double precio;

        public Auto()
        {

        }
        public Auto(string marca,double precio)
        {
            this.marca = marca;
            this.precio = precio;
        }

        public bool Guardar(string path)
        {
            bool retorno = false;
            try
            {
                XmlSerializer miXml = new XmlSerializer(typeof(Auto));
                StreamWriter tw = new StreamWriter(path);
                miXml.Serialize(tw, this);
                tw.Close();
                retorno = true;
               
            }
            catch(Exception e)
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


                XmlSerializer xml = new XmlSerializer(typeof(Auto));
                StreamReader sr = new StreamReader(path);
                obj = (Auto)xml.Deserialize(sr);
                sr.Close();
                retorno = true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = false;
            }
            return retorno ;
        }

        public override string ToString()
        {
            return this.marca + " " + this.precio;
        }
        
    }
}
