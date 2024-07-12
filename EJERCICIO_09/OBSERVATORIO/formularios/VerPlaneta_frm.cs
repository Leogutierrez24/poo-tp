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
    public partial class VerPlaneta_frm : Form
    {
        private readonly PlanetaSimple planeta;

        public VerPlaneta_frm(PlanetaSimple planeta)
        {
            InitializeComponent();
            this.planeta = planeta;
        }

        private void CargarSatelites()
        {
            Satelites_listBox.Items.Clear();
            if (planeta.Satelites.Count > 0) planeta.Satelites.ForEach(satelite => Satelites_listBox.Items.Add(satelite));
            else Satelites_listBox.Items.Add("No posee satelites.");
        }

        private void CargarInfo()
        {
            Nombre_textBox.Text = planeta.Nombre;
            Edad_textBox.Text = planeta.Edad.ToString();
            Masa_textBox.Text = planeta.Masa.ToString();
            Habitabilidad_textBox.Text = planeta.Habitabilidad ? "Si" : "No";
            Temperatura_textBox.Text = planeta.Temperatura.ToString();
            Ricitos_textBox.Text = planeta.Ricitos ? "Si" : "No";
            CargarSatelites();

            EstrellaPrimera_textBox.Text = planeta.Estrella.Nombre;
            PrimeraEstrellaDistancia_textBox.Text = planeta.Distancia.ToString();

            if (planeta is PlanetaBinario pBinario)
            {
                SegundaEstrella_textBox.Text = pBinario.SegundaEstrella.Nombre;
                SegundaEstrellaDistancia_textBox.Text = pBinario.SegundaDistancia.ToString();
            }
            else
            {
                EstrellaSecundaria_groupBox.Visible = false;
            }
        }

        // Comprobacion de campos
        private bool ComprobarNumero(string texto)
        {
            return float.TryParse(texto, out float numero);
        }

        private bool ComprobarTexto(string texto)
        {
            bool resultado = false;
            if (texto.ToLower() == "no" || texto.ToLower() == "si") resultado = true;
            return resultado;
        }

        private bool ComprobarValor(string valor)
        {
            return valor.ToLower() == "si";
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
            Habitabilidad_textBox.ReadOnly = value;
            Temperatura_textBox.ReadOnly = value;
            Ricitos_textBox.ReadOnly = value;

            PrimeraEstrellaDistancia_textBox.ReadOnly = value;

            if (planeta is PlanetaBinario) SegundaEstrellaDistancia_textBox.ReadOnly = value;
        }

        private void VerPlaneta_frm_Load(object sender, EventArgs e)
        {
            CargarInfo();
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
                !string.IsNullOrWhiteSpace(Habitabilidad_textBox.Text) &&
                !string.IsNullOrWhiteSpace(Ricitos_textBox.Text) &&
                !string.IsNullOrWhiteSpace(PrimeraEstrellaDistancia_textBox.Text))
            {
                if (ComprobarNumero(Edad_textBox.Text))
                {
                    if (ComprobarNumero(Masa_textBox.Text))
                    {
                        if (ComprobarNumero(Temperatura_textBox.Text))
                        {
                            if (ComprobarTexto(Habitabilidad_textBox.Text))
                            {
                                if (ComprobarTexto(Ricitos_textBox.Text))
                                {
                                    if (ComprobarNumero(PrimeraEstrellaDistancia_textBox.Text))
                                    {
                                        if (planeta is PlanetaBinario pbinario)
                                        {
                                            if (!string.IsNullOrWhiteSpace(SegundaEstrellaDistancia_textBox.Text))
                                            {
                                                pbinario.Actualizar
                                                (
                                                    Nombre_textBox.Text,
                                                    float.Parse(Masa_textBox.Text),
                                                    float.Parse(Edad_textBox.Text),
                                                    float.Parse(PrimeraEstrellaDistancia_textBox.Text),
                                                    float.Parse(SegundaEstrellaDistancia_textBox.Text),
                                                    float.Parse(Temperatura_textBox.Text),
                                                    ComprobarValor(Habitabilidad_textBox.Text),
                                                    ComprobarValor(Ricitos_textBox.Text)
                                                );
                                                CargarInfo();
                                                ModificarBotones(false);
                                                ModificarCampos(true);
                                            }
                                            else MessageBox.Show("El valor asignado para la Distancia de la Segunda Estrella no es valido.");
                                        } else
                                        {
                                            planeta.Actualizar
                                            (
                                                Nombre_textBox.Text,
                                                float.Parse(Masa_textBox.Text),
                                                float.Parse(Edad_textBox.Text),
                                                float.Parse(PrimeraEstrellaDistancia_textBox.Text),
                                                float.Parse(Temperatura_textBox.Text),
                                                ComprobarValor(Habitabilidad_textBox.Text),
                                                ComprobarValor(Ricitos_textBox.Text)
                                            );
                                            CargarInfo();
                                            ModificarBotones(false);
                                            ModificarCampos(true);
                                        }
                                    }
                                    else MessageBox.Show("El valor asignado para la Distancia de la Primera Estrella no es valido.");
                                }
                                else MessageBox.Show("El valor asignado para Ricitos de oro no es valido.");
                            }
                            else MessageBox.Show("El valor asignado para Habitabilidad no es valido.");
                        }
                        else MessageBox.Show("El valor asignado para Temperatura no es valido.");
                    }
                    else MessageBox.Show("El valor asignado para Masa no es valido.");
                }
                else MessageBox.Show("El valor asignado para Edad no es valido.");
            }
            else MessageBox.Show("Hay campos vacios o incompletos.");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            ModificarBotones(false);
            CargarInfo();
            ModificarCampos(true);
        }
    }
}
