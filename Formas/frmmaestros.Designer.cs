namespace Escolar.Formas
{
    partial class frmmaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmaestros));
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cboxbusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxsexo = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtappaterno = new System.Windows.Forms.TextBox();
            this.txtapmaterno = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbllocalidad = new System.Windows.Forms.Label();
            this.lbldomicilio = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblapmaterno = new System.Windows.Forms.Label();
            this.lblappaterno = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblrfc = new System.Windows.Forms.Label();
            this.txtrfc = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnelininar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cboxlocalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(234, 59);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 31);
            this.btnbuscar.TabIndex = 56;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cboxbusqueda
            // 
            this.cboxbusqueda.FormattingEnabled = true;
            this.cboxbusqueda.Location = new System.Drawing.Point(327, 65);
            this.cboxbusqueda.Name = "cboxbusqueda";
            this.cboxbusqueda.Size = new System.Drawing.Size(356, 21);
            this.cboxbusqueda.TabIndex = 55;
            this.cboxbusqueda.Visible = false;
            this.cboxbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxbusqueda_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "DATOS DEL MAESTRO";
            // 
            // cboxsexo
            // 
            this.cboxsexo.Enabled = false;
            this.cboxsexo.FormattingEnabled = true;
            this.cboxsexo.Location = new System.Drawing.Point(588, 121);
            this.cboxsexo.Name = "cboxsexo";
            this.cboxsexo.Size = new System.Drawing.Size(95, 21);
            this.cboxsexo.TabIndex = 50;
            this.cboxsexo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxsexo_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(63, 121);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(121, 20);
            this.txtnombre.TabIndex = 49;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombre_KeyUp);
            // 
            // txtappaterno
            // 
            this.txtappaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtappaterno.Enabled = false;
            this.txtappaterno.Location = new System.Drawing.Point(206, 121);
            this.txtappaterno.Name = "txtappaterno";
            this.txtappaterno.Size = new System.Drawing.Size(149, 20);
            this.txtappaterno.TabIndex = 48;
            this.txtappaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtappaterno_KeyDown);
            // 
            // txtapmaterno
            // 
            this.txtapmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapmaterno.Enabled = false;
            this.txtapmaterno.Location = new System.Drawing.Point(394, 121);
            this.txtapmaterno.Name = "txtapmaterno";
            this.txtapmaterno.Size = new System.Drawing.Size(164, 20);
            this.txtapmaterno.TabIndex = 47;
            this.txtapmaterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtapmaterno_KeyDown);
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdomicilio.Enabled = false;
            this.txtdomicilio.Location = new System.Drawing.Point(63, 178);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(136, 20);
            this.txtdomicilio.TabIndex = 46;
            this.txtdomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdomicilio_KeyDown);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(136, 65);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(92, 20);
            this.txtid.TabIndex = 44;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lbllocalidad
            // 
            this.lbllocalidad.AutoSize = true;
            this.lbllocalidad.Enabled = false;
            this.lbllocalidad.Location = new System.Drawing.Point(231, 161);
            this.lbllocalidad.Name = "lbllocalidad";
            this.lbllocalidad.Size = new System.Drawing.Size(53, 13);
            this.lbllocalidad.TabIndex = 40;
            this.lbllocalidad.Text = "Localidad";
            // 
            // lbldomicilio
            // 
            this.lbldomicilio.AutoSize = true;
            this.lbldomicilio.Enabled = false;
            this.lbldomicilio.Location = new System.Drawing.Point(60, 162);
            this.lbldomicilio.Name = "lbldomicilio";
            this.lbldomicilio.Size = new System.Drawing.Size(49, 13);
            this.lbldomicilio.TabIndex = 39;
            this.lbldomicilio.Text = "Domicilio";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Enabled = false;
            this.lblsexo.Location = new System.Drawing.Point(585, 105);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(31, 13);
            this.lblsexo.TabIndex = 38;
            this.lblsexo.Text = "Sexo";
            // 
            // lblapmaterno
            // 
            this.lblapmaterno.AutoSize = true;
            this.lblapmaterno.Enabled = false;
            this.lblapmaterno.Location = new System.Drawing.Point(392, 105);
            this.lblapmaterno.Name = "lblapmaterno";
            this.lblapmaterno.Size = new System.Drawing.Size(85, 13);
            this.lblapmaterno.TabIndex = 37;
            this.lblapmaterno.Text = "Apellido materno";
            // 
            // lblappaterno
            // 
            this.lblappaterno.AutoSize = true;
            this.lblappaterno.Enabled = false;
            this.lblappaterno.Location = new System.Drawing.Point(203, 105);
            this.lblappaterno.Name = "lblappaterno";
            this.lblappaterno.Size = new System.Drawing.Size(83, 13);
            this.lblappaterno.TabIndex = 36;
            this.lblappaterno.Text = "Apellido paterno";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Enabled = false;
            this.lblnombre.Location = new System.Drawing.Point(60, 105);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(58, 13);
            this.lblnombre.TabIndex = 35;
            this.lblnombre.Text = "Nombre (s)";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(60, 68);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(70, 13);
            this.lblid.TabIndex = 34;
            this.lblid.Text = "Identificacion";
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(63, 247);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(136, 20);
            this.txttelefono.TabIndex = 60;
            this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttelefono_KeyDown);
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(239, 247);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 20);
            this.txtemail.TabIndex = 59;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Enabled = false;
            this.lblemail.Location = new System.Drawing.Point(236, 222);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 58;
            this.lblemail.Text = "Email";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Enabled = false;
            this.lbltelefono.Location = new System.Drawing.Point(60, 222);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 57;
            this.lbltelefono.Text = "Telefono";
            // 
            // lblrfc
            // 
            this.lblrfc.AutoSize = true;
            this.lblrfc.Enabled = false;
            this.lblrfc.Location = new System.Drawing.Point(476, 162);
            this.lblrfc.Name = "lblrfc";
            this.lblrfc.Size = new System.Drawing.Size(28, 13);
            this.lblrfc.TabIndex = 61;
            this.lblrfc.Text = "RFC";
            // 
            // txtrfc
            // 
            this.txtrfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrfc.Enabled = false;
            this.txtrfc.Location = new System.Drawing.Point(479, 178);
            this.txtrfc.MaxLength = 13;
            this.txtrfc.Name = "txtrfc";
            this.txtrfc.Size = new System.Drawing.Size(204, 20);
            this.txtrfc.TabIndex = 62;
            this.txtrfc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrfc_KeyDown);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(206, 379);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 37);
            this.btnguardar.TabIndex = 65;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnelininar
            // 
            this.btnelininar.Enabled = false;
            this.btnelininar.Image = ((System.Drawing.Image)(resources.GetObject("btnelininar.Image")));
            this.btnelininar.Location = new System.Drawing.Point(315, 379);
            this.btnelininar.Name = "btnelininar";
            this.btnelininar.Size = new System.Drawing.Size(75, 37);
            this.btnelininar.TabIndex = 64;
            this.btnelininar.UseVisualStyleBackColor = true;
            this.btnelininar.Click += new System.EventHandler(this.btnelininar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(437, 379);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 37);
            this.btnsalir.TabIndex = 63;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboxlocalidad
            // 
            this.cboxlocalidad.Enabled = false;
            this.cboxlocalidad.FormattingEnabled = true;
            this.cboxlocalidad.Location = new System.Drawing.Point(234, 178);
            this.cboxlocalidad.Name = "cboxlocalidad";
            this.cboxlocalidad.Size = new System.Drawing.Size(212, 21);
            this.cboxlocalidad.TabIndex = 66;
            this.cboxlocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboxlocalidad_KeyDown);
            // 
            // frmmaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxlocalidad);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnelininar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtrfc);
            this.Controls.Add(this.lblrfc);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.cboxbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxsexo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtappaterno);
            this.Controls.Add(this.txtapmaterno);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbllocalidad);
            this.Controls.Add(this.lbldomicilio);
            this.Controls.Add(this.lblsexo);
            this.Controls.Add(this.lblapmaterno);
            this.Controls.Add(this.lblappaterno);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmaestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestros";
            this.Load += new System.EventHandler(this.frmmaestros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cboxbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxsexo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtappaterno;
        private System.Windows.Forms.TextBox txtapmaterno;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbllocalidad;
        private System.Windows.Forms.Label lbldomicilio;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapmaterno;
        private System.Windows.Forms.Label lblappaterno;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblrfc;
        private System.Windows.Forms.TextBox txtrfc;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnelininar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cboxlocalidad;
    }
}