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

namespace POLIDEPORTIVO.formularios
{
    public partial class Alquilar_frm : Form
    {
        private readonly Polideportivo polideportivo;

        private Alquiler nuevoAlquiler;

        public Alquilar_frm(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
            nuevoAlquiler = new Alquiler();
        }

        private void CargarOpcionales()
        {
            Cancha cancha = Canchas_comboBox.SelectedItem as Cancha;
            Opcionales_comboBox.Items.Clear();
            Opcionales_comboBox.Enabled = false;

            if (cancha.Tipo == TipoCancha.Tenis || cancha.Tipo == TipoCancha.FutbolSiete)
            {
                Opcionales_comboBox.Enabled = true;
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Adiciona 1 árbitro, aumenta $100 al valor de la cancha");
            }
            else if (cancha.Tipo == TipoCancha.FutbolOnce)
            {
                Opcionales_comboBox.Enabled = true;
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Adiciona 1 árbitro, aumenta $100 al valor de la cancha");
                Opcionales_comboBox.Items.Add("Opcional 1 mas dos arbitros de linea, aumenta $90 al valor total");
            }
        }

        private void Alquilar_frm_Load(object sender, EventArgs e)
        {
            polideportivo.Canchas.ForEach(cancha => Canchas_comboBox.Items.Add(cancha));
            polideportivo.Jueces.ForEach(juez => Jueces_listBox.Items.Add(juez));
        }

        private void Canchas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOpcionales();
            nuevoAlquiler.Cancha = Canchas_comboBox.SelectedItem as Cancha;
            Cancha_textBox.Text = nuevoAlquiler.Cancha.Tipo.ToString();
        }

        private void ComprobarOpcional()
        {
            if (Opcionales_comboBox.SelectedIndex > 0)
            {
                Jueces_listBox.Enabled = true;
                ElegirJueces_btn.Enabled = true;
                if (Opcionales_comboBox.SelectedIndex == 1)
                {
                    Jueces_listBox.SelectionMode = SelectionMode.One;
                } else
                {
                    Jueces_listBox.SelectionMode = SelectionMode.MultiSimple;
                }
            }
            else
            {
                Jueces_listBox.Enabled = false;
                ElegirJueces_btn.Enabled = false;
            }
        }

        private void Opcionales_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarOpcional();
            OpcionalElegido_textBox.Text = Opcionales_comboBox.SelectedItem.ToString();
        }

        private void Alquilar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ElegirJueces_btn_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void Fecha_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            nuevoAlquiler.Fecha = Fecha_dateTimePicker.Value;
            Fecha_textBox.Text = nuevoAlquiler.Fecha.ToShortDateString();
        }

        private void Horario_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            nuevoAlquiler.HoraInicio = (int)Horario_numericUpDown.Value;
            HorarioComienzo_textBox.Text = $"{nuevoAlquiler.HoraInicio} hrs";
        }

        private void Duracion_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            nuevoAlquiler.Duracion = (int)Duracion_numericUpDown.Value;
            HorarioFinalizacion_textBox.Text = $"{nuevoAlquiler.HoraInicio + nuevoAlquiler.Duracion} hrs";
        }
    }
}
