using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Clase23
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        public event LimiteSueldoDelegado limiteSueldo; // evento del delegado
        public event LimiteSueldoMejoradoDel limiteSueldoMejorado;

        public Empleado (string nombre, string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public string Nombre { get {return this.nombre; } set {this.nombre=value; } }
        public string Apellido { get {return this.apellido; } set {this.apellido=value; } }
        public int Legajo { get {return this.legajo; } set {this.legajo=value; } }
        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                if (value > 18000 && value <30000)
                {
                    try
                    {
                        this.limiteSueldo(value, this);
                    }
                    catch(Exception)
                    {

                    }
                }
                else if(value>30000)
                {
                    try
                    {
                        EmpleadoEventArgs ev = new EmpleadoEventArgs();
                        ev.SueldoAsignar = value;
                        this.limiteSueldoMejorado(this, ev);
                    }
                    catch(Exception)
                    {

                    }
                }
                else
                {
                    this.sueldo = value;
                }
                
            }
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} - LEGAJO: {2} SUELDO: {3}", this.apellido, this.nombre, this.legajo, this.sueldo);
        }
        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
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
