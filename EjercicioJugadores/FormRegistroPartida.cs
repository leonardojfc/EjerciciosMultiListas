using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioJugadores
{
    public partial class FormRegistroPartida : Form
    {
        public FormRegistroPartida()
        {
            InitializeComponent();
        }

        private void FormRegistroPartida_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void cmbColorPrimerParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorPrimerParticipante.SelectedItem != null)
            {
                if (cmbColorPrimerParticipante.SelectedItem.ToString() == "Negras")
                {
                    cmbColorSegundoParticipante.SelectedItem = "Blancas";
                }
                else if (cmbColorPrimerParticipante.SelectedItem.ToString() == "Blancas")
                {
                    cmbColorSegundoParticipante.SelectedItem = "Negras";
                }
            }
            
        }

        private void cmbColorSegundoParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColorPrimerParticipante.SelectedItem != null)
            {
                if (cmbColorSegundoParticipante.SelectedItem.ToString() == "Negras")
                {
                    cmbColorPrimerParticipante.SelectedItem = "Blancas";
                }
                else if (cmbColorSegundoParticipante.SelectedItem.ToString() == "Blancas")
                {
                    cmbColorPrimerParticipante.SelectedItem = "Negras";
                }
            }
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if (codigo == "" || cmbColorPrimerParticipante.SelectedItem == null || cmbColorSegundoParticipante.SelectedItem == null || cmbGanador.SelectedItem == null)
            {
                MessageBox.Show("Se deben rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Partida> listaPartidasTemporal = FormInicio.ObjControlador.getListaPartidas;
                bool partidaMismoCodigo = listaPartidasTemporal.Exists(partida => partida.getCodigo == codigo);
                if (partidaMismoCodigo)
                {
                    MessageBox.Show("No pueden haber 2 partidas con el mismo codigo, cambie el codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string colorPrimerParticipante = cmbColorPrimerParticipante.SelectedItem.ToString();
                    string colorSegundoParticipante = cmbColorSegundoParticipante.SelectedItem.ToString();
                    string ganador = cmbGanador.SelectedItem.ToString();
                    Participante primerParticipanteSeleccionado = FormInicio.primerParticipante.SelectedItem as Participante;
                    Participante segundoParticipanteSeleccionado = FormInicio.segundoParticipante.SelectedItem as Participante;
                    FormInicio.ObjControlador.registrarPartida(codigo, primerParticipanteSeleccionado, segundoParticipanteSeleccionado, colorPrimerParticipante, colorSegundoParticipante, ganador);
                    btnRegistrar.Enabled = false;
                    this.Close();
                }
            }
        }

        private void FormRegistroPartida_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            cmbColorPrimerParticipante.SelectedItem = null;
            cmbColorSegundoParticipante.SelectedItem = null;
            cmbGanador.SelectedItem = null;
            btnRegistrar.Enabled = true;
        }
    }
}
