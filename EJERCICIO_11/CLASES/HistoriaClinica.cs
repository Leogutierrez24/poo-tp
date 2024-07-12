using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class HistoriaClinica
    {
		private Paciente paciente;
		public Paciente Paciente
		{
			get { return paciente; }
			set { paciente = value; }
		}

		private List<Estudio> estudios;
		public List<Estudio> Estudios
		{
			get { return estudios; }
			set { estudios = value; }
		}

		private List<Consulta> consultas;
		public List<Consulta> Consultas
		{
			get { return consultas; }
			set { consultas = value; }
		}

		private List<Turno> turnos;
		public List<Turno> Turnos
		{
			get { return turnos; }
			set { turnos = value; }
		}

		public HistoriaClinica(Paciente paciente)
		{
			this.paciente = paciente;
		}

	}
}
