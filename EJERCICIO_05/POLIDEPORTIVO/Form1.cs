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
using System.Diagnostics.Eventing.Reader;

namespace POLIDEPORTIVO
{
    public partial class Form1 : Form
    {
        private readonly Polideportivo polideportivo;

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
            LimpiarCamposAlquiler();
            LimpiarCamposCancha();
            LimpiarCamposJuez();
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
                Alquiler alquilerSeleccionado = Alquileres_listBox.SelectedItem as Alquiler;
                tipoCanchaAlquiler_lbl.Text = alquilerSeleccionado.Cancha.ToString();
                totalAlquiler_lbl.Text = string.Format("${0:0.00}", alquilerSeleccionado.Total);
                fechaAlquiler_lbl.Text = alquilerSeleccionado.Fecha.ToShortDateString();
                horaInicio_lbl.Text = $"{alquilerSeleccionado.HoraInicio} hrs";
                horaFin_lbl.Text = $"{alquilerSeleccionado.HoraInicio + alquilerSeleccionado.Duracion} hrs";
                tipoAlquiler_lbl.Text = "Sin opcionales";
                primerJuez_lbl.Text = "No contiene";
                primerLinea_lbl.Text = "No contiene";
                segundoLinea_lbl.Text = "No contiene";
                if (alquilerSeleccionado is AlquilerConOpcionales aConOpcionales)
                {
                    tipoAlquiler_lbl.Text = "Con opcional 2";
                    primerJuez_lbl.Text = aConOpcionales.PrimerJuez.ToString();
                    primerLinea_lbl.Text = aConOpcionales.PrimerJuezLinea.ToString();
                    segundoLinea_lbl.Text = aConOpcionales.SegundoJuezLinea.ToString();
                } else if (alquilerSeleccionado is AlquilerConOpcional aConOpcional)
                {
                    tipoAlquiler_lbl.Text = "Con opcional 1";
                    primerJuez_lbl.Text = aConOpcional.PrimerJuez.ToString();
                }
                
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
            CargarAlquileres();
        }

        private void VerRecaudacion_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("${0:0.00}", polideportivo.CalcularRecaudacion()));
        }
    }
}
