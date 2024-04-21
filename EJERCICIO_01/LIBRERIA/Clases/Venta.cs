using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBRERIA.Clases
{
    public class Venta
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

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

        public void QuitarTodos()
        {
            productos.Clear();
        }

        public float CalcularTotal()
        {
            float total = 0;
            productos.ForEach(producto => total += producto.Precio);
            return total;
        }

        public override string ToString()
        {
            return string.Format("{0} ${1:0.0}", id, CalcularTotal());
        }
    }
}
