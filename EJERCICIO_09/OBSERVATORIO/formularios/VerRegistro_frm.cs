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
    public partial class VerRegistro_frm : Form
    {
        private readonly Registro registro;

        public VerRegistro_frm(Registro registro)
        {
            InitializeComponent();
            this.registro = registro;
        }

        private void VerRegistro_frm_Load(object sender, EventArgs e)
        {
            Nombre_textBox.Text = registro.Observador.Nombre;
            Apellido_textBox.Text = registro.Observador.Apellido;
            FechaNacimiento_textBox.Text = registro.Observador.FechaNacimiento.ToShortDateString();
            if (registro.Observador is Personal p) Legajo_textBox.Text = p.Legajo.ToString();
            else Legajo_textBox.Text = "No es empleado.";
            CuerpoNombre_textBox.Text = registro.Cuerpo.Nombre;
            DistanciaATierra_textBox.Text = registro.Distancia.ToString();
        }

        private void VerCuerpo_button_Click(object sender, EventArgs e)
        {
            CuerpoCeleste cuerpo = registro.Cuerpo;
            if (cuerpo is Satelite)
            {
                VerSatelite_frm form = new VerSatelite_frm(cuerpo as Satelite);
                form.ShowDialog();
            }
            else if (cuerpo is PlanetaSimple)
            {
                VerPlaneta_frm form = new VerPlaneta_frm(cuerpo as PlanetaSimple);
                form.ShowDialog();
            }
            else if (cuerpo is Estrella)
            {
                VerEstrella_frm form = new VerEstrella_frm(cuerpo as Estrella);
                form.ShowDialog();
            }
        }
    }
}
