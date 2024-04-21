namespace LIBRERIA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProductoPrecio_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CancelarProducto_btn = new System.Windows.Forms.Button();
            this.AgregarProducto_btn = new System.Windows.Forms.Button();
            this.ProductoDescripcion_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductoCodigo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoNombre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CancelarVenta_btn = new System.Windows.Forms.Button();
            this.FinalizarVenta_btn = new System.Windows.Forms.Button();
            this.QuitarDelCarrito_btn = new System.Windows.Forms.Button();
            this.Carrito_listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarAlCarrito_btn = new System.Windows.Forms.Button();
            this.Productos_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ventas_listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Recaudacion_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.VentaProductos_listBox = new System.Windows.Forms.ListBox();
            this.Subtotal_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPrecio_numericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProductoPrecio_numericUpDown);
            this.groupBox1.Controls.Add(this.CancelarProducto_btn);
            this.groupBox1.Controls.Add(this.AgregarProducto_btn);
            this.groupBox1.Controls.Add(this.ProductoDescripcion_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductoCodigo_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProductoNombre_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Producto";
            // 
            // ProductoPrecio_numericUpDown
            // 
            this.ProductoPrecio_numericUpDown.DecimalPlaces = 2;
            this.ProductoPrecio_numericUpDown.Location = new System.Drawing.Point(94, 114);
            this.ProductoPrecio_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ProductoPrecio_numericUpDown.Name = "ProductoPrecio_numericUpDown";
            this.ProductoPrecio_numericUpDown.Size = new System.Drawing.Size(100, 20);
            this.ProductoPrecio_numericUpDown.TabIndex = 8;
            // 
            // CancelarProducto_btn
            // 
            this.CancelarProducto_btn.Location = new System.Drawing.Point(119, 265);
            this.CancelarProducto_btn.Name = "CancelarProducto_btn";
            this.CancelarProducto_btn.Size = new System.Drawing.Size(75, 23);
            this.CancelarProducto_btn.TabIndex = 7;
            this.CancelarProducto_btn.Text = "Cancelar";
            this.CancelarProducto_btn.UseVisualStyleBackColor = true;
            this.CancelarProducto_btn.Click += new System.EventHandler(this.CancelarProducto_btn_Click);
            // 
            // AgregarProducto_btn
            // 
            this.AgregarProducto_btn.Location = new System.Drawing.Point(9, 265);
            this.AgregarProducto_btn.Name = "AgregarProducto_btn";
            this.AgregarProducto_btn.Size = new System.Drawing.Size(75, 23);
            this.AgregarProducto_btn.TabIndex = 6;
            this.AgregarProducto_btn.Text = "Agregar";
            this.AgregarProducto_btn.UseVisualStyleBackColor = true;
            this.AgregarProducto_btn.Click += new System.EventHandler(this.AgregarProducto_btn_Click);
            // 
            // ProductoDescripcion_textBox
            // 
            this.ProductoDescripcion_textBox.Location = new System.Drawing.Point(9, 175);
            this.ProductoDescripcion_textBox.Multiline = true;
            this.ProductoDescripcion_textBox.Name = "ProductoDescripcion_textBox";
            this.ProductoDescripcion_textBox.Size = new System.Drawing.Size(185, 84);
            this.ProductoDescripcion_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código de barra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // ProductoCodigo_textBox
            // 
            this.ProductoCodigo_textBox.Location = new System.Drawing.Point(94, 71);
            this.ProductoCodigo_textBox.Name = "ProductoCodigo_textBox";
            this.ProductoCodigo_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoCodigo_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de barra";
            // 
            // ProductoNombre_textBox
            // 
            this.ProductoNombre_textBox.Location = new System.Drawing.Point(94, 27);
            this.ProductoNombre_textBox.Name = "ProductoNombre_textBox";
            this.ProductoNombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoNombre_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Subtotal_lbl);
            this.groupBox2.Controls.Add(this.CancelarVenta_btn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.FinalizarVenta_btn);
            this.groupBox2.Controls.Add(this.QuitarDelCarrito_btn);
            this.groupBox2.Controls.Add(this.Carrito_listBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AgregarAlCarrito_btn);
            this.groupBox2.Controls.Add(this.Productos_listBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(246, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva Venta";
            // 
            // CancelarVenta_btn
            // 
            this.CancelarVenta_btn.Location = new System.Drawing.Point(348, 248);
            this.CancelarVenta_btn.Name = "CancelarVenta_btn";
            this.CancelarVenta_btn.Size = new System.Drawing.Size(75, 23);
            this.CancelarVenta_btn.TabIndex = 13;
            this.CancelarVenta_btn.Text = "Cancelar";
            this.CancelarVenta_btn.UseVisualStyleBackColor = true;
            this.CancelarVenta_btn.Click += new System.EventHandler(this.CancelarVenta_btn_Click);
            // 
            // FinalizarVenta_btn
            // 
            this.FinalizarVenta_btn.Location = new System.Drawing.Point(348, 219);
            this.FinalizarVenta_btn.Name = "FinalizarVenta_btn";
            this.FinalizarVenta_btn.Size = new System.Drawing.Size(75, 23);
            this.FinalizarVenta_btn.TabIndex = 12;
            this.FinalizarVenta_btn.Text = "Finalizar";
            this.FinalizarVenta_btn.UseVisualStyleBackColor = true;
            this.FinalizarVenta_btn.Click += new System.EventHandler(this.FinalizarVenta_btn_Click);
            // 
            // QuitarDelCarrito_btn
            // 
            this.QuitarDelCarrito_btn.Location = new System.Drawing.Point(225, 219);
            this.QuitarDelCarrito_btn.Name = "QuitarDelCarrito_btn";
            this.QuitarDelCarrito_btn.Size = new System.Drawing.Size(75, 40);
            this.QuitarDelCarrito_btn.TabIndex = 11;
            this.QuitarDelCarrito_btn.Text = "Quitar producto";
            this.QuitarDelCarrito_btn.UseVisualStyleBackColor = true;
            this.QuitarDelCarrito_btn.Click += new System.EventHandler(this.QuitarDelCarrito_btn_Click);
            // 
            // Carrito_listBox
            // 
            this.Carrito_listBox.FormattingEnabled = true;
            this.Carrito_listBox.Location = new System.Drawing.Point(225, 43);
            this.Carrito_listBox.Name = "Carrito_listBox";
            this.Carrito_listBox.Size = new System.Drawing.Size(198, 147);
            this.Carrito_listBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carrito";
            // 
            // AgregarAlCarrito_btn
            // 
            this.AgregarAlCarrito_btn.Location = new System.Drawing.Point(9, 196);
            this.AgregarAlCarrito_btn.Name = "AgregarAlCarrito_btn";
            this.AgregarAlCarrito_btn.Size = new System.Drawing.Size(75, 40);
            this.AgregarAlCarrito_btn.TabIndex = 8;
            this.AgregarAlCarrito_btn.Text = "Agregar al carrito";
            this.AgregarAlCarrito_btn.UseVisualStyleBackColor = true;
            this.AgregarAlCarrito_btn.Click += new System.EventHandler(this.AgregarAlCarrito_btn_Click);
            // 
            // Productos_listBox
            // 
            this.Productos_listBox.FormattingEnabled = true;
            this.Productos_listBox.Location = new System.Drawing.Point(9, 43);
            this.Productos_listBox.Name = "Productos_listBox";
            this.Productos_listBox.Size = new System.Drawing.Size(198, 147);
            this.Productos_listBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Productos";
            // 
            // Ventas_listBox
            // 
            this.Ventas_listBox.FormattingEnabled = true;
            this.Ventas_listBox.Location = new System.Drawing.Point(705, 28);
            this.Ventas_listBox.Name = "Ventas_listBox";
            this.Ventas_listBox.Size = new System.Drawing.Size(199, 95);
            this.Ventas_listBox.TabIndex = 2;
            this.Ventas_listBox.SelectedIndexChanged += new System.EventHandler(this.Ventas_listBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(702, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ventas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(707, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recaudación:";
            // 
            // Recaudacion_lbl
            // 
            this.Recaudacion_lbl.AutoSize = true;
            this.Recaudacion_lbl.Location = new System.Drawing.Point(787, 277);
            this.Recaudacion_lbl.Name = "Recaudacion_lbl";
            this.Recaudacion_lbl.Size = new System.Drawing.Size(46, 13);
            this.Recaudacion_lbl.TabIndex = 16;
            this.Recaudacion_lbl.Text = "0000.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(702, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Detalle";
            // 
            // VentaProductos_listBox
            // 
            this.VentaProductos_listBox.FormattingEnabled = true;
            this.VentaProductos_listBox.Location = new System.Drawing.Point(705, 153);
            this.VentaProductos_listBox.Name = "VentaProductos_listBox";
            this.VentaProductos_listBox.Size = new System.Drawing.Size(199, 95);
            this.VentaProductos_listBox.TabIndex = 17;
            // 
            // Subtotal_lbl
            // 
            this.Subtotal_lbl.AutoSize = true;
            this.Subtotal_lbl.Location = new System.Drawing.Point(281, 196);
            this.Subtotal_lbl.Name = "Subtotal_lbl";
            this.Subtotal_lbl.Size = new System.Drawing.Size(46, 13);
            this.Subtotal_lbl.TabIndex = 20;
            this.Subtotal_lbl.Text = "0000.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Subtotal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 344);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VentaProductos_listBox);
            this.Controls.Add(this.Recaudacion_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ventas_listBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Libreria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoPrecio_numericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarProducto_btn;
        private System.Windows.Forms.Button AgregarProducto_btn;
        private System.Windows.Forms.TextBox ProductoDescripcion_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductoCodigo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductoNombre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AgregarAlCarrito_btn;
        private System.Windows.Forms.ListBox Productos_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CancelarVenta_btn;
        private System.Windows.Forms.Button FinalizarVenta_btn;
        private System.Windows.Forms.Button QuitarDelCarrito_btn;
        private System.Windows.Forms.ListBox Carrito_listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Ventas_listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Recaudacion_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox VentaProductos_listBox;
        private System.Windows.Forms.NumericUpDown ProductoPrecio_numericUpDown;
        private System.Windows.Forms.Label Subtotal_lbl;
        private System.Windows.Forms.Label label11;
    }
}

