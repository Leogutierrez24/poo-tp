using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public abstract class Turno
    {
		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private int hora;
		public int Hora
		{
			get { return hora; }
			set { hora = value; }
		}

	}
}
