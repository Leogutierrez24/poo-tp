using POLIDEPORTIVO.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIDEPORTIVO.formularios;

namespace POLIDEPORTIVO
{
    public partial class Form1 : Form
    {
        private Polideportivo polideportivo;

        public Form1()
        {
            InitializeComponent();
            polideportivo = new Polideportivo();
        }

        private void CargarListBox<T>(ListBox listBox, List<T> lista)
        {
            listBox.Items.Clear();
            lista.ForEach(item => listBox.Items.Add(item));
        }

        private void CargarCanchas()
        {
            CargarListBox(Canchas_listBox, polideportivo.Canchas);
        }

        private void CargarJueces()
        {
            CargarListBox(Jueces_listBox, polideportivo.Jueces);
        }

        private void CargarAlquileres()
        {
            CargarListBox(Alquileres_listBox, polideportivo.Alquileres);
        }

        private void LimpiarCamposCancha()
        {
            tipoCancha_lbl.Text = string.Empty;
            precioCancha_lbl.Text = string.Empty;
            recaudacionCancha_lbl.Text = string.Empty;
            cantAlquileresCancha_lbl.Text = string.Empty;
        }

        private void LimpiarCamposJuez()
        {
            nombreJuez_lbl.Text = string.Empty;
            apellidoJuez_lbl.Text = string.Empty;
            legajoJuez_lbl.Text = string.Empty;
            partidosDirigidos_lbl.Text = string.Empty;
            remuneracionJuez_lbl.Text = string.Empty;
        }

        private void LimpiarCamposAlquiler()
        {
            tipoCanchaAlquiler_lbl.Text = string.Empty;
            totalAlquiler_lbl.Text = string.Empty;
            tipoAlquiler_lbl.Text = string.Empty;
            fechaAlquiler_lbl.Text = string.Empty;
            horaInicio_lbl.Text = string.Empty;
            horaFin_lbl.Text = string.Empty;
            primerJuez_lbl.Text = string.Empty;
            primerLinea_lbl.Text = string.Empty;
            segundoLinea_lbl.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCanchas();
            CargarJueces();
            CargarAlquileres();
        }

        private void Canchas_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Canchas_listBox.SelectedItems.Count == 1)
            {
                Cancha cElegida = Canchas_listBox.SelectedItem as Cancha;
                tipoCancha_lbl.Text = cElegida.Tipo.ToString();
                precioCancha_lbl.Text = string.Format("${0:0.00}", cElegida.Precio);
                recaudacionCancha_lbl.Text = string.Format("${0:0.00}", cElegida.Recaudacion);
                cantAlquileresCancha_lbl.Text = cElegida.VecesAlquilada.ToString();
            }
        }

        private void Jueces_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Jueces_listBox.SelectedItems.Count == 1)
            {
                Juez jElegido = Jueces_listBox.SelectedItem as Juez;
                nombreJuez_lbl.Text = jElegido.Nombre;
                apellidoJuez_lbl.Text = jElegido.Apellido;
                legajoJuez_lbl.Text = jElegido.Legajo.ToString();
                partidosDirigidos_lbl.Text = jElegido.PartidosDirigidos.ToString();
                remuneracionJuez_lbl.Text = string.Format("${0:0.00}", jElegido.Remuneracion);
            }
        }

        private void Alquileres_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Alquileres_listBox.SelectedItems.Count == 1)
            {
                tipoCanchaAlquiler_lbl.Text = string.Empty;
                totalAlquiler_lbl.Text = string.Empty;
                tipoAlquiler_lbl.Text = string.Empty;
                fechaAlquiler_lbl.Text = string.Empty;
                horaInicio_lbl.Text = string.Empty;
                horaFin_lbl.Text = string.Empty;
                primerJuez_lbl.Text = string.Empty;
                primerLinea_lbl.Text = string.Empty;
                segundoLinea_lbl.Text = string.Empty;
            }
        }

        private void RegistrarJuez_btn_Click(object sender, EventArgs e)
        {
            RegistroJuez_frm form = new RegistroJuez_frm(polideportivo);
            form.ShowDialog();
            CargarJueces();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquilar_frm form = new Alquilar_frm(polideportivo);
            form.ShowDialog();
        }
    }
}
