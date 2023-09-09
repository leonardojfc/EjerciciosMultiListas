using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPeliculas
{
    public partial class FormRegistroDirector : Form
    {
        public FormRegistroDirector()
        {
            InitializeComponent();
        }

        private void FormRegistroDirector_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombreCompleto = txtNombreCompleto.Text;
            string telefono = txtTelefono.Text;
            if(dni == "" || nombreCompleto == "" || cmbSexo.SelectedItem == null || cmbEstado.SelectedItem == null || telefono == "")
            {
                MessageBox.Show("Se deben rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Director> listaTemporalDirectores = FormInicio.ObjControlador.getListaDirectores();
                bool directorMismoDNI = listaTemporalDirectores.Exists(director => director.getDNI == int.Parse(dni));
                if (directorMismoDNI)
                {
                    MessageBox.Show("No puede haber 2 directores con el mismo DNI, cambie el DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblRespuesta.Visible = true;
                    string sexo = cmbSexo.SelectedItem.ToString();
                    string estado = cmbEstado.SelectedItem.ToString();
                    FormInicio.ObjControlador.registrarDirector(int.Parse(dni), nombreCompleto, sexo, estado, int.Parse(telefono));
                    btnRegistrar.Enabled = false;
                    this.Close();
                }
            }
        }

        private void FormRegistroDirector_Load(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtNombreCompleto.Text = "";
            txtTelefono.Text = "";
            cmbSexo.SelectedItem = null;
            cmbEstado.SelectedItem = null;
            btnRegistrar.Enabled = true;
            lblRespuesta.Visible = false;
        }
    }
}
