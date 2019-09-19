using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_09.Entidades;

namespace Clase_09.WF
{
    public partial class FrmAlumno : Form
    {
        private Alumno miAlumno;

        public Alumno Alumno { get {return this.miAlumno; }  }

        public FrmAlumno()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (ETipoExamen c in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(c);
            }
            this.cmbTipoExamen.SelectedItem = ETipoExamen.Final;
            this.cmbTipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            int legajo = int.Parse(this.txtLegajo.Text);
            this.miAlumno = new Alumno(nombre, apellido, legajo, (ETipoExamen)this.cmbTipoExamen.SelectedItem);
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
