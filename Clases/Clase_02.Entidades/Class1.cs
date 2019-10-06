using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string imprimir()
        {

            return ArmarFormatoMensaje();
        }
        public static void borrar()
        {
            Sello.mensaje = "";

        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(ArmarFormatoMensaje());
            

        }
        static string ArmarFormatoMensaje()
        {
            string techo="*";
            int i;
            for(i=0;i<= Sello.mensaje.Length;i++)
            {
                techo += "*";
            }
            return techo + "\n" + "*" + Sello.mensaje + "*\n" + techo;
                       
        }

    }
}
