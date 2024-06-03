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

		public AlquilerConOpcional (DateTime inicio, DateTime fin, Cancha cancha, Juez juez) : base (inicio, fin, cancha)
		{
			primerJuez = juez;
            primerJuez.Remunerar(50f);
            this.total = (fin.Hour - inicio.Hour) * (cancha.Precio + 100);
		}

	}
}
