using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralitaWindowsForms
{
    public partial class FrmProvincial : FrmLlamada
    {
        //Provincial miProvincial;
        //public Provincial LLamadaProvincial { get {return this.miProvincial; }  }
        public FrmProvincial()
        {
            InitializeComponent();
            foreach (Franja item in Enum.GetValues(typeof(Franja)))
            {
                this.cmbFranja.Items.Add(item);
            }
            this.cmbFranja.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbFranja.SelectedItem = Franja.Franja_1;
        }
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            base.miLlamada = new Provincial(base.txtNroOrigen.Text, (Franja)cmbFranja.SelectedItem, float.Parse(base.txtDuracion.Text), base.txtNroDestino.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
