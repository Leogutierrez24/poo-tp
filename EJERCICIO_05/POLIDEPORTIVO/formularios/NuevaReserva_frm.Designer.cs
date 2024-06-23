namespace POLIDEPORTIVO.formularios
{
    partial class NuevaReserva_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Cancha_comboBox = new System.Windows.Forms.ComboBox();
            this.Fecha_monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.Opcionales_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Jueces_listBox = new System.Windows.Forms.ListBox();
            this.HoraInicio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HoraFin_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Alquileres_listBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConsultarAlquileres_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoraInicio_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraFin_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancha";
            // 
            // Cancha_comboBox
            // 
            this.Cancha_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cancha_comboBox.FormattingEnabled = true;
            this.Cancha_comboBox.Location = new System.Drawing.Point(15, 25);
            this.Cancha_comboBox.Name = "Cancha_comboBox";
            this.Cancha_comboBox.Size = new System.Drawing.Size(248, 21);
            this.Cancha_comboBox.TabIndex = 1;
            this.Cancha_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cancha_comboBox_SelectedIndexChanged);
            // 
            // Fecha_monthCalendar
            // 
            this.Fecha_monthCalendar.Location = new System.Drawing.Point(15, 94);
            this.Fecha_monthCalendar.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.Fecha_monthCalendar.MaxSelectionCount = 1;
            this.Fecha_monthCalendar.Name = "Fecha_monthCalendar";
            this.Fecha_monthCalendar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // Opcionales_comboBox
            // 
            this.Opcionales_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Opcionales_comboBox.FormattingEnabled = true;
            this.Opcionales_comboBox.Location = new System.Drawing.Point(15, 337);
            this.Opcionales_comboBox.Name = "Opcionales_comboBox";
            this.Opcionales_comboBox.Size = new System.Drawing.Size(248, 21);
            this.Opcionales_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opcionales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jueces Disponibles";
            // 
            // Jueces_listBox
            // 
            this.Jueces_listBox.FormattingEnabled = true;
            this.Jueces_listBox.Location = new System.Drawing.Point(287, 337);
            this.Jueces_listBox.Name = "Jueces_listBox";
            this.Jueces_listBox.Size = new System.Drawing.Size(205, 95);
            this.Jueces_listBox.TabIndex = 7;
            // 
            // HoraInicio_numericUpDown
            // 
            this.HoraInicio_numericUpDown.Location = new System.Drawing.Point(58, 20);
            this.HoraInicio_numericUpDown.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.HoraInicio_numericUpDown.Name = "HoraInicio_numericUpDown";
            this.HoraInicio_numericUpDown.Size = new System.Drawing.Size(47, 20);
            this.HoraInicio_numericUpDown.TabIndex = 9;
            this.HoraInicio_numericUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // HoraFin_numericUpDown
            // 
            this.HoraFin_numericUpDown.Location = new System.Drawing.Point(58, 56);
            this.HoraFin_numericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.HoraFin_numericUpDown.Name = "HoraFin_numericUpDown";
            this.HoraFin_numericUpDown.Size = new System.Drawing.Size(47, 20);
            this.HoraFin_numericUpDown.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Inicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HoraFin_numericUpDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.HoraInicio_numericUpDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(287, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(672, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 352);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cancha";
            // 
            // Alquileres_listBox
            // 
            this.Alquileres_listBox.FormattingEnabled = true;
            this.Alquileres_listBox.Location = new System.Drawing.Point(435, 92);
            this.Alquileres_listBox.Name = "Alquileres_listBox";
            this.Alquileres_listBox.Size = new System.Drawing.Size(199, 160);
            this.Alquileres_listBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Alquileres";
            // 
            // ConsultarAlquileres_btn
            // 
            this.ConsultarAlquileres_btn.Location = new System.Drawing.Point(73, 268);
            this.ConsultarAlquileres_btn.Name = "ConsultarAlquileres_btn";
            this.ConsultarAlquileres_btn.Size = new System.Drawing.Size(119, 26);
            this.ConsultarAlquileres_btn.TabIndex = 17;
            this.ConsultarAlquileres_btn.Text = "Consultar Alquileres";
            this.ConsultarAlquileres_btn.UseVisualStyleBackColor = true;
            this.ConsultarAlquileres_btn.Click += new System.EventHandler(this.ConsultarAlquileres_btn_Click_1);
            // 
            // NuevaReserva_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.ConsultarAlquileres_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Alquileres_listBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Jueces_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Opcionales_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Fecha_monthCalendar);
            this.Controls.Add(this.Cancha_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "NuevaReserva_frm";
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.NuevaReserva_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoraInicio_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraFin_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cancha_comboBox;
        private System.Windows.Forms.MonthCalendar Fecha_monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Opcionales_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Jueces_listBox;
        private System.Windows.Forms.NumericUpDown HoraInicio_numericUpDown;
        private System.Windows.Forms.NumericUpDown HoraFin_numericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Alquileres_listBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConsultarAlquileres_btn;
    }
}