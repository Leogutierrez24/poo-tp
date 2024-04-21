using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Venta
    {
		private Surtidor surtidor;
		public Surtidor Surtidor
		{
			get { return surtidor; }
			set { surtidor = value; }
		}

		private float cantidad;
		public float Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}

		private float total;
		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		public Venta(Surtidor surtidor, float cantidad)
		{
			this.surtidor = surtidor;
			this.cantidad = cantidad;
			total = CalcularSubtotal(surtidor.Nafta, cantidad);
			this.surtidor.SetRecaudacion(total);
			this.surtidor.Nafta.TotalVendido += total;
		}

		public static float CalcularSubtotal(Nafta nafta, float cantidad)
		{
			return nafta.Precio * cantidad;
		}
    }
}
