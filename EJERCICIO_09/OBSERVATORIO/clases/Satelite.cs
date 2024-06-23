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

	}
}
