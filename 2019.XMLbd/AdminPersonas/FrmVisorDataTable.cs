using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPersonas
{
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable data;
        public DataTable DATA { get {return this.data; } }
        public FrmVisorDataTable()
        {
            InitializeComponent();
            this.data = new DataTable();
            this.data = new DataTable("Persona");
        }
        public FrmVisorDataTable(DataTable data):this()
        {
            this.lstVisor.Items.Clear();
            this.data = data;
            ActualizarLista();
            
            
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            { 
                DataRow fila = this.data.NewRow();
                fila["nombre"] = frm.Persona.nombre;
                fila["apellido"] = frm.Persona.apellido;
                fila["edad"] = frm.Persona.edad;
                this.data.Rows.Add(fila);
              
            }
            ActualizarLista();
        }
        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow fila =  this.data.Rows[this.lstVisor.SelectedIndex];
            frmPersona frm = new frmPersona(new Entidades.Persona(fila["nombre"].ToString(),fila["apellido"].ToString(),int.Parse(fila["edad"].ToString())));
            frm.ShowDialog();
            if(frm.DialogResult==DialogResult.OK)
            {
                fila["nombre"] = frm.Persona.nombre;
                fila["apellido"] = frm.Persona.apellido;
                fila["edad"] = frm.Persona.edad;
            }
            ActualizarLista();
        }
        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = this.lstVisor.SelectedIndex;
            DataRow fila = this.data.Rows[indice];
            frmPersona frm = new frmPersona(new Entidades.Persona(fila["nombre"].ToString(), fila["apellido"].ToString(), int.Parse(fila["edad"].ToString())));
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                fila.Delete();
            }
            ActualizarLista();

        }
        protected override void ActualizarLista()
        {
            lstVisor.Items.Clear();
            foreach (DataRow item in data.Rows)
            {
                if(item.RowState!=DataRowState.Deleted)
                lstVisor.Items.Add(item["nombre"].ToString()+" "+item["apellido"].ToString()+" "+item["edad"].ToString());
            }
        }
    }
}
