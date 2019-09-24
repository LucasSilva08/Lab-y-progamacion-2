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
    public partial class FrmCatedra : Form
    {
        private Catedra miCatedra = new Catedra();
        private List<AlumnoCalificado> lista;

        public FrmCatedra()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach(ETipoOrdenamiento c in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenamiento.Items.Add(c);
            }
            this.cmbOrdenamiento.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
            this.cmbOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();
            if (frmAlumno.DialogResult == DialogResult.OK)
            {   
                
                 if (miCatedra + frmAlumno.Alumno)
                 {
                    ActualizarListadoAlumnos();
                    
                 }
                 else
                 {
                    MessageBox.Show("Nose puede cargar el Alumno!!");
                 }



            }
        }
        private void ActualizarListadoAlumnos()
        {
            this.listBoxAlumnos.Items.Clear();

            for (int i = 0; i < miCatedra.Alumnos.Count; i++)
            {
                if (!Object.Equals(miCatedra.Alumnos.ElementAt(i), null))
                {
                    //this.listBoxAlumnos.Items.Add(Alumno.Mostrar(miCatedra.Alumnos.ElementAt(i)));
                    this.listBoxAlumnos.Items.Add(miCatedra.Alumnos[i].ToString());
                }

            }


        }

        private void cmbOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ETipoOrdenamiento)this.cmbOrdenamiento.SelectedItem)
            {
                case ETipoOrdenamiento.LegajoAscendente://Legajo Ascendente
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    ActualizarListadoAlumnos();


                    break;
                case ETipoOrdenamiento.LegajoDescendente://Legajo Descendente
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    ActualizarListadoAlumnos();


                    break;
                case ETipoOrdenamiento.ApellidoAscendente://Apellido Ascendente
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    ActualizarListadoAlumnos();

                    break;
                case ETipoOrdenamiento.ApellidoDescendente://Apellido Descendente
                    miCatedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    ActualizarListadoAlumnos();


                    break;
                default:
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = listBoxAlumnos.SelectedIndex;
            FrmAlumno frmAlumno = new FrmAlumno(miCatedra.Alumnos[indice]);
            frmAlumno.ShowDialog();
            if (frmAlumno.DialogResult == DialogResult.OK)
            {
                miCatedra.Alumnos[indice] = frmAlumno.Alumno;
                ActualizarListadoAlumnos();
            }



        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            int indice = listBoxAlumnos.SelectedIndex;
            FrmAlumnoCalificado frmAlumnoCalificado = new FrmAlumnoCalificado(miCatedra.Alumnos[indice]);
            frmAlumnoCalificado.ShowDialog();
        }
    }
}
