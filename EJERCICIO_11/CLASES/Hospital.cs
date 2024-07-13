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

		private List<TurnoConsulta> FiltrarTurnosConsulta()
		{
			List<TurnoConsulta> turnosFiltrados = new List<TurnoConsulta>();
			turnos.ForEach(turno =>
			{
				if (turno is TurnoConsulta tConsulta)
				{
					turnosFiltrados.Add(tConsulta);
				}
			});
			return turnosFiltrados;
		}

		private List<TurnoConsulta> FiltrarTurnosPorMedico(Medico medico, List<TurnoConsulta> listaTurnos)
		{
            List<TurnoConsulta> turnosFiltrados = new List<TurnoConsulta>();
            listaTurnos.ForEach(turno =>
            {
                if (turno.Medico.Documento == medico.Documento)
                {
                    turnosFiltrados.Add(turno);
                }
            });
            return turnosFiltrados;
        }

		public void DisponibilidadTurnoConsulta()
		{
			List<TurnoConsulta> turnos = new List<TurnoConsulta>();
		}

		public void AgendarTurno(TurnoConsulta turno)
		{
			turnos.Add(turno);
			turno.Medico.Agenda.AgendarTurno(turno);
		}
	}
}
