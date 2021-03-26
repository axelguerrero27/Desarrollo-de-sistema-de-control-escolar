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
    public partial class frmasignacionmaestro : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        string user;
        string nvl;
        public frmasignacionmaestro()
        {
            InitializeComponent();
        }

        private void frmasignacionmaestro_Load(object sender, EventArgs e)
        {
            llenarturno();
            llenargrado();
            llenarcboxmaestros();
            cboxmaestro.ResetText();
            user = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a auditorias", user);
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
        }
        private void llenarcboxmaestros()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select [nombre completo] from vmaestros ";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxmaestro.DataSource = dt;
            //defino los campos de la tabla
            this.cboxmaestro.ValueMember = "nombre completo";
            this.cboxmaestro.DisplayMember = "nombre completo";
            //cierro conexion
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + user + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de asignacion de maestros", user);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());


            conexion.Open();

            string query = "insert into asignacionmaestros values (@grado,@grupo,@turno,@cicloesc,@asignatura,@maestro)";


            SqlCommand comando = new SqlCommand(query, conexion);

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@grado", cboxgrado.SelectedIndex);
            comando.Parameters.AddWithValue("@grupo", txtgrupo.Text);
            comando.Parameters.AddWithValue("@turno", cboxturno.Text);
            comando.Parameters.AddWithValue("@cicloesc", txtciclo.Text);
            comando.Parameters.AddWithValue("@asignatura", cboxasignatura.Text);
            comando.Parameters.AddWithValue("@maestro", cboxmaestro.Text);

            comando.ExecuteNonQuery();

            MessageBox.Show("REGISTRO CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
            Clases.globales.auditoria("Realizo una asignacion de maestro", user);
        }
        private void limpiar()
        {
            cboxgrado.SelectedIndex = 0;
            txtgrupo.Clear();
            cboxturno.SelectedIndex = 0;
            cboxasignatura.ResetText();
            cboxmaestro.ResetText();
        }
    }
}
