using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Estudio
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private float costo;
		public float Costo
		{
			get { return costo; }
			set { costo = value; }
		}

		private OrdenMedica orden;
		public OrdenMedica Orden
		{
			get { return orden; }
			set { orden = value; }
		}
	}
}
