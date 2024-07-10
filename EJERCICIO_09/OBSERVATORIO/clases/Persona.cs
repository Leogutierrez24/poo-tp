using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Persona
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

		private DateTime fechaNacimiento;
		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}

		public Persona(string nombre, string apellido, DateTime fechaNacimiento)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.fechaNacimiento = fechaNacimiento;
		}
	}
}
