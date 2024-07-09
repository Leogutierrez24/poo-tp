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

		private int duracion;
		public int Duracion
		{
			get { return duracion; }
			set { duracion = value; }
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

		public Alquiler()
		{

		}

		public Alquiler(DateTime fecha, int horaInicio, int duracion, Cancha cancha) 
		{
			this.fecha = fecha;
			this.horaInicio = horaInicio;
			this.duracion = duracion;
			this.cancha = cancha;
			total = duracion * cancha.Precio;
			this.cancha.Alquilar(total);
        }

        public override string ToString()
        {
            return $"{cancha.Tipo} | {fecha.ToShortDateString()} | {horaInicio} hrs";
        }

		public static int CalcularPrecio(Cancha cancha, int duracion)
		{
			return cancha.Precio * duracion;
		}
    }
}
