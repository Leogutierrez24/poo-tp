using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public abstract class CuerpoCeleste
    {
		protected string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		protected float edad;
		public float Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		protected double masa;
		public double Masa
		{
			get { return masa; }
			set { masa = value; }
		}

        public override string ToString()
        {
            return nombre;
        }
    }
}
