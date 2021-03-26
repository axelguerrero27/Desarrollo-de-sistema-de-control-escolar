namespace Escolar.Formas
{
    partial class frmmaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmaterias));
            this.lblclave = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cboxbuscar = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblgrado = new System.Windows.Forms.Label();
            this.cboxgrado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Location = new System.Drawing.Point(48, 61);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(34, 13);
            this.lblclave.TabIndex = 0;
            this.lblclave.Text = "Clave";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Enabled = false;
            this.lblnombre.Location = new System.Drawing.Point(48, 108);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(88, 58);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(87, 20);
            this.txtclave.TabIndex = 2;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(98, 105);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(206, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyUp);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(180, 47);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 31);
            this.btnbuscar.TabIndex = 35;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cboxbuscar
            // 
            this.cboxbuscar.FormattingEnabled = true;
            this.cboxbuscar.Location = new System.Drawing.Point(273, 53);
            this.cboxbuscar.Name = "cboxbuscar";
            this.cboxbuscar.Size = new System.Drawing.Size(187, 21);
            this.cboxbuscar.TabIndex = 34;
            this.cboxbuscar.Visible = false;
            this.cboxbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxbuscar_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(90, 207);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 37);
            this.btnguardar.TabIndex = 68;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(199, 207);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 37);
            this.btneliminar.TabIndex = 67;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(321, 207);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 66;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblgrado
            // 
            this.lblgrado.AutoSize = true;
            this.lblgrado.Enabled = false;
            this.lblgrado.Location = new System.Drawing.Point(48, 153);
            this.lblgrado.Name = "lblgrado";
            this.lblgrado.Size = new System.Drawing.Size(36, 13);
            this.lblgrado.TabIndex = 69;
            this.lblgrado.Text = "Grado";
            // 
            // cboxgrado
            // 
            this.cboxgrado.Enabled = false;
            this.cboxgrado.FormattingEnabled = true;
            this.cboxgrado.Location = new System.Drawing.Point(98, 153);
            this.cboxgrado.Name = "cboxgrado";
            this.cboxgrado.Size = new System.Drawing.Size(77, 21);
            this.cboxgrado.TabIndex = 70;
            // 
            // frmmaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.cboxgrado);
            this.Controls.Add(this.lblgrado);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxbuscar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblclave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.frmmaterias_Load);
            this.Click += new System.EventHandler(this.frmmaterias_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cboxbuscar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblgrado;
        private System.Windows.Forms.ComboBox cboxgrado;
    }
}