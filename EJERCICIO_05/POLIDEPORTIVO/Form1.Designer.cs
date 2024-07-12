namespace POLIDEPORTIVO
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
            this.Canchas_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantAlquileresCancha_lbl = new System.Windows.Forms.Label();
            this.recaudacionCancha_lbl = new System.Windows.Forms.Label();
            this.precioCancha_lbl = new System.Windows.Forms.Label();
            this.tipoCancha_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remuneracionJuez_lbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.partidosDirigidos_lbl = new System.Windows.Forms.Label();
            this.legajoJuez_lbl = new System.Windows.Forms.Label();
            this.apellidoJuez_lbl = new System.Windows.Forms.Label();
            this.nombreJuez_lbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Jueces_listBox = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.RegistrarJuez_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.horaFin_lbl = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.horaInicio_lbl = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.fechaAlquiler_lbl = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.segundoLinea_lbl = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.primerLinea_lbl = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.primerJuez_lbl = new System.Windows.Forms.Label();
            this.tipoAlquiler_lbl = new System.Windows.Forms.Label();
            this.totalAlquiler_lbl = new System.Windows.Forms.Label();
            this.tipoCanchaAlquiler_lbl = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.Alquileres_listBox = new System.Windows.Forms.ListBox();
            this.label29 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.VerRecaudacion_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canchas";
            // 
            // Canchas_listBox
            // 
            this.Canchas_listBox.FormattingEnabled = true;
            this.Canchas_listBox.Location = new System.Drawing.Point(15, 25);
            this.Canchas_listBox.Name = "Canchas_listBox";
            this.Canchas_listBox.Size = new System.Drawing.Size(135, 95);
            this.Canchas_listBox.TabIndex = 1;
            this.Canchas_listBox.SelectedIndexChanged += new System.EventHandler(this.Canchas_listBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cantAlquileresCancha_lbl);
            this.groupBox1.Controls.Add(this.recaudacionCancha_lbl);
            this.groupBox1.Controls.Add(this.precioCancha_lbl);
            this.groupBox1.Controls.Add(this.tipoCancha_lbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(156, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 136);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancha Info.";
            // 
            // cantAlquileresCancha_lbl
            // 
            this.cantAlquileresCancha_lbl.AutoSize = true;
            this.cantAlquileresCancha_lbl.Location = new System.Drawing.Point(97, 106);
            this.cantAlquileresCancha_lbl.Name = "cantAlquileresCancha_lbl";
            this.cantAlquileresCancha_lbl.Size = new System.Drawing.Size(79, 13);
            this.cantAlquileresCancha_lbl.TabIndex = 7;
            this.cantAlquileresCancha_lbl.Text = "vecesAlquilada";
            // 
            // recaudacionCancha_lbl
            // 
            this.recaudacionCancha_lbl.AutoSize = true;
            this.recaudacionCancha_lbl.Location = new System.Drawing.Point(100, 78);
            this.recaudacionCancha_lbl.Name = "recaudacionCancha_lbl";
            this.recaudacionCancha_lbl.Size = new System.Drawing.Size(83, 13);
            this.recaudacionCancha_lbl.TabIndex = 6;
            this.recaudacionCancha_lbl.Text = "totalRecaudado";
            // 
            // precioCancha_lbl
            // 
            this.precioCancha_lbl.AutoSize = true;
            this.precioCancha_lbl.Location = new System.Drawing.Point(87, 52);
            this.precioCancha_lbl.Name = "precioCancha_lbl";
            this.precioCancha_lbl.Size = new System.Drawing.Size(59, 13);
            this.precioCancha_lbl.TabIndex = 5;
            this.precioCancha_lbl.Text = "precioHora";
            // 
            // tipoCancha_lbl
            // 
            this.tipoCancha_lbl.AutoSize = true;
            this.tipoCancha_lbl.Location = new System.Drawing.Point(43, 26);
            this.tipoCancha_lbl.Name = "tipoCancha_lbl";
            this.tipoCancha_lbl.Size = new System.Drawing.Size(61, 13);
            this.tipoCancha_lbl.TabIndex = 4;
            this.tipoCancha_lbl.Text = "tipoCancha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Veces alquilada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total recaudado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio p/hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remuneracionJuez_lbl);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.partidosDirigidos_lbl);
            this.groupBox2.Controls.Add(this.legajoJuez_lbl);
            this.groupBox2.Controls.Add(this.apellidoJuez_lbl);
            this.groupBox2.Controls.Add(this.nombreJuez_lbl);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(564, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos juez";
            // 
            // remuneracionJuez_lbl
            // 
            this.remuneracionJuez_lbl.AutoSize = true;
            this.remuneracionJuez_lbl.Location = new System.Drawing.Point(146, 134);
            this.remuneracionJuez_lbl.Name = "remuneracionJuez_lbl";
            this.remuneracionJuez_lbl.Size = new System.Drawing.Size(66, 13);
            this.remuneracionJuez_lbl.TabIndex = 9;
            this.remuneracionJuez_lbl.Text = "cantPartidos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(134, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Remuneración acumulada:";
            // 
            // partidosDirigidos_lbl
            // 
            this.partidosDirigidos_lbl.AutoSize = true;
            this.partidosDirigidos_lbl.Location = new System.Drawing.Point(97, 106);
            this.partidosDirigidos_lbl.Name = "partidosDirigidos_lbl";
            this.partidosDirigidos_lbl.Size = new System.Drawing.Size(66, 13);
            this.partidosDirigidos_lbl.TabIndex = 7;
            this.partidosDirigidos_lbl.Text = "cantPartidos";
            // 
            // legajoJuez_lbl
            // 
            this.legajoJuez_lbl.AutoSize = true;
            this.legajoJuez_lbl.Location = new System.Drawing.Point(59, 78);
            this.legajoJuez_lbl.Name = "legajoJuez_lbl";
            this.legajoJuez_lbl.Size = new System.Drawing.Size(35, 13);
            this.legajoJuez_lbl.TabIndex = 6;
            this.legajoJuez_lbl.Text = "legajo";
            // 
            // apellidoJuez_lbl
            // 
            this.apellidoJuez_lbl.AutoSize = true;
            this.apellidoJuez_lbl.Location = new System.Drawing.Point(59, 52);
            this.apellidoJuez_lbl.Name = "apellidoJuez_lbl";
            this.apellidoJuez_lbl.Size = new System.Drawing.Size(43, 13);
            this.apellidoJuez_lbl.TabIndex = 5;
            this.apellidoJuez_lbl.Text = "apellido";
            // 
            // nombreJuez_lbl
            // 
            this.nombreJuez_lbl.AutoSize = true;
            this.nombreJuez_lbl.Location = new System.Drawing.Point(59, 26);
            this.nombreJuez_lbl.Name = "nombreJuez_lbl";
            this.nombreJuez_lbl.Size = new System.Drawing.Size(42, 13);
            this.nombreJuez_lbl.TabIndex = 4;
            this.nombreJuez_lbl.Text = "nombre";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Partidos dirigidos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Legajo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Apellido:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre:";
            // 
            // Jueces_listBox
            // 
            this.Jueces_listBox.FormattingEnabled = true;
            this.Jueces_listBox.Location = new System.Drawing.Point(423, 25);
            this.Jueces_listBox.Name = "Jueces_listBox";
            this.Jueces_listBox.Size = new System.Drawing.Size(135, 95);
            this.Jueces_listBox.TabIndex = 4;
            this.Jueces_listBox.SelectedIndexChanged += new System.EventHandler(this.Jueces_listBox_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(420, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Jueces";
            // 
            // RegistrarJuez_btn
            // 
            this.RegistrarJuez_btn.Location = new System.Drawing.Point(451, 126);
            this.RegistrarJuez_btn.Name = "RegistrarJuez_btn";
            this.RegistrarJuez_btn.Size = new System.Drawing.Size(81, 35);
            this.RegistrarJuez_btn.TabIndex = 6;
            this.RegistrarJuez_btn.Text = "Registrar nuevo juez";
            this.RegistrarJuez_btn.UseVisualStyleBackColor = true;
            this.RegistrarJuez_btn.Click += new System.EventHandler(this.RegistrarJuez_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.horaFin_lbl);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.horaInicio_lbl);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.fechaAlquiler_lbl);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.segundoLinea_lbl);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.primerLinea_lbl);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.primerJuez_lbl);
            this.groupBox3.Controls.Add(this.tipoAlquiler_lbl);
            this.groupBox3.Controls.Add(this.totalAlquiler_lbl);
            this.groupBox3.Controls.Add(this.tipoCanchaAlquiler_lbl);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Location = new System.Drawing.Point(246, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 150);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reserva Info.";
            // 
            // horaFin_lbl
            // 
            this.horaFin_lbl.AutoSize = true;
            this.horaFin_lbl.Location = new System.Drawing.Point(162, 126);
            this.horaFin_lbl.Name = "horaFin_lbl";
            this.horaFin_lbl.Size = new System.Drawing.Size(42, 13);
            this.horaFin_lbl.TabIndex = 17;
            this.horaFin_lbl.Text = "horaFin";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(116, 126);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 13);
            this.label39.TabIndex = 16;
            this.label39.Text = "Hasta:";
            // 
            // horaInicio_lbl
            // 
            this.horaInicio_lbl.AutoSize = true;
            this.horaInicio_lbl.Location = new System.Drawing.Point(53, 126);
            this.horaInicio_lbl.Name = "horaInicio_lbl";
            this.horaInicio_lbl.Size = new System.Drawing.Size(53, 13);
            this.horaInicio_lbl.TabIndex = 15;
            this.horaInicio_lbl.Text = "horaInicio";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(7, 126);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(24, 13);
            this.label37.TabIndex = 14;
            this.label37.Text = "De:";
            // 
            // fechaAlquiler_lbl
            // 
            this.fechaAlquiler_lbl.AutoSize = true;
            this.fechaAlquiler_lbl.Location = new System.Drawing.Point(53, 102);
            this.fechaAlquiler_lbl.Name = "fechaAlquiler_lbl";
            this.fechaAlquiler_lbl.Size = new System.Drawing.Size(34, 13);
            this.fechaAlquiler_lbl.TabIndex = 13;
            this.fechaAlquiler_lbl.Text = "fecha";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(7, 102);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(40, 13);
            this.label35.TabIndex = 12;
            this.label35.Text = "Fecha:";
            // 
            // segundoLinea_lbl
            // 
            this.segundoLinea_lbl.AutoSize = true;
            this.segundoLinea_lbl.Location = new System.Drawing.Point(227, 115);
            this.segundoLinea_lbl.Name = "segundoLinea_lbl";
            this.segundoLinea_lbl.Size = new System.Drawing.Size(74, 13);
            this.segundoLinea_lbl.TabIndex = 11;
            this.segundoLinea_lbl.Text = "segundoLinea";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(220, 102);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(114, 13);
            this.label33.TabIndex = 10;
            this.label33.Text = "Segundo juez de línea";
            // 
            // primerLinea_lbl
            // 
            this.primerLinea_lbl.AutoSize = true;
            this.primerLinea_lbl.Location = new System.Drawing.Point(227, 80);
            this.primerLinea_lbl.Name = "primerLinea_lbl";
            this.primerLinea_lbl.Size = new System.Drawing.Size(61, 13);
            this.primerLinea_lbl.TabIndex = 9;
            this.primerLinea_lbl.Text = "primerLinea";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(220, 67);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 8;
            this.label31.Text = "Primer juez de línea";
            // 
            // primerJuez_lbl
            // 
            this.primerJuez_lbl.AutoSize = true;
            this.primerJuez_lbl.Location = new System.Drawing.Point(227, 44);
            this.primerJuez_lbl.Name = "primerJuez_lbl";
            this.primerJuez_lbl.Size = new System.Drawing.Size(57, 13);
            this.primerJuez_lbl.TabIndex = 7;
            this.primerJuez_lbl.Text = "primerJuez";
            // 
            // tipoAlquiler_lbl
            // 
            this.tipoAlquiler_lbl.AutoSize = true;
            this.tipoAlquiler_lbl.Location = new System.Drawing.Point(96, 78);
            this.tipoAlquiler_lbl.Name = "tipoAlquiler_lbl";
            this.tipoAlquiler_lbl.Size = new System.Drawing.Size(83, 13);
            this.tipoAlquiler_lbl.TabIndex = 6;
            this.tipoAlquiler_lbl.Text = "totalRecaudado";
            // 
            // totalAlquiler_lbl
            // 
            this.totalAlquiler_lbl.AutoSize = true;
            this.totalAlquiler_lbl.Location = new System.Drawing.Point(46, 52);
            this.totalAlquiler_lbl.Name = "totalAlquiler_lbl";
            this.totalAlquiler_lbl.Size = new System.Drawing.Size(59, 13);
            this.totalAlquiler_lbl.TabIndex = 5;
            this.totalAlquiler_lbl.Text = "precioHora";
            // 
            // tipoCanchaAlquiler_lbl
            // 
            this.tipoCanchaAlquiler_lbl.AutoSize = true;
            this.tipoCanchaAlquiler_lbl.Location = new System.Drawing.Point(59, 26);
            this.tipoCanchaAlquiler_lbl.Name = "tipoCanchaAlquiler_lbl";
            this.tipoCanchaAlquiler_lbl.Size = new System.Drawing.Size(61, 13);
            this.tipoCanchaAlquiler_lbl.TabIndex = 4;
            this.tipoCanchaAlquiler_lbl.Text = "tipoCancha";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(220, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "Primer Juez";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 78);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Tipo de reserva:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 52);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(34, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Total:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(47, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Cancha:";
            // 
            // Alquileres_listBox
            // 
            this.Alquileres_listBox.FormattingEnabled = true;
            this.Alquileres_listBox.Location = new System.Drawing.Point(15, 201);
            this.Alquileres_listBox.Name = "Alquileres_listBox";
            this.Alquileres_listBox.Size = new System.Drawing.Size(222, 134);
            this.Alquileres_listBox.TabIndex = 8;
            this.Alquileres_listBox.SelectedIndexChanged += new System.EventHandler(this.Alquileres_listBox_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 185);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 13);
            this.label29.TabIndex = 7;
            this.label29.Text = "Reservas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nuevo Alquiler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VerRecaudacion_btn
            // 
            this.VerRecaudacion_btn.Location = new System.Drawing.Point(713, 257);
            this.VerRecaudacion_btn.Name = "VerRecaudacion_btn";
            this.VerRecaudacion_btn.Size = new System.Drawing.Size(81, 35);
            this.VerRecaudacion_btn.TabIndex = 11;
            this.VerRecaudacion_btn.Text = "Ver recaudación";
            this.VerRecaudacion_btn.UseVisualStyleBackColor = true;
            this.VerRecaudacion_btn.Click += new System.EventHandler(this.VerRecaudacion_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 356);
            this.Controls.Add(this.VerRecaudacion_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Alquileres_listBox);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.RegistrarJuez_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Jueces_listBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Canchas_listBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polideportivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Canchas_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cantAlquileresCancha_lbl;
        private System.Windows.Forms.Label recaudacionCancha_lbl;
        private System.Windows.Forms.Label precioCancha_lbl;
        private System.Windows.Forms.Label tipoCancha_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label partidosDirigidos_lbl;
        private System.Windows.Forms.Label legajoJuez_lbl;
        private System.Windows.Forms.Label apellidoJuez_lbl;
        private System.Windows.Forms.Label nombreJuez_lbl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox Jueces_listBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label remuneracionJuez_lbl;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button RegistrarJuez_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label primerJuez_lbl;
        private System.Windows.Forms.Label tipoAlquiler_lbl;
        private System.Windows.Forms.Label totalAlquiler_lbl;
        private System.Windows.Forms.Label tipoCanchaAlquiler_lbl;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ListBox Alquileres_listBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label horaInicio_lbl;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label fechaAlquiler_lbl;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label segundoLinea_lbl;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label primerLinea_lbl;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label horaFin_lbl;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VerRecaudacion_btn;
    }
}

