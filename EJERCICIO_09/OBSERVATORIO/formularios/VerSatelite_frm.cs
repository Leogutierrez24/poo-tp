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
    public partial class VerSatelite_frm : Form
    {
        private readonly Satelite satelite;

        public VerSatelite_frm(Satelite satelite)
        {
            InitializeComponent();
            this.satelite = satelite;
        }

        private void VerSatelite_frm_Load(object sender, EventArgs e)
        {
            Nombre_textBox.Text = satelite.Nombre;
            Edad_textBox.Text = satelite.Edad.ToString();
            Masa_textBox.Text = satelite.Masa.ToString();
            Acoplamiento_textBox.Text = satelite.AcoplamientoMarea ? "Si" : "No";
        }
    }
}
