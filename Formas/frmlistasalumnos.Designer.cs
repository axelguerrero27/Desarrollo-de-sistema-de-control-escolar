namespace Escolar.Formas
{
    partial class frmlistasalumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlistasalumnos));
            this.gpboxseleccione = new System.Windows.Forms.GroupBox();
            this.cboxgrado = new System.Windows.Forms.ComboBox();
            this.rdbtngrado = new System.Windows.Forms.RadioButton();
            this.rdbtntodos = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdbtnpantalla = new System.Windows.Forms.RadioButton();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cboxmateria = new System.Windows.Forms.ComboBox();
            this.rdbtnmateria = new System.Windows.Forms.RadioButton();
            this.gpboxseleccione.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxseleccione
            // 
            this.gpboxseleccione.Controls.Add(this.cboxmateria);
            this.gpboxseleccione.Controls.Add(this.rdbtnmateria);
            this.gpboxseleccione.Controls.Add(this.cboxgrado);
            this.gpboxseleccione.Controls.Add(this.rdbtngrado);
            this.gpboxseleccione.Controls.Add(this.rdbtntodos);
            this.gpboxseleccione.Location = new System.Drawing.Point(54, 54);
            this.gpboxseleccione.Name = "gpboxseleccione";
            this.gpboxseleccione.Size = new System.Drawing.Size(200, 165);
            this.gpboxseleccione.TabIndex = 0;
            this.gpboxseleccione.TabStop = false;
            this.gpboxseleccione.Text = "Listas por:";
            // 
            // cboxgrado
            // 
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(66, 76);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(121, 21);
            this.cboxgrado.TabIndex = 83;
            this.cboxgrado.Visible = false;
            // 
            // rdbtngrado
            // 
            this.rdbtngrado.AutoSize = true;
            this.rdbtngrado.Location = new System.Drawing.Point(6, 77);
            this.rdbtngrado.Name = "rdbtngrado";
            this.rdbtngrado.Size = new System.Drawing.Size(54, 17);
            this.rdbtngrado.TabIndex = 2;
            this.rdbtngrado.Text = "Grado";
            this.rdbtngrado.UseVisualStyleBackColor = true;
            this.rdbtngrado.CheckedChanged += new System.EventHandler(this.rdbtngrupo_CheckedChanged);
            // 
            // rdbtntodos
            // 
            this.rdbtntodos.AutoSize = true;
            this.rdbtntodos.Checked = true;
            this.rdbtntodos.Location = new System.Drawing.Point(6, 36);
            this.rdbtntodos.Name = "rdbtntodos";
            this.rdbtntodos.Size = new System.Drawing.Size(55, 17);
            this.rdbtntodos.TabIndex = 2;
            this.rdbtntodos.TabStop = true;
            this.rdbtntodos.Text = "Todos";
            this.rdbtntodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.rdbtnpantalla);
            this.groupBox1.Location = new System.Drawing.Point(422, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimir por: ";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(16, 77);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(71, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Impresora";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // rdbtnpantalla
            // 
            this.rdbtnpantalla.AutoSize = true;
            this.rdbtnpantalla.Checked = true;
            this.rdbtnpantalla.Location = new System.Drawing.Point(16, 36);
            this.rdbtnpantalla.Name = "rdbtnpantalla";
            this.rdbtnpantalla.Size = new System.Drawing.Size(63, 17);
            this.rdbtnpantalla.TabIndex = 2;
            this.rdbtnpantalla.TabStop = true;
            this.rdbtnpantalla.Text = "Pantalla";
            this.rdbtnpantalla.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(260, 261);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 43);
            this.btnimprimir.TabIndex = 81;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(412, 261);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 82;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // cboxmateria
            // 
            this.cboxmateria.FormattingEnabled = true;
            this.cboxmateria.Location = new System.Drawing.Point(66, 124);
            this.cboxmateria.Name = "cboxmateria";
            this.cboxmateria.Size = new System.Drawing.Size(121, 21);
            this.cboxmateria.TabIndex = 85;
            this.cboxmateria.Visible = false;
            // 
            // rdbtnmateria
            // 
            this.rdbtnmateria.AutoSize = true;
            this.rdbtnmateria.Location = new System.Drawing.Point(6, 125);
            this.rdbtnmateria.Name = "rdbtnmateria";
            this.rdbtnmateria.Size = new System.Drawing.Size(60, 17);
            this.rdbtnmateria.TabIndex = 84;
            this.rdbtnmateria.Text = "Materia";
            this.rdbtnmateria.UseVisualStyleBackColor = true;
            this.rdbtnmateria.CheckedChanged += new System.EventHandler(this.rdbtnmateria_CheckedChanged);
            // 
            // frmlistasalumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpboxseleccione);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlistasalumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de alumnos";
            this.Load += new System.EventHandler(this.frmlistasalumnos_Load);
            this.gpboxseleccione.ResumeLayout(false);
            this.gpboxseleccione.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxseleccione;
        private System.Windows.Forms.RadioButton rdbtngrado;
        private System.Windows.Forms.RadioButton rdbtntodos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdbtnpantalla;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cboxgrado;
        private System.Windows.Forms.ComboBox cboxmateria;
        private System.Windows.Forms.RadioButton rdbtnmateria;
    }
}