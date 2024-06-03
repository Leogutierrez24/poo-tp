using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class Alquiler
    {
		private DateTime inicio;
		public DateTime Inicio
		{
			get { return inicio; }
			set { inicio = value; }
		}

		private DateTime fin;
		public DateTime Fin
		{
			get { return fin; }
			set { fin = value; }
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

		public Alquiler(DateTime inicio, DateTime fin, Cancha cancha) 
		{
			this.inicio = inicio;
			this.fin = fin;
			this.cancha = cancha;
			this.total = (fin.Hour - inicio.Hour) * cancha.Precio;
			this.cancha.Alquilar();
        }
	}
}
