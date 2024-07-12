using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBSERVATORIO.clases;

namespace OBSERVATORIO.formularios
{
    public partial class VerEstrella_frm : Form
    {
        private readonly Estrella estrella;

        public VerEstrella_frm(Estrella estrella)
        {
            InitializeComponent();
            this.estrella = estrella;
        }

        private void CargarInfo()
        {
            Nombre_textBox.Text = estrella.Nombre;
            Edad_textBox.Text = estrella.Edad.ToString();
            Masa_textBox.Text = estrella.Masa.ToString();
            Temperatura_textBox.Text = estrella.Temperatura.ToString();
            Tipo_textBox.Text = estrella.Tipo.ToString();
            Color_textBox.Text = estrella.Color.ToString();
            Diametro_textBox.Text = estrella.Diametro.ToString();
        }

        private void VerEstrella_frm_Load(object sender, EventArgs e)
        {
            CargarInfo();
        }

        // Comprobacion de campos
        private bool ComprobarNumero(string texto)
        {
            return float.TryParse(texto, out float numero);
        }

        private bool ComprobarTipo(string texto)
        {
            bool resultado = false;
            if (texto.ToLower() == "enana" || texto.ToLower() == "gigante") resultado = true;
            return resultado;
        }

        private bool ComprobarColor(string texto)
        {
            bool resultado = false;
            if (texto.ToLower() == "roja" ||
                texto.ToLower() == "amarilla" ||
                texto.ToLower() == "azul" ||
                texto.ToLower() == "blanca" || texto.ToLower() == "naranja") resultado = true;
            return resultado;
        }

        private TipoEstrella DeterminarTipo(string tipo)
        {
            TipoEstrella resultado;

            if (tipo.ToLower() == "enana") resultado = TipoEstrella.Enana;
            else resultado = TipoEstrella.Gigante;

            return resultado;
        }

        private Color DeterminarColor(string color)
        {
            Color resultado;

            if (color == "roja") resultado = Color.Roja;
            else if (color == "amarilla") resultado = Color.Amarilla;
            else if (color == "naranja") resultado = Color.Naranja;
            else if (color == "blanca") resultado = Color.Blanca;
            else resultado = Color.Azul;

            return resultado;
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
            Temperatura_textBox.ReadOnly = value;
            Tipo_textBox.ReadOnly = value;
            Color_textBox.ReadOnly = value;
            Diametro_textBox.ReadOnly = value;
        }

        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            ModificarCampos(false);
            ModificarBotones(true);
        }

        private void AceptarCambios_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Nombre_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Edad_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Masa_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Temperatura_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Tipo_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Color_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Diametro_textBox.Text))
            {
                if (ComprobarNumero(Edad_textBox.Text))
                {
                    if (ComprobarNumero(Masa_textBox.Text))
                    {
                        if (ComprobarNumero(Temperatura_textBox.Text))
                        {
                            if (ComprobarTipo(Tipo_textBox.Text))
                            {
                                if (ComprobarColor(Color_textBox.Text))
                                {
                                    if (ComprobarNumero(Diametro_textBox.Text))
                                    {
                                        estrella.Actualizar
                                        (
                                            Nombre_textBox.Text,
                                            float.Parse(Masa_textBox.Text),
                                            float.Parse(Edad_textBox.Text),
                                            float.Parse(Diametro_textBox.Text),
                                            DeterminarTipo(Tipo_textBox.Text),
                                            DeterminarColor(Color_textBox.Text),
                                            float.Parse(Temperatura_textBox.Text)
                                        );
                                        CargarInfo();
                                        ModificarBotones(false);
                                        ModificarCampos(true);
                                    } 
                                    else MessageBox.Show("El valor asignado para el Diametro no es válido.");
                                } 
                                else MessageBox.Show("El valor asignado para el Color no es válido.");
                            } 
                            else MessageBox.Show("El valor asignado para el Tipo de Estrella no es válido.");
                        } 
                        else MessageBox.Show("El valor asignado para Temperatura no es válido.");
                    }
                    else MessageBox.Show("El valor asignado para Masa no es válido.");
                }
                else MessageBox.Show("El valor asignado para Edad no es válido.");
            }
            else MessageBox.Show("Hay campos vacíos o incompletos.");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            ModificarBotones(false);
            CargarInfo();
            ModificarCampos(true);
        }
    }
}
