using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase4.Entidades;

namespace Clase04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCrear_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            string cadena = this.txtCadena.Text;
            DateTime fecha = Convert.ToDateTime(this.txtFecha.Text);
            Cosa c = new Cosa(cadena, fecha, entero);
            lstLista.Items.Add(c.Mostrar());

            MessageBox.Show(c.Mostrar());

           
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
