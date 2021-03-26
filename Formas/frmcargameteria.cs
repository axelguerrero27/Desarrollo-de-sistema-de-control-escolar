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
    public partial class frmcargameteria : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        string user;
        string nvl;
        public frmcargameteria()
        {
            InitializeComponent();
        }

        private void frmcargameteria_Load(object sender, EventArgs e)
        {
            llenarturno();
            llenargrado();
            llenarcboxmaestros();
            cboxalumno.ResetText();
            user = frmlogin.usuario;
            nvl = frmlogin.nvl;
        }
        private void llenarturno()
        {
            cboxturno.Items.Add("Seleccione");
            cboxturno.Items.Add("MATUTINO");
            cboxturno.Items.Add("VESPERTINO");
            cboxturno.SelectedIndex = 0;
        }
        private void llenargrado()
        {
            cboxgrado.Items.Add("Seleccione");
            cboxgrado.Items.Add("1");
            cboxgrado.Items.Add("2");
            cboxgrado.Items.Add("3");
            cboxgrado.Items.Add("4");
            cboxgrado.Items.Add("5");
            cboxgrado.Items.Add("6");
            cboxgrado.SelectedIndex = 0;
        }
        public void llenarasignatura()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select * from materias where mat_grado=@cboxgrado", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@cboxgrado", cboxgrado.SelectedIndex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboxasignatura.DisplayMember = "mat_nombre";
            cboxasignatura.DataSource = dt;
        }

        private void cboxgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxasignatura.ResetText();
            llenarasignatura();
            cboxalumno.ResetText();
            llenarcboxmaestros();
        }
        private void llenarcboxmaestros()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select [nombre completo] from busqueda where al_grado=@cboxgrado", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@cboxgrado", cboxgrado.SelectedIndex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cboxalumno.ValueMember = "nombre completo";
            cboxalumno.DisplayMember = "nombre completo";
            cboxalumno.DataSource = dt;
        }
        private void llenarmatricula()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select matricula from busqueda where [nombre completo]=@cboxalumno", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@cboxalumno", cboxalumno.Text);
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read())
            {
                txtmatricula.Text = leer["matricula"].ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());


            conexion.Open();

            string query = "insert into evaluaciones values (@matricula,@alumno,@materia,'-',0,'-',0,'-',0,'-',@cicloesc)";


            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@matricula", txtmatricula.Text);
            comando.Parameters.AddWithValue("@alumno", cboxalumno.Text);
            comando.Parameters.AddWithValue("@materia", cboxasignatura.Text);
            comando.Parameters.AddWithValue("@cicloesc", txtciclo.Text);

            comando.ExecuteNonQuery();

            MessageBox.Show("REGISTRO CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }
        private void limpiar()
        {
            cboxgrado.SelectedIndex = 0;
            txtgrupo.Clear();
            cboxturno.SelectedIndex = 0;
            cboxasignatura.ResetText();
            cboxalumno.ResetText();
            txtmatricula.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + user + " " + "NIVEL: " + nvl;
            x.Show();
        }

        private void cboxalumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmatricula.Clear();
            llenarmatricula();
        }
    }
}
