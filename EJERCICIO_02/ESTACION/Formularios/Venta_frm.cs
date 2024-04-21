using ESTACION.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTACION.Formularios
{
    public partial class Venta_frm : Form
    {
        private readonly Estacion estacion;

        private readonly Surtidor surtidor;

        public Venta_frm(Estacion estacion, Surtidor surtidor)
        {
            InitializeComponent();
            this.estacion = estacion;
            this.surtidor = surtidor;
        }

        private void Venta_frm_Load(object sender, EventArgs e)
        {
            Nafta_textBox.Text = surtidor.Nafta.Tipo.ToString();
            carga_textBox.Text = surtidor.Carga.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cantidad = (float)carga_numericUpDown.Value;
            if (cantidad <= surtidor.Carga)
            {
                Venta ventaGenerada = estacion.NuevaVenta(surtidor, cantidad);
                if (ventaGenerada != null) MessageBox.Show("Se generó la venta con éxito.");
                else MessageBox.Show("No se pudo realizar la venta.");
                Close();
            }
            else MessageBox.Show("¡La capacidad de descarga no puede ser mayor a la disponible en el surtidor!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
