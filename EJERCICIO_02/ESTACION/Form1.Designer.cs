namespace ESTACION
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
            this.Surtidores_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipoNafta_lbl = new System.Windows.Forms.Label();
            this.precioNafta_lbl = new System.Windows.Forms.Label();
            this.capacidadSurtidor_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.recaudacion_lbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surtidores";
            // 
            // Surtidores_comboBox
            // 
            this.Surtidores_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Surtidores_comboBox.FormattingEnabled = true;
            this.Surtidores_comboBox.Location = new System.Drawing.Point(15, 25);
            this.Surtidores_comboBox.Name = "Surtidores_comboBox";
            this.Surtidores_comboBox.Size = new System.Drawing.Size(183, 21);
            this.Surtidores_comboBox.TabIndex = 1;
            this.Surtidores_comboBox.SelectedIndexChanged += new System.EventHandler(this.Surtidores_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capacidadSurtidor_lbl);
            this.groupBox1.Controls.Add(this.precioNafta_lbl);
            this.groupBox1.Controls.Add(this.tipoNafta_lbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(237, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surtidor Seleccionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nafta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Capacidad:";
            // 
            // tipoNafta_lbl
            // 
            this.tipoNafta_lbl.AutoSize = true;
            this.tipoNafta_lbl.Location = new System.Drawing.Point(72, 24);
            this.tipoNafta_lbl.Name = "tipoNafta_lbl";
            this.tipoNafta_lbl.Size = new System.Drawing.Size(50, 13);
            this.tipoNafta_lbl.TabIndex = 6;
            this.tipoNafta_lbl.Text = "tipoNafta";
            // 
            // precioNafta_lbl
            // 
            this.precioNafta_lbl.AutoSize = true;
            this.precioNafta_lbl.Location = new System.Drawing.Point(72, 46);
            this.precioNafta_lbl.Name = "precioNafta_lbl";
            this.precioNafta_lbl.Size = new System.Drawing.Size(62, 13);
            this.precioNafta_lbl.TabIndex = 7;
            this.precioNafta_lbl.Text = "precioNafta";
            // 
            // capacidadSurtidor_lbl
            // 
            this.capacidadSurtidor_lbl.AutoSize = true;
            this.capacidadSurtidor_lbl.Location = new System.Drawing.Point(73, 70);
            this.capacidadSurtidor_lbl.Name = "capacidadSurtidor_lbl";
            this.capacidadSurtidor_lbl.Size = new System.Drawing.Size(93, 13);
            this.capacidadSurtidor_lbl.TabIndex = 8;
            this.capacidadSurtidor_lbl.Text = "capacidadSurtidor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Recargar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ver informes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Recaudación:";
            // 
            // recaudacion_lbl
            // 
            this.recaudacion_lbl.AutoSize = true;
            this.recaudacion_lbl.Location = new System.Drawing.Point(92, 79);
            this.recaudacion_lbl.Name = "recaudacion_lbl";
            this.recaudacion_lbl.Size = new System.Drawing.Size(55, 13);
            this.recaudacion_lbl.TabIndex = 10;
            this.recaudacion_lbl.Text = "$ 0000,00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 161);
            this.Controls.Add(this.recaudacion_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Surtidores_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTACIÓN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Surtidores_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label capacidadSurtidor_lbl;
        private System.Windows.Forms.Label precioNafta_lbl;
        private System.Windows.Forms.Label tipoNafta_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label recaudacion_lbl;
    }
}

