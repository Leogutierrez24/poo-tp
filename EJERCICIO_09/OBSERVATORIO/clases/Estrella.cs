using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Estrella : CuerpoCeleste
    {
		private float temperatura;
		public float Temperatura
		{
			get { return temperatura; }
			set { temperatura = value; }
		}

		private Color color;
		public Color Color
		{
			get { return color; }
			set { color = value; }
		}

		private TipoEstrella tipo;
		public TipoEstrella Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private float diametro;
		public float Diametro
		{
			get { return diametro; }
			set { diametro = value; }
		}

		// Falta agregar la constelación

	}
}
