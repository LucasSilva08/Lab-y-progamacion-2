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
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        public AlumnoCalificado AlumnoCalificado { get {return this.AlumnoCalificado; }  }
        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FrmAlumnoCalificado(Alumno c):base(c)
        {
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.cmbTipoExamen.Enabled = false;
        }
    }
}
