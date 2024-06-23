using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POLIDEPORTIVO.clases;

namespace POLIDEPORTIVO.formularios
{
    public partial class RegistroJuez_frm : Form
    {
        private readonly Polideportivo polideportivo;

        public RegistroJuez_frm(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
        }

        private bool ValidarCampos()
        {
            bool resultado = true;

            if(string.IsNullOrEmpty(Nombre_textBox.Text) || string.IsNullOrEmpty(Apellido_textBox.Text))
            {
                resultado = false;
            }

            return resultado;
        }

        private void Aceptar_btn_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Juez nuevoJuez = new Juez(Nombre_textBox.Text, Apellido_textBox.Text);
                polideportivo.RegistrarJuez(nuevoJuez);
                MessageBox.Show($"Se registró al juez: {nuevoJuez}");
                this.Close();
            }
            else MessageBox.Show("Hay campos vacíos!!!");
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
