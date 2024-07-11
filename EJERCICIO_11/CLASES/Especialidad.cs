using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Especialidad
    {
		private int codigo;
		public int Codigo
		{
			get { return codigo; }
		}

		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public Especialidad(int codigo, string nombre)
		{
			this.codigo = codigo;
			this.nombre = nombre;
		}

	}
}
