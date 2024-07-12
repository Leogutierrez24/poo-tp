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
        private readonly Observatorio observatorio;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarRegistros();
            CargarCuerpos();
        }

        private void AgregarCuerpo_btn_Click(object sender, EventArgs e)
        {
            AgregarCuerpo_frm form = new AgregarCuerpo_frm(observatorio);
            form.ShowDialog();
            CargarCuerpos();
        }

        private void VerCuerpo_btn_Click(object sender, EventArgs e)
        {
            if (CuerposRegistrados_listBox.SelectedItems.Count == 1)
            {
                CuerpoCeleste cuerpo = CuerposRegistrados_listBox.SelectedItem as CuerpoCeleste;
                if (cuerpo is Satelite)
                {
                    VerSatelite_frm form = new VerSatelite_frm(cuerpo as Satelite);
                    form.ShowDialog();
                } else if (cuerpo is PlanetaSimple)
                {
                    VerPlaneta_frm form = new VerPlaneta_frm(cuerpo as PlanetaSimple);
                    form.ShowDialog();
                } else if (cuerpo is Estrella)
                {
                    VerEstrella_frm form = new VerEstrella_frm(cuerpo as Estrella);
                    form.ShowDialog();
                }
                CargarCuerpos();
            }
            else MessageBox.Show("Selecciona un cuerpo para continuar.");
        }

        private void NuevoRegistro_btn_Click(object sender, EventArgs e)
        {
            NuevoRegistro_frm form = new NuevoRegistro_frm(observatorio);
            form.ShowDialog();
            CargarRegistros();
        }

        private void VerRegistro_btn_Click(object sender, EventArgs e)
        {
            if (Registros_listBox.SelectedItems.Count == 1)
            {
               VerRegistro_frm form = new VerRegistro_frm(Registros_listBox.SelectedItem as Registro);
                form.ShowDialog();
            }
            else MessageBox.Show("Selecciona al menos un registro para continuar.");
        }
    }
}
