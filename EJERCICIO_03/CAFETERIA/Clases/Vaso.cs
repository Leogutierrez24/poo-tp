using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Vaso
    {
		private readonly TipoVaso tipo;
		public TipoVaso Tipo
		{
			get { return tipo; }
		}

		private readonly float medida;
		public float Medida
		{
			get { return medida; }
		}

		private Cafe cafe;
		public Cafe Cafe
		{
			get { return cafe; }
		}

		public Vaso(TipoVaso tipo)
		{
			this.tipo = tipo;
			this.medida = DeterminarMedida(tipo);
		}

		private float DeterminarMedida(TipoVaso tipo)
		{
			float medida;
			if (tipo == TipoVaso.Chico) medida = 0.05f;
			else if (tipo == TipoVaso.Mediano) medida = 0.1f;
			else medida = 0.25f;
			return medida;
		}

		public void AgregarCafe(Cafe cafe)
		{
			this.cafe = cafe;
		}

	}
}
