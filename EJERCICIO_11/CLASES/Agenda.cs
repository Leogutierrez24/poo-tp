using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Agenda
    {
		private List<TurnoConsulta> turnoAgendados = new List<TurnoConsulta>();
		public List<TurnoConsulta> TurnosAgendados
		{
			get { return turnoAgendados; }
		}

		public void AgendarTurno(TurnoConsulta turno)
		{
			turnoAgendados.Add(turno);
		}
	}
}
