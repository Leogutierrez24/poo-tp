using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Hospital
    {
		private List<Medico> medicos;
		public List<Medico> Medicos
		{
			get { return medicos; }
			set { medicos = value; }
		}

		private List<Especialidad> especialidades;
		public List<Especialidad> Especialidades
		{
			get { return especialidades; }
			set { especialidades = value; }
		}

		private List<Paciente> pacientes;
		public List<Paciente> Pacientes
		{
			get { return pacientes; }
			set { pacientes = value; }
		}

		private List<HistoriaClinica> historiasClinicas;
		public List<HistoriaClinica> HistoriasClinicas
		{
			get { return historiasClinicas; }
			set { historiasClinicas = value; }
		}

		private List<Turno> turnos;
		public List<Turno> Turnos
		{
			get { return turnos; }
			set { turnos = value; }
		}

		public Hospital()
		{

		}

		public void RegistrarMedico(Medico medico)
		{
			medicos.Add(medico);
		}

		public void IngresarPaciente(Paciente paciente)
		{
			HistoriaClinica nuevaHistoriaClinica = new HistoriaClinica(paciente);
			historiasClinicas.Add(nuevaHistoriaClinica);
			pacientes.Add(paciente);
		}

		public void AgregarEspecialidad(Especialidad especialidad)
		{
			especialidades.Add(especialidad);
		}

		public void AgendarTurno(Turno turno)
		{
			turnos.Add(turno);
		}
	}
}
