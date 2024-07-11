using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class OrdenMedica
    {
		private string diagnostico;
		public string Diagnostico
		{
			get { return diagnostico; }
			set { diagnostico = value; }
		}

		private Medico medico;
		public Medico Medico
		{
			get { return medico; }
			set { medico = value; }
		}

	}
}
