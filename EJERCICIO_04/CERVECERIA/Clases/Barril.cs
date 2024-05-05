using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERVECERIA.Clases
{
    public class Barril
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private Cerveza cerveza;
		public Cerveza Cerveza
		{
			get { return cerveza; }
			set { cerveza = value; }
		}

		private float capacidad;
		public float Capacidad
		{
			get { return capacidad; }
			set { capacidad = value; }
		}

		public Barril(int id, Cerveza cerveza)
		{
			this.id = id;
			this.cerveza = cerveza;
			capacidad = 20f;
		}

		public int Descargar(float cantidad)
		{
			int resultado = 0;
			if (cantidad <= capacidad)
			{
				capacidad -= cantidad;
			}
			else resultado = -1;
			return resultado;
		}

	}
}
