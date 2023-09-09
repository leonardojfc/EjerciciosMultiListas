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
    public partial class FormReporte2 : Form
    {
        public FormReporte2()
        {
            InitializeComponent();
            dgvPeliculas.Columns.Add("nombre", "Nombre");
            dgvPeliculas.Columns.Add("director", "Director");
            dgvPeliculas.Columns.Add("taquillaGenerada", "Taquilla generada");
        }

        private void FormReporte2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormReporte2_Load(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = FormInicio.ObjControlador.reporte2();
            dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
            dgvPeliculas.Columns["director"].DataPropertyName = "getNombreDirector";
            dgvPeliculas.Columns["taquillaGenerada"].DataPropertyName = "getTaquillaGenerada";
        }
    }
}
