using System;
using System.Windows.Forms;

namespace EjercicioPeliculas
{
    public partial class FormInicio : Form
    {
        public static FormInicio instance;
        private static Controlador objControlador;
        public static ComboBox directores;
        public FormRegistroDirector fRegistroDirector = new FormRegistroDirector();
        public FormRegistroPelicula fRegistroPelicula = new FormRegistroPelicula();
        public FormReporte1 fReporte1 = new FormReporte1();
        public FormReporte2 fReporte2 = new FormReporte2();
        public FormReporte3 fReporte3 = new FormReporte3();

        public FormInicio()
        {
            InitializeComponent();
            instance = this;
            objControlador = new Controlador();
            directores = cmbDirectores;
        }

        internal static Controlador ObjControlador { get => objControlador; set => objControlador = value; }

        private void btnRegistrarDirector_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegistroDirector.ShowDialog();
            cmbDirectores.DataSource = null;
            cmbDirectores.DataSource = ObjControlador.getListaDirectores();
            cmbDirectores.DisplayMember = "getNombreCompleto";
            cmbDirectores.SelectedItem = null;
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReporte1.ShowDialog();
        }

        private void btnRegistrarPelicula_Click(object sender, EventArgs e)
        {
            if(cmbDirectores.SelectedItem == null)
            {
                MessageBox.Show("Se debe seleccionar un director para registrar una pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                fRegistroPelicula.ShowDialog();
            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReporte2.ShowDialog();
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReporte3.ShowDialog();
        }
    }
}
