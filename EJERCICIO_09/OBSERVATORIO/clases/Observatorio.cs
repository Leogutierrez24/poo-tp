using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVATORIO.clases
{
    public class Observatorio
    {
		private List<Registro> registros;
		public List<Registro> Registros
		{
			get { return registros; }
			set { registros = value; }
		}

		private List<CuerpoCeleste> cuerposRegistrados;
		public List<CuerpoCeleste> CuerposRegistrados
		{
			get { return cuerposRegistrados; }
			set { cuerposRegistrados = value; }
		}

		private List<Constelacion> constelaciones;
		public List<Constelacion> Constelaciones
		{
			get => constelaciones;
			set => constelaciones = value;
		}

		public void RegistrarCuerpoCeleste(CuerpoCeleste cuerpo)
		{
			cuerposRegistrados.Add(cuerpo);
		}
	}
}
