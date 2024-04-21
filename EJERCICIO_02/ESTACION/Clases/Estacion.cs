using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Estacion
    {
		private readonly List<Surtidor> surtidores;
		public List<Surtidor> Surtidores
		{
			get { return surtidores; }
		}

		private readonly List<Nafta> naftas;
		public List<Nafta> Naftas
		{
			get { return naftas; }
		}

		private List<Venta> ventas = new List<Venta>();
		public List<Venta> Ventas
		{
			get { return ventas; }
		}

		private float recaudacion;
		public float Recaudacion
		{
			get { return recaudacion; }
		}

		public Estacion()
		{
			naftas = new List<Nafta>
			{
				new Nafta(TipoNafta.Normal),
				new Nafta(TipoNafta.Super),
				new Nafta(TipoNafta.Premium),
			};

			surtidores = new List<Surtidor>();
			naftas.ForEach(nafta => surtidores.Add(new Surtidor(nafta)));

			recaudacion = 0;
		}

		public Venta NuevaVenta(Surtidor surtidor, float cantidad)
		{
			int resultado = surtidor.Descargar(cantidad);
			Venta v;
			if (resultado == 0)
			{
				v = new Venta(surtidor, cantidad);
				ventas.Add(v);
				recaudacion += v.Total;
			} else
			{
				v = null;
			}
			
			return v;
		}

		public Surtidor SurtidorMayorRecaudacion()
		{
			float mayorRecaudacion = surtidores.Max(surtidor => surtidor.Recaudacion);
			return surtidores.Find(surtidor => surtidor.Recaudacion == mayorRecaudacion);
		}

		public Surtidor SurtidorMenorRecaudacion()
		{
            float menorRecaudacion = surtidores.Min(surtidor => surtidor.Recaudacion);
            return surtidores.Find(surtidor => surtidor.Recaudacion == menorRecaudacion);
        }

		public Surtidor SurtidorMasClientes()
		{
			int cantClientes = 0;
			Surtidor masClientes = null;

			surtidores.ForEach(surtidor =>
			{
				IEnumerable<Venta> v = ventas.Where(venta => venta.Surtidor == surtidor);
				if (v?.Count() > cantClientes)
				{
                    cantClientes = v.Count();
                    masClientes = surtidor;
                }
			});

			return masClientes;
		}

		public Surtidor SurtidorMasRecargas()
		{
			int mayorRecargas = surtidores.Max(surtidor => surtidor.Recargas);
			return surtidores.First(surtidor => surtidor.Recargas == mayorRecargas);
		}

		public List<(Nafta, float)> PorcentajeVentaNaftas()
		{
            List<(Nafta, float)> porcentajes = new List<(Nafta, float)>();

			naftas.ForEach(nafta =>
			{
				int ventasNafta = ventas.Count(venta => venta.Surtidor.Nafta.Tipo == nafta.Tipo);
				float porcentaje = (ventasNafta * 100) / ventas.Count;
				porcentajes.Add((nafta, porcentaje));
			});
			
			return porcentajes;
        }

		public List<(Nafta, float)> PorcentajeRecaudacionNaftas()
		{
			List<(Nafta, float)> porcentajes = new List<(Nafta, float)>();

			naftas.ForEach(nafta =>
			{
				float porcentaje = (nafta.TotalVendido * 100) / recaudacion;
				porcentajes.Add((nafta, porcentaje));
			});

			return porcentajes;
		}

		public List<(Surtidor, float)> PromedioVentaSurtidores()
		{
            List<(Surtidor, float)> porcentajes = new List<(Surtidor, float)>();

            surtidores.ForEach(surtidor =>
            {
                int ventasSurtidor = ventas.Count(venta => venta.Surtidor == surtidor);
                float porcentaje = (ventasSurtidor * 100) / ventas.Count;
                porcentajes.Add((surtidor, porcentaje));
            });

            return porcentajes;
        }

		public List<(Surtidor, float)> PromedioRecaudacionSurtidores()
		{
            List<(Surtidor, float)> porcentajes = new List<(Surtidor, float)>();

			surtidores.ForEach(surtidor =>
			{
				float porcentaje = (surtidor.Recaudacion * 100) / recaudacion;
				porcentajes.Add((surtidor, porcentaje));
			});

            return porcentajes;
        }
	}
}
