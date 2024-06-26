using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
	public class Observatorio
	{
		private List<Registro> registros;
		public List<Registro> Registros
		{
			get { return registros; }
			set { registros = value; }
		}

		private List<CuerpoCeleste> cuerposRegistrados;
		public List<CuerpoCeleste> CuerposRegistrados
		{
			get { return cuerposRegistrados; }
			set { cuerposRegistrados = value; }
		}

		private List<Constelacion> constelaciones;
		public List<Constelacion> Constelaciones
		{
			get => constelaciones;
			set => constelaciones = value;
		}

		public Observatorio()
		{
			registros = new List<Registro>();
			cuerposRegistrados = new List<CuerpoCeleste>();
			constelaciones = new List<Constelacion>();
		}

		public void RegistrarCuerpoCeleste(CuerpoCeleste cuerpo)
		{
			cuerposRegistrados.Add(cuerpo);
		}

		public void ModificarCuerpoCeleste()
		{
			// todo
		}

		public float ConvertirCelsius(float tempFahrenheit)
		{
			return (tempFahrenheit - 32) * 5 / 9;
		}

		public float ConvertirFahrenheit(float tempCelsius)
		{
			return (tempCelsius * 9 / 5) + 32;
        }

		public List<PlanetaSimple> ObtenerPlanetas()
		{
            List<PlanetaSimple> planetas = new List<PlanetaSimple>();

            foreach (CuerpoCeleste p in cuerposRegistrados)
            {
                if (p is PlanetaSimple) planetas.Add(p as PlanetaSimple);
				if (p is PlanetaBinario) planetas.Add(p as PlanetaBinario);
            }

			return planetas;
        }

		private List<Estrella> ObtenerEstrellas()
		{
			List<Estrella> estrellas = new List<Estrella>();

			foreach(Estrella e in cuerposRegistrados)
			{
				if (e is Estrella) estrellas.Add(e as Estrella);
			}

			return estrellas;
		}

		public List<Satelite> ObtenerSatelites()
		{
            List<Satelite> satelites = new List<Satelite>();

            foreach (Satelite s in cuerposRegistrados)
            {
                if (s is Satelite) satelites.Add(s as Satelite);
            }

            return satelites;
        }
	
		public PlanetaSimple BuscarPlaneta(string nombre)
		{
			List<PlanetaSimple> planetas = ObtenerPlanetas();

			 return planetas.Find(planeta => planeta.Nombre == nombre);
		}

		public List<PlanetaSimple> BuscarPlanetas(Estrella estrella)
		{
			List<PlanetaSimple> planetas = ObtenerPlanetas();

			foreach(PlanetaSimple p in planetas)
			{
				if (p.Estrella.Nombre == estrella.Nombre) planetas.Add(p);
				if (p is PlanetaBinario)
				{
					PlanetaBinario pBinario = (PlanetaBinario)p;
					if (pBinario.Estrella.Nombre == estrella.Nombre || pBinario.SegundaEstrella.Nombre == estrella.Nombre) planetas.Add(pBinario);
				}
			}

            return planetas;
        }

		public List<PlanetaSimple> BuscarPlanetas(bool habitabilidad)
		{
            List<PlanetaSimple> planetas = ObtenerPlanetas();

			return planetas.FindAll(planeta => planeta.Habitabilidad == habitabilidad);
        }

		public List<Estrella> BuscarEstrellas(Color color, TipoEstrella tipo)
		{
			List<Estrella> estrellas = ObtenerEstrellas();

			return estrellas.FindAll(estrella => estrella.Color == color && estrella.Tipo == tipo);
        }

		public List<Estrella> BuscarEstrellas(float temperatura)
		{
            List<Estrella> estrellas = ObtenerEstrellas();

            return estrellas.FindAll(estrella => estrella.Temperatura == temperatura);
        }

		public List<Estrella> BuscarEstrellas(Constelacion constelacion)
		{
			Constelacion c = constelaciones.Find(cons => cons.Nombre == constelacion.Nombre);
			return c.Estrellas;
		}
	}
}
