using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Satelite : CuerpoCeleste
    {
		private bool acoplamientoMarea;
		public bool AcoplamientoMarea
		{
			get { return acoplamientoMarea; }
			set { acoplamientoMarea = value; }
		}

		public Satelite(string nombre, float masa, float edad, bool acoplamientoMarea = false)
		{
			this.nombre = nombre;
			this.masa = masa;
			this.edad = edad;
			this.acoplamientoMarea = acoplamientoMarea;
		}

		public void Actualizar(string nombre, float edad, float masa, bool acoplamiento)
		{
            this.nombre = nombre;
            this.masa = masa;
            this.edad = edad;
            acoplamientoMarea = acoplamiento;
        }

	}
}
