namespace Escolar
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.pboxfoto = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnaccesar = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblususario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnivel
            // 
            this.txtnivel.Enabled = false;
            this.txtnivel.Location = new System.Drawing.Point(153, 239);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(100, 20);
            this.txtnivel.TabIndex = 15;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(121, 246);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(31, 13);
            this.lblnivel.TabIndex = 14;
            this.lblnivel.Text = "Nivel";
            // 
            // pboxfoto
            // 
            this.pboxfoto.Image = ((System.Drawing.Image)(resources.GetObject("pboxfoto.Image")));
            this.pboxfoto.Location = new System.Drawing.Point(124, 105);
            this.pboxfoto.Name = "pboxfoto";
            this.pboxfoto.Size = new System.Drawing.Size(137, 128);
            this.pboxfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxfoto.TabIndex = 13;
            this.pboxfoto.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(480, 278);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(94, 40);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnaccesar
            // 
            this.btnaccesar.Enabled = false;
            this.btnaccesar.Image = ((System.Drawing.Image)(resources.GetObject("btnaccesar.Image")));
            this.btnaccesar.Location = new System.Drawing.Point(270, 278);
            this.btnaccesar.Name = "btnaccesar";
            this.btnaccesar.Size = new System.Drawing.Size(94, 40);
            this.btnaccesar.TabIndex = 11;
            this.btnaccesar.UseVisualStyleBackColor = true;
            this.btnaccesar.Click += new System.EventHandler(this.btnaccesar_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(317, 190);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(105, 20);
            this.txtpassword.TabIndex = 9;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyUp);
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(317, 125);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(109, 20);
            this.txtusuario.TabIndex = 7;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(342, 174);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 10;
            this.lblpassword.Text = "Password";
            // 
            // lblususario
            // 
            this.lblususario.AutoSize = true;
            this.lblususario.Location = new System.Drawing.Point(346, 109);
            this.lblususario.Name = "lblususario";
            this.lblususario.Size = new System.Drawing.Size(43, 13);
            this.lblususario.TabIndex = 8;
            this.lblususario.Text = "Usuario";
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.pboxfoto);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnaccesar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblususario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al sistema control escolar";
            ((System.ComponentModel.ISupportInitialize)(this.pboxfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.PictureBox pboxfoto;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnaccesar;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblususario;
    }
}

