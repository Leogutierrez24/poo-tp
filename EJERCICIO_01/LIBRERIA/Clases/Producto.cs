using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Producto
    {
		private string codigoBarra;
		public string CodigoBarra
		{
			get { return codigoBarra; }
			set { codigoBarra = value; }
		}

		private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private float precio;
		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private string descripcion;
		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		public Producto(string codigoBarra, string nombre, float precio, string descripcion = "")
		{
			this.codigoBarra = codigoBarra;
			this.nombre = nombre;
			this.precio = precio;
			this.descripcion = descripcion;
		}

        public override string ToString()
        {
            return $"{Nombre} {CodigoBarra} ${Precio}";
        }
    }
}
