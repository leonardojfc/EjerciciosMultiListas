using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class Director
    {
        private int dni;
        private string nombreCompleto;
        private string sexo;
        private string estado;
        private int telefono;

        public Director(int dni, string nombreCompleto, string sexo, string estado, int telefono)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.sexo = sexo;
            this.estado = estado;
            this.telefono = telefono;
        }

        public int getDNI
        {
            get { return dni; }
        }

        public string getNombreCompleto 
        {
            get { return nombreCompleto;}
        }
    }
}
