using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Registro
    {
		private Persona observador;
		public Persona Observador
		{
			get { return observador; }
			set { observador = value; }
		}

		private DateTime fechaAvistamiento;
		public DateTime FechaAvistamiento
		{
			get { return fechaAvistamiento; }
			set { fechaAvistamiento = value; }
		}

		private CuerpoCeleste cuerpo;
		public CuerpoCeleste Cuerpo
		{
			get { return cuerpo; }
			set { cuerpo = value; }
		}

		private float distancia;
		public float Distancia
		{
			get { return distancia; }
			set { distancia = value; }
		}
	}
}
