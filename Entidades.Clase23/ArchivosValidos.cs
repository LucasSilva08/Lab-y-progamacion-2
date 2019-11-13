using Entidades.Clase23;
//Solo le interesa la Firma y no si es de Clase o de Instancia
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);
public delegate void LimiteSueldoMejoradoDel(Empleado emp, EmpleadoEventArgs ev);
public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos
}