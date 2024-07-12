using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Agenda
    {
		private List<TurnoConsulta> turnoAgendados;
		public List<TurnoConsulta> TurnosAgendados
		{
			get { return turnoAgendados; }
			set { turnoAgendados = value; }
		}

	}
}
