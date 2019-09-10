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
    public partial class FormTempera : Form
    {
        private Tempera t;

        public Tempera MiTempera
        {
            get
            {
                return this.t;
            } 

        }

        public FormTempera()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.combo.Items.Add(c);
            }
            this.combo.SelectedItem = ConsoleColor.Magenta;
            this.combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            string cadena = this.txtMarca.Text;
            int cantidad = int.Parse(this.txtCantidad.Text);
            this.t = new Tempera((ConsoleColor) this.combo.SelectedItem, cadena, cantidad);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show(t);

        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
