using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJugadores
{
    public partial class FormListaParticipantesMayorEdad : Form
    {
        public FormListaParticipantesMayorEdad()
        {
            InitializeComponent();
            dgvListaParticipantesMayorEdad.Columns.Add("nombre", "Nombre");
            dgvListaParticipantesMayorEdad.Columns.Add("anioNacimiento", "Año de nacimiento");
        }

        private void FormListaParticipantesMayorEdad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormListaParticipantesMayorEdad_Load(object sender, EventArgs e)
        {
            dgvListaParticipantesMayorEdad.DataSource = null;
            dgvListaParticipantesMayorEdad.AutoGenerateColumns = false;
            dgvListaParticipantesMayorEdad.DataSource = FormInicio.ObjControlador.listaParticipantesMayorEdad();
            dgvListaParticipantesMayorEdad.Columns["nombre"].DataPropertyName = "getNombre";
            dgvListaParticipantesMayorEdad.Columns["anioNacimiento"].DataPropertyName = "getAnioNacimiento";
        }
    }
}
