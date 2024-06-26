using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBSERVATORIO.clases;
using OBSERVATORIO.formularios;

namespace OBSERVATORIO.formularios
{
    public partial class AgregarCuerpo_frm : Form
    {
        private readonly Observatorio observatorio;

        public AgregarCuerpo_frm(Observatorio observatorio)
        {
            InitializeComponent();
            this.observatorio = observatorio;
        }

        private void CargarPlanetas()
        {
            PlanetaQueOrbita_comboBox.Items.Clear();
            PlanetaQueOrbita_comboBox.Items.Add("No posee");
            List<PlanetaSimple> listaPlanetas = observatorio.ObtenerPlanetas();
            listaPlanetas.ForEach(p => PlanetaQueOrbita_comboBox.Items.Add(p));
        }

        private void CargarSatelites()
        {
            PlanetaSatelites_listBox.Items.Clear();
            List<Satelite> listaSatelites = observatorio.ObtenerSatelites();
            listaSatelites.ForEach(satelite => PlanetaSatelites_listBox.Items.Add(satelite));
        }

        private void AgregarCuerpo_frm_Load(object sender, EventArgs e)
        {
            CargarPlanetas();
            CargarSatelites();
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarCuerpo_btn_Click(object sender, EventArgs e)
        {

        }

        private void EstablecerGroupBox(GroupBox groupBox, RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                groupBox.Enabled = true;
            }
            else
            {
                groupBox.Enabled = false;
            }
        }

        private void TipoCuerpo01_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Satelite_groupBox, TipoCuerpo01_radioButton);
        }

        private void TipoCuerpo02_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Planeta_groupBox, TipoCuerpo02_radioButton);
        }        

        private void TipoCuerpo03_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Estrella_groupBox, TipoCuerpo03_radioButton);
        }

        private bool ValidarCamposSatelite()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(SateliteNombre_textBox.Text) || 
                SateliteEdad_numericUpDown.Value == 0 ||
                SateliteMasa_numericUpDown.Value == 0) resultado = false;
            return resultado;
        }

        
    }
}
