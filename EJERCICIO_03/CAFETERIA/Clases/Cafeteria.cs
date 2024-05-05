using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
	public class Cafeteria
	{
		private readonly List<Cafe> cafes = new List<Cafe>();
		public List<Cafe> Cafes
		{
			get { return cafes; }
		}

		private readonly List<Vaso> vasos = new List<Vaso>();
		public List<Vaso> Vasos
		{
			get { return vasos; }
		}

		private List<Cafetera> cafeteras = new List<Cafetera>();
		public List<Cafetera> Cafeteras
		{
			get { return cafeteras; }
		}

		public Cafeteria()
		{
			cafes = new List<Cafe>
			{
				new Cafe(TipoCafe.Arabigo),
				new Cafe(TipoCafe.Robusto),
			};

			vasos = new List<Vaso>
			{
				new Vaso(TipoVaso.Chico),
				new Vaso(TipoVaso.Mediano),
				new Vaso(TipoVaso.Grande),
			};

			cafeteras = new List<Cafetera>
			{
				new Cafetera(cafes[0], 1),
				new Cafetera(cafes[1], 2),
			};
		}

        public static float CalcularTotal(Vaso vaso, Cafe cafe)
        {
            return vaso.Medida * cafe.Precio;
        }

        public void AgregarCafetera(Cafe cafe)
		{
			Cafetera c = new Cafetera(cafe, cafeteras.Count + 1);
			cafeteras.Add(c);
		}

		public float CalcularRecaudacionTotal()
		{
			float recaudacion = 0;
			cafeteras.ForEach(cafetera => recaudacion += cafetera.Recaudacion);
			return recaudacion;
		}

		public Cafetera CafeteraMasSirvio()
		{
			float litrosMaximos = cafeteras.Max(cafetera => cafetera.CantidadServida);
			return cafeteras.Find(cafetera => cafetera.CantidadServida == litrosMaximos);
		}

		public Cafetera CafeteraMenosSirvio()
		{
			float litrosMinimos = cafeteras.Min(cafetera => cafetera.CantidadServida);
			return cafeteras.Find(cafetera => cafetera.CantidadServida == litrosMinimos);
		}

		public Cafetera CafeteraMayorRecaudacion()
		{
			float recaudacionMaxima = cafeteras.Max(cafetera => cafetera.Recaudacion);
			return cafeteras.Find(cafetera => cafetera.Recaudacion == recaudacionMaxima);
		}

		public Cafetera CafeteraMenorRecaudacion()
		{
			float recaudacionMinima = cafeteras.Min(cafetera => cafetera.Recaudacion);
			return cafeteras.Find(cafetera => cafetera.Recaudacion == recaudacionMinima);
		}

		public Cafe CafeMasServido()
		{
			int maxServido = cafes.Max(cafe => cafe.VecesServido);
			return cafes.Find(cafe => cafe.VecesServido == maxServido);
		}

		public Cafe CafeMenosServido()
        {
            int minServido = cafes.Min(cafe => cafe.VecesServido);
            return cafes.Find(cafe => cafe.VecesServido == minServido);
        }

		public List<(Cafe, float)> PromedioRecaudacionCafes()
		{
			List<(Cafe, float)> promedios = new List<(Cafe, float)>();
			float recaudacionTotal = 0;
			cafes.ForEach(cafe => recaudacionTotal += cafe.Recaudacion);
			cafes.ForEach(cafe =>
			{
				float promedio = (cafe.Recaudacion * 100) / recaudacionTotal;
                promedios.Add((cafe, promedio));
			});

			return promedios;
		}

		public List<(Cafetera, float)> PromedioRecaudacionCafetera()
		{
			List<(Cafetera, float)> promedios = new List<(Cafetera, float)>();
			float recaudacionTotal = 0;
			cafeteras.ForEach(cafetera => recaudacionTotal += cafetera.Recaudacion);
			cafeteras.ForEach(cafetera =>
			{
				float promedio = (cafetera.Recaudacion * 100) / recaudacionTotal;
				promedios.Add((cafetera, promedio));
			});
			return promedios;
		}

		/*public List<(Cafe, float)> PromedioVentasCafe()
		{

		}

		public List<(Cafetera, float)> PromedioVentasCafetera()
		{

		}*/

		public Cafetera CafeteraMasRecargas()
		{
			int maxRecargas = cafeteras.Max(cafetera => cafetera.Recargas);
			return cafeteras.Find(cafetera => cafetera.Recargas == maxRecargas);
		}

		public Cafe CafeMenosRecaudacion()
		{
			float maxRecaudacion = cafes.Max(cafe => cafe.Recaudacion);
			return cafes.Find(cafe => cafe.Recaudacion == maxRecaudacion);
		}

		public Cafe CafeMayorRecaudacion()
		{
			float minRecaudacion = cafes.Min(cafe => cafe.Recaudacion);
			return cafes.Find(cafe => cafe.Recaudacion == minRecaudacion);
		}
    }
}
