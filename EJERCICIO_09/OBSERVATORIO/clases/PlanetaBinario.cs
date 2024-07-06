using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class PlanetaBinario : PlanetaSimple
    {
        private Estrella segundaEstrella;
        public Estrella SegundaEstrella
        {
            get { return segundaEstrella; }
            set { segundaEstrella = value; }
        }

        private float segundaDistancia;
        public float SegundaDistancia
        {
            get { return segundaDistancia; }
            set { segundaDistancia = value; }
        }

        public PlanetaBinario(string nombre,
            float masa,
            float edad,
            Estrella primeraEstrella,
            float primeraDistancia,
            Estrella segundaEstrella,
            float segundaDistancia,
            float temp,
            List<Satelite> satelites,
            bool habitabilidad,
            bool ricitos) : base(nombre, masa, edad, primeraEstrella, primeraDistancia, temp, satelites, habitabilidad, ricitos)
        {
            this.segundaEstrella = segundaEstrella;
            this.segundaDistancia = segundaDistancia;
        }
    }
}
