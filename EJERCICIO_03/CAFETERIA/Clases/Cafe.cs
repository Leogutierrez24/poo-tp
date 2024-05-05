using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFETERIA.Clases
{
    public class Cafe
    {
		private TipoCafe tipo;
		public TipoCafe Tipo
		{
			get { return tipo; }
		}

		private float precio;
		public float Precio
		{
			get { return precio; }
		}

		private int vecesServido = 0;
		public int VecesServido
		{
			get { return vecesServido; }
		}

		private float recaudacion = 0;
		public float Recaudacion
		{
			get { return recaudacion; }
			set { recaudacion = value; }
		}

		public Cafe(TipoCafe tipo)
		{
			this.tipo = tipo;
			this.precio = CalcularPrecio(tipo);
		}

		private float CalcularPrecio(TipoCafe tipo)
		{
			float precio = 0;
			if (tipo == TipoCafe.Arabigo) precio = 50f;
			else if (tipo == TipoCafe.Robusto) precio = 58f;
			return precio;
		}


		public void Servido()
		{
			vecesServido++;
		}

        public override string ToString()
        {
            return $"{tipo} - ${precio}";
        }
    }
}
