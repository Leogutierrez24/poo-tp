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
    public partial class Informe_frm : Form
    {
        private Cafeteria cafeteria;

        public Informe_frm(Cafeteria cafeteria)
        {
            InitializeComponent();
            this.cafeteria = cafeteria;
        }

        private void CargarInformacion()
        {
            recaudacion_lbl.Text = string.Format("${0:0.00}", cafeteria.CalcularRecaudacionTotal());

            cafeteria.Cafeteras.ForEach(cafetera =>
            {
                string item = $"{cafetera} - ${cafetera.Recaudacion}";
                RecaudacionCafeteras_listBox.Items.Add(item);
            });

            cafeteraMasSirvio_lbl.Text = cafeteria.CafeteraMasSirvio().ToString();
            cafeteraMenosSirvio_lbl.Text = cafeteria.CafeteraMenosSirvio().ToString();
            cafeteraMasRecaudacion_lbl.Text = cafeteria.CafeteraMayorRecaudacion().ToString();
            cafeteraMenosRecaudacion_lbl.Text = cafeteria.CafeteraMenorRecaudacion().ToString();
            CafeteraMasRecargas_lbl.Text = cafeteria.CafeteraMasRecargas().ToString();

            cafeMasServido_lbl.Text = cafeteria.CafeMasServido().ToString();
            cafeMenosServido_lbl.Text = cafeteria.CafeMenosServido().ToString();
            cafeMasRecaudacion_lbl.Text = cafeteria.CafeMayorRecaudacion().ToString();
            cafeMenosRecaudacion_lbl.Text = cafeteria.CafeteraMenorRecaudacion().ToString();
        }

        private void Informe_frm_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }
    }
}
