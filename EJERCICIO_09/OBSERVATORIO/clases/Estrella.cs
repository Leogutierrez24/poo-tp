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

		private double diametro;
		public double Diametro
		{
			get { return diametro; }
			set { diametro = value; }
		}

        public Estrella(string nombre, float masa, float edad, float diametro, TipoEstrella tipo, Color color, float temperatura)
		{
			this.nombre = nombre;
			this.masa = masa;
			this.edad = edad;
			this.diametro = diametro;
			this.tipo = tipo;
			this.color = color;
			this.temperatura = temperatura;
		}
    }
}
