using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EjercicioPeliculas
{
    public partial class FormReporte3 : Form
    {
        public FormReporte3()
        {
            InitializeComponent();
            dgvPeliculas.Columns.Add("nombre", "Nombre");
            dgvPeliculas.Columns.Add("anio", "Año de estreno");
            dgvPeliculas.Columns.Add("taquillaGenerada", "Taquilla generada");
        }

        private void FormReporte3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormReporte3_Load(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = FormInicio.ObjControlador.getListaPeliculas();
            dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
            dgvPeliculas.Columns["anio"].DataPropertyName = "getAnioEstreno";
            dgvPeliculas.Columns["taquillaGenerada"].DataPropertyName = "getTaquillaGenerada";
        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            int anio = 0;
            bool existeAnio = int.TryParse(txtAnio.Text, out anio);
            if (existeAnio)
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.AutoGenerateColumns = false;
                dgvPeliculas.DataSource = FormInicio.ObjControlador.reporte3(anio);
                dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
                dgvPeliculas.Columns["anio"].DataPropertyName = "getAnioEstreno";
                dgvPeliculas.Columns["taquillaGenerada"].DataPropertyName = "getTaquillaGenerada";
            }
            else
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.AutoGenerateColumns = false;
                dgvPeliculas.DataSource = FormInicio.ObjControlador.getListaPeliculas();
                dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
                dgvPeliculas.Columns["anio"].DataPropertyName = "getAnioEstreno";
                dgvPeliculas.Columns["taquillaGenerada"].DataPropertyName = "getTaquillaGenerada";
            }
        }
    }
}
