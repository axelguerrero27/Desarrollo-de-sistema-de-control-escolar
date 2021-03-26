namespace Escolar.Formas
{
    partial class frmasignacionmaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmasignacionmaestro));
            this.cboxmaestro = new System.Windows.Forms.ComboBox();
            this.lblmaestro = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxmaestro
            // 
            this.cboxmaestro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboxmaestro.FormattingEnabled = true;
            this.cboxmaestro.Location = new System.Drawing.Point(143, 167);
            this.cboxmaestro.Name = "cboxmaestro";
            this.cboxmaestro.Size = new System.Drawing.Size(351, 21);
            this.cboxmaestro.TabIndex = 4;
            // 
            // lblmaestro
            // 
            this.lblmaestro.AutoSize = true;
            this.lblmaestro.Location = new System.Drawing.Point(92, 170);
            this.lblmaestro.Name = "lblmaestro";
            this.lblmaestro.Size = new System.Drawing.Size(45, 13);
            this.lblmaestro.TabIndex = 98;
            this.lblmaestro.Text = "Maestro";
            // 
            // cboxgrado
            // 
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(143, 79);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(89, 21);
            this.cboxgrado.TabIndex = 0;
            this.cboxgrado.SelectedIndexChanged += new System.EventHandler(this.cboxgrado_SelectedIndexChanged);
            // 
            // cboxturno
            // 
            this.cboxturno.FormattingEnabled = true;
            this.cboxturno.Location = new System.Drawing.Point(408, 80);
            this.cboxturno.Name = "cboxturno";
            this.cboxturno.Size = new System.Drawing.Size(86, 21);
            this.cboxturno.TabIndex = 2;
            // 
            // cboxasignatura
            // 
            this.cboxasignatura.FormattingEnabled = true;
            this.cboxasignatura.Location = new System.Drawing.Point(143, 127);
            this.cboxasignatura.Name = "cboxasignatura";
            this.cboxasignatura.Size = new System.Drawing.Size(351, 21);
            this.cboxasignatura.TabIndex = 3;
            // 
            // txtgrupo
            // 
            this.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupo.Location = new System.Drawing.Point(284, 80);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(65, 20);
            this.txtgrupo.TabIndex = 1;
            // 
            // txtciclo
            // 
            this.txtciclo.Enabled = false;
            this.txtciclo.Location = new System.Drawing.Point(551, 81);
            this.txtciclo.Name = "txtciclo";
            this.txtciclo.Size = new System.Drawing.Size(182, 20);
            this.txtciclo.TabIndex = 92;
            this.txtciclo.Text = "2020-2021";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Ciclo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Turno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Grupo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Asignatura";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(403, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(263, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmasignacionmaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cboxmaestro);
            this.Controls.Add(this.lblmaestro);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmasignacionmaestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de maestros";
            this.Load += new System.EventHandler(this.frmasignacionmaestro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxmaestro;
        private System.Windows.Forms.Label lblmaestro;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}