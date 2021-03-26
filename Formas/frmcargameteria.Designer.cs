namespace Escolar.Formas
{
    partial class frmcargameteria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcargameteria));
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboxalumno = new System.Windows.Forms.ComboBox();
            this.lblalumno = new System.Windows.Forms.Label();
            this.cboxgrado = new System.Windows.Forms.ComboBox();
            this.cboxturno = new System.Windows.Forms.ComboBox();
            this.cboxasignatura = new System.Windows.Forms.ComboBox();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.txtciclo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(425, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 105;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(285, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 104;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboxalumno
            // 
            this.cboxalumno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxalumno.FormattingEnabled = true;
            this.cboxalumno.Location = new System.Drawing.Point(165, 196);
            this.cboxalumno.Name = "cboxalumno";
            this.cboxalumno.Size = new System.Drawing.Size(351, 21);
            this.cboxalumno.TabIndex = 103;
            this.cboxalumno.SelectedIndexChanged += new System.EventHandler(this.cboxalumno_SelectedIndexChanged);
            // 
            // lblalumno
            // 
            this.lblalumno.AutoSize = true;
            this.lblalumno.Location = new System.Drawing.Point(114, 199);
            this.lblalumno.Name = "lblalumno";
            this.lblalumno.Size = new System.Drawing.Size(42, 13);
            this.lblalumno.TabIndex = 112;
            this.lblalumno.Text = "Alumno";
            // 
            // cboxgrado
            // 
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(165, 108);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(89, 21);
            this.cboxgrado.TabIndex = 99;
            this.cboxgrado.SelectedIndexChanged += new System.EventHandler(this.cboxgrado_SelectedIndexChanged);
            // 
            // cboxturno
            // 
            this.cboxturno.FormattingEnabled = true;
            this.cboxturno.Location = new System.Drawing.Point(430, 109);
            this.cboxturno.Name = "cboxturno";
            this.cboxturno.Size = new System.Drawing.Size(86, 21);
            this.cboxturno.TabIndex = 101;
            // 
            // cboxasignatura
            // 
            this.cboxasignatura.FormattingEnabled = true;
            this.cboxasignatura.Location = new System.Drawing.Point(165, 156);
            this.cboxasignatura.Name = "cboxasignatura";
            this.cboxasignatura.Size = new System.Drawing.Size(351, 21);
            this.cboxasignatura.TabIndex = 102;
            // 
            // txtgrupo
            // 
            this.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupo.Location = new System.Drawing.Point(306, 109);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(65, 20);
            this.txtgrupo.TabIndex = 100;
            // 
            // txtciclo
            // 
            this.txtciclo.Enabled = false;
            this.txtciclo.Location = new System.Drawing.Point(573, 110);
            this.txtciclo.Name = "txtciclo";
            this.txtciclo.Size = new System.Drawing.Size(182, 20);
            this.txtciclo.TabIndex = 111;
            this.txtciclo.Text = "2020-2021";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Ciclo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Asignatura";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Enabled = false;
            this.txtmatricula.Location = new System.Drawing.Point(531, 197);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(100, 20);
            this.txtmatricula.TabIndex = 113;
            this.txtmatricula.Visible = false;
            // 
            // frmcargameteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cboxalumno);
            this.Controls.Add(this.lblalumno);
            this.Controls.Add(this.cboxgrado);
            this.Controls.Add(this.cboxturno);
            this.Controls.Add(this.cboxasignatura);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.txtciclo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcargameteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de materias";
            this.Load += new System.EventHandler(this.frmcargameteria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboxalumno;
        private System.Windows.Forms.Label lblalumno;
        private System.Windows.Forms.ComboBox cboxgrado;
        private System.Windows.Forms.ComboBox cboxturno;
        private System.Windows.Forms.ComboBox cboxasignatura;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.TextBox txtciclo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricula;
    }
}