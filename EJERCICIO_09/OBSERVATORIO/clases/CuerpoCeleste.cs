using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public abstract class CuerpoCeleste
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private float edad;
		public float Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		private float masa;
		public float Masa
		{
			get { return masa; }
			set { masa = value; }
		}		
	}
}
