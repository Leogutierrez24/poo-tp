using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACION.Clases
{
    public class Nafta
    {
		private TipoNafta tipo;
		public TipoNafta Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private float precio;
		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private float totalVendido;
		public float TotalVendido
		{
			get { return totalVendido; }
			set { totalVendido = value; }
		}

		public Nafta(TipoNafta tipo)
		{
			this.tipo = tipo;
			this.precio = SetPrecio(tipo);
		}

		private float SetPrecio(TipoNafta tipo)
		{
			float precio;
			if (tipo == TipoNafta.Normal) precio = 17.20f;
			else if (tipo == TipoNafta.Super) precio = 18.85f;
			else if (tipo == TipoNafta.Premium) precio = 21.30f;
			else precio = -1;
			return precio;
		}

        public override string ToString()
        {
            return tipo.ToString();
        }
    }
}
