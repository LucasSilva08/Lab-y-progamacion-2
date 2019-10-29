using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20.Test
{
    public static class Serializadora
    {
        public static bool Serializar(IXML x)
        {
            return x.Guardar(@"D:\VisualStudio\Clase_20\Archivo.xml");
        }
        public static bool Deserializar(IXML x,out object obj)
        {
            obj = null;
            return x.Leer(@"D:\VisualStudio\Clase_20\Archivo.xml", out obj);
        }
    }
}
