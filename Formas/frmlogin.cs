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

namespace Escolar
{

    public partial class frmlogin : Form
    {
        //definiendo la conexion
        
        Clases.conexion objconexion;
        SqlConnection conexion;

        int existe;
        string pass;
        string nivel;
        int intentos = 0;
        public frmlogin()
        {
            InitializeComponent();
        }
        public static string usuario;
        public static string nvl;
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "select * from usuarios where us_login=@us_login";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    
                    //lo encuentra
                    pass = leer["us_password"].ToString();
                    nivel = leer["us_nivel"].ToString();
                    if (nivel == "1")
                        txtnivel.Text = "Administrador";
                    if (nivel == "2")
                        txtnivel.Text = "Operador";
                    if (nivel == "3")
                        txtnivel.Text = "Invitado";
                    txtpassword.Enabled = true;
                    txtpassword.Focus();
                    btnaccesar.Enabled = true;
                    string foto = "c:\\fotos\\" + this.txtusuario.Text + ".jpg";
                    pboxfoto.Image = Image.FromFile(foto);
                    pboxfoto.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Error, usuario no registrado", "ERRROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Clear();
                    txtusuario.Focus();

                }
                conexion.Close();
            }
            else
            {
                

            }

        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Text = encriptar();
                conexion.Open();
                SqlCommand comando = new SqlCommand("select * from usuarios where us_login=@us_login and us_password=@us_password", conexion);
                //asigo a comando el sql command
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                comando.Parameters.AddWithValue("@us_password", txtpassword.Text);
                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    pass = leer["us_password"].ToString();

                    /*DialogResult res = MessageBox.Show("Bienvenido al sistema: " + txtusuario.Text, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if(res== DialogResult.OK)
                    {*/
                        Clases.globales.auditoria("Ingreso al sistema", txtusuario.Text);
                        Formas.frmmenu x = new Formas.frmmenu();
                        x.Text = "Menu principal VERSION 1.0 USUARIO: " +  txtusuario.Text + " "       + "NIVEL: " + txtnivel.Text;
                        x.Show();
                        this.Hide();
                        usuario = txtusuario.Text;
                        nvl = txtnivel.Text;
                    //}
                    

                }
                else//password incorrecto
                {
                    
                    MessageBox.Show("Error, password incorrecta", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    txtpassword.Focus();
                    intentos++;
                    if (intentos == 3)
                    {
                        MessageBox.Show("Oportunidades agotadas!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //El sistema se cierra
                        Application.Exit();
                    }

                }
                conexion.Close();

            }
        }

        private void btnaccesar_Click(object sender, EventArgs e)
        {
            txtpassword.Text = encriptar();
            conexion.Open();
            string query = "select * from usuarios where us_password=@us_password";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            //inicializo cualquier parametro definido anteriormente
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@us_password", txtpassword.Text);
            //asigno a leer el sqldatareader para leer el registro
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                pass = leer["us_password"].ToString();



                Formas.frmmenu x = new Formas.frmmenu();
                x.Show();
                this.Hide();

            }
            else//password incorrecto
            {

                MessageBox.Show("Error, password incorrecta", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtpassword.Focus();
                intentos++;
                if (intentos == 3)
                {
                    MessageBox.Show("Oportunidades agotadas!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //El sistema se cierra
                    Application.Exit();
                }

            }
            if (pass == txtpassword.Text.Trim())
            {

            }
                conexion.Close();
        }
        public string encriptar()
        {
            pass = txtpassword.Text;
            double[] calc = new double[pass.Length];
            byte[] bytes = Encoding.ASCII.GetBytes(pass);
            string str = BitConverter.ToString(bytes).Replace("-", "%");
            return (str);
        }

        private void txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                string foto = "c:\\fotos\\x.jpg";
                pboxfoto.Image = Image.FromFile(foto);
                txtpassword.Clear();
                txtpassword.Enabled = false;
                btnaccesar.Enabled = false;
                txtnivel.Clear();
                txtusuario.Clear();
                txtusuario.Focus();
            }
        }

    }
}
