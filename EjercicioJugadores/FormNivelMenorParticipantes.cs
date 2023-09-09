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
    public partial class FormNivelMenorParticipantes : Form
    {
        public FormNivelMenorParticipantes()
        {
            InitializeComponent();
            dgvNivelMenorCantidadParticipantes.Columns.Add("nivel", "Nivel");
            dgvNivelMenorCantidadParticipantes.Columns.Add("cantidadParticipantes", "Cantidad de participantes");
        }

        private void FormNivelMenorParticipantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormNivelMenorParticipantes_Load(object sender, EventArgs e)
        {
            dgvNivelMenorCantidadParticipantes.DataSource = null;
            dgvNivelMenorCantidadParticipantes.AutoGenerateColumns = false;
            dgvNivelMenorCantidadParticipantes.DataSource = FormInicio.ObjControlador.getNivelesConMenorCantidadParticipantes();
            dgvNivelMenorCantidadParticipantes.Columns["nivel"].DataPropertyName = "nivel";
            dgvNivelMenorCantidadParticipantes.Columns["cantidadParticipantes"].DataPropertyName = "cantidadParticipantes";
        }
    }
}
