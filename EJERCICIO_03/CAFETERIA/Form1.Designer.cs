namespace CAFETERIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cafeteras_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cafeDisponible_lbl = new System.Windows.Forms.Label();
            this.tipoCafe_lbl = new System.Windows.Forms.Label();
            this.precioCafe_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServirCafe_btn = new System.Windows.Forms.Button();
            this.vasoChico_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vasoGrande_radioButton = new System.Windows.Forms.RadioButton();
            this.vasoMediano_radioButton = new System.Windows.Forms.RadioButton();
            this.AgregarCafetera_btn = new System.Windows.Forms.Button();
            this.RecargarCafetera_btn = new System.Windows.Forms.Button();
            this.VerInforme_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cafeteras_comboBox
            // 
            this.Cafeteras_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cafeteras_comboBox.FormattingEnabled = true;
            this.Cafeteras_comboBox.Location = new System.Drawing.Point(15, 25);
            this.Cafeteras_comboBox.Name = "Cafeteras_comboBox";
            this.Cafeteras_comboBox.Size = new System.Drawing.Size(178, 21);
            this.Cafeteras_comboBox.TabIndex = 0;
            this.Cafeteras_comboBox.SelectedIndexChanged += new System.EventHandler(this.Cafeteras_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cafeteras";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cafeDisponible_lbl);
            this.groupBox1.Controls.Add(this.tipoCafe_lbl);
            this.groupBox1.Controls.Add(this.precioCafe_lbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info. Cafetera";
            // 
            // cafeDisponible_lbl
            // 
            this.cafeDisponible_lbl.AutoSize = true;
            this.cafeDisponible_lbl.Location = new System.Drawing.Point(99, 86);
            this.cafeDisponible_lbl.Name = "cafeDisponible_lbl";
            this.cafeDisponible_lbl.Size = new System.Drawing.Size(77, 13);
            this.cafeDisponible_lbl.TabIndex = 5;
            this.cafeDisponible_lbl.Text = "cafeDisponible";
            // 
            // tipoCafe_lbl
            // 
            this.tipoCafe_lbl.AutoSize = true;
            this.tipoCafe_lbl.Location = new System.Drawing.Point(99, 21);
            this.tipoCafe_lbl.Name = "tipoCafe_lbl";
            this.tipoCafe_lbl.Size = new System.Drawing.Size(46, 13);
            this.tipoCafe_lbl.TabIndex = 4;
            this.tipoCafe_lbl.Text = "tipoCafe";
            // 
            // precioCafe_lbl
            // 
            this.precioCafe_lbl.AutoSize = true;
            this.precioCafe_lbl.Location = new System.Drawing.Point(99, 53);
            this.precioCafe_lbl.Name = "precioCafe_lbl";
            this.precioCafe_lbl.Size = new System.Drawing.Size(58, 13);
            this.precioCafe_lbl.TabIndex = 3;
            this.precioCafe_lbl.Text = "precioCafe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cafe disponible:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio (por Litro):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cafe:";
            // 
            // ServirCafe_btn
            // 
            this.ServirCafe_btn.Location = new System.Drawing.Point(218, 266);
            this.ServirCafe_btn.Name = "ServirCafe_btn";
            this.ServirCafe_btn.Size = new System.Drawing.Size(75, 41);
            this.ServirCafe_btn.TabIndex = 3;
            this.ServirCafe_btn.Text = "Servir Cafe";
            this.ServirCafe_btn.UseVisualStyleBackColor = true;
            this.ServirCafe_btn.Click += new System.EventHandler(this.ServirCafe_btn_Click);
            // 
            // vasoChico_radioButton
            // 
            this.vasoChico_radioButton.AutoSize = true;
            this.vasoChico_radioButton.Checked = true;
            this.vasoChico_radioButton.Location = new System.Drawing.Point(6, 19);
            this.vasoChico_radioButton.Name = "vasoChico_radioButton";
            this.vasoChico_radioButton.Size = new System.Drawing.Size(86, 17);
            this.vasoChico_radioButton.TabIndex = 4;
            this.vasoChico_radioButton.TabStop = true;
            this.vasoChico_radioButton.Text = "Chico - 50 ml";
            this.vasoChico_radioButton.UseVisualStyleBackColor = true;
            this.vasoChico_radioButton.CheckedChanged += new System.EventHandler(this.vasoChico_radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vasoGrande_radioButton);
            this.groupBox2.Controls.Add(this.vasoMediano_radioButton);
            this.groupBox2.Controls.Add(this.vasoChico_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(218, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 92);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vasos";
            // 
            // vasoGrande_radioButton
            // 
            this.vasoGrande_radioButton.AutoSize = true;
            this.vasoGrande_radioButton.Location = new System.Drawing.Point(6, 65);
            this.vasoGrande_radioButton.Name = "vasoGrande_radioButton";
            this.vasoGrande_radioButton.Size = new System.Drawing.Size(100, 17);
            this.vasoGrande_radioButton.TabIndex = 6;
            this.vasoGrande_radioButton.TabStop = true;
            this.vasoGrande_radioButton.Text = "Grande - 250 ml";
            this.vasoGrande_radioButton.UseVisualStyleBackColor = true;
            this.vasoGrande_radioButton.CheckedChanged += new System.EventHandler(this.vasoGrande_radioButton_CheckedChanged);
            // 
            // vasoMediano_radioButton
            // 
            this.vasoMediano_radioButton.AutoSize = true;
            this.vasoMediano_radioButton.Location = new System.Drawing.Point(6, 42);
            this.vasoMediano_radioButton.Name = "vasoMediano_radioButton";
            this.vasoMediano_radioButton.Size = new System.Drawing.Size(106, 17);
            this.vasoMediano_radioButton.TabIndex = 5;
            this.vasoMediano_radioButton.TabStop = true;
            this.vasoMediano_radioButton.Text = "Mediano - 100 ml";
            this.vasoMediano_radioButton.UseVisualStyleBackColor = true;
            this.vasoMediano_radioButton.CheckedChanged += new System.EventHandler(this.vasoMediano_radioButton_CheckedChanged);
            // 
            // AgregarCafetera_btn
            // 
            this.AgregarCafetera_btn.Location = new System.Drawing.Point(15, 52);
            this.AgregarCafetera_btn.Name = "AgregarCafetera_btn";
            this.AgregarCafetera_btn.Size = new System.Drawing.Size(83, 39);
            this.AgregarCafetera_btn.TabIndex = 4;
            this.AgregarCafetera_btn.Text = "Agregar Cafetera";
            this.AgregarCafetera_btn.UseVisualStyleBackColor = true;
            this.AgregarCafetera_btn.Click += new System.EventHandler(this.AgregarCafetera_btn_Click);
            // 
            // RecargarCafetera_btn
            // 
            this.RecargarCafetera_btn.Location = new System.Drawing.Point(443, 23);
            this.RecargarCafetera_btn.Name = "RecargarCafetera_btn";
            this.RecargarCafetera_btn.Size = new System.Drawing.Size(75, 41);
            this.RecargarCafetera_btn.TabIndex = 5;
            this.RecargarCafetera_btn.Text = "Recargar Cafetera";
            this.RecargarCafetera_btn.UseVisualStyleBackColor = true;
            this.RecargarCafetera_btn.Click += new System.EventHandler(this.RecargarCafetera_btn_Click);
            // 
            // VerInforme_btn
            // 
            this.VerInforme_btn.Location = new System.Drawing.Point(15, 118);
            this.VerInforme_btn.Name = "VerInforme_btn";
            this.VerInforme_btn.Size = new System.Drawing.Size(83, 39);
            this.VerInforme_btn.TabIndex = 6;
            this.VerInforme_btn.Text = "Ver Informe";
            this.VerInforme_btn.UseVisualStyleBackColor = true;
            this.VerInforme_btn.Click += new System.EventHandler(this.VerInforme_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total:";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(261, 240);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(52, 13);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "$0000,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 316);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VerInforme_btn);
            this.Controls.Add(this.RecargarCafetera_btn);
            this.Controls.Add(this.AgregarCafetera_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ServirCafe_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cafeteras_comboBox);
            this.Name = "Form1";
            this.Text = "Cafeteria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cafeteras_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ServirCafe_btn;
        private System.Windows.Forms.RadioButton vasoChico_radioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton vasoGrande_radioButton;
        private System.Windows.Forms.RadioButton vasoMediano_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarCafetera_btn;
        private System.Windows.Forms.Button RecargarCafetera_btn;
        private System.Windows.Forms.Button VerInforme_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label cafeDisponible_lbl;
        private System.Windows.Forms.Label tipoCafe_lbl;
        private System.Windows.Forms.Label precioCafe_lbl;
    }
}

