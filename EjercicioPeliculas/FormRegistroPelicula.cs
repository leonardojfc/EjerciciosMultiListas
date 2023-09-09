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
    public partial class FormRegistroPelicula : Form
    {
        public FormRegistroPelicula()
        {
            InitializeComponent();
        }



        private void FormRegistroPelicula_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string duracion = txtDuracion.Text;
            string taquillaGenerada = txtTaquillaGenerada.Text;
            string anioEstreno = txtAnioEstreno.Text;
            if (codigo == "" || nombre == "" || cmbGenero.SelectedItem == null || duracion == "" || taquillaGenerada == "" || anioEstreno == "")
            {
                MessageBox.Show("Se deben rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Pelicula> listaTemporalPeliculas = FormInicio.ObjControlador.getListaPeliculas();
                bool peliculaMismoCodigo = listaTemporalPeliculas.Exists(pelicula => pelicula.getCodigo == codigo);
                if (peliculaMismoCodigo)
                {
                    MessageBox.Show("No pueden haber 2 peliculas con el mismo codigo, cambie el codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblRespuesta.Visible = true;
                    string genero = cmbGenero.SelectedItem.ToString();
                    Director directorSeleccionado = FormInicio.directores.SelectedItem as Director;
                    FormInicio.ObjControlador.registrarPelicula(directorSeleccionado, codigo, nombre, genero, int.Parse(duracion), int.Parse(taquillaGenerada), int.Parse(anioEstreno));
                    btnRegistrar.Enabled = false;
                    this.Close();
                }
            }
        }

        private void FormRegistroPelicula_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDuracion.Text = "";
            txtTaquillaGenerada.Text = "";
            txtAnioEstreno.Text = "";
            cmbGenero.SelectedItem = null;
            btnRegistrar.Enabled = true;
            lblRespuesta.Visible = false;
        }
    }
}
