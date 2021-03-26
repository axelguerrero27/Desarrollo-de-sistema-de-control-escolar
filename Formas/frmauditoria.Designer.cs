namespace Escolar.Formas
{
    partial class frmauditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmauditoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpboxcambiar = new System.Windows.Forms.GroupBox();
            this.btncambiar = new System.Windows.Forms.Button();
            this.txtrepetir = new System.Windows.Forms.TextBox();
            this.lblrepetir = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.pboxfoto = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxnivel = new System.Windows.Forms.ComboBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.txtncompleto = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblnombrecompleto = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneliminarregistro = new System.Windows.Forms.Button();
            this.cboxuser = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dgauditoria = new System.Windows.Forms.DataGridView();
            this.lblusuario = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbtnusuario = new System.Windows.Forms.RadioButton();
            this.rdbtntodos = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdbtnpantalla = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbtnusuarios = new System.Windows.Forms.RadioButton();
            this.cboxuse = new System.Windows.Forms.ComboBox();
            this.rdbtntodo = new System.Windows.Forms.RadioButton();
            this.btnsalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpboxcambiar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxfoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgauditoria)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 362);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gpboxcambiar);
            this.tabPage1.Controls.Add(this.pboxfoto);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro de usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gpboxcambiar
            // 
            this.gpboxcambiar.Controls.Add(this.btncambiar);
            this.gpboxcambiar.Controls.Add(this.txtrepetir);
            this.gpboxcambiar.Controls.Add(this.lblrepetir);
            this.gpboxcambiar.Controls.Add(this.txtpassword);
            this.gpboxcambiar.Controls.Add(this.lblpassword);
            this.gpboxcambiar.Location = new System.Drawing.Point(44, 172);
            this.gpboxcambiar.Name = "gpboxcambiar";
            this.gpboxcambiar.Size = new System.Drawing.Size(606, 74);
            this.gpboxcambiar.TabIndex = 40;
            this.gpboxcambiar.TabStop = false;
            this.gpboxcambiar.Text = "Cambiar contraseña";
            this.gpboxcambiar.Visible = false;
            // 
            // btncambiar
            // 
            this.btncambiar.Enabled = false;
            this.btncambiar.Location = new System.Drawing.Point(469, 12);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 47);
            this.btncambiar.TabIndex = 13;
            this.btncambiar.Text = "Cambiar contraseña";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // txtrepetir
            // 
            this.txtrepetir.Enabled = false;
            this.txtrepetir.Location = new System.Drawing.Point(308, 26);
            this.txtrepetir.Name = "txtrepetir";
            this.txtrepetir.PasswordChar = '*';
            this.txtrepetir.Size = new System.Drawing.Size(101, 20);
            this.txtrepetir.TabIndex = 12;
            this.txtrepetir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrepetir_KeyPress);
            // 
            // lblrepetir
            // 
            this.lblrepetir.AutoSize = true;
            this.lblrepetir.Location = new System.Drawing.Point(205, 29);
            this.lblrepetir.Name = "lblrepetir";
            this.lblrepetir.Size = new System.Drawing.Size(97, 13);
            this.lblrepetir.TabIndex = 11;
            this.lblrepetir.Text = "Repetir contraseña";
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(79, 29);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(101, 20);
            this.txtpassword.TabIndex = 10;
            this.txtpassword.Click += new System.EventHandler(this.txtpassword_Click);
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(12, 29);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(61, 13);
            this.lblpassword.TabIndex = 9;
            this.lblpassword.Text = "Contraseña";
            // 
            // pboxfoto
            // 
            this.pboxfoto.Image = ((System.Drawing.Image)(resources.GetObject("pboxfoto.Image")));
            this.pboxfoto.Location = new System.Drawing.Point(31, 23);
            this.pboxfoto.Name = "pboxfoto";
            this.pboxfoto.Size = new System.Drawing.Size(115, 130);
            this.pboxfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxfoto.TabIndex = 11;
            this.pboxfoto.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(269, 255);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 37);
            this.btnguardar.TabIndex = 39;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(378, 255);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 37);
            this.btneliminar.TabIndex = 38;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxnivel);
            this.groupBox1.Controls.Add(this.lblnivel);
            this.groupBox1.Controls.Add(this.txtncompleto);
            this.groupBox1.Controls.Add(this.txtcontraseña);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.lblnombrecompleto);
            this.groupBox1.Controls.Add(this.lblcontraseña);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(174, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cboxnivel
            // 
            this.cboxnivel.Enabled = false;
            this.cboxnivel.FormattingEnabled = true;
            this.cboxnivel.Location = new System.Drawing.Point(86, 122);
            this.cboxnivel.Name = "cboxnivel";
            this.cboxnivel.Size = new System.Drawing.Size(121, 21);
            this.cboxnivel.TabIndex = 10;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Enabled = false;
            this.lblnivel.Location = new System.Drawing.Point(39, 125);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(31, 13);
            this.lblnivel.TabIndex = 9;
            this.lblnivel.Text = "Nivel";
            // 
            // txtncompleto
            // 
            this.txtncompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtncompleto.Enabled = false;
            this.txtncompleto.Location = new System.Drawing.Point(114, 87);
            this.txtncompleto.Name = "txtncompleto";
            this.txtncompleto.Size = new System.Drawing.Size(312, 20);
            this.txtncompleto.TabIndex = 6;
            this.txtncompleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtncompleto_KeyDown);
            this.txtncompleto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtncompleto_KeyUp);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Enabled = false;
            this.txtcontraseña.Location = new System.Drawing.Point(96, 52);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(101, 20);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            this.txtcontraseña.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcontraseña_KeyUp);
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(94, 19);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(89, 20);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblnombrecompleto
            // 
            this.lblnombrecompleto.AutoSize = true;
            this.lblnombrecompleto.Enabled = false;
            this.lblnombrecompleto.Location = new System.Drawing.Point(18, 90);
            this.lblnombrecompleto.Name = "lblnombrecompleto";
            this.lblnombrecompleto.Size = new System.Drawing.Size(90, 13);
            this.lblnombrecompleto.TabIndex = 3;
            this.lblnombrecompleto.Text = "Nombre completo";
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Enabled = false;
            this.lblcontraseña.Location = new System.Drawing.Point(29, 52);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(61, 13);
            this.lblcontraseña.TabIndex = 2;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminarregistro);
            this.tabPage2.Controls.Add(this.cboxuser);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.btnlimpiar);
            this.tabPage2.Controls.Add(this.dgauditoria);
            this.tabPage2.Controls.Add(this.lblusuario);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depuracion de movimintos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneliminarregistro
            // 
            this.btneliminarregistro.Enabled = false;
            this.btneliminarregistro.Image = ((System.Drawing.Image)(resources.GetObject("btneliminarregistro.Image")));
            this.btneliminarregistro.Location = new System.Drawing.Point(329, 266);
            this.btneliminarregistro.Name = "btneliminarregistro";
            this.btneliminarregistro.Size = new System.Drawing.Size(75, 61);
            this.btneliminarregistro.TabIndex = 39;
            this.btneliminarregistro.UseVisualStyleBackColor = true;
            this.btneliminarregistro.Click += new System.EventHandler(this.btneliminarregistro_Click);
            // 
            // cboxuser
            // 
            this.cboxuser.FormattingEnabled = true;
            this.cboxuser.Location = new System.Drawing.Point(361, 80);
            this.cboxuser.Name = "cboxuser";
            this.cboxuser.Size = new System.Drawing.Size(121, 21);
            this.cboxuser.TabIndex = 10;
            this.cboxuser.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(220, 266);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 61);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(431, 266);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 61);
            this.btnlimpiar.TabIndex = 8;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // dgauditoria
            // 
            this.dgauditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgauditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgauditoria.Location = new System.Drawing.Point(32, 119);
            this.dgauditoria.Name = "dgauditoria";
            this.dgauditoria.Size = new System.Drawing.Size(656, 141);
            this.dgauditoria.TabIndex = 7;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(312, 85);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 5;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha inicial";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbtnusuario);
            this.groupBox3.Controls.Add(this.rdbtntodos);
            this.groupBox3.Location = new System.Drawing.Point(32, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // rdbtnusuario
            // 
            this.rdbtnusuario.AutoSize = true;
            this.rdbtnusuario.Location = new System.Drawing.Point(6, 67);
            this.rdbtnusuario.Name = "rdbtnusuario";
            this.rdbtnusuario.Size = new System.Drawing.Size(61, 17);
            this.rdbtnusuario.TabIndex = 2;
            this.rdbtnusuario.TabStop = true;
            this.rdbtnusuario.Text = "Usuario";
            this.rdbtnusuario.UseVisualStyleBackColor = true;
            this.rdbtnusuario.CheckedChanged += new System.EventHandler(this.rdbtnusuario_CheckedChanged);
            // 
            // rdbtntodos
            // 
            this.rdbtntodos.AutoSize = true;
            this.rdbtntodos.Location = new System.Drawing.Point(6, 30);
            this.rdbtntodos.Name = "rdbtntodos";
            this.rdbtntodos.Size = new System.Drawing.Size(55, 17);
            this.rdbtntodos.TabIndex = 1;
            this.rdbtntodos.TabStop = true;
            this.rdbtntodos.Text = "Todos";
            this.rdbtntodos.UseVisualStyleBackColor = true;
            this.rdbtntodos.CheckedChanged += new System.EventHandler(this.rdbtntodos_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnimprimir);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 336);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reporte de auditoria";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(241, 211);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 43);
            this.btnimprimir.TabIndex = 80;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fecha2);
            this.groupBox6.Controls.Add(this.fecha1);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(396, 38);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 100);
            this.groupBox6.TabIndex = 75;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Periodo";
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(43, 54);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(221, 20);
            this.fecha2.TabIndex = 8;
            this.fecha2.ValueChanged += new System.EventHandler(this.hasta_ValueChanged);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(43, 28);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(221, 20);
            this.fecha1.TabIndex = 7;
            this.fecha1.ValueChanged += new System.EventHandler(this.de_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Al:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Del:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton6);
            this.groupBox5.Controls.Add(this.rdbtnpantalla);
            this.groupBox5.Location = new System.Drawing.Point(255, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 87);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salida por:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(14, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(71, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "Impresora";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // rdbtnpantalla
            // 
            this.rdbtnpantalla.AutoSize = true;
            this.rdbtnpantalla.Checked = true;
            this.rdbtnpantalla.Location = new System.Drawing.Point(14, 33);
            this.rdbtnpantalla.Name = "rdbtnpantalla";
            this.rdbtnpantalla.Size = new System.Drawing.Size(63, 17);
            this.rdbtnpantalla.TabIndex = 0;
            this.rdbtnpantalla.TabStop = true;
            this.rdbtnpantalla.Text = "Pantalla";
            this.rdbtnpantalla.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbtnusuarios);
            this.groupBox4.Controls.Add(this.cboxuse);
            this.groupBox4.Controls.Add(this.rdbtntodo);
            this.groupBox4.Location = new System.Drawing.Point(30, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 87);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informe";
            // 
            // rdbtnusuarios
            // 
            this.rdbtnusuarios.AutoSize = true;
            this.rdbtnusuarios.Location = new System.Drawing.Point(15, 56);
            this.rdbtnusuarios.Name = "rdbtnusuarios";
            this.rdbtnusuarios.Size = new System.Drawing.Size(61, 17);
            this.rdbtnusuarios.TabIndex = 4;
            this.rdbtnusuarios.TabStop = true;
            this.rdbtnusuarios.Text = "Usuario";
            this.rdbtnusuarios.UseVisualStyleBackColor = true;
            this.rdbtnusuarios.CheckedChanged += new System.EventHandler(this.rdbtnusuarios_CheckedChanged);
            // 
            // cboxuse
            // 
            this.cboxuse.FormattingEnabled = true;
            this.cboxuse.Location = new System.Drawing.Point(84, 54);
            this.cboxuse.Name = "cboxuse";
            this.cboxuse.Size = new System.Drawing.Size(121, 21);
            this.cboxuse.TabIndex = 79;
            this.cboxuse.Visible = false;
            // 
            // rdbtntodo
            // 
            this.rdbtntodo.AutoSize = true;
            this.rdbtntodo.Location = new System.Drawing.Point(15, 19);
            this.rdbtntodo.Name = "rdbtntodo";
            this.rdbtntodo.Size = new System.Drawing.Size(55, 17);
            this.rdbtntodo.TabIndex = 3;
            this.rdbtntodo.TabStop = true;
            this.rdbtntodo.Text = "Todos";
            this.rdbtntodo.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(445, 380);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 37;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmauditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnsalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmauditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmauditoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gpboxcambiar.ResumeLayout(false);
            this.gpboxcambiar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxfoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgauditoria)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtncompleto;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblnombrecompleto;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbtnusuario;
        private System.Windows.Forms.RadioButton rdbtntodos;
        private System.Windows.Forms.DataGridView dgauditoria;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbtnusuarios;
        private System.Windows.Forms.RadioButton rdbtntodo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdbtnpantalla;
        private System.Windows.Forms.PictureBox pboxfoto;
        private System.Windows.Forms.ComboBox cboxnivel;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.GroupBox gpboxcambiar;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.TextBox txtrepetir;
        private System.Windows.Forms.Label lblrepetir;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.ComboBox cboxuser;
        private System.Windows.Forms.Button btneliminarregistro;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.ComboBox cboxuse;
    }
}