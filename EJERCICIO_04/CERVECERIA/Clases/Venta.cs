using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERVECERIA.Clases
{
    public class Venta
    {
		private Barril barril;
		public Barril Barril
		{
			get { return barril; }
			set { barril = value; }
		}

		private Vaso vaso;
		public Vaso Vaso
		{
			get { return vaso; }
			set { vaso = value; }
		}

		public Venta(Barril barril, Vaso vaso)
		{
			this.barril = barril;
			this.vaso = vaso;
			vaso.Solicitar();
		}

		public static float CalcularTotal(Cerveza cerveza, Vaso vaso)
		{
			return (cerveza.Precio * vaso.Capacidad) * 1.05f;
		}
	}
}
