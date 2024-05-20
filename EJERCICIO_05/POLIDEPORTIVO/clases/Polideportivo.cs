using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class Polideportivo
    {
		private List<Cancha> canchas;
		public List<Cancha> Canchas
		{
			get { return canchas; }
			set { canchas = value; }
		}

		private List<Juez> jueces;
		public List <Juez> Jueces
		{
			get { return jueces; }
			set { jueces = value; }
		}

		private List<Alquiler> alquileres;
		public List<Alquiler> Alquileres
		{
			get { return alquileres; }
			set { alquileres = value; }
		}

		public Polideportivo()
		{
			canchas = new List<Cancha>
			{
				new Cancha(TipoCancha.Tenis),
				new Cancha(TipoCancha.FutbolCinco),
				new Cancha(TipoCancha.FutbolSiete),
				new Cancha(TipoCancha.FutbolOnce),
			};
		}
	}
}
