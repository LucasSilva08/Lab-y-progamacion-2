using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_06.WF
{
    public partial class Form1 : Form

    {
        Paleta miPaleta;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            
            this.groupBox1.Visible = false;
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miPaleta = 5;
            this.groupBox1.Visible = true;
            this.paletaToolStripMenuItem.Enabled = false;
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTempera frm = new FormTempera();
            //frm.MdiParent = this;
            string cadena;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
               cadena = frm.MiTempera;
               this.listBox1.Items.Add(cadena);
            }
            
        }
    }
}
