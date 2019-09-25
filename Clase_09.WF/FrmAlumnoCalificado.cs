﻿using System;
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
        private AlumnoCalificado miAlumnoCalificado;
        public AlumnoCalificado AlumnoCalificado { get {return this.miAlumnoCalificado; }  }
        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public FrmAlumnoCalificado(Alumno c):this()
        {
            this.txtApellido.Text = c.Apellido;
            this.txtNombre.Text = c.Nombre;
            this.txtLegajo.Text = c.Legajo.ToString();
            this.cmbTipoExamen.SelectedIndex = (int)c.Examen;
            this.txtApellido.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoExamen.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double nota = double.Parse(this.txtNota.Text);
            this.miAlumnoCalificado = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedIndex, nota);
            this.DialogResult = DialogResult.OK;
        }
    }
}
