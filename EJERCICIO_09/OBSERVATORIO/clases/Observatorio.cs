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
			InicializarCuerposCelestes();
		}

		private void InicializarCuerposCelestes()
		{
			Satelite luna = new Satelite("Luna", 0.01230f, 4.53f, true);
			Estrella sol = new Estrella("Sol", 3330598439.44f, 4.603f, 1.3927f, TipoEstrella.Gigante, Color.Blanca);
			List<Satelite> s = new List<Satelite> { luna };
			PlanetaSimple tierra = new PlanetaSimple("Tierra", 1, 4.54f, sol, 150f, 13.9f, s, true, true);
			RegistrarCuerpoCeleste(luna);
			RegistrarCuerpoCeleste(sol);
			RegistrarCuerpoCeleste(tierra);
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

		public List<Estrella> ObtenerEstrellas()
		{
			List<Estrella> estrellas = new List<Estrella>();

			foreach(CuerpoCeleste e in cuerposRegistrados)
			{
				if (e is Estrella) estrellas.Add(e as Estrella);
			}

			return estrellas;
		}

		public List<Satelite> ObtenerSatelites()
		{
            List<Satelite> satelites = new List<Satelite>();

            foreach (CuerpoCeleste s in cuerposRegistrados)
            {
                if (s is Satelite) satelites.Add(s as Satelite);
            }

            return satelites;
        }
	
		public List<PlanetaSimple> BuscarPlaneta(string nombre)
		{
			List<PlanetaSimple> planetas = ObtenerPlanetas();

			return planetas.FindAll(planeta => planeta.Nombre.Contains(nombre));
		}

		public List<PlanetaSimple> BuscarPlanetaPorHabitabilidad()
		{
            List<PlanetaSimple> planetas = ObtenerPlanetas();

            return planetas.FindAll(planeta => planeta.Habitabilidad);
        }

		public List<PlanetaSimple> BuscarPlanetaPorEstrella(string nombreEstrella)
		{
            List<PlanetaSimple> planetas = ObtenerPlanetas();
			List<PlanetaSimple> planetasObtenidos = new List<PlanetaSimple>();

			foreach(PlanetaSimple planeta in planetas)
			{
				if (planeta.Estrella.Nombre.Contains(nombreEstrella))
				{
					planetasObtenidos.Add(planeta);
				}

				if (planeta is PlanetaBinario)
				{
					PlanetaBinario p = planeta as PlanetaBinario;
                    if (p.SegundaEstrella.Nombre.Contains(nombreEstrella))
                    {
                        planetasObtenidos.Add(p);
                    }
                }
			}

			return planetasObtenidos;
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
