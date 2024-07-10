using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Personal : Persona
    {
		private int legajo;
		public int Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		public Personal(string nombre, string apellido, DateTime fechaNacimiento, int legajo) : base (nombre, apellido, fechaNacimiento)
		{
			this.legajo = legajo;
		}
	}
}
