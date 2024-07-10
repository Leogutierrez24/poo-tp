namespace OBSERVATORIO.formularios
{
    partial class VerSatelite_frm
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
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.Edad_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Masa_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Acoplamiento_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Location = new System.Drawing.Point(25, 35);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.ReadOnly = true;
            this.Nombre_textBox.Size = new System.Drawing.Size(219, 20);
            this.Nombre_textBox.TabIndex = 1;
            // 
            // Edad_textBox
            // 
            this.Edad_textBox.Location = new System.Drawing.Point(25, 88);
            this.Edad_textBox.Name = "Edad_textBox";
            this.Edad_textBox.ReadOnly = true;
            this.Edad_textBox.Size = new System.Drawing.Size(219, 20);
            this.Edad_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad";
            // 
            // Masa_textBox
            // 
            this.Masa_textBox.Location = new System.Drawing.Point(25, 143);
            this.Masa_textBox.Name = "Masa_textBox";
            this.Masa_textBox.ReadOnly = true;
            this.Masa_textBox.Size = new System.Drawing.Size(219, 20);
            this.Masa_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masa";
            // 
            // Acoplamiento_textBox
            // 
            this.Acoplamiento_textBox.Location = new System.Drawing.Point(146, 186);
            this.Acoplamiento_textBox.Name = "Acoplamiento_textBox";
            this.Acoplamiento_textBox.ReadOnly = true;
            this.Acoplamiento_textBox.Size = new System.Drawing.Size(98, 20);
            this.Acoplamiento_textBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Acoplamiento de marea";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "miles de millones de años";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = " M🜨 = 5,97 × 10^24 kg";
            // 
            // VerSatelite_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 232);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Acoplamiento_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Masa_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Edad_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label1);
            this.Name = "VerSatelite_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Satelite";
            this.Load += new System.EventHandler(this.VerSatelite_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.TextBox Edad_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Masa_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Acoplamiento_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}