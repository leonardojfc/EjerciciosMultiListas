using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJugadores
{
    internal class Participante
    {
        private int dni;
        private string nombre;
        private string departamento;
        private int anioNacimiento;
        private int nivelJuego;

        public Participante(int dni, string nombre, string departamento, int anioNacimiento, int nivelJuego)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.departamento = departamento;
            this.anioNacimiento = anioNacimiento;
            this.nivelJuego = nivelJuego;
        }

        public int getDNI
        {
            get { return dni; }
        }

        public string getNombre
        {
            get { return nombre; }
        }

        public string getDepartamento
        {
           get { return departamento; }
        }

        public int getAnioNacimiento
        {
            get { return anioNacimiento; }
        }

        public int getNivelJuego
        {
            get { return nivelJuego; }
        }
    }
}
