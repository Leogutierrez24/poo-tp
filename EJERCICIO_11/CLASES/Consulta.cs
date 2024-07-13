﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class Consulta : IComparable<Consulta>
    {
		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private Medico medico;
		public Medico Medico
		{
			get { return medico; }
			set { medico = value; }
		}

		private Paciente paciente;
		public Paciente Paciente
		{
			get { return paciente; }
			set { paciente = value; }
		}

		private float costo;
		public float Costo
		{
			get { return costo; }
			set { costo = value; }
		}

		private string tratamiento;
		public string Tratamiento
		{
			get { return tratamiento; }
			set { tratamiento = value; }
		}


		public int CompareTo(Consulta other)
        {
            if (other == null) return 1;
			else
			{
				return fecha.CompareTo(other.fecha)*-1;
			}
        }

		public float CalcularCosto()
		{
			return medico.Costo * (medico.Especialidades.Count > 0 ? medico.Especialidades.Count : 1);
		}
    }
}
