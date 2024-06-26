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
        }

        private void ModificarCuerpo_btn_Click(object sender, EventArgs e)
        {

        }

        private void VerCuerpo_btn_Click(object sender, EventArgs e)
        {

        }

        private void Filtrar_btn_Click(object sender, EventArgs e)
        {

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

        
    }
}
