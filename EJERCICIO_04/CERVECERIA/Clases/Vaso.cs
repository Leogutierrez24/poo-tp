using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERVECERIA.Clases
{
    public class Vaso
    {
		private TipoVaso tipo;
		public TipoVaso Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private float capacidad;
		public float Capacidad
		{
			get => capacidad;
			set => capacidad = value;
		}

		private int solicitudes;
		public int Solicitudes
		{
			get { return solicitudes; }
		}

		public Vaso(TipoVaso tipo)
		{
			this.tipo = tipo;
			capacidad = DeterminarCapcidad(tipo);
		}

		private float DeterminarCapcidad(TipoVaso tipo)
		{
			float capacidad;
			if (tipo == TipoVaso.Chopp) capacidad = 0.75f;
			else if (tipo == TipoVaso.Vaso) capacidad = 0.50f;
			else capacidad = 3f;
			return capacidad;
		}

		public void Solicitar()
		{
			solicitudes++;
		}

        public override string ToString()
        {
            return Tipo.ToString();
        }
    }
}
