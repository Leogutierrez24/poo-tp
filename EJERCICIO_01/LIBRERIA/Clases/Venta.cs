using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Venta
    {
        private readonly List<Producto> productos = new List<Producto>();
        public List<Producto> Productos 
        { 
            get { return productos; } 
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void QuitarProducto(Producto producto)
        {
            productos.Remove(producto);
        }

        public float CalcularTotal()
        {
            float total = 0;
            productos.ForEach(producto => total += producto.Precio);
            return total;
        }
    }
}
