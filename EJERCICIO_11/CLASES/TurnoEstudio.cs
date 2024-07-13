using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class TurnoEstudio : Turno
    {
		private Estudio estudio;
		public Estudio Estudio
		{
			get { return estudio; }
			set { estudio = value; }
		}

	}
}
