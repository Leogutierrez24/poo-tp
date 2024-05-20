using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class Alquiler
    {
		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private int horaInicio;
		public int HoraInicio
		{
			get { return horaInicio; }
			set { horaInicio = value; }
		}

		private int horaFin;
		public int HoraFin
		{
			get { return horaFin; }
			set { horaFin = value; }
		}

		private float total;
		public float Precio
		{
			get { return total; }
			set { total = value; }
		}

		public Alquiler() { }

	}
}
