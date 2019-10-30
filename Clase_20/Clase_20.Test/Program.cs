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
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Persona> lista = new List<Persona>();
            Persona miPersona = new Persona("Juan", "Perez",20);
            Persona otraPersona = new Persona("Lucas", "Silva",26);
            lista.Add(miPersona);
            lista.Add(otraPersona);
            miPersona.ListaApodos.Add("Toto");
            miPersona.ListaApodos.Add("Locura");
            otraPersona.ListaApodos.Add("Fierrito");
            otraPersona.ListaApodos.Add("Pocho");
            Console.WriteLine(miPersona.ToString());
            try
            {

                XmlSerializer miXml = new XmlSerializer(typeof(Persona));
                StreamWriter tw = new StreamWriter(@"D:\VisualStudio\Clase_20\persona.xml");// con text write // no utilizar el True para q pueda sobre Escribir el archivo y no agregar informacion
                //XmlTextWriter twr = new XmlTextWriter(@"D:\VisualStudio\Clase_20\persona.xml", Encoding.UTF8);//con XmlTextWrite 
                // USO SOLAMENTE UNO
                miXml.Serialize(tw, miPersona);//TextWrite
                tw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                XmlSerializer otroXml = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader(@"D:\VisualStudio\Clase_20\persona.xml");
                miPersona=(Persona)otroXml.Deserialize(sr);// devuelve un obj con el valor del tipo Persona, es decir el tipo de dato especificado cuando instancio el Serialaizer
                sr.Close();
                Console.WriteLine(miPersona.ToString());

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sr1 = new StreamWriter(@"D:\VisualStudio\Clase_20\listaPersona.xml");
                xml.Serialize(sr1, lista);
                sr1.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            //las clases serializan y deserializan por si mismas

            /*Auto miAuto=new Auto("Chevrolet",15000);
            object otroAuto=null;
            Persona miPersona = new Persona("Lucas", "Silva",20);
            Serializadora.Serializar(miAuto);
            //Serializadora.Serializar(miPersona);
            if(Serializadora.Deserializar(miAuto,out otroAuto)==true)
            {
                Console.WriteLine(((Auto)otroAuto).ToString());
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }*/
            List<Persona> lista=new List<Persona>();
            Empleado miEmpleado = new Empleado("Juan", "Perez", 20, 1234, 15000);
            Alumno miAlumno = new Alumno("Lucas", "Silva", 26, 9);
            Persona miPersona = new Persona("Pepe", "Ortiz", 30);
            miAlumno.ListaApodos.Add("Pocho");
            lista.Add(miEmpleado);
            lista.Add(miAlumno);
            lista.Add(miPersona);
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sr1 = new StreamWriter(@"D:\VisualStudio\Clase_20\listaPersona.xml");
                xml.Serialize(sr1, lista);
                sr1.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            



           Console.ReadKey();
        }
    }
}
