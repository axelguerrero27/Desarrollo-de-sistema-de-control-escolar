namespace Escolar.Formas
{
    partial class frmcatalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcatalogos));
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdbtnpantalla = new System.Windows.Forms.RadioButton();
            this.gpboxseleccione = new System.Windows.Forms.GroupBox();
            this.rdbtnmaestros = new System.Windows.Forms.RadioButton();
            this.rdbtnlocalidades = new System.Windows.Forms.RadioButton();
            this.rdbtnmateria = new System.Windows.Forms.RadioButton();
            this.gpboxpor = new System.Windows.Forms.GroupBox();
            this.rbtngrupo = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rdbtnclave = new System.Windows.Forms.RadioButton();
            this.cboxgrado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gpboxseleccione.SuspendLayout();
            this.gpboxpor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(395, 362);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 88;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(243, 362);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 43);
            this.btnimprimir.TabIndex = 87;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.rdbtnpantalla);
            this.groupBox1.Location = new System.Drawing.Point(464, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 86;
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
            this.gpboxseleccione.Controls.Add(this.rdbtnmaestros);
            this.gpboxseleccione.Controls.Add(this.rdbtnlocalidades);
            this.gpboxseleccione.Controls.Add(this.rdbtnmateria);
            this.gpboxseleccione.Location = new System.Drawing.Point(96, 52);
            this.gpboxseleccione.Name = "gpboxseleccione";
            this.gpboxseleccione.Size = new System.Drawing.Size(200, 160);
            this.gpboxseleccione.TabIndex = 85;
            this.gpboxseleccione.TabStop = false;
            this.gpboxseleccione.Text = "Catalogo de:";
            // 
            // rdbtnmaestros
            // 
            this.rdbtnmaestros.AutoSize = true;
            this.rdbtnmaestros.Checked = true;
            this.rdbtnmaestros.Location = new System.Drawing.Point(10, 36);
            this.rdbtnmaestros.Name = "rdbtnmaestros";
            this.rdbtnmaestros.Size = new System.Drawing.Size(68, 17);
            this.rdbtnmaestros.TabIndex = 3;
            this.rdbtnmaestros.TabStop = true;
            this.rdbtnmaestros.Text = "Maestros";
            this.rdbtnmaestros.UseVisualStyleBackColor = true;
            // 
            // rdbtnlocalidades
            // 
            this.rdbtnlocalidades.AutoSize = true;
            this.rdbtnlocalidades.Location = new System.Drawing.Point(7, 124);
            this.rdbtnlocalidades.Name = "rdbtnlocalidades";
            this.rdbtnlocalidades.Size = new System.Drawing.Size(82, 17);
            this.rdbtnlocalidades.TabIndex = 2;
            this.rdbtnlocalidades.Text = "Localidades";
            this.rdbtnlocalidades.UseVisualStyleBackColor = true;
            // 
            // rdbtnmateria
            // 
            this.rdbtnmateria.AutoSize = true;
            this.rdbtnmateria.Location = new System.Drawing.Point(10, 77);
            this.rdbtnmateria.Name = "rdbtnmateria";
            this.rdbtnmateria.Size = new System.Drawing.Size(65, 17);
            this.rdbtnmateria.TabIndex = 2;
            this.rdbtnmateria.Text = "Materias";
            this.rdbtnmateria.UseVisualStyleBackColor = true;
            this.rdbtnmateria.CheckedChanged += new System.EventHandler(this.rdbtnmateria_CheckedChanged);
            // 
            // gpboxpor
            // 
            this.gpboxpor.Controls.Add(this.cboxgrado);
            this.gpboxpor.Controls.Add(this.rbtngrupo);
            this.gpboxpor.Controls.Add(this.rbtnnombre);
            this.gpboxpor.Controls.Add(this.rdbtnclave);
            this.gpboxpor.Location = new System.Drawing.Point(96, 218);
            this.gpboxpor.Name = "gpboxpor";
            this.gpboxpor.Size = new System.Drawing.Size(200, 104);
            this.gpboxpor.TabIndex = 89;
            this.gpboxpor.TabStop = false;
            this.gpboxpor.Text = "Ordenado por: ";
            // 
            // rbtngrupo
            // 
            this.rbtngrupo.AutoSize = true;
            this.rbtngrupo.Location = new System.Drawing.Point(16, 82);
            this.rbtngrupo.Name = "rbtngrupo";
            this.rbtngrupo.Size = new System.Drawing.Size(54, 17);
            this.rbtngrupo.TabIndex = 4;
            this.rbtngrupo.Text = "Grado";
            this.rbtngrupo.UseVisualStyleBackColor = true;
            this.rbtngrupo.Visible = false;
            this.rbtngrupo.CheckedChanged += new System.EventHandler(this.rbtngrupo_CheckedChanged);
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(16, 59);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnnombre.TabIndex = 3;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rdbtnclave
            // 
            this.rdbtnclave.AutoSize = true;
            this.rdbtnclave.Checked = true;
            this.rdbtnclave.Location = new System.Drawing.Point(16, 36);
            this.rdbtnclave.Name = "rdbtnclave";
            this.rdbtnclave.Size = new System.Drawing.Size(52, 17);
            this.rdbtnclave.TabIndex = 2;
            this.rdbtnclave.TabStop = true;
            this.rdbtnclave.Text = "Clave";
            this.rdbtnclave.UseVisualStyleBackColor = true;
            // 
            // cboxgrado
            // 
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(73, 83);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(121, 21);
            this.cboxgrado.TabIndex = 90;
            this.cboxgrado.Visible = false;
            // 
            // frmcatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpboxpor);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpboxseleccione);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcatalogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogos";
            this.Load += new System.EventHandler(this.frmcatalogos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpboxseleccione.ResumeLayout(false);
            this.gpboxseleccione.PerformLayout();
            this.gpboxpor.ResumeLayout(false);
            this.gpboxpor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdbtnpantalla;
        private System.Windows.Forms.GroupBox gpboxseleccione;
        private System.Windows.Forms.RadioButton rdbtnmaestros;
        private System.Windows.Forms.RadioButton rdbtnlocalidades;
        private System.Windows.Forms.RadioButton rdbtnmateria;
        private System.Windows.Forms.GroupBox gpboxpor;
        private System.Windows.Forms.RadioButton rbtngrupo;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rdbtnclave;
        private System.Windows.Forms.ComboBox cboxgrado;
    }
}