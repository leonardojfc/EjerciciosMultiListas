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
    public partial class FormRegistroParticipante : Form
    {
        public FormRegistroParticipante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string anioNacimiento = txtAnioNacimiento.Text;
            if (dni == "" || nombre == "" || cmbDepartamento.SelectedItem == null || anioNacimiento == "" || cmbNivelJuego.SelectedItem == null)
            {
                MessageBox.Show("Se deben rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Participante> listaTemporalParticipantes = FormInicio.ObjControlador.getListaParticipantes;
                bool participanteMismoDNI = listaTemporalParticipantes.Exists(participante => participante.getDNI == int.Parse(dni));
                if (participanteMismoDNI)
                {
                    MessageBox.Show("No puede haber 2 participantes con el mismo DNI, cambie el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(int.Parse(anioNacimiento) > 2007 || int.Parse(anioNacimiento) < 1950)
                    {
                        MessageBox.Show("El año de nacimiento debe ser entre 1950 y 2007", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string departamento = cmbDepartamento.SelectedItem.ToString();
                        string nivelJuego = cmbNivelJuego.SelectedItem.ToString();
                        FormInicio.ObjControlador.registrarParticipante(int.Parse(dni), nombre, departamento, int.Parse(anioNacimiento), int.Parse(nivelJuego));
                        btnRegistrar.Enabled = false;
                        this.Close();
                    }
                }
            }
        }

        private void FormRegistroParticipante_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormRegistroParticipante_Load(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = true;
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtAnioNacimiento.Text = "";
            cmbDepartamento.SelectedItem = null;
            cmbNivelJuego.SelectedItem = null;
        }
    }
}
