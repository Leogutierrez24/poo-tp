using POLIDEPORTIVO.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POLIDEPORTIVO.formularios
{
    public partial class Alquilar_frm : Form
    {
        private readonly Polideportivo polideportivo;

        private bool canchaDisponible = true;
        private bool juezDisponible = true;

        // Nuevo Alquiler props
        private Cancha canchaElegida;

        private DateTime fechaElegida;

        private int horaElegida;

        private int duracionElegida;

        private Juez primerJuez;

        private Juez primerJuezLinea;

        private Juez segundoJuezLinea;

        public Alquilar_frm(Polideportivo polideportivo)
        {
            InitializeComponent();
            this.polideportivo = polideportivo;
        }

        private void CargarOpcionales()
        {
            Cancha cancha = Canchas_comboBox.SelectedItem as Cancha;
            Opcionales_comboBox.Items.Clear();
            Opcionales_comboBox.Enabled = false;

            if (cancha.Tipo == TipoCancha.Tenis || cancha.Tipo == TipoCancha.FutbolSiete)
            {
                Opcionales_comboBox.Enabled = true;
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Adiciona 1 árbitro, aumenta $100 al valor de la cancha");
            }
            else if (cancha.Tipo == TipoCancha.FutbolOnce)
            {
                Opcionales_comboBox.Enabled = true;
                Opcionales_comboBox.Items.Add("Sin opcional");
                Opcionales_comboBox.Items.Add("Adiciona 1 árbitro, aumenta $100 al valor de la cancha");
                Opcionales_comboBox.Items.Add("Opcional 1 mas dos arbitros de linea, aumenta $90 al valor total");
            }
        }

        private void HorarioMinimo()
        {
            if (Fecha_dateTimePicker.Value.Date == DateTime.Now.Date) Horario_numericUpDown.Minimum = DateTime.Now.Hour;
            else Horario_numericUpDown.Minimum = 9;
        }

        private void Alquilar_frm_Load(object sender, EventArgs e)
        {
            polideportivo.Canchas.ForEach(cancha => Canchas_comboBox.Items.Add(cancha));
            polideportivo.Jueces.ForEach(juez => Jueces_listBox.Items.Add(juez));
            Canchas_comboBox.SelectedIndex = 0;
            Fecha_dateTimePicker.MinDate = DateTime.Now;
            horaElegida = (int)Horario_numericUpDown.Value;
            duracionElegida = (int)Duracion_numericUpDown.Value;
            HorarioMinimo();
            HorarioComienzo_textBox.Text = $"{horaElegida} hrs";
            HorarioFinalizacion_textBox.Text = $"{horaElegida + duracionElegida} hrs";
        }

        private void DisponibilidadLabels(Label label, bool var)
        {
            label.Visible = true;
            if (var)
            {
                label.Text = "Disponible";
                label.ForeColor = Color.Green;
            } else
            {
                label.Text = "No disponible";
                label.ForeColor = Color.Red;
            }
        }

        private void DisponibilidadCancha()
        {
            canchaDisponible = polideportivo.DisponibilidadCancha(canchaElegida, Fecha_dateTimePicker.Value, (int)Horario_numericUpDown.Value, (int)Duracion_numericUpDown.Value);
            Cancha_textBox.Text = canchaElegida.Tipo.ToString();
            DisponibilidadLabels(CanchaDisponble_lbl, canchaDisponible);
        }

        private float CalcularPrecio(Cancha cancha, int duracion, int opcional)
        {
            float resultado = 0;
            if (opcional == 0) resultado = Alquiler.CalcularPrecio(cancha, duracion);
            if (opcional == 1) resultado = AlquilerConOpcional.CalcularPrecio(cancha, duracion);
            if (opcional == 2) resultado = AlquilerConOpcionales.CalcularPrecio(cancha, duracion);
            return resultado;
        }

        private void Canchas_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarOpcionales();
            ComprobarOpcional();
            canchaElegida = Canchas_comboBox.SelectedItem as Cancha;
            DisponibilidadCancha();
            primerJuez = null;
            primerJuezLinea = null;
            segundoJuezLinea = null;
            if (Opcionales_comboBox.SelectedIndex == -1 || Opcionales_comboBox.SelectedIndex == 0) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 0));
            else if (Opcionales_comboBox.SelectedIndex == 1) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 1));
            else if (Opcionales_comboBox.SelectedIndex == 2) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 2));
        }

        private void ComprobarOpcional()
        {
            if (Opcionales_comboBox.SelectedIndex > 0)
            {
                Jueces_listBox.Enabled = true;
                ElegirJueces_btn.Enabled = true;
                if (Opcionales_comboBox.SelectedIndex == 1)
                {
                    Jueces_listBox.SelectionMode = SelectionMode.One;
                } else
                {
                    Jueces_listBox.SelectionMode = SelectionMode.MultiSimple;
                }
            }
            else
            {
                Jueces_listBox.Enabled = false;
                ElegirJueces_btn.Enabled = false;
            }
        }

        private void Opcionales_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComprobarOpcional();
            OpcionalElegido_textBox.Text = Opcionales_comboBox.SelectedItem.ToString();
            primerJuez = null;
            primerJuezLinea = null;
            segundoJuezLinea = null;
            if (Opcionales_comboBox.SelectedIndex == -1 || Opcionales_comboBox.SelectedIndex == 0) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 0));
            else if (Opcionales_comboBox.SelectedIndex == 1) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 1));
            else if (Opcionales_comboBox.SelectedIndex == 2) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 2));
        }

        private void Fecha_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            HorarioMinimo(); 
            fechaElegida = Fecha_dateTimePicker.Value;
            Fecha_textBox.Text = fechaElegida.ToShortDateString();
            DisponibilidadCancha();
        }

        private void Horario_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            horaElegida = (int)Horario_numericUpDown.Value;
            HorarioComienzo_textBox.Text = $"{horaElegida} hrs";
            HorarioFinalizacion_textBox.Text = $"{horaElegida + duracionElegida} hrs";
            DisponibilidadCancha();
        }

        private void Duracion_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            duracionElegida = (int)Duracion_numericUpDown.Value;
            HorarioFinalizacion_textBox.Text = $"{horaElegida + duracionElegida} hrs";
            DisponibilidadCancha();
            if (Opcionales_comboBox.SelectedIndex == -1 || Opcionales_comboBox.SelectedIndex == 0) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 0));
            else if (Opcionales_comboBox.SelectedIndex == 1) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 1));
            else if (Opcionales_comboBox.SelectedIndex == 2) TotalAlquiler_lbl.Text = string.Format("${0:0.00}", CalcularPrecio(canchaElegida, duracionElegida, 2));
        }

        // Botones

        private void ElegirJueces_btn_Click(object sender, EventArgs e)
        {
            if (Opcionales_comboBox.SelectedIndex == 1)
            {
                if  (Jueces_listBox.SelectedItems.Count == 1)
                {
                    juezDisponible = polideportivo.DisponibilidadJuez((Juez) Jueces_listBox.SelectedItem, fechaElegida, horaElegida, duracionElegida);
                    DisponibilidadLabels(PrimerJuezDisponible_lbl, juezDisponible);

                    if (juezDisponible) primerJuez = Jueces_listBox.SelectedItem as Juez;
                }
            } else if (Opcionales_comboBox.SelectedIndex == 2)
            {
                if (Jueces_listBox.SelectedItems.Count == 3)
                {
                    juezDisponible = true;

                    List<Juez> juecesSeleccionados = new List<Juez>();
                    foreach (object o in Jueces_listBox.SelectedItems)
                    {
                        juecesSeleccionados.Add(o as Juez);
                    }

                    if (juecesSeleccionados.Exists(juez => !polideportivo.DisponibilidadJuez(juez, fechaElegida, horaElegida, duracionElegida)))
                    {
                        MessageBox.Show("No todos los jueces estan disponibles para dirigir.");
                        juezDisponible = false;
                    }

                    if (juezDisponible)
                    {
                        primerJuez = juecesSeleccionados[0];
                        PrimerJuez_textBox.Text = primerJuez.ToString();
                        primerJuezLinea = juecesSeleccionados[1];
                        SegundoJuez_textBox.Text = primerJuezLinea.ToString();
                        segundoJuezLinea = juecesSeleccionados[2];
                        TercerJuez_textBox.Text = segundoJuezLinea.ToString();
                    }
                }
                else MessageBox.Show("Es necesario elegir solo 3 jueces para continuar.");
            }
        }

        private void Alquilar_btn_Click(object sender, EventArgs e)
        {
            if (!Opcionales_comboBox.Enabled || Opcionales_comboBox.SelectedIndex == -1 || Opcionales_comboBox.SelectedIndex == 0)
            {
                if (canchaElegida != null && fechaElegida != null)
                {
                    if (canchaDisponible)
                    {
                        int resultado = polideportivo.GenerarAlquiler(canchaElegida, fechaElegida, horaElegida, duracionElegida);

                        if (resultado == 0)
                        {
                            MessageBox.Show("Se ha registrado el alquiler con exito.");
                            this.Close();
                        }
                        else MessageBox.Show("Hubo un error al intentar alquilar.");                        
                    }
                }
                else MessageBox.Show("Todavia no se ha elegido una cancha o fecha por alquilar.");
            }
            else if (Opcionales_comboBox.SelectedIndex == 1)
            {
                if (canchaElegida != null && fechaElegida != null)
                {
                    if (canchaDisponible)
                    {
                        if (primerJuez != null && juezDisponible)
                        {
                            List<Juez> juecesElegidos = new List<Juez> { primerJuez };
                            int resultado = polideportivo.GenerarAlquiler(canchaElegida, fechaElegida, horaElegida, duracionElegida, juecesElegidos);

                            if (resultado == 0)
                            {
                                MessageBox.Show("Se ha registrado el alquiler con exito.");
                                this.Close();
                            }
                            else MessageBox.Show("Hubo un error al intentar alquilar.");
                        }
                        else MessageBox.Show("Es necesario elegir un juez para continuar con el alquiler.");

                    }
                    else MessageBox.Show("La cancha seleccionada no esta disponible para ser alquilada.");
                }
                else MessageBox.Show("Todavia no se ha elegido una cancha o fecha por alquilar.");
            }
            else if (Opcionales_comboBox.SelectedIndex == 2)
            {
                if (canchaElegida != null && fechaElegida != null)
                {
                    if (canchaDisponible)
                    {
                        if (primerJuez != null && primerJuezLinea != null && segundoJuezLinea != null && juezDisponible)
                        {
                            List<Juez> juecesElegidos = new List<Juez> { primerJuez, primerJuezLinea, segundoJuezLinea };
                            int resultado = polideportivo.GenerarAlquiler(canchaElegida, fechaElegida, horaElegida, duracionElegida, juecesElegidos);

                            if (resultado == 0)
                            {
                                MessageBox.Show("Se ha registrado el alquiler con exito.");
                                this.Close();
                            }
                            else MessageBox.Show("Hubo un error al intentar alquilar.");
                        }
                        else MessageBox.Show("Es necesario elegir un juez para continuar con el alquiler.");

                    }
                    else MessageBox.Show("La cancha seleccionada no esta disponible para ser alquilada.");
                }
                else MessageBox.Show("Todavia no se ha elegido una cancha o fecha por alquilar.");
            }
            else MessageBox.Show("Hubo un error.");

            
        }
    }
}
