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
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamReader sr1 = new StreamReader(path);
                this.lista=(List<Persona>)xml.Deserialize(sr1);
                sr1.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.saveFileDialog1.ShowDialog();
            //this.saveFileDialog1.InitialDirectory
            string path = this.saveFileDialog1.FileName;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Persona>));
                StreamWriter sr1 = new StreamWriter(path);
                xml.Serialize(sr1, lista);
                sr1.Close();
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            this.lista = frm.listaPersonas;


            
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexion);
                conexion.Open();
                MessageBox.Show("OK");
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT TOP 1000[id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                SqlDataReader data = command.ExecuteReader();
                while (data.Read()!=false)
                {
                    MessageBox.Show(data["id"].ToString()+" " +data["nombre"].ToString() + " " + data["apellido"].ToString() + " " + data["edad"].ToString());
                }
                data.Close();
                conexion.Close();

            }
            catch(Exception exep)
            {
                MessageBox.Show(exep.Message);


            }
        }
    }
}
