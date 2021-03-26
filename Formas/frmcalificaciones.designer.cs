namespace Escolar.Formas
{
    partial class frmcalificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalificaciones));
            this.dgcalificaciones = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcial3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtciclo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboxasignatura = new System.Windows.Forms.ComboBox();
            this.cboxturno = new System.Windows.Forms.ComboBox();
            this.cboxgrado = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcalificaciones
            // 
            this.dgcalificaciones.AllowUserToAddRows = false;
            this.dgcalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcalificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nombre,
            this.parcial1,
            this.faltas1,
            this.parcial2,
            this.faltas2,
            this.parcial3,
            this.faltas3,
            this.promedio});
            this.dgcalificaciones.Location = new System.Drawing.Point(9, 143);
            this.dgcalificaciones.Name = "dgcalificaciones";
            this.dgcalificaciones.Size = new System.Drawing.Size(917, 223);
            this.dgcalificaciones.TabIndex = 81;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "ev_matricula";
            this.matricula.FillWeight = 22.84262F;
            this.matricula.HeaderText = "MATRICULA";
            this.matricula.Name = "matricula";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "ev_al";
            this.nombre.FillWeight = 717.259F;
            this.nombre.HeaderText = "NOMBRE COMPLETO";
            this.nombre.Name = "nombre";
            this.nombre.Width = 300;
            // 
            // parcial1
            // 
            this.parcial1.DataPropertyName = "ev_trim1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcial1.DefaultCellStyle = dataGridViewCellStyle1;
            this.parcial1.FillWeight = 22.84262F;
            this.parcial1.HeaderText = "PARCIAL 1";
            this.parcial1.Name = "parcial1";
            this.parcial1.Width = 70;
            // 
            // faltas1
            // 
            this.faltas1.DataPropertyName = "ev_faltas1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.faltas1.DefaultCellStyle = dataGridViewCellStyle2;
            this.faltas1.FillWeight = 22.84262F;
            this.faltas1.HeaderText = "FALTAS P1";
            this.faltas1.Name = "faltas1";
            this.faltas1.Width = 65;
            // 
            // parcial2
            // 
            this.parcial2.DataPropertyName = "ev_trim2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcial2.DefaultCellStyle = dataGridViewCellStyle3;
            this.parcial2.FillWeight = 22.84262F;
            this.parcial2.HeaderText = "PARCIAL 2";
            this.parcial2.Name = "parcial2";
            this.parcial2.Width = 70;
            // 
            // faltas2
            // 
            this.faltas2.DataPropertyName = "ev_faltas2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.faltas2.DefaultCellStyle = dataGridViewCellStyle4;
            this.faltas2.FillWeight = 22.84262F;
            this.faltas2.HeaderText = "FALTAS P2";
            this.faltas2.Name = "faltas2";
            this.faltas2.Width = 65;
            // 
            // parcial3
            // 
            this.parcial3.DataPropertyName = "ev_trim3";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.parcial3.DefaultCellStyle = dataGridViewCellStyle5;
            this.parcial3.FillWeight = 22.84262F;
            this.parcial3.HeaderText = "PARCIAL 3";
            this.parcial3.Name = "parcial3";
            this.parcial3.Width = 70;
            // 
            // faltas3
            // 
            this.faltas3.DataPropertyName = "ev_faltas3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.faltas3.DefaultCellStyle = dataGridViewCellStyle6;
            this.faltas3.FillWeight = 22.84262F;
            this.faltas3.HeaderText = "FALTAS P3";
            this.faltas3.Name = "faltas3";
            this.faltas3.Width = 65;
            // 
            // promedio
            // 
            this.promedio.DataPropertyName = "ev_promediofinal";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.promedio.DefaultCellStyle = dataGridViewCellStyle7;
            this.promedio.FillWeight = 22.84262F;
            this.promedio.HeaderText = "PROMEDIO";
            this.promedio.Name = "promedio";
            this.promedio.Width = 70;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(302, 428);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 55);
            this.button4.TabIndex = 66;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(523, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 67;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Grado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Ciclo";
            // 
            // txtciclo
            // 
            this.txtciclo.Enabled = false;
            this.txtciclo.Location = new System.Drawing.Point(588, 12);
            this.txtciclo.Name = "txtciclo";
            this.txtciclo.Size = new System.Drawing.Size(182, 20);
            this.txtciclo.TabIndex = 75;
            this.txtciclo.Text = "2020-2021";
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(324, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(65, 20);
            this.textBox3.TabIndex = 76;
            // 
            // cboxasignatura
            // 
            this.cboxasignatura.Enabled = false;
            this.cboxasignatura.FormattingEnabled = true;
            this.cboxasignatura.Location = new System.Drawing.Point(183, 59);
            this.cboxasignatura.Name = "cboxasignatura";
            this.cboxasignatura.Size = new System.Drawing.Size(251, 21);
            this.cboxasignatura.TabIndex = 77;
            // 
            // cboxturno
            // 
            this.cboxturno.FormattingEnabled = true;
            this.cboxturno.Location = new System.Drawing.Point(448, 12);
            this.cboxturno.Name = "cboxturno";
            this.cboxturno.Size = new System.Drawing.Size(86, 21);
            this.cboxturno.TabIndex = 78;
            // 
            // cboxgrado
            // 
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(179, 9);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(89, 21);
            this.cboxgrado.TabIndex = 79;
            this.cboxgrado.SelectedIndexChanged += new System.EventHandler(this.cboxgrado_SelectedIndexChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(376, 106);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 31);
            this.btnbuscar.TabIndex = 84;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(401, 428);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 55);
            this.btnlimpiar.TabIndex = 85;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // frmcalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgcalificaciones);
            this.Controls.Add(this.cboxgrado);
            this.Controls.Add(this.cboxturno);
            this.Controls.Add(this.cboxasignatura);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtciclo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcalificaciones";
            this.Text = "Calificaciones";
            this.Load += new System.EventHandler(this.frmevaluaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtciclo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cboxasignatura;
        private System.Windows.Forms.ComboBox cboxturno;
        private System.Windows.Forms.ComboBox cboxgrado;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.DataGridView dgcalificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcial3;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas3;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedio;
        private System.Windows.Forms.Button btnlimpiar;
    }
}