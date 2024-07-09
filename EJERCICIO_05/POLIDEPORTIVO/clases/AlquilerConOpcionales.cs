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
            DateTime fecha,
            int inicio,
            int duracion,
            Cancha cancha,
            Juez juez, 
            Juez primerLinea,
            Juez segundoLinea) : base (fecha, inicio, duracion, cancha, juez)
        {
            primerJuezLinea = primerLinea;
            segundoJuezLinea = segundoLinea;
            primerJuezLinea.Remunerar(35);
            segundoJuezLinea.Remunerar(35);
            this.total += 90;
        }

        public void EstablecerJuecesDeLinea(Juez primerJuez, Juez segundoJuez)
        {
            primerJuezLinea = primerJuez;
            segundoJuezLinea = segundoJuez;            
        }

        public static new int CalcularPrecio(Cancha cancha, int duracion)
        {
            return duracion * (cancha.Precio + 100) + 90;
        }
    }
}
