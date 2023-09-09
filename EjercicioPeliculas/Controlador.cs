using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPeliculas
{
    internal class Controlador
    {
        private List<Director> listaDirectores;
        private List<Pelicula> listaPeliculas;
        public Controlador() {
            listaDirectores = new List<Director>();
            listaPeliculas = new List<Pelicula>();
        }

        public List<Director> getListaDirectores()
        {
            return listaDirectores;
        }
        public List<Pelicula> getListaPeliculas()
        {
            return listaPeliculas;
        }
        public void registrarDirector(int dni, string nombreCompleto, string sexo, string estado, int telefono)
        {
            Director objDirector = new Director(dni, nombreCompleto, sexo, estado, telefono);
            listaDirectores.Add(objDirector);
        }

        public void registrarPelicula(Director objDirector, string codigo, string nombre, string genero, int duracion, int taquillaGenerada, int anioEstreno)
        {
            Pelicula objPelicula = new Pelicula(objDirector, codigo, nombre, genero, duracion, taquillaGenerada, anioEstreno);
            listaPeliculas.Add(objPelicula);
        }

        public List<Pelicula> reporte1(bool porDuracionMinima, bool porGenero, string genero)
        {
            List<Pelicula> listaTemporal = listaPeliculas.ToList();
            if(porDuracionMinima)
            {
                listaTemporal.Sort((pelicula1, pelicula2) => pelicula1.getDuracion.CompareTo(pelicula2.getDuracion));
            }
            if(porGenero && genero!="")
            {
                listaTemporal = listaTemporal.Where(pelicula => pelicula.getGenero == genero).ToList();
            }
            return listaTemporal;
        }

        public List<Pelicula> reporte2()
        {
            List<Pelicula> listaTemporal = new List<Pelicula>();
            foreach (var group in listaPeliculas.GroupBy(pelicula => pelicula.getDirector))
            {
                int maxTaquilla = group.Max(pelicula => pelicula.getTaquillaGenerada);
                listaTemporal.AddRange(group.Where(pelicula => pelicula.getTaquillaGenerada == maxTaquilla));
            }
            return listaTemporal;
        }

        public List<Pelicula> reporte3(int anioEstreno)
        {
            List<Pelicula> listaTemporal = new List<Pelicula>();
            int maxTaquilla = 0;
            foreach (Pelicula pelicula in listaPeliculas)
            {
                if (pelicula.getAnioEstreno == anioEstreno)
                {
                    if (pelicula.getTaquillaGenerada > maxTaquilla)
                    {
                        listaTemporal.Clear();
                        listaTemporal.Add(pelicula);
                        maxTaquilla = pelicula.getTaquillaGenerada;
                    }
                    else if (pelicula.getTaquillaGenerada == maxTaquilla)
                    {
                        listaTemporal.Add(pelicula);
                    }
                }
            }
            return listaTemporal;
        }

    }
}
