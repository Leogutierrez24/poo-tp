using System;
using System.Collections;
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

namespace OBSERVATORIO
{
    public partial class Form1 : Form
    {
        private Observatorio observatorio;

        public Form1()
        {
            InitializeComponent();
            observatorio = new Observatorio();
        }

        private void CargarListBox<T>(ListBox listBox, List<T> coleccion)
        {
            listBox.Items.Clear();
            coleccion.ForEach(item => listBox.Items.Add(item));
        }

        private void CargarRegistros()
        {
            CargarListBox(Registros_listBox, observatorio.Registros);
        }

        private void CargarCuerpos()
        {
            CargarListBox(CuerposRegistrados_listBox, observatorio.CuerposRegistrados);
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
            } else if (Opcion02_radioButton.Checked)
            {
                Filtros_comboBox.Items.Add("Nombre");
                Filtros_comboBox.Items.Add("Estrella que orbita");
                Filtros_comboBox.Items.Add("Planeta Habitable");
            } else if (Opcion03_radioButton.Checked)
            {
                Filtros_comboBox.Items.Add("Color");
                Filtros_comboBox.Items.Add("Tipo");
                Filtros_comboBox.Items.Add("Temperatura");
                Filtros_comboBox.Items.Add("Constelación");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarRegistros();
            CargarCuerpos();
        }

        private void CargarCuerposEncontrados<T>(List<T> coleccion)
        {
            CargarListBox(CuerposEncontrados_listBox, coleccion);
        }

        private void AgregarCuerpo_btn_Click(object sender, EventArgs e)
        {
            AgregarCuerpo_frm form = new AgregarCuerpo_frm(observatorio);
            form.ShowDialog();
            CargarCuerpos();
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

        private void ModificarCuerpo_btn_Click(object sender, EventArgs e)
        {

        }

        private void VerCuerpo_btn_Click(object sender, EventArgs e)
        {

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

        private void Filtrar_btn_Click(object sender, EventArgs e)
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

        private void NuevoRegistro_btn_Click(object sender, EventArgs e)
        {

        }

        private void VerRegistro_btn_Click(object sender, EventArgs e)
        {

        }

        private void VerCuerpoFiltrado_btn_Click(object sender, EventArgs e)
        {

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
    }
}
