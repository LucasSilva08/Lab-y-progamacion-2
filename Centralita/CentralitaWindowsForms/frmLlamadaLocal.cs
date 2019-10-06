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
    public partial class FrmLlamadaLocal : FrmLlamada
    {
        //private Local miLocal;
        //public Local LLamadaLocal { get {return this.miLocal; } }

        public FrmLlamadaLocal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float costo = float.Parse(this.txtCosto.Text);

            base.miLlamada = new Local(base.txtNroOrigen.Text, float.Parse(base.txtDuracion.Text), base.txtNroDestino.Text, costo);
            this.DialogResult = DialogResult.OK;
        }
    }
}
