using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJugadores
{
    public class CantidadParticipantesPorNivel
    {
        public int nivel { get; set; }
        public int cantidadParticipantes { get; set; }
    }
    public class PartidaPorColorParticipante
    {
        public string nombreParticipante { get; set; }
        public string colorParticipante { get; set; }
        public int cantidadPartidas { get; set; }

    }
    public class PartidaGanadaPorDepartamento
    {
        public string departamento { get; set; }
        public int partidasGanadas { get; set; }
    }
    internal class Controlador
    {
        private List<Participante> listaParticipantes;
        private List<Partida> listaPartidas;

        public Controlador()
        {
            listaParticipantes = new List<Participante>();
            listaPartidas = new List<Partida>();
        }

        public List<Participante> getListaParticipantes
        {
            get { return listaParticipantes; }
        }
        public List<Partida> getListaPartidas
        {
            get { return listaPartidas; }
        }

        public void registrarParticipante(int dni, string nombre, string departamento, int anioNacimiento, int nivelJuego)
        {
            Participante objParticipante = new Participante(dni, nombre, departamento, anioNacimiento, nivelJuego);
            listaParticipantes.Add(objParticipante);
        }

        public void registrarPartida(string codigo, Participante primerParticipante, Participante segundoParticipante, string colorFichaPrimerParticipante, string colorFichaSegundoParticipante, string ganador)
        {
            Partida objPartida = new Partida(codigo, primerParticipante, segundoParticipante, colorFichaPrimerParticipante, colorFichaSegundoParticipante, ganador);
            listaPartidas.Add(objPartida);
        }

        public List<PartidaGanadaPorDepartamento> partidasGanadasPorDepartamento()
        {
            Dictionary<string, int> pGanadasPorDepartamento = new Dictionary<string, int>();
            List<PartidaGanadaPorDepartamento> listaTemporal = new List<PartidaGanadaPorDepartamento>();
            foreach (Partida partida in listaPartidas)
            {
                string ganador = partida.getGanador;
                string departamentoGanador = "";
                if (ganador == "Negras")
                {
                    departamentoGanador = partida.getColorFichaPrimerParticipante == "Negras" ? partida.getPrimerParticipante.getDepartamento : partida.getSegundoParticipante.getDepartamento;
                }
                else if (ganador == "Blancas")
                {
                    departamentoGanador = partida.getColorFichaPrimerParticipante == "Blancas" ? partida.getPrimerParticipante.getDepartamento : partida.getSegundoParticipante.getDepartamento;
                }
                if (departamentoGanador != "")
                {
                    if (!pGanadasPorDepartamento.ContainsKey(departamentoGanador))
                    {
                        pGanadasPorDepartamento[departamentoGanador] = 0;
                    }
                    pGanadasPorDepartamento[departamentoGanador]++;
                }
            }
            foreach (KeyValuePair<string, int> entry in pGanadasPorDepartamento)
            {
                listaTemporal.Add(new PartidaGanadaPorDepartamento { departamento = entry.Key, partidasGanadas = entry.Value });
            }
            return listaTemporal;
        }

        public List<Participante> listaParticipantesMayorEdad()
        {
            int anioActual = DateTime.Now.Year;

            int mayorEdad = listaParticipantes.Max(participante => anioActual - participante.getAnioNacimiento);
            List<Participante> listaTemporal = listaParticipantes.Where(participante => anioActual - participante.getAnioNacimiento == mayorEdad).ToList();
            return listaTemporal;
        }

        public List<PartidaPorColorParticipante> getMayorCantidadPartidasPorColor(string color)
        {
            var partidasPorColor = new Dictionary<string, PartidaPorColorParticipante>();

            foreach (var partida in listaPartidas)
            {
                if (partida.getColorFichaPrimerParticipante == color)
                {
                    var primerParticipante = partida.getPrimerParticipante.getNombre;
                    var keyPrimerParticipante = primerParticipante + "-" + color;

                    if (!partidasPorColor.ContainsKey(keyPrimerParticipante))
                    {
                        partidasPorColor[keyPrimerParticipante] = new PartidaPorColorParticipante { nombreParticipante = primerParticipante, colorParticipante = color, cantidadPartidas = 0 };
                    }
                    partidasPorColor[keyPrimerParticipante].cantidadPartidas++;
                }

                if (partida.getColorFichaSegundoParticipante == color)
                {
                    var segundoParticipante = partida.getSegundoParticipante.getNombre;
                    var keySegundoParticipante = segundoParticipante + "-" + color;

                    if (!partidasPorColor.ContainsKey(keySegundoParticipante))
                    {
                        partidasPorColor[keySegundoParticipante] = new PartidaPorColorParticipante { nombreParticipante = segundoParticipante, colorParticipante = color, cantidadPartidas = 0 };
                    }
                    partidasPorColor[keySegundoParticipante].cantidadPartidas++;
                }
            }

            int maxCantidad = partidasPorColor.Values.Max(x => x.cantidadPartidas);
            return partidasPorColor.Values.Where(x => x.cantidadPartidas == maxCantidad).ToList();
        }
        public List<PartidaPorColorParticipante> getListaPartidaPorColorParticipante()
        {
            var partidasPorColor = new Dictionary<string, PartidaPorColorParticipante>();

            foreach (var partida in listaPartidas)
            {
                var primerParticipante = partida.getPrimerParticipante.getNombre;
                var colorPrimerParticipante = partida.getColorFichaPrimerParticipante;
                var keyPrimerParticipante = primerParticipante + "-" + colorPrimerParticipante;

                if (!partidasPorColor.ContainsKey(keyPrimerParticipante))
                {
                    partidasPorColor[keyPrimerParticipante] = new PartidaPorColorParticipante { nombreParticipante = primerParticipante, colorParticipante = colorPrimerParticipante, cantidadPartidas = 0 };
                }
                partidasPorColor[keyPrimerParticipante].cantidadPartidas++;

                var segundoParticipante = partida.getSegundoParticipante.getNombre;
                var colorSegundoParticipante = partida.getColorFichaSegundoParticipante;
                var keySegundoParticipante = segundoParticipante + "-" + colorSegundoParticipante;

                if (!partidasPorColor.ContainsKey(keySegundoParticipante))
                {
                    partidasPorColor[keySegundoParticipante] = new PartidaPorColorParticipante { nombreParticipante = segundoParticipante, colorParticipante = colorSegundoParticipante, cantidadPartidas = 0 };
                }
                partidasPorColor[keySegundoParticipante].cantidadPartidas++;
            }

            int maxCantidad = partidasPorColor.Values.Max(x => x.cantidadPartidas);
            return partidasPorColor.Values.ToList();
        }

        public List<CantidadParticipantesPorNivel> getNivelesConMenorCantidadParticipantes()
        {
            var participantesPorNivel = new Dictionary<int, int>();

            foreach (var participante in listaParticipantes)
            {
                var nivel = participante.getNivelJuego;
                if (!participantesPorNivel.ContainsKey(nivel))
                {
                    participantesPorNivel[nivel] = 0;
                }
                participantesPorNivel[nivel]++;
            }

            var minCantidad = participantesPorNivel.Values.Min();
            var nivelesConMenorCantidad = participantesPorNivel.Where(x => x.Value == minCantidad).Select(x => new CantidadParticipantesPorNivel { nivel = x.Key, cantidadParticipantes = x.Value }).ToList();

            return nivelesConMenorCantidad;
        }
    }
}
