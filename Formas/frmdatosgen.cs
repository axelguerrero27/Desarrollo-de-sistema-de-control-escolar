using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escolar.Formas
{
    public partial class frmdatosgen : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        string usuario;
        string nvl;
        public frmdatosgen()
        {
            InitializeComponent();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtdirector.Enabled = true;
            txtdomicilio.Enabled = true;
            txtlocalidad.Enabled = true;
            txttelefono.Enabled = true;
            txtemail.Enabled = true;
            txtpagina.Enabled = true;
            txtfacebook.Enabled = true;
            btnguardar.Enabled = true;
            btneditar.Enabled = false;
            txtnombre.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de datos generales", usuario);
        }

        private void frmdatosgen_Load(object sender, EventArgs e)
        {
            cargar();
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a datos generales", usuario);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "insert into datosgen values (@dg_nombre,@dg_director,@dg_domicilio,@dg_localidad,@dg_telefono,@dg_email,@dg_paginaweb,@dg_facebook)";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@dg_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@dg_director", txtdirector.Text);
                comando.Parameters.AddWithValue("@dg_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@dg_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@dg_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@dg_email", txtemail.Text);
                comando.Parameters.AddWithValue("@dg_paginaweb", txtpagina.Text);
                comando.Parameters.AddWithValue("@dg_facebook", txtfacebook.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("INFORMACION GUARDADA CON EXITO!!", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deshabilitar();
            }
            if (existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update datosgen set dg_nombre=@dg_nombre,dg_director=@dg_director,dg_domicilio=@dg_domicilio,dg_localidad=@dg_localidad,dg_telefono=@dg_telefono,dg_email=@dg_email,dg_paginaweb=@dg_paginaweb,dg_facebook=@dg_facebook";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@dg_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@dg_director", txtdirector.Text);
                comando.Parameters.AddWithValue("@dg_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@dg_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@dg_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@dg_email", txtemail.Text);
                comando.Parameters.AddWithValue("@dg_paginaweb", txtpagina.Text);
                comando.Parameters.AddWithValue("@dg_facebook", txtfacebook.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("INFORMACION MODIFICADA CON EXITO!!", "MODIFICACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Modifico datos generales", usuario);
                deshabilitar();
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtdirector.Focus();
            }
        }

        private void txtdirector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtdomicilio.Focus();
            }
        }

        private void txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtlocalidad.Focus();
            }
        }

        private void txtlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txttelefono.Focus();
            }
        }
        private void cargar()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from datosgen ";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@dg_nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@dg_director", txtdirector.Text);
            comando.Parameters.AddWithValue("@dg_domicilio", txtdomicilio.Text);
            comando.Parameters.AddWithValue("@dg_localidad", txtlocalidad.Text);
            comando.Parameters.AddWithValue("@dg_telefono", txttelefono.Text);
            comando.Parameters.AddWithValue("@dg_email", txtemail.Text);
            comando.Parameters.AddWithValue("@dg_paginaweb", txtpagina.Text);
            comando.Parameters.AddWithValue("@dg_facebook", txtfacebook.Text);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                existe = 1;
                txtnombre.Text = leer["dg_nombre"].ToString();
                txtdirector.Text = leer["dg_director"].ToString();
                txtdomicilio.Text = leer["dg_domicilio"].ToString();
                txtlocalidad.Text = leer["dg_localidad"].ToString();
                txttelefono.Text = leer["dg_telefono"].ToString();
                txtemail.Text = leer["dg_email"].ToString();
                txtpagina.Text = leer["dg_paginaweb"].ToString();
                txtfacebook.Text = leer["dg_facebook"].ToString();
            }
        }

        private void txttelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtpagina.Focus();
            }
        }

        private void txtpagina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtfacebook.Focus();
            }
        }
        private void deshabilitar()
        {
            txtnombre.Enabled = false;
            txtdirector.Enabled = false;
            txtdomicilio.Enabled = false;
            txtlocalidad.Enabled = false;
            txttelefono.Enabled = false;
            txtemail.Enabled = false;
            txtpagina.Enabled = false;
            txtfacebook.Enabled = false;
            btnguardar.Enabled = false;
            btneditar.Enabled = true;
            btnguardar.Enabled = false;
        }
        
    }
}
