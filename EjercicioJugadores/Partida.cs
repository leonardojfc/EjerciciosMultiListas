using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJugadores
{
    internal class Partida
    {
        private string codigo;
        private Participante primerParticipante;
        private Participante segundoParticipante;
        private string colorFichaPrimerParticipante;
        private string colorFichaSegundoParticipante;
        private string ganador;

        public Partida(string codigo, Participante primerParticipante, Participante segundoParticipante, string colorFichaPrimerParticipante, string colorFichaSegundoParticipante, string ganador)
        {
            this.codigo = codigo;
            this.primerParticipante = primerParticipante;
            this.segundoParticipante = segundoParticipante;
            this.colorFichaPrimerParticipante = colorFichaPrimerParticipante;
            this.colorFichaSegundoParticipante = colorFichaSegundoParticipante;
            this.ganador = ganador;
        }

        public string getCodigo
        {
            get { return codigo; }
        }

        public Participante getPrimerParticipante
        {
            get { return primerParticipante; }
        }
        public Participante getSegundoParticipante
        {
            get { return segundoParticipante; }
        }
        public string getColorFichaPrimerParticipante
        {
            get { return colorFichaPrimerParticipante; }
        }
        public string getColorFichaSegundoParticipante
        {
            get { return colorFichaSegundoParticipante; }
        }
        public string getGanador
        {
            get { return ganador; }
        }

    }
}
