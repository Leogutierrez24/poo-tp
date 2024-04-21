namespace ESTACION.Formularios
{
    partial class Venta_frm
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
            this.label2 = new System.Windows.Forms.Label();
            this.Nafta_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.carga_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.carga_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carga_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nafta:";
            // 
            // Nafta_textBox
            // 
            this.Nafta_textBox.Location = new System.Drawing.Point(70, 37);
            this.Nafta_textBox.Name = "Nafta_textBox";
            this.Nafta_textBox.ReadOnly = true;
            this.Nafta_textBox.Size = new System.Drawing.Size(136, 20);
            this.Nafta_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // carga_numericUpDown
            // 
            this.carga_numericUpDown.DecimalPlaces = 2;
            this.carga_numericUpDown.Location = new System.Drawing.Point(70, 91);
            this.carga_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carga_numericUpDown.Name = "carga_numericUpDown";
            this.carga_numericUpDown.Size = new System.Drawing.Size(136, 20);
            this.carga_numericUpDown.TabIndex = 4;
            this.carga_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.carga_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Terminar Venta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // carga_textBox
            // 
            this.carga_textBox.Location = new System.Drawing.Point(70, 63);
            this.carga_textBox.Name = "carga_textBox";
            this.carga_textBox.ReadOnly = true;
            this.carga_textBox.Size = new System.Drawing.Size(136, 20);
            this.carga_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carga:";
            // 
            // Venta_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(224, 231);
            this.Controls.Add(this.carga_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carga_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nafta_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Venta_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nueva Venta";
            this.Load += new System.EventHandler(this.Venta_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carga_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nafta_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown carga_numericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox carga_textBox;
        private System.Windows.Forms.Label label4;
    }
}