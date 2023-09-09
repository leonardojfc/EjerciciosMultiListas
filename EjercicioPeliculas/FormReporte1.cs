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
    public partial class FormReporte1 : Form
    {
        public FormReporte1()
        {
            InitializeComponent();
            dgvPeliculas.Columns.Add("nombre", "Nombre");
            dgvPeliculas.Columns.Add("genero", "Género");
            dgvPeliculas.Columns.Add("duracion", "Duración");
        }

        private void FormReporte1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void chkGenero_CheckedChanged(object sender, EventArgs e)
        {


            if(chkGenero.Checked)
            {
                txtGenero.Visible = true;
                txtGenero.Focus();
            }
            else
            {
                txtGenero.Visible = false;
                txtGenero.Text = "";
                dgvPeliculas.DataSource = null;
                dgvPeliculas.AutoGenerateColumns = false;
                dgvPeliculas.DataSource = FormInicio.ObjControlador.getListaPeliculas();
                dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
                dgvPeliculas.Columns["genero"].DataPropertyName = "getGenero";
                dgvPeliculas.Columns["duracion"].DataPropertyName = "getDuracion";
            }
            

        }

        private void FormReporte1_Load(object sender, EventArgs e)
        {
            txtGenero.Visible = false;
            txtGenero.Text = "";
            chkGenero.Checked = false;
            chkDuracion.Checked = false;
            dgvPeliculas.DataSource = null;
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = FormInicio.ObjControlador.getListaPeliculas();
            dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
            dgvPeliculas.Columns["genero"].DataPropertyName = "getGenero";
            dgvPeliculas.Columns["duracion"].DataPropertyName = "getDuracion";
        }

        private void chkDuracion_CheckedChanged(object sender, EventArgs e)
        {
            if( chkDuracion.Checked || chkGenero.Checked)
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.AutoGenerateColumns = false;
                dgvPeliculas.DataSource = FormInicio.ObjControlador.reporte1(chkDuracion.Checked, chkGenero.Checked, txtGenero.Text);
                dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
                dgvPeliculas.Columns["genero"].DataPropertyName = "getGenero";
                dgvPeliculas.Columns["duracion"].DataPropertyName = "getDuracion";
                
            }
            else
            {
                dgvPeliculas.DataSource = null;
                dgvPeliculas.AutoGenerateColumns = false;
                dgvPeliculas.DataSource = FormInicio.ObjControlador.getListaPeliculas();
                dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
                dgvPeliculas.Columns["genero"].DataPropertyName = "getGenero";
                dgvPeliculas.Columns["duracion"].DataPropertyName = "getDuracion";
            }
            
        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = null;
            dgvPeliculas.AutoGenerateColumns = false;
            dgvPeliculas.DataSource = FormInicio.ObjControlador.reporte1(chkDuracion.Checked, chkGenero.Checked, txtGenero.Text);
            dgvPeliculas.Columns["nombre"].DataPropertyName = "getNombre";
            dgvPeliculas.Columns["genero"].DataPropertyName = "getGenero";
            dgvPeliculas.Columns["duracion"].DataPropertyName = "getDuracion";
        }
    }
}
