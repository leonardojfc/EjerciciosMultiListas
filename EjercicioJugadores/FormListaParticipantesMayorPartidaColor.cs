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
    public partial class FormListaParticipantesMayorPartidaColor : Form
    {
        public FormListaParticipantesMayorPartidaColor()
        {
            InitializeComponent();
            dgvListaParticipantesMayorPartidasColor.Columns.Add("nombre", "Nombre");
            dgvListaParticipantesMayorPartidasColor.Columns.Add("color", "Color");
            dgvListaParticipantesMayorPartidasColor.Columns.Add("cantidadPartidas", "Partidas");
        }

        private void FormListaParticipantesMayorPartidaColor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormListaParticipantesMayorPartidaColor_Load(object sender, EventArgs e)
        {
            cmbColor.SelectedItem = null;
            dgvListaParticipantesMayorPartidasColor.DataSource = null;
            dgvListaParticipantesMayorPartidasColor.AutoGenerateColumns = false;
            dgvListaParticipantesMayorPartidasColor.DataSource = FormInicio.ObjControlador.getListaPartidaPorColorParticipante();
            dgvListaParticipantesMayorPartidasColor.Columns["nombre"].DataPropertyName = "nombreParticipante";
            dgvListaParticipantesMayorPartidasColor.Columns["color"].DataPropertyName = "colorParticipante";
            dgvListaParticipantesMayorPartidasColor.Columns["cantidadPartidas"].DataPropertyName = "cantidadPartidas";
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbColor.SelectedItem != null)
            {
                if(cmbColor.SelectedItem.ToString() == "Negras")
                {
                    dgvListaParticipantesMayorPartidasColor.DataSource = null;
                    dgvListaParticipantesMayorPartidasColor.AutoGenerateColumns = false;
                    dgvListaParticipantesMayorPartidasColor.DataSource = FormInicio.ObjControlador.getMayorCantidadPartidasPorColor(cmbColor.SelectedItem.ToString());
                    dgvListaParticipantesMayorPartidasColor.Columns["nombre"].DataPropertyName = "nombreParticipante";
                    dgvListaParticipantesMayorPartidasColor.Columns["color"].DataPropertyName = "colorParticipante";
                    dgvListaParticipantesMayorPartidasColor.Columns["cantidadPartidas"].DataPropertyName = "cantidadPartidas";
                }
                else
                {
                    dgvListaParticipantesMayorPartidasColor.DataSource = null;
                    dgvListaParticipantesMayorPartidasColor.AutoGenerateColumns = false;
                    dgvListaParticipantesMayorPartidasColor.DataSource = FormInicio.ObjControlador.getMayorCantidadPartidasPorColor(cmbColor.SelectedItem.ToString());
                    dgvListaParticipantesMayorPartidasColor.Columns["nombre"].DataPropertyName = "nombreParticipante";
                    dgvListaParticipantesMayorPartidasColor.Columns["color"].DataPropertyName = "colorParticipante";
                    dgvListaParticipantesMayorPartidasColor.Columns["cantidadPartidas"].DataPropertyName = "cantidadPartidas";
                }
            }
        }
    }
}
