using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class AlquilerConOpcionales : AlquilerConOpcional
    {
        private Juez primerJuezLinea;
        public Juez PrimerJuezLinea
        {
            get { return primerJuezLinea; }
            set { primerJuezLinea = value; }
        }

        private Juez segundoJuezLinea;
        public Juez SegundoJuezLinea
        {
            get { return segundoJuezLinea; }
            set { segundoJuezLinea = value; }
        }

        public AlquilerConOpcionales(
            DateTime inicio,
            DateTime fin,
            Cancha cancha,
            Juez juez, 
            Juez primerLinea,
            Juez segundoLinea) : base (inicio, fin, cancha, juez)
        {
            primerJuezLinea = primerLinea;
            segundoJuezLinea = segundoLinea;
            primerJuezLinea.Remunerar(35);
            segundoJuezLinea.Remunerar(35);
            this.total += 90;
        }
    }
}
