
namespace MaquinaTuringPrototipo
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlfabeto = new System.Windows.Forms.Button();
            this.lblAlfabeto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarSimbolo = new System.Windows.Forms.Button();
            this.txtSimbolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVacioCadena = new System.Windows.Forms.Button();
            this.btnEliminarCadena = new System.Windows.Forms.Button();
            this.btnAgregarCadena = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPosicionInicial = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEscribirMemoria = new System.Windows.Forms.Button();
            this.btnOperacionEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelta = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDecisionEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numDestino = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDecision = new System.Windows.Forms.Button();
            this.chkNegacionDec = new System.Windows.Forms.CheckBox();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.txtSimboloReescribir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkNegacionOp = new System.Windows.Forms.CheckBox();
            this.txtSimboloBusqueda = new System.Windows.Forms.TextBox();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnEjecutarPasos = new System.Windows.Forms.Button();
            this.btnReiniciarOperaciones = new System.Windows.Forms.Button();
            this.btnReiniciarCadena = new System.Windows.Forms.Button();
            this.btnReiniciarMaquina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(210, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(578, 56);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarAlfabeto);
            this.groupBox1.Controls.Add(this.lblAlfabeto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAgregarSimbolo);
            this.groupBox1.Controls.Add(this.txtSimbolo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alfabeto";
            // 
            // btnEliminarAlfabeto
            // 
            this.btnEliminarAlfabeto.Location = new System.Drawing.Point(6, 122);
            this.btnEliminarAlfabeto.Name = "btnEliminarAlfabeto";
            this.btnEliminarAlfabeto.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarAlfabeto.TabIndex = 5;
            this.btnEliminarAlfabeto.Text = "Eliminar ultimo simbolo";
            this.btnEliminarAlfabeto.UseVisualStyleBackColor = true;
            this.btnEliminarAlfabeto.Click += new System.EventHandler(this.btnEliminarAlfabeto_Click);
            // 
            // lblAlfabeto
            // 
            this.lblAlfabeto.AutoSize = true;
            this.lblAlfabeto.Location = new System.Drawing.Point(6, 95);
            this.lblAlfabeto.Name = "lblAlfabeto";
            this.lblAlfabeto.Size = new System.Drawing.Size(0, 13);
            this.lblAlfabeto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Simbolos del alfabeto:";
            // 
            // btnAgregarSimbolo
            // 
            this.btnAgregarSimbolo.Location = new System.Drawing.Point(105, 26);
            this.btnAgregarSimbolo.Name = "btnAgregarSimbolo";
            this.btnAgregarSimbolo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSimbolo.TabIndex = 2;
            this.btnAgregarSimbolo.Text = "Agregar";
            this.btnAgregarSimbolo.UseVisualStyleBackColor = true;
            this.btnAgregarSimbolo.Click += new System.EventHandler(this.btnAgregarSimbolo_Click);
            // 
            // txtSimbolo
            // 
            this.txtSimbolo.Location = new System.Drawing.Point(60, 28);
            this.txtSimbolo.Name = "txtSimbolo";
            this.txtSimbolo.Size = new System.Drawing.Size(39, 20);
            this.txtSimbolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simbolo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVacioCadena);
            this.groupBox2.Controls.Add(this.btnEliminarCadena);
            this.groupBox2.Controls.Add(this.btnAgregarCadena);
            this.groupBox2.Controls.Add(this.txtCadena);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(211, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 108);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadena";
            // 
            // btnVacioCadena
            // 
            this.btnVacioCadena.Location = new System.Drawing.Point(12, 50);
            this.btnVacioCadena.Name = "btnVacioCadena";
            this.btnVacioCadena.Size = new System.Drawing.Size(105, 23);
            this.btnVacioCadena.TabIndex = 9;
            this.btnVacioCadena.Text = "Agregar Vacio";
            this.btnVacioCadena.UseVisualStyleBackColor = true;
            this.btnVacioCadena.Click += new System.EventHandler(this.btnVacioCadena_Click);
            // 
            // btnEliminarCadena
            // 
            this.btnEliminarCadena.Location = new System.Drawing.Point(12, 79);
            this.btnEliminarCadena.Name = "btnEliminarCadena";
            this.btnEliminarCadena.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarCadena.TabIndex = 6;
            this.btnEliminarCadena.Text = "Eliminar ultimo simbolo";
            this.btnEliminarCadena.UseVisualStyleBackColor = true;
            this.btnEliminarCadena.Click += new System.EventHandler(this.btnEliminarCadena_Click);
            // 
            // btnAgregarCadena
            // 
            this.btnAgregarCadena.Location = new System.Drawing.Point(107, 19);
            this.btnAgregarCadena.Name = "btnAgregarCadena";
            this.btnAgregarCadena.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCadena.TabIndex = 8;
            this.btnAgregarCadena.Text = "Agregar";
            this.btnAgregarCadena.UseVisualStyleBackColor = true;
            this.btnAgregarCadena.Click += new System.EventHandler(this.btnAgregarCadena_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(62, 22);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(39, 20);
            this.txtCadena.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Simbolo:";
            // 
            // btnPosicionInicial
            // 
            this.btnPosicionInicial.Location = new System.Drawing.Point(413, 79);
            this.btnPosicionInicial.Name = "btnPosicionInicial";
            this.btnPosicionInicial.Size = new System.Drawing.Size(103, 39);
            this.btnPosicionInicial.TabIndex = 10;
            this.btnPosicionInicial.Text = "Guardar Posicion Inicial";
            this.btnPosicionInicial.UseVisualStyleBackColor = true;
            this.btnPosicionInicial.Click += new System.EventHandler(this.btnPosicionInicial_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEscribirMemoria);
            this.groupBox3.Controls.Add(this.btnOperacionEliminar);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnDelta);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnOperacion);
            this.groupBox3.Controls.Add(this.txtSimboloReescribir);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chkNegacionOp);
            this.groupBox3.Controls.Add(this.txtSimboloBusqueda);
            this.groupBox3.Controls.Add(this.cboOperacion);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(13, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 248);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones";
            // 
            // btnEscribirMemoria
            // 
            this.btnEscribirMemoria.Location = new System.Drawing.Point(183, 155);
            this.btnEscribirMemoria.Name = "btnEscribirMemoria";
            this.btnEscribirMemoria.Size = new System.Drawing.Size(28, 23);
            this.btnEscribirMemoria.TabIndex = 22;
            this.btnEscribirMemoria.Text = "σ";
            this.btnEscribirMemoria.UseVisualStyleBackColor = true;
            this.btnEscribirMemoria.Click += new System.EventHandler(this.btnEscribirMemoria_Click);
            // 
            // btnOperacionEliminar
            // 
            this.btnOperacionEliminar.Location = new System.Drawing.Point(147, 200);
            this.btnOperacionEliminar.Name = "btnOperacionEliminar";
            this.btnOperacionEliminar.Size = new System.Drawing.Size(107, 42);
            this.btnOperacionEliminar.TabIndex = 21;
            this.btnOperacionEliminar.Text = "Eliminar ultima operacion";
            this.btnOperacionEliminar.UseVisualStyleBackColor = true;
            this.btnOperacionEliminar.Click += new System.EventHandler(this.btnOperacionEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Δ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelta
            // 
            this.btnDelta.Location = new System.Drawing.Point(149, 156);
            this.btnDelta.Name = "btnDelta";
            this.btnDelta.Size = new System.Drawing.Size(28, 23);
            this.btnDelta.TabIndex = 10;
            this.btnDelta.Text = "Δ";
            this.btnDelta.UseVisualStyleBackColor = true;
            this.btnDelta.Click += new System.EventHandler(this.btnDelta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDecisionEliminar);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.numDestino);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnDecision);
            this.groupBox4.Controls.Add(this.chkNegacionDec);
            this.groupBox4.Controls.Add(this.txtDecision);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(261, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 146);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decisiones";
            // 
            // btnDecisionEliminar
            // 
            this.btnDecisionEliminar.Location = new System.Drawing.Point(132, 104);
            this.btnDecisionEliminar.Name = "btnDecisionEliminar";
            this.btnDecisionEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnDecisionEliminar.TabIndex = 22;
            this.btnDecisionEliminar.Text = "Eliminar decision";
            this.btnDecisionEliminar.UseVisualStyleBackColor = true;
            this.btnDecisionEliminar.Click += new System.EventHandler(this.btnDecisionEliminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Δ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(232, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 121);
            this.listBox1.TabIndex = 25;
            // 
            // numDestino
            // 
            this.numDestino.Location = new System.Drawing.Point(107, 52);
            this.numDestino.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDestino.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDestino.Name = "numDestino";
            this.numDestino.Size = new System.Drawing.Size(49, 20);
            this.numDestino.TabIndex = 24;
            this.numDestino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Operacion destino:";
            // 
            // btnDecision
            // 
            this.btnDecision.Location = new System.Drawing.Point(14, 104);
            this.btnDecision.Name = "btnDecision";
            this.btnDecision.Size = new System.Drawing.Size(107, 29);
            this.btnDecision.TabIndex = 20;
            this.btnDecision.Text = "Agregar decision";
            this.btnDecision.UseVisualStyleBackColor = true;
            this.btnDecision.Click += new System.EventHandler(this.btnDecision_Click);
            // 
            // chkNegacionDec
            // 
            this.chkNegacionDec.AutoSize = true;
            this.chkNegacionDec.Location = new System.Drawing.Point(13, 76);
            this.chkNegacionDec.Name = "chkNegacionDec";
            this.chkNegacionDec.Size = new System.Drawing.Size(72, 17);
            this.chkNegacionDec.TabIndex = 22;
            this.chkNegacionDec.Text = "Negacion";
            this.chkNegacionDec.UseVisualStyleBackColor = true;
            // 
            // txtDecision
            // 
            this.txtDecision.Location = new System.Drawing.Point(107, 25);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.Size = new System.Drawing.Size(39, 20);
            this.txtDecision.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Simbolo a buscar:";
            // 
            // btnOperacion
            // 
            this.btnOperacion.Location = new System.Drawing.Point(6, 200);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(107, 29);
            this.btnOperacion.TabIndex = 18;
            this.btnOperacion.Text = "Agregar operacion";
            this.btnOperacion.UseVisualStyleBackColor = true;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // txtSimboloReescribir
            // 
            this.txtSimboloReescribir.Location = new System.Drawing.Point(103, 158);
            this.txtSimboloReescribir.Name = "txtSimboloReescribir";
            this.txtSimboloReescribir.Size = new System.Drawing.Size(39, 20);
            this.txtSimboloReescribir.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Simbolo a escribir:";
            // 
            // chkNegacionOp
            // 
            this.chkNegacionOp.AutoSize = true;
            this.chkNegacionOp.Location = new System.Drawing.Point(183, 124);
            this.chkNegacionOp.Name = "chkNegacionOp";
            this.chkNegacionOp.Size = new System.Drawing.Size(72, 17);
            this.chkNegacionOp.TabIndex = 15;
            this.chkNegacionOp.Text = "Negacion";
            this.chkNegacionOp.UseVisualStyleBackColor = true;
            // 
            // txtSimboloBusqueda
            // 
            this.txtSimboloBusqueda.Location = new System.Drawing.Point(103, 121);
            this.txtSimboloBusqueda.Name = "txtSimboloBusqueda";
            this.txtSimboloBusqueda.Size = new System.Drawing.Size(39, 20);
            this.txtSimboloBusqueda.TabIndex = 7;
            // 
            // cboOperacion
            // 
            this.cboOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "Derecha",
            "Izquierda",
            "Busqueda a derecha",
            "Busqueda a izquierda",
            "Escrbir",
            "Guardar",
            "N"});
            this.cboOperacion.Location = new System.Drawing.Point(6, 96);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(171, 21);
            this.cboOperacion.TabIndex = 14;
            this.cboOperacion.SelectedIndexChanged += new System.EventHandler(this.cboOperacion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Simbolo a buscar:";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(9, 19);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(647, 71);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // btnEjecutarPasos
            // 
            this.btnEjecutarPasos.Location = new System.Drawing.Point(681, 403);
            this.btnEjecutarPasos.Name = "btnEjecutarPasos";
            this.btnEjecutarPasos.Size = new System.Drawing.Size(107, 29);
            this.btnEjecutarPasos.TabIndex = 23;
            this.btnEjecutarPasos.Text = "Ejecutar por pasos";
            this.btnEjecutarPasos.UseVisualStyleBackColor = true;
            this.btnEjecutarPasos.Click += new System.EventHandler(this.btnEjecutarPasos_Click);
            // 
            // btnReiniciarOperaciones
            // 
            this.btnReiniciarOperaciones.Location = new System.Drawing.Point(685, 209);
            this.btnReiniciarOperaciones.Name = "btnReiniciarOperaciones";
            this.btnReiniciarOperaciones.Size = new System.Drawing.Size(103, 39);
            this.btnReiniciarOperaciones.TabIndex = 24;
            this.btnReiniciarOperaciones.Text = "Reiniciar operaciones";
            this.btnReiniciarOperaciones.UseVisualStyleBackColor = true;
            this.btnReiniciarOperaciones.Click += new System.EventHandler(this.btnReiniciarOperaciones_Click);
            // 
            // btnReiniciarCadena
            // 
            this.btnReiniciarCadena.Location = new System.Drawing.Point(685, 79);
            this.btnReiniciarCadena.Name = "btnReiniciarCadena";
            this.btnReiniciarCadena.Size = new System.Drawing.Size(103, 39);
            this.btnReiniciarCadena.TabIndex = 25;
            this.btnReiniciarCadena.Text = "Reiniciar posicion";
            this.btnReiniciarCadena.UseVisualStyleBackColor = true;
            this.btnReiniciarCadena.Click += new System.EventHandler(this.btnReiniciarCadena_Click);
            // 
            // btnReiniciarMaquina
            // 
            this.btnReiniciarMaquina.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReiniciarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciarMaquina.Location = new System.Drawing.Point(685, 298);
            this.btnReiniciarMaquina.Name = "btnReiniciarMaquina";
            this.btnReiniciarMaquina.Size = new System.Drawing.Size(103, 39);
            this.btnReiniciarMaquina.TabIndex = 26;
            this.btnReiniciarMaquina.Text = "Reiniciar Maquina";
            this.btnReiniciarMaquina.UseVisualStyleBackColor = false;
            this.btnReiniciarMaquina.Click += new System.EventHandler(this.btnReiniciarMaquina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReiniciarMaquina);
            this.Controls.Add(this.btnReiniciarCadena);
            this.Controls.Add(this.btnReiniciarOperaciones);
            this.Controls.Add(this.btnEjecutarPasos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPosicionInicial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Simulador Maquina Turing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDestino)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlfabeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarSimbolo;
        private System.Windows.Forms.TextBox txtSimbolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarAlfabeto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarCadena;
        private System.Windows.Forms.Button btnAgregarCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVacioCadena;
        private System.Windows.Forms.Button btnPosicionInicial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox txtSimboloBusqueda;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDecision;
        private System.Windows.Forms.CheckBox chkNegacionDec;
        private System.Windows.Forms.TextBox txtDecision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.TextBox txtSimboloReescribir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkNegacionOp;
        private System.Windows.Forms.Button btnEjecutarPasos;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOperacionEliminar;
        private System.Windows.Forms.Button btnDecisionEliminar;
        private System.Windows.Forms.Button btnReiniciarOperaciones;
        private System.Windows.Forms.Button btnReiniciarCadena;
        private System.Windows.Forms.Button btnEscribirMemoria;
        private System.Windows.Forms.Button btnReiniciarMaquina;
    }
}

