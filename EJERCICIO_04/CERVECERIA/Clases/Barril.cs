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
		}

		private float capacidad;
		public float Capacidad
		{
			get { return capacidad; }
		}

		private float recaudacion;
		public float Recaudacion
		{
			get { return recaudacion; }
		}

		private float cantidadVendida;
		public float CantidadVendida
		{
			get { return cantidadVendida; }
		}

		public Barril() { }

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
				recaudacion += (cantidad * cerveza.Precio) * 1.05f;
				cantidadVendida += cantidad;
			}
			else resultado = -1;
			return resultado;
		}

		public void EstablecerCerveza(Cerveza cerveza)
		{
			this.cerveza = cerveza;
		}

        public override string ToString()
        {
            return $"Barril {id}";
        }
    }
}
