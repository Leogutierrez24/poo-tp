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

		protected float distancia;
		public float Distancia
		{
			get { return distancia; }
			set { distancia = value; }
		}

		protected float temperatura;
		public float Temperatura
		{
			get { return temperatura; }
			set { temperatura = value; }
		}

		private List<Satelite> satelites = new List<Satelite>();
		public List<Satelite> Satelites
		{
			get { return satelites; }
			set { satelites = value; }
		}

		protected bool habitabilidad;
		public bool Habitabilidad
		{
			get { return habitabilidad; }
			set { habitabilidad = value; }
		}

		protected bool ricitos;
		public bool Ricitos
		{
			get { return ricitos; }
			set { ricitos = value; }
		}

        public PlanetaSimple(string nombre, float masa, float edad, Estrella estrella, float distancia, float temp, List<Satelite> satelites, bool habitabilidad, bool ricitos)
		{
			this.nombre = nombre;
			this.masa = masa;
			this.edad = edad;
			this.estrella = estrella;
			this.distancia = distancia;
			temperatura = temp;
			if(satelites.Count != 0) AgregarSatelites(satelites);
			this.habitabilidad = habitabilidad;
			this.ricitos = ricitos;
		}

		public void AgregarSatelite(Satelite satelite)
		{
			satelites.Add(satelite);
		}

		public void AgregarSatelites(List<Satelite> satelites)
		{
			satelites.ForEach(satelite => this.satelites.Add(satelite));
		}

		public void Actualizar(string nombre, float masa, float edad, float distancia, float temp, bool habitabilidad, bool ricitos)
		{
			this.nombre = nombre;
			this.masa = masa;
			this.edad = edad;
			this.distancia= distancia;
			temperatura = temp;
			this.habitabilidad = habitabilidad;
			this.ricitos = ricitos;
		}
    }
}
