using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Constelacion
    {
		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private List<Estrella> estrellas = new List<Estrella>();
		public List<Estrella> Estrellas
		{
			get { return estrellas; }
		}

		public Constelacion() { }
		public Constelacion(string nombre) => this.nombre = nombre;

		public void AgregarEstrella(Estrella estrella)
		{
			estrellas.Add(estrella);
		}

        public override string ToString()
        {
            return nombre;
        }

    }
}
