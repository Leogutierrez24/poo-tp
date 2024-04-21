using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESTACION.Clases;
using ESTACION.Formularios;

namespace ESTACION
{
    public partial class Form1 : Form
    {
        private readonly Estacion estacion;

        private Surtidor surtidor;

        public Form1()
        {
            InitializeComponent();
            estacion = new Estacion();
        }

        private void CargarSurtidores()
        {
            estacion.Surtidores.ForEach(surtidor =>
            {
                Surtidores_comboBox.Items.Add(surtidor);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarSurtidores();
            Surtidores_comboBox.SelectedIndex = 0;
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            tipoNafta_lbl.Text = surtidor.Nafta.Tipo.ToString();
            precioNafta_lbl.Text = surtidor.Nafta.Precio.ToString();
            capacidadSurtidor_lbl.Text = surtidor.Carga.ToString();
            recaudacion_lbl.Text = string.Format("$ {0:0.0}", estacion.Recaudacion);
        }

        private void Surtidores_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            surtidor = Surtidores_comboBox.SelectedItem as Surtidor;
            CargarInformacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (surtidor.Carga < 100)
            {
                surtidor.Recargar();
                CargarInformacion();
            }
            else MessageBox.Show("Capacidad máxima alcanzada.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surtidor.Carga != 0)
            {
                Venta_frm form = new Venta_frm(estacion, (Surtidor)Surtidores_comboBox.SelectedItem);
                form.ShowDialog();
                CargarInformacion();
            }
            else MessageBox.Show("¡El surtidor está vacío!");           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (estacion.Ventas.Count > 0)
            {
                Informes_frm form = new Informes_frm(estacion);
                form.ShowDialog();
            }
            else MessageBox.Show("Debe existir al menos una venta para poder generar informes.");
        }
    }
}
