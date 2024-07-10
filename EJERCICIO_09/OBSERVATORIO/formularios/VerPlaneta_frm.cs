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
            if (planeta.Satelites.Count > 0) planeta.Satelites.ForEach(satelite => Satelites_listBox.Items.Add(satelite));
            else Satelites_listBox.Items.Add("No posee satelites.");
        }

        private void VerPlaneta_frm_Load(object sender, EventArgs e)
        {
            Nombre_textBox.Text = planeta.Nombre;
            Edad_textBox.Text = planeta.Edad.ToString();
            Masa_textBox.Text = planeta.Masa.ToString();
            Habitabilidad_textBox.Text = planeta.Habitabilidad ? "Habitable" : "Inhabitable";
            Temperatura_textBox.Text = planeta.ToString();
            Ricitos_textBox.Text = planeta.Ricitos ? "Si" : "No";
            CargarSatelites();

            EstrellaPrimera_textBox.Text = planeta.Estrella.Nombre;
            PrimeraEstrellaDistancia_textBox.Text = planeta.Distancia.ToString();

            if (planeta is PlanetaBinario pBinario)
            {
                SegundaEstrella_textBox.Text = pBinario.SegundaEstrella.Nombre;
                SegundaEstrellaDistancia_textBox.Text = pBinario.SegundaDistancia.ToString();
            } else
            {
                EstrellaSecundaria_groupBox.Visible = false;
            }
        }
    }
}
