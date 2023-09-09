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
    public partial class FormInicio : Form
    {
        public static FormInicio instance;
        private static Controlador objControlador;
        public static ComboBox primerParticipante;
        public static ComboBox segundoParticipante;
        public FormRegistroParticipante fRegistroParticipante = new FormRegistroParticipante();
        public FormRegistroPartida fRegistroPartida = new FormRegistroPartida();
        public FormPartidasGandasPorDepartamento fPartidasGanadasPorDepartamento = new FormPartidasGandasPorDepartamento();
        public FormListaParticipantesMayorEdad fListaParticipantesMayorEdad = new FormListaParticipantesMayorEdad();
        public FormNivelMenorParticipantes fNivelMenorParticipantes = new FormNivelMenorParticipantes();
        public FormListaParticipantesMayorPartidaColor fListaParticipantesMayorPartidaColor = new FormListaParticipantesMayorPartidaColor();
        public FormInicio()
        {
            InitializeComponent();
            instance = this;
            objControlador = new Controlador();
            primerParticipante = cmbPrimerParticipante;
            segundoParticipante = cmbSegundoParticipante;
        }

        internal static Controlador ObjControlador { get => objControlador; set => objControlador = value; }

        private void btnParticipante_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegistroParticipante.ShowDialog();
            cmbPrimerParticipante.DataSource = null;
            cmbPrimerParticipante.DataSource = objControlador.getListaParticipantes.ToList();
            cmbPrimerParticipante.DisplayMember = "getNombre";
            cmbPrimerParticipante.SelectedItem = null;
            cmbSegundoParticipante.DataSource = null;
            cmbSegundoParticipante.DataSource = objControlador.getListaParticipantes.ToList();
            cmbSegundoParticipante.DisplayMember = "getNombre";
            cmbSegundoParticipante.SelectedItem = null;
        }

        private void cmbPrimerParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Participante participanteSeleccionado = cmbPrimerParticipante.SelectedItem as Participante;
            List<Participante> listaParticipantes = objControlador.getListaParticipantes.Where(participante => participante != participanteSeleccionado).ToList();
            cmbSegundoParticipante.SelectedItem = null;
            cmbSegundoParticipante.DataSource = null;
            cmbSegundoParticipante.DataSource = listaParticipantes;
            cmbSegundoParticipante.DisplayMember = "getNombre";
        }

        private void btnRegistrarPartida_Click(object sender, EventArgs e)
        {
            if (cmbPrimerParticipante.SelectedItem == null || cmbSegundoParticipante.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar un primer participante y segundo participante para registrar una partida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                fRegistroPartida.ShowDialog();
            }
            
        }

        private void btnPartidasGanadasPorDepartamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            fPartidasGanadasPorDepartamento.ShowDialog(); 
        }

        private void btnListaParticipantesMayorEdad_Click(object sender, EventArgs e)
        {
            this.Hide();
            fListaParticipantesMayorEdad.ShowDialog();
        }

        private void btnListaParticipantesMayorPartidaColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            fListaParticipantesMayorPartidaColor.ShowDialog();
        }

        private void btnNivelMenorCantidadParticipantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            fNivelMenorParticipantes.ShowDialog();
        }
    }
}
