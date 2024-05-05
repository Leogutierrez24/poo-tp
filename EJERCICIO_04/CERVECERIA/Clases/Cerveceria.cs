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

	}
}
