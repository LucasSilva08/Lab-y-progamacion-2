using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase23;

namespace WindowsForms_Clase23
{
    public partial class FrmEmpleado : Form
    {
        private Empleado emp;
        public FrmEmpleado()
        {
            
            InitializeComponent();
            foreach(TipoManejador item in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(item);
                this.StartPosition = FormStartPosition.CenterScreen;
            }
                

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.emp = new Empleado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text));
            try
            {
                if ((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.LimiteSueldo)
                {

                    this.emp.limiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                }
                else if ((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.LimiteSueldoMejorado)
                {
                    this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.ManejadorLimiteSueldoMejorado2);
                    this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(FrmEmpleado.ManejadorLimiteSueldoMejorado);
                }
                else if ((TipoManejador)this.cmbManejador.SelectedItem == TipoManejador.Todos)
                {
                    this.emp.limiteSueldo += new LimiteSueldoDelegado(this.ManejadorLimiteSueldo);
                    this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(this.ManejadorLimiteSueldoMejorado2);
                    this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(FrmEmpleado.ManejadorLimiteSueldoMejorado);
                }
            }
            catch(Exception)
            {
                
            }
            this.emp.Sueldo = double.Parse(this.txtSueldo.Text);
            MessageBox.Show(this.emp.ToString());

        }
        public void ManejadorLimiteSueldo(double sueldo, Empleado emp)
        {
            //Console.WriteLine("PRIMER EVENTO");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", sueldo, emp.Apellido, emp.Nombre, emp.Legajo);
            MessageBox.Show( String.Format("MANEJADOR LIMITE SUELDO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", sueldo, emp.Apellido, emp.Nombre, emp.Legajo));
            
        }
        public static void ManejadorLimiteSueldoMejorado(Empleado emp, EmpleadoEventArgs ev)
        {
            //Console.WriteLine("SEGUNDO EVENTO STATIC");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3} ", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);

            MessageBox.Show( String.Format("MANEJADOR LIMITE SUELDO MEJORADO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo));
        }
        public void ManejadorLimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs ev)
        {
            //Console.WriteLine("SEGUNDO EVENTO DE INSTANCIA");
            //Console.WriteLine("SUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3} ", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo);
            MessageBox.Show( String.Format("MANEJADOR LIMITE SUELDO MEJORADO\nSUELDO EXCEDIDO: {0}, DEL EMPLEADO: {1}, {2} LEGAJO: {3}", ev.SueldoAsignar, emp.Apellido, emp.Nombre, emp.Legajo));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtLegajo.Text = "";
            this.txtSueldo.Text = "";
        }
    }
}
