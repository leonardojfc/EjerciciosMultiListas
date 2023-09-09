using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class Pelicula
    {
        private string codigo;
        private string nombre;
        private string genero;
        private int duracion;
        private int taquillaGenerada;
        private int anioEstreno;
        private Director director;

        public Pelicula(Director director, string codigo, string nombre, string genero, int duracion, int taquillaGenerada, int anioEstreno)
        {
            this.director = director;
            this.codigo = codigo;
            this.nombre = nombre;
            this.genero = genero;
            this.duracion = duracion;
            this.taquillaGenerada = taquillaGenerada;
            this.anioEstreno = anioEstreno;
        }


        public string getNombre { get { return nombre; } }
        public string getCodigo { get { return codigo; } }
        public string getGenero { get { return genero; } }
        public int getDuracion { get { return duracion; } }
        public int getTaquillaGenerada { get { return taquillaGenerada; } }
        public int getAnioEstreno { get { return anioEstreno; } }
        public Director getDirector{ get { return director; } }
        public string getNombreDirector { get { return director.getNombreCompleto; } }
    }
}
