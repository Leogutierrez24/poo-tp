using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Constelacion
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private List<Estrella> estrellas;
		public List<Estrella> Estrellas
		{
			get { return estrellas; }
			set { estrellas = value; }
		}
	}
}
