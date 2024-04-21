using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Libreria
    {
		private List<Producto> productos;
		public List<Producto> Productos
		{
			get { return productos; }
			set { productos = value; }
		}

		private List<Venta> ventas = new List<Venta>();
		public List<Venta> Ventas
		{
			get { return  ventas; }
			set {  ventas = value; }
		}

		private float recaudacion;
		public float Recaudacion
		{
			get { return recaudacion; }
		}

		public Libreria()
		{
			productos = new List<Producto>
			{
				new Producto("213AS212", "Lapiz", 425f, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."),
				new Producto("321PE765", "Borra Tinta", 789f, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."),
				new Producto("876FE320", "Tijera", 2400f, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."),
			};

			recaudacion = 0;
		}

		public void NuevoProducto(Producto producto)
		{
			productos.Add(producto);
		}

		public void NuevaVenta(Venta venta)
		{
			venta.Id = ventas.Count + 1;
			ventas.Add(venta);
			recaudacion += venta.CalcularTotal();
		}

	}
}
