using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telefonica");
            Local llamadaUno = new Local("Cordoba", 40, "Capital", 2.65f);
            Provincial llamadaDos = new Provincial("Formosa", Franja.Franja_1, 21, "Santiago del Estero");
            Local llamadaTres = new Local("La Rioja", 45, "La Pampa", 1.99f);
            Provincial llamdaCuatro = new Provincial(Franja.Franja_3,llamadaDos);

            central += llamadaUno;
            central += llamadaDos;
            central += llamdaCuatro;
            central += llamadaTres;

            Console.WriteLine(central.ToString());

            Console.WriteLine("ORDENAMIENTO");

            central.OrdenarLLamadas();
            Console.WriteLine(central.ToString());
            Console.WriteLine("Costo Local TOTAL: {0}", central.GananciaPorLocal);


            Console.ReadKey();

        }
    }
}
