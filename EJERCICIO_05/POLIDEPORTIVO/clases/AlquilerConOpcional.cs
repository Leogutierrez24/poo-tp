using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLIDEPORTIVO.clases
{
    public class AlquilerConOpcional : Alquiler
    {
		private Juez primerJuez;
		public Juez PrimerJuez
		{
			get { return primerJuez; }
		}

		public AlquilerConOpcional (DateTime fecha, int inicio, int duracion, Cancha cancha, Juez juez) : base (fecha, inicio, duracion, cancha)
		{
			primerJuez = juez;
            primerJuez.Remunerar(50f);
            this.total = duracion * (cancha.Precio + 100);
		}

		public void EstablecerPrimerJuez(Juez juez)
		{
			primerJuez = juez;
		}

		public static new int CalcularPrecio(Cancha cancha, int duracion)
		{
			return duracion * (cancha.Precio + 100);

        }
	}
}
