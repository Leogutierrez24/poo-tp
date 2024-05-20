using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class Cancha
    {
		private readonly TipoCancha tipo;
		public TipoCancha Tipo
		{
			get { return tipo; }
		}

		private readonly int precio;
		public int Precio
		{
			get { return precio; }
		}

		public Cancha(TipoCancha tipo)
		{
			this.tipo = tipo;
			this.precio = CalcularPrecio(tipo);
		}

		private int CalcularPrecio(TipoCancha tipo)
		{
			int precio;
			if (tipo == TipoCancha.Tenis) precio = 200;
			else if (tipo == TipoCancha.FutbolCinco) precio = 500;
			else if (tipo == TipoCancha.FutbolSiete) precio = 650;
			else precio = 800;
			return precio;
		}
	}
}
