using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool retorno=false;
            if(c=='S'||c=='s')
            {
                retorno = true;
            }
            else if(c=='N'||c=='n')
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
