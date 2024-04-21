using ESTACION.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTACION.Formularios
{
    public partial class Informes_frm : Form
    {
        private readonly Estacion estacion;

        public Informes_frm(Estacion estacion)
        {
            InitializeComponent();
            this.estacion = estacion;
        }

        private void CargarInfo()
        {
            naftaVentas_listBox.DataSource = estacion.PorcentajeVentaNaftas();
            naftaRecaudacion_listBox.DataSource = estacion.PorcentajeRecaudacionNaftas();
            surtidorVentas_listBox.DataSource = estacion.PromedioVentaSurtidores();
            surtidorRecaudacion_listBox.DataSource = estacion.PromedioRecaudacionSurtidores();
            mayorRecaudacion_lbl.Text = $"{estacion.SurtidorMayorRecaudacion()}";
            menorRecaudacion_lbl.Text = $"{estacion.SurtidorMenorRecaudacion()}";
            masClientes_lbl.Text = $"{estacion.SurtidorMasClientes()}";
            masRecargas_lbl.Text = $"{estacion.SurtidorMasRecargas()}";
        }

        private void Informes_frm_Load(object sender, EventArgs e)
        {
            CargarInfo();
        }
    }
}
