using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class Juez
    {
		private readonly string nombre;
		public string Nombre
		{
			get { return nombre; }
		}

		private readonly string apellido;
		public string Apellido
		{
			get { return apellido; }
		}

		private int legajo;
		public int Legajo
		{
			get { return legajo; }
			set { legajo = value; }
		}

		private float remuneracion;
		public float Remuneracion
		{
			get { return remuneracion; }
		}

		private int partidosDirigidos;
		public int PartidosDirigidos
		{
			get { return partidosDirigidos; }
		}

		public Juez(string nombre, string apellido, int legajo)
		{
			this.nombre = nombre.ToUpper();
			this.apellido = apellido.ToUpper();
			this.legajo = legajo;
			remuneracion = 0;
			partidosDirigidos = 0;
		}

		public Juez(string nombre, string apellido)
		{
			this.nombre = nombre.ToUpper();
			this.apellido = apellido.ToUpper();
			this.legajo = 0;
            remuneracion = 0;
            partidosDirigidos = 0;
        }

		public void Remunerar(float total)
		{
			if (total > 0)
			{
				partidosDirigidos++;
				remuneracion += total;
			}
		}

        public override string ToString()
        {
			return $"{nombre} {apellido}";
        }
    }
}
