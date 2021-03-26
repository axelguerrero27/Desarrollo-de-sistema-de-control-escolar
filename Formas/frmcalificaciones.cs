using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escolar.Formas
{
    public partial class frmcalificaciones : Form
    {
        string user;
        string nvl;
        Clases.conexion objconexion;
        SqlConnection conexion;

        public frmcalificaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmenu x = new frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + user + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de capturas de calificaciones", user);
        }

        private void frmevaluaciones_Load(object sender, EventArgs e)
        {
            llenarturno();
            llenargrado();
            //llenarasignatura();
            user = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a capturas de calificaciones", user);
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
            cboxasignatura.ValueMember = "mat_id";
            cboxasignatura.DisplayMember = "mat_nombre";
            cboxasignatura.DataSource = dt;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //consultamateria();
            llenaralumnos();
            Clases.globales.auditoria("Realizo busqueda para capturas de calificaciones", user);
        }
        private void llenaralumnos()
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("SELECT ev_matricula,ev_al,ev_trim1,ev_faltas1,ev_trim2,ev_faltas2,ev_trim3,ev_faltas3,ev_promediofinal FROM evaluaciones where ev_mat= @ev_mat", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@ev_mat", cboxasignatura.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgcalificaciones.AutoGenerateColumns = false;
            dgcalificaciones.Columns[0].DataPropertyName = "ev_matricula";
            dgcalificaciones.Columns[1].DataPropertyName = "ev_al";
            dgcalificaciones.Columns[2].DataPropertyName = "ev_trim1";
            dgcalificaciones.Columns[3].DataPropertyName = "ev_faltas1";
            dgcalificaciones.Columns[4].DataPropertyName = "ev_trim2";
            dgcalificaciones.Columns[5].DataPropertyName = "ev_faltas2";
            dgcalificaciones.Columns[6].DataPropertyName = "ev_trim3";
            dgcalificaciones.Columns[7].DataPropertyName = "ev_faltas3";
            dgcalificaciones.Columns[8].DataPropertyName = "ev_promediofinal";
            dgcalificaciones.DataSource =dt;
            
        }

        private void cboxgrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxasignatura.Enabled = true;
            cboxasignatura.ResetText();
            llenarasignatura();
            //llenaralumnos();
        }
        /*public void consultamateria()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("insert into evaluaciones values(@ev_al,@ev_mat,0,0,0,0,0,0,0,@ev_cicloesc)", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@ev_al", cboxalumno.Text);
            cm.Parameters.AddWithValue("@ev_mat", cboxasignatura.Text);
            cm.Parameters.AddWithValue("@ev_cicloesc", txtciclo.Text);
            cm.ExecuteNonQuery();
            /*SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dgcalificaciones.DataSource = dt;
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
           
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update evaluaciones set ev_al=@ev_al,ev_trim1=@ev_trim1,ev_faltas1=@ev_faltas1,ev_trim2=@ev_trim2,ev_faltas2=@ev_faltas2,ev_trim3=@ev_trim3,ev_faltas3=@ev_faltas3,ev_promediofinal=@ev_promediofinal where ev_matricula=@ev_matricula and ev_mat=@ev_mat";
                SqlCommand comando = new SqlCommand(query, conexion);
                foreach (DataGridViewRow row in dgcalificaciones.Rows)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ev_matricula", Convert.ToString(row.Cells["matricula"].Value));
                    comando.Parameters.AddWithValue("@ev_al", Convert.ToString(row.Cells["nombre"].Value));
                    comando.Parameters.AddWithValue("@ev_mat", cboxasignatura.Text);
                    comando.Parameters.AddWithValue("@ev_trim1", Convert.ToString(row.Cells["parcial1"].Value));
                    comando.Parameters.AddWithValue("@ev_faltas1", Convert.ToString(row.Cells["faltas1"].Value));
                    comando.Parameters.AddWithValue("@ev_trim2", Convert.ToString(row.Cells["parcial2"].Value));
                    comando.Parameters.AddWithValue("@ev_faltas2", Convert.ToString(row.Cells["faltas2"].Value));
                    comando.Parameters.AddWithValue("@ev_trim3", Convert.ToString(row.Cells["parcial3"].Value));
                    comando.Parameters.AddWithValue("@ev_faltas3", Convert.ToString(row.Cells["faltas3"].Value));
                    comando.Parameters.AddWithValue("@ev_promediofinal", Convert.ToString(row.Cells["promedio"].Value));
                    comando.ExecuteNonQuery();

                }
                MessageBox.Show("ACTUALIZADO CON EXITO!!", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Agrego/actualizo calificaciones", user);
            //}
        }
        
        public void capturapormateria()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select * from vevaluaciones where materia=@ev_mat ", conexion);
            cm.Parameters.AddWithValue("@ev_mat", cboxasignatura.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgcalificaciones.DataSource = dt;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgcalificaciones.DataSource = null;
        }
    }
}
