using OBSERVATORIO.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBSERVATORIO.formularios
{
    public partial class VerSatelite_frm : Form
    {
        private readonly Satelite satelite;

        public VerSatelite_frm(Satelite satelite)
        {
            InitializeComponent();
            this.satelite = satelite;
        }

        private void CargarInfo()
        {
            Nombre_textBox.Text = satelite.Nombre;
            Edad_textBox.Text = satelite.Edad.ToString();
            Masa_textBox.Text = satelite.Masa.ToString();
            Acoplamiento_textBox.Text = satelite.AcoplamientoMarea ? "Si" : "No";
        }

        private void VerSatelite_frm_Load(object sender, EventArgs e)
        {
            CargarInfo();
        }

        // Comprobacion de campos
        private bool ComprobarNumero(string texto)
        {
            return float.TryParse(texto, out float numero);
        }

        private bool ComprobarCampoAcoplamiento(string texto)
        {
            bool resultado = false;
            if (texto.ToLower() == "si" || texto.ToLower() == "no") resultado = true;
            return resultado;
        }

        private bool ComprobarAcoplamiento(string texto)
        {
            return texto.ToLower() == "si"; 
        }

        // Botones
        private void ModificarBotones(bool value)
        {
            AceptarCambios_btn.Enabled = value;
            Cancelar_btn.Enabled = value;
        }

        private void ModificarCampos(bool value)
        {
            Nombre_textBox.ReadOnly = value;
            Edad_textBox.ReadOnly = value;
            Masa_textBox.ReadOnly = value;
            Acoplamiento_textBox.ReadOnly = value;
        }

        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            ModificarCampos(false);
            ModificarBotones(true);
        }

        private void AceptarCambios_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nombre_textBox.Text) && !string.IsNullOrWhiteSpace(Edad_textBox.Text) && !string.IsNullOrWhiteSpace(Masa_textBox.Text) && !string.IsNullOrWhiteSpace(Acoplamiento_textBox.Text))
            {
                if (ComprobarNumero(Edad_textBox.Text))
                {
                    if (ComprobarNumero(Masa_textBox.Text))
                    {
                        if (ComprobarCampoAcoplamiento(Acoplamiento_textBox.Text))
                        {
                            satelite.Actualizar(Nombre_textBox.Text, float.Parse(Edad_textBox.Text), float.Parse(Masa_textBox.Text), ComprobarAcoplamiento(Acoplamiento_textBox.Text));
                            CargarInfo();
                            ModificarBotones(false);
                            ModificarCampos(true);
                        }
                        else MessageBox.Show("El valor asignado para Acomplamiento de marea no es valido.");
                    } else MessageBox.Show("El valor asignado para Masa no es valido.");
                } else MessageBox.Show("El valor asignado para Edad no es valido.");
            } else MessageBox.Show("Hay campos vacios o incompletos.");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            ModificarBotones(false);
            CargarInfo();
            ModificarCampos(true);
        }
    }
}
