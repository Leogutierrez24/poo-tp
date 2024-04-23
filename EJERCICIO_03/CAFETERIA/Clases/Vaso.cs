using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Vaso
    {
		private TipoVaso tipo;
		public TipoVaso Tipo
		{
			get { return tipo; }
		}

		private float medida;
		public float Medida
		{
			get { return medida; }
		}

		private Cafe cafe;
		public Cafe Cafe
		{
			get { return cafe; }
		}


		public Vaso()
		{

		}

	}
}
