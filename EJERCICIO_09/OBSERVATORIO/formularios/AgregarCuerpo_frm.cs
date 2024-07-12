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

        private void CargarSatelites()
        {
            PlanetaSatelites_listBox.Items.Clear();
            List<Satelite> listaSatelites = observatorio.ObtenerSatelites();
            listaSatelites.ForEach(satelite => PlanetaSatelites_listBox.Items.Add(satelite));
        }

        private void AgregarCuerpo_frm_Load(object sender, EventArgs e)
        {            
            CargarSatelites();
            CargarComboEstrellas(observatorio.ObtenerEstrellas(), PlanetaPrimeraEstrella_comboBox);
            CargarComboEstrellas(observatorio.ObtenerEstrellas(), PlanetaSegundaEstrella_comboBox);
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validacion de los campos de cada formulario.
        private bool ValidarCamposSatelite()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(SateliteNombre_textBox.Text) ||
                SateliteEdad_numericUpDown.Value == 0 ||
                SateliteMasa_numericUpDown.Value == 0 ||
                AcoplamientoMarea_comboBox.SelectedIndex == -1) resultado = false;
            return resultado;
        }

        private bool ValidarCamposPlaneta()
        {
            bool resultado = true;
            if (string.IsNullOrWhiteSpace(PlanetaNombre_textBox.Text) ||
                PlanetaEdad_numericUpDown.Value == 0 ||
                PlanetaMasa_numericUpDown.Value == 0) resultado = false;

            if (!PlanetaSinSatelites_checkBox.Checked && PlanetaSatelites_listBox.SelectedIndex == -1) resultado = false;

            if (PlanetaPrimeraEstrella_comboBox.SelectedIndex == -1 || DistanciaPrimerEstrella_numericUpDown.Value == 0) resultado = false;
            if (PlanetaBinario_radioButton.Checked && (PlanetaSegundaEstrella_comboBox.SelectedIndex == -1 || DistanciaSegundaEstrella_numericUpDown.Value == 0)) resultado = false;

            return resultado;
        }

        private bool ValidarCamposEstrella()
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(EstrellaNombre_textBox.Text) ||
                EstrellaEdad_numericUpDown.Value == 0 ||
                EstrellaMasa_numericUpDown.Value == 0 ||
                EstrellaDiametro_numericUpDown.Value == 0 ||
                EstrellaColor_comboBox.SelectedIndex == -1 ||
                EstrellaTemperatura_numericUpDown.Value < 0) resultado = false;

            return resultado;
        }


        // Agregar cuerpo celeste segun corresponda.
        private void AgregarSatelite()
        {
            if (ValidarCamposSatelite())
            {
                Satelite nuevoSatelite = new Satelite(SateliteNombre_textBox.Text,
                    (float)SateliteMasa_numericUpDown.Value,
                    (float)SateliteEdad_numericUpDown.Value,
                    AcoplamientoMarea_comboBox.SelectedIndex == 0 ? false : true);

                observatorio.RegistrarCuerpoCeleste(nuevoSatelite);
                MessageBox.Show($"Se registro al Satélite: {nuevoSatelite.Nombre}");
                this.Close();
            }
            else MessageBox.Show("Hay campos con valores erroneos o incompletos!!!");
        }

        private void AgregarPlaneta()
        {
            if (ValidarCamposPlaneta())
            {
                PlanetaSimple nuevoPlaneta;
                List<Satelite> satelitesDelPlaneta = new List<Satelite>();
                if (!PlanetaSinSatelites_checkBox.Checked)
                {
                    foreach (var satelite in PlanetaSatelites_listBox.SelectedItems)
                    {
                        satelitesDelPlaneta.Add(satelite as Satelite);
                    }
                }

                if (PlanetaSimple_radioButton.Checked)
                {
                    nuevoPlaneta = new PlanetaSimple(PlanetaNombre_textBox.Text,
                        (float)PlanetaMasa_numericUpDown.Value,
                        (float)PlanetaEdad_numericUpDown.Value,
                        PlanetaPrimeraEstrella_comboBox.SelectedItem as Estrella,
                        (float)DistanciaPrimerEstrella_numericUpDown.Value,
                        (float)PlanetaTemp_numericUpDown.Value,
                        satelitesDelPlaneta,
                        PlanetaHabitable_radioButton.Checked,
                        PlanetaSiRicitos_radioButton.Checked
                        );
                } else
                {
                    nuevoPlaneta = new PlanetaBinario(PlanetaNombre_textBox.Text,
                        (float)PlanetaMasa_numericUpDown.Value,
                        (float)PlanetaEdad_numericUpDown.Value,
                        PlanetaPrimeraEstrella_comboBox.SelectedItem as Estrella,
                        (float)DistanciaPrimerEstrella_numericUpDown.Value,
                        PlanetaSegundaEstrella_comboBox.SelectedItem as Estrella,
                        (float)DistanciaSegundaEstrella_numericUpDown.Value,
                        (float)PlanetaTemp_numericUpDown.Value,
                        satelitesDelPlaneta,
                        PlanetaHabitable_radioButton.Checked,
                        PlanetaSiRicitos_radioButton.Checked);
                }

                observatorio.RegistrarCuerpoCeleste(nuevoPlaneta);
                MessageBox.Show($"Se registró al Planeta: {nuevoPlaneta.Nombre}");
                this.Close();
            }
            else MessageBox.Show("Hay campos con valores erroneos o incompletos!!!");
        }

        private Color DeterminarColorEstrella(int color)
        {
            Color tipoColor;
            if (color == 0) tipoColor = Color.Roja;
            else if (color == 1) tipoColor = Color.Amarilla;
            else if (color == 2) tipoColor = Color.Naranja;
            else if (color == 3) tipoColor = Color.Blanca;
            else tipoColor = Color.Azul;
            return tipoColor;
        }

        private void AgregarEstrella()
        {
            if (ValidarCamposEstrella() && Constelacion_checkBox.Checked)
            {
                Estrella nuevaEstrella = new Estrella(EstrellaNombre_textBox.Text,
                    (float)EstrellaMasa_numericUpDown.Value,
                    (float)EstrellaEdad_numericUpDown.Value,
                    (float)EstrellaDiametro_numericUpDown.Value,
                    EstrellaEnana_radioButton.Checked ? TipoEstrella.Enana : TipoEstrella.Gigante,
                    DeterminarColorEstrella(EstrellaColor_comboBox.SelectedIndex),
                    (float)EstrellaTemperatura_numericUpDown.Value
                    );

                observatorio.RegistrarCuerpoCeleste(nuevaEstrella);
                MessageBox.Show($"Se registró la Estrella: {nuevaEstrella.Nombre}");
                this.Close();
            } else if (ValidarCamposEstrella() && !Constelacion_checkBox.Checked)
            {               
                if (Constelaciones_listBox.SelectedItems.Count == 1)
                {
                    Estrella nuevaEstrella = new Estrella(EstrellaNombre_textBox.Text,
                        (float)EstrellaMasa_numericUpDown.Value,
                        (float)EstrellaEdad_numericUpDown.Value,
                        (float)EstrellaDiametro_numericUpDown.Value,
                        EstrellaEnana_radioButton.Checked ? TipoEstrella.Enana : TipoEstrella.Gigante,
                        DeterminarColorEstrella(EstrellaColor_comboBox.SelectedIndex),
                        (float)EstrellaTemperatura_numericUpDown.Value
                    );

                    Constelacion c = Constelaciones_listBox.SelectedItem as Constelacion;
                    c.AgregarEstrella(nuevaEstrella);

                    observatorio.RegistrarCuerpoCeleste(nuevaEstrella);
                    MessageBox.Show($"Se registró la Estrella: {nuevaEstrella.Nombre}");
                    this.Close();
                }
                else MessageBox.Show("Debe haber solo una constelación seleccionada para agregar la estrella.");                
            }
            else MessageBox.Show("Hay campos con valores erroneos o incompletos!!!");
        }

        private void AgregarCuerpo_btn_Click(object sender, EventArgs e)
        {
            if (TipoCuerpo01_radioButton.Checked)
            {
                AgregarSatelite();
            }
            else if (TipoCuerpo02_radioButton.Checked)
            {
                AgregarPlaneta();
            }
            else if (TipoCuerpo03_radioButton.Checked)
            {
                AgregarEstrella();
                CargarComboEstrellas(observatorio.ObtenerEstrellas(), PlanetaPrimeraEstrella_comboBox);
                CargarComboEstrellas(observatorio.ObtenerEstrellas(), PlanetaSegundaEstrella_comboBox);
            }
            else MessageBox.Show("Ocurrió un error!!!");
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

        private void HabilitarCamposSegundaEstrella()
        {
            if (PlanetaSimple_radioButton.Checked)
            {
                PlanetaSegundaEstrella_comboBox.Enabled = false;
                DistanciaSegundaEstrella_numericUpDown.Enabled = false;
            } else
            {
                PlanetaSegundaEstrella_comboBox.Enabled = true;
                DistanciaSegundaEstrella_numericUpDown.Enabled = true;
            }
        }

        private void CargarComboEstrellas(List<Estrella> lista, ComboBox combo)
        {
            combo.Items.Clear();
            if (lista.Count > 0) lista.ForEach(item => combo.Items.Add(item));
            else combo.Items.Add("No hay estrellas cargadas.");
        }

        private void CargarConstelaciones()
        {
            Constelaciones_listBox.Items.Clear();
            observatorio.Constelaciones.ForEach(constelacion  => Constelaciones_listBox.Items.Add(constelacion));
        }

        // Establecer que formulario estara disponible
        private void TipoCuerpo01_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Satelite_groupBox, TipoCuerpo01_radioButton);
        }

        private void TipoCuerpo02_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Planeta_groupBox, TipoCuerpo02_radioButton);
            HabilitarCamposSegundaEstrella();
        }        

        private void TipoCuerpo03_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            EstablecerGroupBox(Estrella_groupBox, TipoCuerpo03_radioButton);
        }

        private void PlanetaSimple_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCamposSegundaEstrella();
        }

        private void AgregarConstelacion_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ConstelacionNombre_textBox.Text))
            {
                Constelacion nuevaConstelacion = new Constelacion(ConstelacionNombre_textBox.Text);
                observatorio.AgregarConstelacion(nuevaConstelacion);
                CargarConstelaciones();
                ConstelacionNombre_textBox.Text = string.Empty;
            }
            else MessageBox.Show("Es necesario un nombre para agregar una nueva constelación!!!");
            
        }
    }
}
