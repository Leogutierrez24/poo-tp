using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Paciente
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private int documento;
		public int Documento
		{
			get { return documento; }
			set { documento = value; }
		}

	}
}
