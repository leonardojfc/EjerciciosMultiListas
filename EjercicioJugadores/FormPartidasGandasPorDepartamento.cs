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
    public partial class FormPartidasGandasPorDepartamento : Form
    {
        public FormPartidasGandasPorDepartamento()
        {
            InitializeComponent();
            dgvPartidasGanadasPorDepartamento.Columns.Add("departamento", "Departamento");
            dgvPartidasGanadasPorDepartamento.Columns.Add("partidasGanadas", "Partidas Ganadas");
        }

        private void FormPartidasGandasPorDepartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            FormInicio.instance.Show();
        }

        private void FormPartidasGandasPorDepartamento_Load(object sender, EventArgs e)
        {
            dgvPartidasGanadasPorDepartamento.DataSource = null;
            dgvPartidasGanadasPorDepartamento.AutoGenerateColumns = false;
            dgvPartidasGanadasPorDepartamento.DataSource = FormInicio.ObjControlador.partidasGanadasPorDepartamento();
            dgvPartidasGanadasPorDepartamento.Columns["departamento"].DataPropertyName = "departamento";
            dgvPartidasGanadasPorDepartamento.Columns["partidasGanadas"].DataPropertyName = "partidasGanadas";
        }
    }
}
