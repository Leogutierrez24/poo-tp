using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Medico : Paciente
    {
		private List<Especialidad> especialidades = new List<Especialidad>();
		public List<Especialidad> Especialidades
		{
			get { return especialidades; }
		}

		private Agenda agenda;
		public Agenda Agenda
		{
			get { return agenda; }
			set { agenda = value; }
		}


		public Medico() { }

		public void AgregarEspecialidad(Especialidad especialidad)
		{
			especialidades.Add(especialidad);
		}

		public void AgregarEspecialidad(List<Especialidad> lista)
		{ 
			lista.ForEach(especialidad => especialidades.Add(especialidad));
		}
		
	}
}
