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
            //string cadena;
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                //cadena = frm.MiTempera;
                miPaleta = miPaleta+ frm.MiTempera;
                for(int i=0;i<miPaleta.CantidadMaxima;i++)
                {
                    if(!Object.Equals(miPaleta[i],null))
                    {
                        this.listBox1.Items.Add((string)miPaleta[i]);

                    }
                    

                }
               
            }
            
        }

        private void bttnSumar_Click(object sender, EventArgs e)
        {
            FormTempera frm = new FormTempera();
            //frm.MdiParent = this;
            //string cadena;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //cadena = frm.MiTempera;
                miPaleta = miPaleta + frm.MiTempera;
                this.listBox1.Items.Clear();
                for (int i = 0; i < miPaleta.CantidadMaxima; i++)
                {
                    if (!Object.Equals(miPaleta[i], null))
                    {
                        this.listBox1.Items.Add((string)miPaleta[i]);

                    }


                }

            }

        }

        private void bttnRestar_Click(object sender, EventArgs e)
        {
            FormTempera frm = new FormTempera();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                miPaleta -= frm.MiTempera;
                this.listBox1.Items.Clear();
                for (int i = 0; i < miPaleta.CantidadMaxima; i++)
                {
                    if (!Object.Equals(miPaleta[i], null))
                    {
                        this.listBox1.Items.Add((string)miPaleta[i]);

                    }


                }
            }

        }

        private void bttnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = this.listBox1.SelectedIndex;
            FormTempera frm = new FormTempera(miPaleta[indice]);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                miPaleta[indice] = frm.MiTempera;
                this.listBox1.Items.Clear();
                for (int i = 0; i < miPaleta.CantidadMaxima; i++)
                {
                    if (!Object.Equals(miPaleta[i], null))
                    {
                        this.listBox1.Items.Add((string)miPaleta[i]);

                    }


                }

            }




        }
    }
}
