namespace Escolar.Formas
{
    partial class frmregistrousuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmregistrousuarios));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.cboxnivel = new System.Windows.Forms.ComboBox();
            this.pboxfotonueva = new System.Windows.Forms.PictureBox();
            this.btnañadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxfotonueva)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Location = new System.Drawing.Point(272, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(143, 20);
            this.txtnombre.TabIndex = 10;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(192, 107);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(46, 13);
            this.lblnombre.TabIndex = 9;
            this.lblnombre.Text = "Usuario:";
            // 
            // txtpassword
            // 
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpassword.Location = new System.Drawing.Point(272, 152);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(143, 20);
            this.txtpassword.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nivel:";
            // 
            // btngrabar
            // 
            this.btngrabar.Image = ((System.Drawing.Image)(resources.GetObject("btngrabar.Image")));
            this.btngrabar.Location = new System.Drawing.Point(285, 286);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(76, 39);
            this.btngrabar.TabIndex = 15;
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(403, 286);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(76, 39);
            this.btncerrar.TabIndex = 17;
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // cboxnivel
            // 
            this.cboxnivel.FormattingEnabled = true;
            this.cboxnivel.Location = new System.Drawing.Point(272, 202);
            this.cboxnivel.Name = "cboxnivel";
            this.cboxnivel.Size = new System.Drawing.Size(121, 21);
            this.cboxnivel.TabIndex = 18;
            // 
            // pboxfotonueva
            // 
            this.pboxfotonueva.Image = ((System.Drawing.Image)(resources.GetObject("pboxfotonueva.Image")));
            this.pboxfotonueva.Location = new System.Drawing.Point(458, 104);
            this.pboxfotonueva.Name = "pboxfotonueva";
            this.pboxfotonueva.Size = new System.Drawing.Size(100, 94);
            this.pboxfotonueva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxfotonueva.TabIndex = 19;
            this.pboxfotonueva.TabStop = false;
            // 
            // btnañadir
            // 
            this.btnañadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnañadir.Location = new System.Drawing.Point(469, 204);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(75, 38);
            this.btnañadir.TabIndex = 20;
            this.btnañadir.Text = "...";
            this.btnañadir.UseVisualStyleBackColor = true;
            // 
            // frmregistrousuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnañadir);
            this.Controls.Add(this.pboxfotonueva);
            this.Controls.Add(this.cboxnivel);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmregistrousuarios";
            this.Text = "Registros de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pboxfotonueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ComboBox cboxnivel;
        private System.Windows.Forms.PictureBox pboxfotonueva;
        private System.Windows.Forms.Button btnañadir;
    }
}