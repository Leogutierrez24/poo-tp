namespace OBSERVATORIO.formularios
{
    partial class NuevoRegistro_frm
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
            this.FechaAvistamiento_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ValorFiltro_textBox = new System.Windows.Forms.TextBox();
            this.Filtrar_btn = new System.Windows.Forms.Button();
            this.CuerposEncontrados_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Filtros_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Opcion03_radioButton = new System.Windows.Forms.RadioButton();
            this.Opcion02_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Opcion01_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Legajo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Personal_checkBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaNacimieto_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Apellido_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DistanciaATierra_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Legajo_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaATierra_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de avistamiento:";
            // 
            // FechaAvistamiento_dateTimePicker
            // 
            this.FechaAvistamiento_dateTimePicker.Location = new System.Drawing.Point(135, 9);
            this.FechaAvistamiento_dateTimePicker.Name = "FechaAvistamiento_dateTimePicker";
            this.FechaAvistamiento_dateTimePicker.Size = new System.Drawing.Size(223, 20);
            this.FechaAvistamiento_dateTimePicker.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ValorFiltro_textBox);
            this.groupBox1.Controls.Add(this.Filtrar_btn);
            this.groupBox1.Controls.Add(this.CuerposEncontrados_listBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Filtros_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Opcion03_radioButton);
            this.groupBox1.Controls.Add(this.Opcion02_radioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Opcion01_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cuerpos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Concepto a filtrar:";
            // 
            // ValorFiltro_textBox
            // 
            this.ValorFiltro_textBox.Enabled = false;
            this.ValorFiltro_textBox.Location = new System.Drawing.Point(200, 41);
            this.ValorFiltro_textBox.Name = "ValorFiltro_textBox";
            this.ValorFiltro_textBox.Size = new System.Drawing.Size(158, 20);
            this.ValorFiltro_textBox.TabIndex = 11;
            // 
            // Filtrar_btn
            // 
            this.Filtrar_btn.Location = new System.Drawing.Point(236, 69);
            this.Filtrar_btn.Name = "Filtrar_btn";
            this.Filtrar_btn.Size = new System.Drawing.Size(81, 36);
            this.Filtrar_btn.TabIndex = 10;
            this.Filtrar_btn.Text = "Buscar";
            this.Filtrar_btn.UseVisualStyleBackColor = true;
            this.Filtrar_btn.Click += new System.EventHandler(this.Filtrar_btn_Click_1);
            // 
            // CuerposEncontrados_listBox
            // 
            this.CuerposEncontrados_listBox.FormattingEnabled = true;
            this.CuerposEncontrados_listBox.Location = new System.Drawing.Point(15, 188);
            this.CuerposEncontrados_listBox.Name = "CuerposEncontrados_listBox";
            this.CuerposEncontrados_listBox.Size = new System.Drawing.Size(343, 121);
            this.CuerposEncontrados_listBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // Filtros_comboBox
            // 
            this.Filtros_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filtros_comboBox.FormattingEnabled = true;
            this.Filtros_comboBox.Location = new System.Drawing.Point(18, 138);
            this.Filtros_comboBox.Name = "Filtros_comboBox";
            this.Filtros_comboBox.Size = new System.Drawing.Size(158, 21);
            this.Filtros_comboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar por:";
            // 
            // Opcion03_radioButton
            // 
            this.Opcion03_radioButton.AutoSize = true;
            this.Opcion03_radioButton.Location = new System.Drawing.Point(18, 88);
            this.Opcion03_radioButton.Name = "Opcion03_radioButton";
            this.Opcion03_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Opcion03_radioButton.TabIndex = 3;
            this.Opcion03_radioButton.Text = "Estrella";
            this.Opcion03_radioButton.UseVisualStyleBackColor = true;
            this.Opcion03_radioButton.CheckedChanged += new System.EventHandler(this.Opcion03_radioButton_CheckedChanged);
            // 
            // Opcion02_radioButton
            // 
            this.Opcion02_radioButton.AutoSize = true;
            this.Opcion02_radioButton.Location = new System.Drawing.Point(18, 65);
            this.Opcion02_radioButton.Name = "Opcion02_radioButton";
            this.Opcion02_radioButton.Size = new System.Drawing.Size(61, 17);
            this.Opcion02_radioButton.TabIndex = 2;
            this.Opcion02_radioButton.Text = "Planeta";
            this.Opcion02_radioButton.UseVisualStyleBackColor = true;
            this.Opcion02_radioButton.CheckedChanged += new System.EventHandler(this.Opcion02_radioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuerpo Celeste:";
            // 
            // Opcion01_radioButton
            // 
            this.Opcion01_radioButton.AutoSize = true;
            this.Opcion01_radioButton.Checked = true;
            this.Opcion01_radioButton.Location = new System.Drawing.Point(18, 42);
            this.Opcion01_radioButton.Name = "Opcion01_radioButton";
            this.Opcion01_radioButton.Size = new System.Drawing.Size(60, 17);
            this.Opcion01_radioButton.TabIndex = 0;
            this.Opcion01_radioButton.TabStop = true;
            this.Opcion01_radioButton.Text = "Satelite";
            this.Opcion01_radioButton.UseVisualStyleBackColor = true;
            this.Opcion01_radioButton.CheckedChanged += new System.EventHandler(this.Opcion01_radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Legajo_numericUpDown);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Personal_checkBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.FechaNacimieto_dateTimePicker);
            this.groupBox2.Controls.Add(this.Apellido_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Nombre_textBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(401, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descubridor";
            // 
            // Legajo_numericUpDown
            // 
            this.Legajo_numericUpDown.Location = new System.Drawing.Point(56, 161);
            this.Legajo_numericUpDown.Name = "Legajo_numericUpDown";
            this.Legajo_numericUpDown.Size = new System.Drawing.Size(166, 20);
            this.Legajo_numericUpDown.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Legajo:";
            // 
            // Personal_checkBox
            // 
            this.Personal_checkBox.AutoSize = true;
            this.Personal_checkBox.Location = new System.Drawing.Point(9, 133);
            this.Personal_checkBox.Name = "Personal_checkBox";
            this.Personal_checkBox.Size = new System.Drawing.Size(81, 17);
            this.Personal_checkBox.TabIndex = 7;
            this.Personal_checkBox.Text = "Es personal";
            this.Personal_checkBox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fecha de nacimiento:";
            // 
            // FechaNacimieto_dateTimePicker
            // 
            this.FechaNacimieto_dateTimePicker.Location = new System.Drawing.Point(9, 93);
            this.FechaNacimieto_dateTimePicker.Name = "FechaNacimieto_dateTimePicker";
            this.FechaNacimieto_dateTimePicker.Size = new System.Drawing.Size(202, 20);
            this.FechaNacimieto_dateTimePicker.TabIndex = 5;
            // 
            // Apellido_textBox
            // 
            this.Apellido_textBox.Location = new System.Drawing.Point(56, 44);
            this.Apellido_textBox.Name = "Apellido_textBox";
            this.Apellido_textBox.Size = new System.Drawing.Size(166, 20);
            this.Apellido_textBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido:";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(56, 18);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(166, 20);
            this.Nombre_textBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombe:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar Registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(532, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Distancia a la tierra:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "(en años luz)";
            // 
            // DistanciaATierra_numericUpDown
            // 
            this.DistanciaATierra_numericUpDown.DecimalPlaces = 2;
            this.DistanciaATierra_numericUpDown.Location = new System.Drawing.Point(118, 367);
            this.DistanciaATierra_numericUpDown.Name = "DistanciaATierra_numericUpDown";
            this.DistanciaATierra_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DistanciaATierra_numericUpDown.TabIndex = 13;
            // 
            // NuevoRegistro_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 417);
            this.Controls.Add(this.DistanciaATierra_numericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaAvistamiento_dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "NuevoRegistro_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Registro";
            this.Load += new System.EventHandler(this.NuevoRegistro_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Legajo_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistanciaATierra_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaAvistamiento_dateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ValorFiltro_textBox;
        private System.Windows.Forms.Button Filtrar_btn;
        private System.Windows.Forms.ListBox CuerposEncontrados_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Filtros_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Opcion03_radioButton;
        private System.Windows.Forms.RadioButton Opcion02_radioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Opcion01_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox Personal_checkBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaNacimieto_dateTimePicker;
        private System.Windows.Forms.TextBox Apellido_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown DistanciaATierra_numericUpDown;
        private System.Windows.Forms.NumericUpDown Legajo_numericUpDown;
    }
}