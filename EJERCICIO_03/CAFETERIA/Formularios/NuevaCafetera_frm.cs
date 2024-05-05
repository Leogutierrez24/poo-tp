using CAFETERIA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFETERIA.Formularios
{
    public partial class NuevaCafetera_frm : Form
    {
        private readonly Cafeteria cafeteria;

        public NuevaCafetera_frm(Cafeteria cafeteria)
        {
            InitializeComponent();
            this.cafeteria = cafeteria;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Arabigo_radioButton.Checked)
            {
                cafeteria.AgregarCafetera(cafeteria.Cafes.Find(cafe => cafe.Tipo == TipoCafe.Arabigo));
            } else
            {
                cafeteria.AgregarCafetera(cafeteria.Cafes.Find(cafe => cafe.Tipo == TipoCafe.Robusto));
            }
            Close();
        }
    }
}
