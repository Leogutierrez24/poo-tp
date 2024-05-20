using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERVECERIA.Clases
{
    public class Cerveceria
    {
		private List<Cerveza> cervezas;
		public List<Cerveza> Cervezas
		{
			get { return cervezas; }
		}

		private List<Vaso> vasos;
		public List<Vaso> Vasos
		{
			get { return vasos; }
		}

		private List<Barril> barriles = new List<Barril>();
		public List<Barril> Barriles
		{
			get { return barriles; }
		}

		private List<Venta> ventas;
		public List<Venta> Ventas
		{
			get { return ventas; }
		}

		public Cerveceria()
		{
			cervezas = new List<Cerveza>
			{
				new Cerveza(TipoCerveza.RubiaNacional),
				new Cerveza(TipoCerveza.NegraNacional),
				new Cerveza(TipoCerveza.RubiaExtranjera),
			};

			vasos = new List<Vaso>
			{
				new Vaso(TipoVaso.Chopp),
				new Vaso(TipoVaso.Vaso),
				new Vaso(TipoVaso.Jarra),
			};
		}

		public float CalcularRecaudacion()
		{
			float recaudacion = 0;
			barriles.ForEach(barril => recaudacion += barril.Recaudacion);
			return recaudacion;
		}

		public Barril ObtenerBarrilMasSirvio()
		{
			Barril masSirvio = null;
			barriles.ForEach(barril =>
			{
				if (masSirvio == null || barril.CantidadVendida > masSirvio.CantidadVendida)
				{
					masSirvio = barril;
				}
			});
			return masSirvio;
		}

		public Barril ObtenerBarrilMenosSirvio()
		{
			Barril menosSirvio = null;
			barriles.ForEach(barril =>
			{
				if (menosSirvio == null || barril.CantidadVendida < menosSirvio.CantidadVendida)
				{
					menosSirvio = barril;
				}
			});
			return menosSirvio;
		}

		public Barril ObtenerBarrilMasRecaudacion()
		{
			float recaudacionMaxima = barriles.Max(barril => barril.Recaudacion);
			return barriles.Find(barril => barril.Recaudacion == recaudacionMaxima);
		}

		public Cerveza ObtenerCervezaMasVendida()
		{
			int totalVentas = 0;
			Cerveza cerveza = cervezas[0];
			for (int i = 0; i < cervezas.Count - 1; i++)
			{
                int auxVentas = 0;
                for (int j = 0; j < ventas.Count - 1; j++)
				{
					if (ventas[j].Barril.Cerveza.Tipo == cerveza.Tipo) auxVentas++;
				}
				
				if(auxVentas > totalVentas)
				{
					cerveza = cervezas[i];
				}

                auxVentas = 0;
            }
			return cerveza;
		}

		public Cerveza ObtenerCervezaMasServida()
		{
			Cerveza cervezaMasServida = cervezas[0];
			float totalServido = 0f;
			
			for (int j = 0; j < cervezas.Count - 1; j++)
			{
                for (int i = 0; i < this.barriles.Count - 1; i++)
                {
                    List<Barril> barriles = this.barriles.FindAll(barril => barril.Cerveza.Tipo == cervezas[j].Tipo);
                    float totalAux = 0f;
                    barriles.ForEach(barril => totalAux += barril.CantidadVendida);
					if (totalAux > totalServido)
					{
						cervezaMasServida = cervezas[j];
						totalServido = totalAux;
					}
				}
            }
			return cervezaMasServida;
		}

        public Cerveza ObtenerCervezaMenosServida()
        {
            Cerveza cervezaMenosServida = cervezas[0];
            float totalServido = 0f;

            for (int j = 0; j < cervezas.Count - 1; j++)
            {
                for (int i = 0; i < this.barriles.Count - 1; i++)
                {
                    List<Barril> barriles = this.barriles.FindAll(barril => barril.Cerveza.Tipo == cervezas[j].Tipo);
                    float totalAux = 0f;
                    barriles.ForEach(barril => totalAux += barril.CantidadVendida);
                    if (totalAux < totalServido)
                    {
                        cervezaMenosServida = cervezas[j];
                        totalServido = totalAux;
                    }
                }
            }
            return cervezaMenosServida;
        }

		public Vaso ObtenerVasoMasSolicitado()
		{
			int vecesSolicitado = vasos.Max(vaso => vaso.Solicitudes);
			return vasos.Find(vaso => vaso.Solicitudes == vecesSolicitado);
		}

		public void CalcularPorcentajeVentaCervezas()
		{

		}

		public void CalcularPorcentajeRecaudacionCerveza()
		{

		}

		public void CalcularPorcentajeVentaBarriles()
		{

		}

		public void CalcularPorcentajeRecaudacionBarriles()
		{

		}

		public int NuevaVenta(Barril barril, Vaso vaso)
		{
			int resultado = barril.Descargar(vaso.Capacidad);
			if (resultado == 0)
			{
				Venta v = new Venta(barril, vaso);
				ventas.Add(v);
			}
			return resultado;
		}

		public void AgregarBarril(Barril barril)
		{
			barriles.Add(barril);
		}
    }
}
