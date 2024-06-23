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
		}

		private int horaInicio;
		public int HoraInicio
		{
			get { return horaInicio; }
		}

		private int horaFin;
		public int HoraFin
		{
			get { return horaFin; }
		}

		private Cancha cancha;
		public Cancha Cancha
		{
			get { return cancha; }
			set { cancha = value; }
		}

		protected float total;
		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		public Alquiler(DateTime fecha, int horaInicio, int horaFin, Cancha cancha) 
		{
			this.fecha = fecha;
			this.horaInicio = horaInicio;
			this.horaFin = horaFin;
			this.cancha = cancha;
			total = (horaFin - horaInicio) * cancha.Precio;
			this.cancha.Alquilar(total);
        }

        public override string ToString()
        {
            return $"{cancha.Tipo} | {fecha.ToShortDateString()} | {horaInicio} a {horaFin}";
        }
    }
}
