using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> lista;
        public List<Persona> listaPersonas { get {return this.lista; } }
        public frmVisorPersona()
        {
            
            InitializeComponent();
            this.lista = new List<Persona>();
        }
        public frmVisorPersona(List<Persona> lista):this()
        {
            this.lista = lista;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
            }
            ActualizarLista();

            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }
        private void ActualizarLista()
        {
            lstVisor.Items.Clear();
            foreach (Persona item in this.lista)
            {
                lstVisor.Items.Add(item.ToString());
            }

        }
    }
}
