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
            this.Registros_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NuevoRegistro_btn = new System.Windows.Forms.Button();
            this.AgregarCuerpo_btn = new System.Windows.Forms.Button();
            this.VerRegistro_btn = new System.Windows.Forms.Button();
            this.VerCuerpo_btn = new System.Windows.Forms.Button();
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
            // Registros_listBox
            // 
            this.Registros_listBox.FormattingEnabled = true;
            this.Registros_listBox.Location = new System.Drawing.Point(236, 25);
            this.Registros_listBox.Name = "Registros_listBox";
            this.Registros_listBox.Size = new System.Drawing.Size(177, 121);
            this.Registros_listBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Registros";
            // 
            // NuevoRegistro_btn
            // 
            this.NuevoRegistro_btn.Location = new System.Drawing.Point(236, 152);
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
            // VerRegistro_btn
            // 
            this.VerRegistro_btn.Location = new System.Drawing.Point(332, 152);
            this.VerRegistro_btn.Name = "VerRegistro_btn";
            this.VerRegistro_btn.Size = new System.Drawing.Size(81, 36);
            this.VerRegistro_btn.TabIndex = 8;
            this.VerRegistro_btn.Text = "Ver registro";
            this.VerRegistro_btn.UseVisualStyleBackColor = true;
            this.VerRegistro_btn.Click += new System.EventHandler(this.VerRegistro_btn_Click);
            // 
            // VerCuerpo_btn
            // 
            this.VerCuerpo_btn.Location = new System.Drawing.Point(108, 154);
            this.VerCuerpo_btn.Name = "VerCuerpo_btn";
            this.VerCuerpo_btn.Size = new System.Drawing.Size(81, 36);
            this.VerCuerpo_btn.TabIndex = 10;
            this.VerCuerpo_btn.Text = "Ver Cuerpo";
            this.VerCuerpo_btn.UseVisualStyleBackColor = true;
            this.VerCuerpo_btn.Click += new System.EventHandler(this.VerCuerpo_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 207);
            this.Controls.Add(this.VerCuerpo_btn);
            this.Controls.Add(this.VerRegistro_btn);
            this.Controls.Add(this.AgregarCuerpo_btn);
            this.Controls.Add(this.NuevoRegistro_btn);
            this.Controls.Add(this.Registros_listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CuerposRegistrados_listBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observatorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CuerposRegistrados_listBox;
        private System.Windows.Forms.ListBox Registros_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevoRegistro_btn;
        private System.Windows.Forms.Button AgregarCuerpo_btn;
        private System.Windows.Forms.Button VerRegistro_btn;
        private System.Windows.Forms.Button VerCuerpo_btn;
    }
}

