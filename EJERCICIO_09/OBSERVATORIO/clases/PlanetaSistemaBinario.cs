using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class PlanetaSistemaBinario : PlanetaSistemaSimple
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
    }
}
