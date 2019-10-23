using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
