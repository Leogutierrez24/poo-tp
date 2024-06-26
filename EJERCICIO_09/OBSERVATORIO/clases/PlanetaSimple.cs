using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class PlanetaSimple : CuerpoCeleste
    {
		private Estrella estrella;
		public Estrella Estrella
		{
			get { return estrella; }
			set { estrella = value; }
		}

		private float distancia;
		public float Distancia
		{
			get { return distancia; }
			set { distancia = value; }
		}

		private float temperatura;
		public float Temperatura
		{
			get { return temperatura; }
			set { temperatura = value; }
		}

		private List<Satelite> satelites;
		public List<Satelite> Satelites
		{
			get { return satelites; }
			set { satelites = value; }
		}

		private bool habitabilidad;
		public bool Habitabilidad
		{
			get { return habitabilidad; }
			set { habitabilidad = value; }
		}

		private bool ricitos;
		public bool Ricitos
		{
			get { return ricitos; }
			set { ricitos = value; }
		}
	}
}
