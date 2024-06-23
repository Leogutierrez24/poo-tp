using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIDEPORTIVO.clases;

namespace POLIDEPORTIVO.formularios
{
    public partial class NuevaReserva_frm : Form
    {
        private readonly Polideportivo polideportivo;

        private Cancha canchaSeleccionada;

        public NuevaReserva_frm(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
        }

        private void EstablecerOpcionales()
        {
            Opcionales_comboBox.Enabled = true;
            Opcionales_comboBox.Items.Clear();
            if (canchaSeleccionada.Tipo == TipoCancha.Tenis || canchaSeleccionada.Tipo == TipoCancha.FutbolSiete)
            {
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Opcional 1: Agregar juez");
            } else if (canchaSeleccionada.Tipo == TipoCancha.FutbolCinco)
            {
                Opcionales_comboBox.Enabled = false;
            } else
            {
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Opcional 1: Agregar juez");
                Opcionales_comboBox.Items.Add("Opcional 2: Opcional 1 más dos jueces de línea");
            }
        }

        private void EstablecerValoresHorario()
        {
            
        }

        private void NuevaReserva_frm_Load(object sender, EventArgs e)
        {
            polideportivo.Canchas.ForEach(cancha => Cancha_comboBox.Items.Add(cancha));
            Cancha_comboBox.SelectedIndex = 0;
            canchaSeleccionada = Cancha_comboBox.SelectedItem as Cancha;
            EstablecerOpcionales();
        }

        private void ConsultarAlquileres_btn_Click_1(object sender, EventArgs e)
        {
            if (canchaSeleccionada != null)
            {
                Alquileres_listBox.Items.Clear();
                List<Alquiler> alquileres = polideportivo.BuscarAlquileres(canchaSeleccionada, Fecha_monthCalendar.TodayDate);
                if (alquileres.Count != 0)
                {
                    alquileres.ForEach(alquiler => Alquileres_listBox.Items.Add(alquiler));
                }
                else Alquileres_listBox.Items.Add("No hay alquileres en esta fecha.");
            }
        }

        private void Cancha_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            canchaSeleccionada = Cancha_comboBox.SelectedItem as Cancha;
            EstablecerOpcionales();
        }

        
    }
}
