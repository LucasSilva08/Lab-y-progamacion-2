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
    public partial class FrmCentralita : Form
    {
        private Centralita miCentralita;
        public FrmCentralita()
        {
            InitializeComponent();
            miCentralita = new Centralita();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (OrdenamientoDuracion c in Enum.GetValues(typeof(OrdenamientoDuracion)))
            {
                this.cboOrdenamiento.Items.Add(c);
            }
            this.cboOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboOrdenamiento.SelectedItem = OrdenamientoDuracion.DuracionAscendente;

        }

        private void btnLlamadaLocal_Click(object sender, EventArgs e)
        {
            FrmLlamadaLocal miLlamadaLocal = new FrmLlamadaLocal();
            miLlamadaLocal.ShowDialog();
            
            if (miLlamadaLocal.DialogResult==DialogResult.OK)
            {
                miCentralita += miLlamadaLocal.LLamada;
                ActualizarLista();
            }
        }

        private void btnLlamadaProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial miLlamadaProvincial = new FrmProvincial();
            miLlamadaProvincial.ShowDialog();
            if(miLlamadaProvincial.DialogResult==DialogResult.OK)
            {
                miCentralita += miLlamadaProvincial.LLamada;
                ActualizarLista();
            }
        }
        private void ActualizarLista()
        {
            lstVisor.Items.Clear();
            foreach (Llamada item in miCentralita.LLamadas)
            {
                lstVisor.Items.Add(item.ToString());
            }

        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((OrdenamientoDuracion)this.cboOrdenamiento.SelectedItem)
            {
                case OrdenamientoDuracion.DuracionAscendente:
                    miCentralita.OrdenarLLamadas();
                    ActualizarLista();
                    
                    break;
                case OrdenamientoDuracion.DuracionDescendente:
                    miCentralita.OrdenarDescendente();
                    ActualizarLista();
                    break;
                default:
                    break;
            }
        }
    }
}
