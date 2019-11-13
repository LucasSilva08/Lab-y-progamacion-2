using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase23;

namespace Test.Clase23
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Empleado e1 = new Empleado("Juan", "Perez", 123);
            e1.limiteSueldo += new LimiteSueldoDelegado(p.ManejadorLimiteSueldo);
            e1.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(p.ManejadorLimiteSueldoMejorado2);
            e1.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(Program.ManejadorLimiteSueldoMejorado);
            e1.Sueldo = 35000;


            Console.WriteLine(e1.ToString());

            Console.ReadKey();
        }
        //public void AtrapaEvento(double sueldo, Empleado emp)
        //{
        //    Console.WriteLine("PRIMER EVENTO");
        //    Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", sueldo, emp.Apellido, emp.Nombre, emp.Legajo);
        //}
        //public void AtrapaEventoII(Empleado emp,EmpleadoEventArgs ev)
        //{
        //    Console.WriteLine("SEGUNDO EVENTO");
        //    Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3} ",ev.SueldoAsignar,emp.Apellido,emp.Nombre,emp.Legajo);
        //}
        public void ManejadorLimiteSueldo(double sueldo,Empleado emp)
        {
            //Console.WriteLine("PRIMER EVENTO");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", sueldo, emp.Apellido, emp.Nombre, emp.Legajo);
            String.Format("MANEJADOR LIMITE SUELDO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", sueldo, emp.Apellido, emp.Nombre, emp.Legajo);
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs ev)
        {
            //Console.WriteLine("SEGUNDO EVENTO STATIC");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3} ", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);
            String.Format("MANEJADOR LIMITE SUELDO MEJORADO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs ev)
        {
            //Console.WriteLine("SEGUNDO EVENTO DE INSTANCIA");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3} ", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);
            String.Format("MANEJADOR LIMITE SUELDO MEJORADO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);
        }
    }
}
