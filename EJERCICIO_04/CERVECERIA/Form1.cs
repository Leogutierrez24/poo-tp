using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CERVECERIA.Clases;

namespace CERVECERIA
{
    public partial class Form1 : Form
    {

        private Cerveceria cerveceria;

        private Barril barrilSeleccionado;

        private Vaso vasoSeleccionado;

        public Form1()
        {
            InitializeComponent();
            this.cerveceria = new Cerveceria();
        }

        private void CargarBarriles()
        {
            Barriles_comboBox.Items.Clear();
            cerveceria.Barriles.ForEach(barril =>
            {
                Barriles_comboBox.Items.Add(barril);
            });
        }

        private void CargarCervezas()
        {
            Cervezas_comboBox.Items.Clear();
            cerveceria.Cervezas.ForEach(cerveza =>
            {
                Cervezas_comboBox.Items.Add(cerveza);
            });
        }

        private void CargarVasos()
        {
            radioButton1.Text = cerveceria.Vasos[0].ToString();
            radioButton2.Text = cerveceria.Vasos[1].ToString();
            radioButton3.Text = cerveceria.Vasos[2].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarBarriles();
            CargarCervezas();
            ActualizarBarrilInfo();
            CargarVasos();
            totalVenta_lbl.Text = "$00,00";
        }

        private void ActualizarTotal()
        {
            if (barrilSeleccionado != null)
            {
                if (radioButton1.Checked) totalVenta_lbl.Text = string.Format("${0:0.00}", Venta.CalcularTotal(barrilSeleccionado.Cerveza, cerveceria.Vasos[0]));
                if (radioButton2.Checked) totalVenta_lbl.Text = string.Format("${0:0.00}", Venta.CalcularTotal(barrilSeleccionado.Cerveza, cerveceria.Vasos[1]));
                if (radioButton3.Checked) totalVenta_lbl.Text = string.Format("${0:0.00}", Venta.CalcularTotal(barrilSeleccionado.Cerveza, cerveceria.Vasos[2]));
            }
        }

        private void ActualizarBarrilInfo()
        {
            if (barrilSeleccionado != null)
            {
                label5.Text = barrilSeleccionado.Cerveza.ToString();
                label6.Text = string.Format("${0:0.00}", barrilSeleccionado.Cerveza.Precio);
                label7.Text = string.Format("{0:0.00}", barrilSeleccionado.Capacidad);
            } else
            {
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
            }
        }

        private void Barriles_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            barrilSeleccionado = Barriles_comboBox.SelectedItem as Barril;
            ActualizarBarrilInfo();
            ActualizarTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Cervezas_comboBox.SelectedItem != null)
            {
                Cerveza cervezaElegida = Cervezas_comboBox.SelectedItem as Cerveza;
                Barril nuevoBarril = new Barril(cerveceria.Barriles.Count + 1, cervezaElegida);
                cerveceria.AgregarBarril(nuevoBarril);
                MessageBox.Show($"Nuevo barril agregado: {nuevoBarril}");
                CargarBarriles();
            }
            else MessageBox.Show("Elegí una cerveza");
        }

        private void Cervezas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cerveza cervezaElegida = Cervezas_comboBox.SelectedItem as Cerveza;
            label10.Text = string.Format("${0:0.0}", cervezaElegida.Precio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarBarrilInfo();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }
    }
}
