using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIBRERIA.Clases;

namespace LIBRERIA
{
    public partial class Form1 : Form
    {
        private readonly Libreria libreria;

        private Venta venta;

        public Form1()
        {
            InitializeComponent();
            libreria = new Libreria();
            venta = new Venta();
        }

        private void ActualizarListBox<T>(ListBox listBox, List<T> lista)
        {
            listBox.Items.Clear();
            lista.ForEach(item => listBox.Items.Add(item));
        }

        private void LimpiarCamposProducto()
        {
            ProductoNombre_textBox.Text = string.Empty;
            ProductoCodigo_textBox.Text = string.Empty;
            ProductoPrecio_numericUpDown.Value = 0;
            ProductoDescripcion_textBox.Text = string.Empty;
        }

        // Agregar Producto

        private void AgregarProducto_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProductoNombre_textBox.Text) &&
                !string.IsNullOrWhiteSpace(ProductoCodigo_textBox.Text) &&
                ProductoPrecio_numericUpDown.Value > 0)               
            {
                Producto p = new Producto
                (
                    ProductoCodigo_textBox.Text,
                    ProductoNombre_textBox.Text,
                    (float)ProductoPrecio_numericUpDown.Value
                );
                libreria.NuevoProducto(p);
                MessageBox.Show($"Se agregó el producto: {p.Nombre}");
                ActualizarListBox(Productos_listBox, libreria.Productos);
                LimpiarCamposProducto();
            } else
            {
                MessageBox.Show("¡Hay campos vacíos!");
            }
        }

        private void CancelarProducto_btn_Click(object sender, EventArgs e)
        {
            LimpiarCamposProducto();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListBox(Productos_listBox, libreria.Productos);
        }

        // Nueva venta

        private void AgregarAlCarrito_btn_Click(object sender, EventArgs e)
        {
            if (Productos_listBox.SelectedItems.Count > 0)
            {
                Producto prodSeleccionado = Productos_listBox.SelectedItem as Producto;
                this.venta.AgregarProducto(prodSeleccionado);
                Subtotal_lbl.Text = string.Format("$ {0:0.00}", venta.CalcularTotal());
                ActualizarListBox(Carrito_listBox, venta.Productos);
            }
            else MessageBox.Show("Selecciona un producto para agregar.");
        }

        private void QuitarDelCarrito_btn_Click(object sender, EventArgs e)
        {
            if (Carrito_listBox.SelectedItems.Count > 0)
            {
                Producto prodSeleccionado = Productos_listBox.SelectedItem as Producto;
                this.venta.QuitarProducto(prodSeleccionado);
                Subtotal_lbl.Text = string.Format("$ {0:0.00}", venta.CalcularTotal());
                ActualizarListBox(Carrito_listBox, venta.Productos);
            }
            else MessageBox.Show("Selecciona un producto para quitar.");
        }

        private void FinalizarVenta_btn_Click(object sender, EventArgs e)
        {
            if (venta.Productos.Count > 0)
            {
                libreria.NuevaVenta(venta);
                venta = null;
                GC.Collect();
                venta = new Venta();
                ActualizarListBox(Ventas_listBox, libreria.Ventas);
                Carrito_listBox.Items.Clear();
                Subtotal_lbl.Text = "$ 0,00";
                Recaudacion_lbl.Text = string.Format("$ {0:0.00}", libreria.Recaudacion);
            }
            else MessageBox.Show("No hay productos por vender.");
        }

        private void CancelarVenta_btn_Click(object sender, EventArgs e)
        {
            if (venta.Productos.Count > 0)
            {
                venta.QuitarTodos();
                Carrito_listBox.Items.Clear();
            }
        }

        // Detalle ventas

        private void Ventas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Venta ventaSeleccionada = Ventas_listBox.SelectedItem as Venta;
            ActualizarListBox(VentaProductos_listBox, ventaSeleccionada.Productos);
        }
    }
}
