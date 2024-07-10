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
    public partial class VerEstrella_frm : Form
    {
        private readonly Estrella estrella;

        public VerEstrella_frm(Estrella estrella)
        {
            InitializeComponent();
            this.estrella = estrella;
        }

        private void VerEstrella_frm_Load(object sender, EventArgs e)
        {
            Nombre_textBox.Text = estrella.Nombre;
            Edad_textBox.Text = estrella.Edad.ToString();
            Masa_textBox.Text = estrella.Masa.ToString();
            Temperatura_textBox.Text = estrella.Temperatura.ToString();
            Tipo_textBox.Text = estrella.Tipo.ToString();
            Color_textBox.Text = estrella.Color.ToString();
            Diametro_textBox.Text = estrella.Diametro.ToString();
        }
    }
}
