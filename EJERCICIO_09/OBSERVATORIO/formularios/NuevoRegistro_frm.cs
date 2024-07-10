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

namespace OBSERVATORIO.formularios
{
    public partial class NuevoRegistro_frm : Form
    {
        private readonly Observatorio observatorio;

        public NuevoRegistro_frm(Observatorio observatorio)
        {
            InitializeComponent();
            this.observatorio = observatorio;
        }

        private void CargarFiltros()
        {
            Filtros_comboBox.Items.Clear();
            Filtros_comboBox.Enabled = true;
            ValorFiltro_textBox.Enabled = true;
            if (Opcion01_radioButton.Checked)
            {
                Filtros_comboBox.Enabled = false;
                ValorFiltro_textBox.Enabled = false;
            }
            else if (Opcion02_radioButton.Checked)
            {
                Filtros_comboBox.Items.Add("Nombre");
                Filtros_comboBox.Items.Add("Estrella que orbita");
                Filtros_comboBox.Items.Add("Planeta Habitable");
            }
            else if (Opcion03_radioButton.Checked)
            {
                Filtros_comboBox.Items.Add("Color");
                Filtros_comboBox.Items.Add("Tipo");
                Filtros_comboBox.Items.Add("Temperatura");
                Filtros_comboBox.Items.Add("Constelación");
            }
        }

        private void CargarListBoxBusqueda<T>(List<T> lista)
        {
            CuerposEncontrados_listBox.Items.Clear();
            if (lista?.Count > 0)
            {
                lista.ForEach(item => CuerposEncontrados_listBox.Items.Add(item));
            }
            else MessageBox.Show("No se encontraron cuerpos.");
        }

        private void CargarListBoxBusqueda(Constelacion constelacion)
        {
            CuerposEncontrados_listBox.Items.Clear();
            if (constelacion != null)
            {
                constelacion.Estrellas.ForEach(item => CuerposEncontrados_listBox.Items.Add(item));
            }
            else MessageBox.Show("No se encontro constelacion.");
        }

        private void FiltrarPlanetas()
        {
            if (Filtros_comboBox.SelectedIndex != -1)
            {
                if (Filtros_comboBox.SelectedIndex == 0)
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text)) // Por Nombre
                    {
                        CargarListBoxBusqueda(observatorio.BuscarPlaneta(ValorFiltro_textBox.Text));
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
                else if (Filtros_comboBox.SelectedIndex == 1) // Por estrella que orbita
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text))
                    {
                        CargarListBoxBusqueda(observatorio.BuscarPlanetaPorEstrella(ValorFiltro_textBox.Text));
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
                else if (Filtros_comboBox.SelectedIndex == 2) // Por Habitabilidad
                {
                    CargarListBoxBusqueda(observatorio.BuscarPlanetaPorHabitabilidad());
                }
            }
            else MessageBox.Show("Es necesario elegir una opción de filtro para continuar.");
        }

        private void FiltrarEstrellas()
        {
            if (Filtros_comboBox.SelectedIndex != -1)
            {
                if (Filtros_comboBox.SelectedIndex == 0)
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text)) // Por Color
                    {
                        CargarListBoxBusqueda(observatorio.BuscarEstrellasPorColor(ValorFiltro_textBox.Text));
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
                else if (Filtros_comboBox.SelectedIndex == 1) // Por Tipo
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text))
                    {
                        CargarListBoxBusqueda(observatorio.BuscarEstrellaPorTipo(ValorFiltro_textBox.Text));
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
                else if (Filtros_comboBox.SelectedIndex == 2) // Por Temperatura
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text))
                    {
                        try
                        {
                            CargarListBoxBusqueda(observatorio.BuscarEstrellasPorTemperatura(float.Parse(ValorFiltro_textBox.Text)));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio el siguiente error: " + ex);
                        }
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
                else if (Filtros_comboBox.SelectedIndex == 3) // Por Constelacion
                {
                    if (!string.IsNullOrEmpty(ValorFiltro_textBox.Text))
                    {
                        CargarListBoxBusqueda(observatorio.BuscarEstrellasPorConstelacion(ValorFiltro_textBox.Text));
                    }
                    else MessageBox.Show("El filtro de busqueda esta vacío.");
                }
            }
            else MessageBox.Show("Es necesario elegir una opción de filtro para continuar.");
        }

        private void NuevoRegistro_frm_Load(object sender, EventArgs e)
        {

        }

        private void Filtrar_btn_Click_1(object sender, EventArgs e)
        {
            if (Opcion01_radioButton.Checked) // Buscar Satelites
            {
                CargarListBoxBusqueda(observatorio.ObtenerSatelites());
            }
            else if (Opcion02_radioButton.Checked) // Buscar Planetas
            {
                FiltrarPlanetas();
            }
            else if (Opcion03_radioButton.Checked) // Buscar Estrellas
            {
                FiltrarEstrellas();
            }
            else MessageBox.Show("Hubo un error");
        }

        private void Opcion01_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void Opcion02_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private void Opcion03_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            CargarFiltros();
        }

        private bool ComprobarCampos()
        {
            bool resultado = true;
            if (CuerposEncontrados_listBox.SelectedItems.Count != 1 ||
                string.IsNullOrWhiteSpace(Nombre_textBox.Text) ||
                string.IsNullOrWhiteSpace(Apellido_textBox.Text)) resultado = false;
            if (Personal_checkBox.Checked && Legajo_numericUpDown.Value > 0) resultado = false; 
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                Persona descubridor;
                if (Personal_checkBox.Checked) descubridor = new Personal(Nombre_textBox.Text, Apellido_textBox.Text, FechaNacimieto_dateTimePicker.Value, (int)Legajo_numericUpDown.Value);
                else descubridor = new Persona(Nombre_textBox.Text, Apellido_textBox.Text, FechaNacimieto_dateTimePicker.Value);
                observatorio.NuevoRegistro(CuerposEncontrados_listBox.SelectedItem as CuerpoCeleste, descubridor, FechaAvistamiento_dateTimePicker.Value, (float)DistanciaATierra_numericUpDown.Value);
                MessageBox.Show("Registro agregado!");
                Close();
            }
            else MessageBox.Show("Hay campos vacios o incompletos.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
