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
using CrystalDecisions.CrystalReports.Engine;

namespace Escolar.Formas
{
    public partial class frmauditoria : Form
    {
        string pass;
        int nivel;
        int existe;
        string user;
        string nvl;
        Clases.conexion objconexion;
        SqlConnection conexion;
        public frmauditoria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + user + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de auditoria", user);
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
                        existe = 1;
                        txtcontraseña.Enabled = true;
                        txtcontraseña.Focus();
                        lblcontraseña.Enabled = true;
                    }
                    else
                    {
                        existe = 0;
                        if (MessageBox.Show("Error: usuario no encontrado. Deseas agregar un nuevo usuario?", "ERROR!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            cboxnivel.Enabled = true;
                            lblnivel.Enabled = true;
                            lblnombrecompleto.Enabled = true;
                            txtncompleto.Enabled = true;
                            txtncompleto.Enabled = true;
                            //txtcontraseña.Enabled = true;
                            lblcontraseña.Enabled = true;
                            //txtcontraseña.Focus();
                            btnguardar.Enabled = true;
                            gpboxcambiar.Visible = true;
                        }
                        else
                        {
                            txtusuario.Clear();
                            txtusuario.Focus();
                        }

                    }
                    conexion.Close();
                }

            }

        }
        public void limpiar()
        {
            lblnombrecompleto.Enabled = false;
            lblcontraseña.Enabled = false;
            lblnivel.Enabled = false;
            txtusuario.Enabled = true;
            txtusuario.Clear();
            txtusuario.Focus();
            txtncompleto.Enabled = false;
            txtncompleto.Clear();
            txtcontraseña.Enabled = false;
            txtcontraseña.Clear();
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            cboxnivel.Enabled = false;
            txtncompleto.Clear();
            cboxnivel.SelectedIndex = 0;

        }


        private void frmauditoria_Load(object sender, EventArgs e)
        {
            cboxnivel.Items.Add("Seleccione");
            cboxnivel.Items.Add("Administrador");
            cboxnivel.Items.Add("Operador");
            cboxnivel.Items.Add("Invitado");

            cboxnivel.SelectedIndex = 0;
            txtusuario.Focus();
            user = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a auditorias", user);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                //cboxnivel.SelectedIndex = 0;
                cboxnivel.Enabled = true;

                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());


                conexion.Open();

                string query = "insert into usuarios values (@us_login,@us_nombre,@us_password,@us_nivel)";


                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                comando.Parameters.AddWithValue("@us_nombre", txtncompleto.Text);
                comando.Parameters.AddWithValue("@us_password", txtcontraseña.Text);
                comando.Parameters.AddWithValue("@us_nivel", cboxnivel.SelectedIndex);

                comando.ExecuteNonQuery();

                MessageBox.Show("GUARDADO CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Registro nuevo usuario", user);
                limpiar();
                gpboxcambiar.Visible = false;


            }
            if (existe == 1)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                conexion.Open();
                string query = "update usuarios set us_nombre=@us_nombre, us_password=@us_password, us_nivel=@us_nivel where us_login=@us_login";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                comando.Parameters.AddWithValue("@us_nombre", txtncompleto.Text);
                comando.Parameters.AddWithValue("@us_password", txtcontraseña.Text);
                comando.Parameters.AddWithValue("@us_nivel", cboxnivel.SelectedIndex);



                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICADO CON EXITO!!", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Modifico usuarios", user);
                limpiar();
                gpboxcambiar.Visible = false;
            }
        }
        public string encriptar(string pass)
        {
            //pass = txtcontraseña.Text;
            double[] calc = new double[pass.Length];
            byte[] bytes = Encoding.ASCII.GetBytes(pass);
            string str = BitConverter.ToString(bytes).Replace("-", "%");
            return (str);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "delete from usuarios where us_login=@us_login";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@us_login", txtusuario.Text);

            if (MessageBox.Show("Seguro que desea eliminar??", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("usuario eliminado con exito!!", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Elimino usuarios", user);
                limpiar();
                gpboxcambiar.Visible = false;
            }
        }

        private void txtncompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxnivel.Focus();
            }
        }



        private void txtcontraseñarepetir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtncompleto.Focus();
            }
        }


        public string encriptar()
        {
            pass = txtcontraseña.Text;
            double[] calc = new double[pass.Length];
            byte[] bytes = Encoding.ASCII.GetBytes(pass);
            string str = BitConverter.ToString(bytes).Replace("-", "%");
            return (str);
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Text = encriptar();
                conexion.Open();
                //string query = "select , us_nombre, us_nivel from usuarios where us_login=@us_login";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand("select us_nombre, us_nivel from usuarios where us_login=@us_login and us_password=@us_password", conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                comando.Parameters.AddWithValue("@us_password", txtpassword.Text);
                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtncompleto.Text = leer["us_nombre"].ToString();

                    cboxnivel.SelectedIndex = int.Parse(leer["us_nivel"].ToString());
                    lblnombrecompleto.Enabled = true;
                    txtncompleto.Enabled = true;
                    lblcontraseña.Enabled = true;
                    lblnivel.Enabled = true;
                    cboxnivel.Enabled = true;
                    txtncompleto.Focus();
                    btnguardar.Enabled = true;
                    btneliminar.Enabled = true;
                    gpboxcambiar.Visible = true;
                    //}
                    txtpassword.Clear();
                    btncambiar.Enabled = true;
                    Clases.globales.auditoria("Consulto usuarios", user);

                }
                else//password incorrecto
                {

                        existe = 0;


                }
                
                conexion.Close();

            }

        }

        private void txtcontraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtcontraseña.Clear();
                txtcontraseña.Enabled = false;
                lblcontraseña.Enabled = false;
                txtusuario.Clear();
                txtusuario.Focus();
            }
        }

        private void txtncompleto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtcontraseña.Clear();
                txtcontraseña.Enabled = false;
                lblcontraseña.Enabled = false;
                lblnombrecompleto.Enabled = false;
                txtncompleto.Clear();
                txtncompleto.Enabled = false;
                lblnivel.Enabled = false;
                cboxnivel.SelectedIndex = 0;
                cboxnivel.Enabled = false;
                txtusuario.Clear();
                txtusuario.Focus();
                btnguardar.Enabled = false;
                btneliminar.Enabled = false;
                gpboxcambiar.Visible = false;
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtrepetir.Enabled = true;
                txtrepetir.Focus();
            }
        }

        private void txtrepetir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtpassword.Text == txtrepetir.Text)
                {
                    MessageBox.Show("Correcto!! Favor de aplicar los cambios", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcontraseña.Text = string.Format("{0}", encriptar(txtrepetir.Text));
                    txtpassword.Clear();
                    txtpassword.Enabled = false;
                    txtrepetir.Clear();
                    txtrepetir.Enabled = false;
                    gpboxcambiar.Visible = false;
                    txtncompleto.Focus();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden!! Favor de verificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtrepetir.Clear();
                }

            }
        }

        private void txtpassword_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("¿Deseas insertar una contraseña o cambiar contraseña?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
                
                txtpassword.Enabled = true;
                txtrepetir.Enabled = true;
                txtpassword.Clear();
                txtpassword.Focus();
                

            //}
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            txtpassword.Enabled = true;
            txtpassword.Clear();
            txtpassword.Focus();
           
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select us_login from usuarios ";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxuser.DataSource = dt;
            //defino los campos de la tabla
            this.cboxuser.ValueMember = "us_login";
            this.cboxuser.DisplayMember = "us_login";
            //cierro conexion
            conexion.Close();
        }
        private void llenarcboxuse()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select us_login from usuarios ";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxuse.DataSource = dt;
            //defino los campos de la tabla
            this.cboxuse.ValueMember = "us_login";
            this.cboxuse.DisplayMember = "us_login";
            //cierro conexion
            conexion.Close();
        }
        private void rdbtnusuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnusuario.Checked)
            {
                lblusuario.Visible = true;
                cboxuser.Visible = true;
                llenarcbox();

            }
            else
            {
                lblusuario.Visible = false;
                cboxuser.Visible = false;

            }
        }
        public void consultatodo(DataGridView dgauditoria)//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select * from vauditoria where fecha BETWEEN @dateTimePicker1 AND @dateTimePicker2 order by fecha", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgauditoria.DataSource = dt;
            if (!(dt.Rows.Count > 0))
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btneliminarregistro.Enabled = false;

            }
            else
            {
                btneliminarregistro.Enabled = true;
            }
            Clases.globales.auditoria("Depuro movimientos por todos los usuarios", user);
        }
        public void consultausuario(DataGridView dgauditoria)//esto es para llenar con usuarios
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("select * from vauditoria where usuario=@user and fecha BETWEEN @dateTimePicker1 AND @dateTimePicker2 order by fecha", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@user", cboxuser.SelectedValue.ToString());
            cm.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgauditoria.DataSource = dt;
            if (!(dt.Rows.Count > 0))
            {
                MessageBox.Show("No se encontraron resultados", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btneliminarregistro.Enabled = false;

            }
            else
            {
                btneliminarregistro.Enabled = true;
            }
            Clases.globales.auditoria("Depuro movimientos por usuario especifico", user);

        }

        public void eliminousuario()//esto es para llenar con usuarios
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("delete from vauditoria where usuario=@user and fecha BETWEEN @dateTimePicker1 AND @dateTimePicker2", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@user", cboxuser.SelectedValue.ToString());
            cm.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            
            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgauditoria.DataSource = dt;
                cm.ExecuteNonQuery();
                MessageBox.Show("Registro por usuario eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btneliminarregistro.Enabled = false;
                Clases.globales.auditoria("Elimino movimientos por usuario especifico", user);
            }
            

        }
        public void eliminotodo()//esto es para lenar el datagrid con TODOS
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            SqlCommand cm = new SqlCommand("delete from vauditoria where fecha BETWEEN @dateTimePicker1 AND @dateTimePicker2 ", conexion);
            cm.Parameters.Clear();
            cm.Parameters.AddWithValue("@dateTimePicker1", dateTimePicker1.Value.Date.Add(new TimeSpan(0, 0, 0)));
            cm.Parameters.AddWithValue("@dateTimePicker2", dateTimePicker2.Value.Date.Add(new TimeSpan(23, 59, 59)));
            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgauditoria.DataSource = dt;
                cm.ExecuteNonQuery();
                MessageBox.Show("Registro de todo eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btneliminarregistro.Enabled = false;
                Clases.globales.auditoria("Elimino movimientos de usuarios en general ", user);
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (rdbtntodos.Checked)
            {
                consultatodo(dgauditoria);

            }
            if (rdbtnusuario.Checked)
            {
                consultausuario(dgauditoria);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
        }

        private void rdbtntodos_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtntodos.Checked)
            {
                btnbuscar.Enabled = true;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgauditoria.DataSource = null;
        }

        private void btneliminarregistro_Click(object sender, EventArgs e)
        {
            if (rdbtntodos.Checked)
            {
                eliminotodo();

            }
            if (rdbtnusuario.Checked)
            {
                eliminousuario();
            }
        }
        
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if(rdbtntodo.Checked && rdbtnpantalla.Checked)
            {
                Formas.frmreporte r = new Formas.frmreporte();
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\Escolar\Informes\reportetodousuario.rpt");
                rep.SetParameterValue("@fecha1", fecha1.Value.Date.Add(new TimeSpan(0, 0, 0)));
                rep.SetParameterValue("@fecha2", fecha2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                r.crystalReportViewer1.ReportSource = rep;
                r.Show();
                Clases.globales.auditoria("Reviso informes por todos los usuarios ", user);
            }
            if(rdbtnusuarios.Checked && rdbtnpantalla.Checked)
            {
                Formas.frmreporte r = new Formas.frmreporte();
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\Escolar\Informes\reporteusuarios.rpt");
                rep.SetParameterValue("@usuario", cboxuse.SelectedValue.ToString());
                rep.SetParameterValue("@fecha1", fecha1.Value.Date.Add(new TimeSpan(0, 0, 0)));
                rep.SetParameterValue("@fecha2", fecha2.Value.Date.Add(new TimeSpan(23, 59, 59)));
                r.crystalReportViewer1.ReportSource = rep;
                r.Show();
                Clases.globales.auditoria("Reviso informes por usuario en especifico ", user);
            }
        }

        private void de_ValueChanged(object sender, EventArgs e)
        {
            fecha2.MinDate = fecha1.Value;
        }

        private void hasta_ValueChanged(object sender, EventArgs e)
        {
           fecha1.MaxDate = fecha2.Value;
        }

        private void rdbtnusuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnusuarios.Checked)
            {
                cboxuse.Visible = true;
                llenarcboxuse();

            }
            else
            {
                cboxuse.Visible = false;

            }
        }
    }
}
