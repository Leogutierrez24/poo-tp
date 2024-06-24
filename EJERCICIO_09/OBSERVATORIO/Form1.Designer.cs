namespace OBSERVATORIO
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
            this.label1 = new System.Windows.Forms.Label();
            this.CuerposRegistrados_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Opcion01_radioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Opcion02_radioButton = new System.Windows.Forms.RadioButton();
            this.Opcion03_radioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Filtros_comboBox = new System.Windows.Forms.ComboBox();
            this.CuerposEncontrados_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Registros_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevoRegistro_btn = new System.Windows.Forms.Button();
            this.AgregarCuerpo_btn = new System.Windows.Forms.Button();
            this.ModificarCuerpo_btn = new System.Windows.Forms.Button();
            this.VerRegistro_btn = new System.Windows.Forms.Button();
            this.VerCuerpoFiltrado_btn = new System.Windows.Forms.Button();
            this.VerCuerpo_btn = new System.Windows.Forms.Button();
            this.Filtrar_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuerpos registrados";
            // 
            // CuerposRegistrados_listBox
            // 
            this.CuerposRegistrados_listBox.FormattingEnabled = true;
            this.CuerposRegistrados_listBox.Location = new System.Drawing.Point(12, 25);
            this.CuerposRegistrados_listBox.Name = "CuerposRegistrados_listBox";
            this.CuerposRegistrados_listBox.Size = new System.Drawing.Size(177, 121);
            this.CuerposRegistrados_listBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Filtrar_btn);
            this.groupBox1.Controls.Add(this.VerCuerpoFiltrado_btn);
            this.groupBox1.Controls.Add(this.CuerposEncontrados_listBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Filtros_comboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Opcion03_radioButton);
            this.groupBox1.Controls.Add(this.Opcion02_radioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Opcion01_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(220, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Cuerpos";
            // 
            // Opcion01_radioButton
            // 
            this.Opcion01_radioButton.AutoSize = true;
            this.Opcion01_radioButton.Location = new System.Drawing.Point(18, 42);
            this.Opcion01_radioButton.Name = "Opcion01_radioButton";
            this.Opcion01_radioButton.Size = new System.Drawing.Size(60, 17);
            this.Opcion01_radioButton.TabIndex = 0;
            this.Opcion01_radioButton.TabStop = true;
            this.Opcion01_radioButton.Text = "Satelite";
            this.Opcion01_radioButton.UseVisualStyleBackColor = true;
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
            // Opcion02_radioButton
            // 
            this.Opcion02_radioButton.AutoSize = true;
            this.Opcion02_radioButton.Location = new System.Drawing.Point(18, 65);
            this.Opcion02_radioButton.Name = "Opcion02_radioButton";
            this.Opcion02_radioButton.Size = new System.Drawing.Size(61, 17);
            this.Opcion02_radioButton.TabIndex = 2;
            this.Opcion02_radioButton.TabStop = true;
            this.Opcion02_radioButton.Text = "Planeta";
            this.Opcion02_radioButton.UseVisualStyleBackColor = true;
            // 
            // Opcion03_radioButton
            // 
            this.Opcion03_radioButton.AutoSize = true;
            this.Opcion03_radioButton.Location = new System.Drawing.Point(18, 88);
            this.Opcion03_radioButton.Name = "Opcion03_radioButton";
            this.Opcion03_radioButton.Size = new System.Drawing.Size(59, 17);
            this.Opcion03_radioButton.TabIndex = 3;
            this.Opcion03_radioButton.TabStop = true;
            this.Opcion03_radioButton.Text = "Estrella";
            this.Opcion03_radioButton.UseVisualStyleBackColor = true;
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
            // Filtros_comboBox
            // 
            this.Filtros_comboBox.FormattingEnabled = true;
            this.Filtros_comboBox.Location = new System.Drawing.Point(18, 138);
            this.Filtros_comboBox.Name = "Filtros_comboBox";
            this.Filtros_comboBox.Size = new System.Drawing.Size(158, 21);
            this.Filtros_comboBox.TabIndex = 5;
            // 
            // CuerposEncontrados_listBox
            // 
            this.CuerposEncontrados_listBox.FormattingEnabled = true;
            this.CuerposEncontrados_listBox.Location = new System.Drawing.Point(6, 237);
            this.CuerposEncontrados_listBox.Name = "CuerposEncontrados_listBox";
            this.CuerposEncontrados_listBox.Size = new System.Drawing.Size(177, 121);
            this.CuerposEncontrados_listBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // Registros_listBox
            // 
            this.Registros_listBox.FormattingEnabled = true;
            this.Registros_listBox.Location = new System.Drawing.Point(12, 260);
            this.Registros_listBox.Name = "Registros_listBox";
            this.Registros_listBox.Size = new System.Drawing.Size(177, 121);
            this.Registros_listBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registros";
            // 
            // NuevoRegistro_btn
            // 
            this.NuevoRegistro_btn.Location = new System.Drawing.Point(12, 387);
            this.NuevoRegistro_btn.Name = "NuevoRegistro_btn";
            this.NuevoRegistro_btn.Size = new System.Drawing.Size(87, 36);
            this.NuevoRegistro_btn.TabIndex = 5;
            this.NuevoRegistro_btn.Text = "Nuevo registro";
            this.NuevoRegistro_btn.UseVisualStyleBackColor = true;
            this.NuevoRegistro_btn.Click += new System.EventHandler(this.NuevoRegistro_btn_Click);
            // 
            // AgregarCuerpo_btn
            // 
            this.AgregarCuerpo_btn.Location = new System.Drawing.Point(15, 154);
            this.AgregarCuerpo_btn.Name = "AgregarCuerpo_btn";
            this.AgregarCuerpo_btn.Size = new System.Drawing.Size(87, 36);
            this.AgregarCuerpo_btn.TabIndex = 6;
            this.AgregarCuerpo_btn.Text = "Agregar cuerpo celeste";
            this.AgregarCuerpo_btn.UseVisualStyleBackColor = true;
            this.AgregarCuerpo_btn.Click += new System.EventHandler(this.AgregarCuerpo_btn_Click);
            // 
            // ModificarCuerpo_btn
            // 
            this.ModificarCuerpo_btn.Location = new System.Drawing.Point(108, 154);
            this.ModificarCuerpo_btn.Name = "ModificarCuerpo_btn";
            this.ModificarCuerpo_btn.Size = new System.Drawing.Size(81, 36);
            this.ModificarCuerpo_btn.TabIndex = 7;
            this.ModificarCuerpo_btn.Text = "Modificar";
            this.ModificarCuerpo_btn.UseVisualStyleBackColor = true;
            this.ModificarCuerpo_btn.Click += new System.EventHandler(this.ModificarCuerpo_btn_Click);
            // 
            // VerRegistro_btn
            // 
            this.VerRegistro_btn.Location = new System.Drawing.Point(108, 387);
            this.VerRegistro_btn.Name = "VerRegistro_btn";
            this.VerRegistro_btn.Size = new System.Drawing.Size(81, 36);
            this.VerRegistro_btn.TabIndex = 8;
            this.VerRegistro_btn.Text = "Ver registro";
            this.VerRegistro_btn.UseVisualStyleBackColor = true;
            this.VerRegistro_btn.Click += new System.EventHandler(this.VerRegistro_btn_Click);
            // 
            // VerCuerpoFiltrado_btn
            // 
            this.VerCuerpoFiltrado_btn.Location = new System.Drawing.Point(9, 364);
            this.VerCuerpoFiltrado_btn.Name = "VerCuerpoFiltrado_btn";
            this.VerCuerpoFiltrado_btn.Size = new System.Drawing.Size(81, 36);
            this.VerCuerpoFiltrado_btn.TabIndex = 9;
            this.VerCuerpoFiltrado_btn.Text = "Ver Cuerpo";
            this.VerCuerpoFiltrado_btn.UseVisualStyleBackColor = true;
            this.VerCuerpoFiltrado_btn.Click += new System.EventHandler(this.VerCuerpoFiltrado_btn_Click);
            // 
            // VerCuerpo_btn
            // 
            this.VerCuerpo_btn.Location = new System.Drawing.Point(108, 196);
            this.VerCuerpo_btn.Name = "VerCuerpo_btn";
            this.VerCuerpo_btn.Size = new System.Drawing.Size(81, 36);
            this.VerCuerpo_btn.TabIndex = 10;
            this.VerCuerpo_btn.Text = "Ver Cuerpo";
            this.VerCuerpo_btn.UseVisualStyleBackColor = true;
            this.VerCuerpo_btn.Click += new System.EventHandler(this.VerCuerpo_btn_Click);
            // 
            // Filtrar_btn
            // 
            this.Filtrar_btn.Location = new System.Drawing.Point(56, 165);
            this.Filtrar_btn.Name = "Filtrar_btn";
            this.Filtrar_btn.Size = new System.Drawing.Size(81, 36);
            this.Filtrar_btn.TabIndex = 10;
            this.Filtrar_btn.Text = "Filtrar";
            this.Filtrar_btn.UseVisualStyleBackColor = true;
            this.Filtrar_btn.Click += new System.EventHandler(this.Filtrar_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 436);
            this.Controls.Add(this.VerCuerpo_btn);
            this.Controls.Add(this.VerRegistro_btn);
            this.Controls.Add(this.ModificarCuerpo_btn);
            this.Controls.Add(this.AgregarCuerpo_btn);
            this.Controls.Add(this.NuevoRegistro_btn);
            this.Controls.Add(this.Registros_listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CuerposRegistrados_listBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Observatorio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CuerposRegistrados_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Opcion01_radioButton;
        private System.Windows.Forms.ListBox CuerposEncontrados_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Filtros_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Opcion03_radioButton;
        private System.Windows.Forms.RadioButton Opcion02_radioButton;
        private System.Windows.Forms.ListBox Registros_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevoRegistro_btn;
        private System.Windows.Forms.Button AgregarCuerpo_btn;
        private System.Windows.Forms.Button VerCuerpoFiltrado_btn;
        private System.Windows.Forms.Button ModificarCuerpo_btn;
        private System.Windows.Forms.Button VerRegistro_btn;
        private System.Windows.Forms.Button VerCuerpo_btn;
        private System.Windows.Forms.Button Filtrar_btn;
    }
}

