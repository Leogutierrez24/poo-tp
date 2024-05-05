using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERVECERIA.Clases
{
    public class Cerveza
    {
		private TipoCerveza tipo;
		public TipoCerveza Tipo
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

		public Cerveza(TipoCerveza tipo)
		{
			this.tipo = tipo;
			precio = DeterminarPrecio(tipo);
		}

		private float DeterminarPrecio(TipoCerveza tipo)
		{
			float precio;
			if (tipo == TipoCerveza.RubiaNacional) precio = 50f;
			else if (tipo == TipoCerveza.NegraNacional) precio = 58f;
			else precio = 65f;
			return precio;
		}

	}
}
