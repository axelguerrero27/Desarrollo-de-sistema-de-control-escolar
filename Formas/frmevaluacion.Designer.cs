namespace Escolar.Formas
{
    partial class frmevaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmevaluacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdbtnpantalla = new System.Windows.Forms.RadioButton();
            this.gpboxseleccione = new System.Windows.Forms.GroupBox();
            this.rdbtnalumno = new System.Windows.Forms.RadioButton();
            this.rdbtngrupo = new System.Windows.Forms.RadioButton();
            this.rdbtnmateria = new System.Windows.Forms.RadioButton();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpboxseleccione.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.rdbtnpantalla);
            this.groupBox1.Location = new System.Drawing.Point(448, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 3;
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
            // gpboxseleccione
            // 
            this.gpboxseleccione.Controls.Add(this.rdbtnalumno);
            this.gpboxseleccione.Controls.Add(this.rdbtngrupo);
            this.gpboxseleccione.Controls.Add(this.rdbtnmateria);
            this.gpboxseleccione.Location = new System.Drawing.Point(80, 43);
            this.gpboxseleccione.Name = "gpboxseleccione";
            this.gpboxseleccione.Size = new System.Drawing.Size(200, 160);
            this.gpboxseleccione.TabIndex = 2;
            this.gpboxseleccione.TabStop = false;
            this.gpboxseleccione.Text = "Evaluacion por:";
            // 
            // rdbtnalumno
            // 
            this.rdbtnalumno.AutoSize = true;
            this.rdbtnalumno.Location = new System.Drawing.Point(7, 77);
            this.rdbtnalumno.Name = "rdbtnalumno";
            this.rdbtnalumno.Size = new System.Drawing.Size(60, 17);
            this.rdbtnalumno.TabIndex = 3;
            this.rdbtnalumno.Text = "Alumno";
            this.rdbtnalumno.UseVisualStyleBackColor = true;
            // 
            // rdbtngrupo
            // 
            this.rdbtngrupo.AutoSize = true;
            this.rdbtngrupo.Location = new System.Drawing.Point(7, 124);
            this.rdbtngrupo.Name = "rdbtngrupo";
            this.rdbtngrupo.Size = new System.Drawing.Size(54, 17);
            this.rdbtngrupo.TabIndex = 2;
            this.rdbtngrupo.Text = "Grupo";
            this.rdbtngrupo.UseVisualStyleBackColor = true;
            // 
            // rdbtnmateria
            // 
            this.rdbtnmateria.AutoSize = true;
            this.rdbtnmateria.Checked = true;
            this.rdbtnmateria.Location = new System.Drawing.Point(6, 36);
            this.rdbtnmateria.Name = "rdbtnmateria";
            this.rdbtnmateria.Size = new System.Drawing.Size(60, 17);
            this.rdbtnmateria.TabIndex = 2;
            this.rdbtnmateria.TabStop = true;
            this.rdbtnmateria.Text = "Materia";
            this.rdbtnmateria.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(375, 305);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 84;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(223, 305);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 43);
            this.btnimprimir.TabIndex = 83;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // frmevaluacion
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
            this.Name = "frmevaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.frmevaluacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpboxseleccione.ResumeLayout(false);
            this.gpboxseleccione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdbtnpantalla;
        private System.Windows.Forms.GroupBox gpboxseleccione;
        private System.Windows.Forms.RadioButton rdbtnalumno;
        private System.Windows.Forms.RadioButton rdbtngrupo;
        private System.Windows.Forms.RadioButton rdbtnmateria;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnimprimir;
    }
}