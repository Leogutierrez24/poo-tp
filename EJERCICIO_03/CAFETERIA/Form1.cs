using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAFETERIA.Clases;
using CAFETERIA.Formularios;

namespace CAFETERIA
{
    public partial class Form1 : Form
    {
        private readonly Cafeteria cafeteria;

        private Cafetera cafeteraSeleccionada;

        public Form1()
        {
            InitializeComponent();
            cafeteria = new Cafeteria();
        }

        private void CargarCafeteras()
        {
            Cafeteras_comboBox.Items.Clear();
            cafeteria.Cafeteras.ForEach(cafetera =>
            {
                Cafeteras_comboBox.Items.Add(cafetera);
            });
        }

        private void CargarCafetera()
        {
            tipoCafe_lbl.Text = cafeteraSeleccionada.Cafe.Tipo.ToString();
            precioCafe_lbl.Text = string.Format("${0:0.00}", cafeteraSeleccionada.Cafe.Precio);
            cafeDisponible_lbl.Text = string.Format("{0:0.00} Litros", cafeteraSeleccionada.Capacidad);
        }

        private Vaso DeterminarVaso()
        {
            Vaso v;
            if (vasoChico_radioButton.Checked) v = new Vaso(TipoVaso.Chico);
            else if (vasoMediano_radioButton.Checked) v = new Vaso(TipoVaso.Mediano);
            else v = new Vaso(TipoVaso.Grande);
            return v;
        }

        private void ActualizarTotal()
        {
            total_lbl.Text = string.Format("${0:0.0}", Cafeteria.CalcularTotal(DeterminarVaso(), cafeteraSeleccionada.Cafe));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cafeteraSeleccionada = cafeteria.Cafeteras[0];
            CargarCafeteras();
            Cafeteras_comboBox.SelectedIndex = 0;
            CargarCafetera();
        }

        private void Cafeteras_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cafeteraSeleccionada = Cafeteras_comboBox.SelectedItem as Cafetera;
            CargarCafetera();
            ActualizarTotal();
        }

        private void AgregarCafetera_btn_Click(object sender, EventArgs e)
        {
            NuevaCafetera_frm form = new NuevaCafetera_frm(cafeteria);
            form.ShowDialog();
            CargarCafeteras();
        }

        private void RecargarCafetera_btn_Click(object sender, EventArgs e)
        {
            int resultado = cafeteraSeleccionada.Recargar();

            if (resultado == 0)
            {
                MessageBox.Show($"{cafeteraSeleccionada} fue recargada.");
                CargarCafetera();
            }
            else MessageBox.Show("¡La cafetera esta llena!");

        }

        private void ServirCafe_btn_Click(object sender, EventArgs e)
        {
            Vaso vasoSeleccionado= DeterminarVaso();

            int resultado = cafeteraSeleccionada.Servir(vasoSeleccionado);

            if (resultado == 0)
            {
                MessageBox.Show("Cafe servido!");
                CargarCafetera();
            }
            else MessageBox.Show("No hay suficiente cafe para servir!");
        }

        private void vasoChico_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void vasoMediano_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void vasoGrande_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
        }

        private void VerInforme_btn_Click(object sender, EventArgs e)
        {
            Informe_frm form = new Informe_frm(cafeteria);
            form.ShowDialog();
        }
    }
}
