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
    public partial class frmmaterias : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        int estatus;
        string usuario;
        string nvl;
        public frmmaterias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de materias", usuario);
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "select * from materias where mat_id=@mat_id";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@mat_id", txtclave.Text);
                comando.Parameters.AddWithValue("@mat_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@mat_grado", cboxgrado.SelectedIndex);
                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtclave.Text = leer["mat_id"].ToString();
                    txtnombre.Text = leer["mat_nombre"].ToString();
                    cboxgrado.SelectedIndex=int.Parse(leer["mat_grado"].ToString());
                    estatus = int.Parse(leer["mat_estatus"].ToString());
                    if (estatus == 0)
                    {
                        MessageBox.Show("La materia esta dado de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtclave.Focus();
                        desabilitar();
                        limpiar();
                    }
                    else { habilitar(); }
                    
                    Clases.globales.auditoria("Consulto materias", usuario);

                }
                else
                {
                    if (MessageBox.Show("Materia no registrada, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        habilitar();
                        txtclave.Enabled = false;
                        lblclave.Enabled = false;
                        txtnombre.Focus();

                    }
                    else
                    {
                        txtclave.Clear();
                        txtclave.Focus();
                    }

                }
                conexion.Close();
            }
            else
            {


            }
        }
        private void habilitar()
        {
            lblnombre.Enabled = true;
            txtnombre.Enabled = true;
            lblgrado.Enabled = true;
            cboxgrado.Enabled = true;
            txtclave.Enabled = false;
            lblclave.Enabled = true;
            btnguardar.Enabled = true;
            btneliminar.Enabled = true;
        }
        private void desabilitar()
        {
            lblnombre.Enabled = false;
            txtnombre.Enabled = false;
            lblgrado.Enabled = false;
            cboxgrado.Enabled = false;
            txtclave.Enabled = true;
            lblclave.Enabled = true;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void limpiar()
        {
            txtclave.Clear();
            txtnombre.Clear();
            cboxgrado.SelectedIndex = 0;
        }
        private void frmmaterias_Load(object sender, EventArgs e)
        {
            cboxgrado.Items.Add("Seleccione");
            cboxgrado.Items.Add("1");
            cboxgrado.Items.Add("2");
            cboxgrado.Items.Add("3");
            cboxgrado.Items.Add("4");
            cboxgrado.Items.Add("5");
            cboxgrado.Items.Add("6");
            cboxgrado.SelectedIndex = 0;
            txtclave.Focus();
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a materias", usuario);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cboxbuscar.Visible = true;
            llenarcbox();
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from materias where mat_estatus=1 order by mat_grado";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxbuscar.DataSource = dt;
            //defino los campos de la tabla
            this.cboxbuscar.ValueMember = "mat_id";
            this.cboxbuscar.DisplayMember = "mat_nombre";
            //cierro conexion
            conexion.Close();
        }

        private void cboxbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxbuscar.SelectedValue.ToString();
                cboxbuscar.Visible = false;
                txtclave.Enabled = true; ;
                txtclave.Focus();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "insert into materias values (@mat_id,@mat_nombre, @mat_grado,1)";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@mat_id", this.txtclave.Text);
                comando.Parameters.AddWithValue("@mat_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@mat_grado", this.cboxgrado.SelectedIndex);
                comando.ExecuteNonQuery();
                MessageBox.Show("MATERIA GUARDADA CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Añadio materia", usuario);
                lblnombre.Enabled = false;
                txtnombre.Enabled = false;
                lblgrado.Enabled = false;
                cboxgrado.Enabled = false;
                txtclave.Enabled = true;
                lblclave.Enabled = true;
                txtnombre.Clear();
                cboxgrado.SelectedIndex = 0;
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
                btnguardar.Enabled = false;
                btneliminar.Enabled = false;
                Clases.globales.auditoria("Guardo materias", usuario);
            }
            else
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "update  materias set mat_nombre=@mat_nombre, mat_grado=@mat_grado where mat_id=@mat_id  ";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@mat_id", this.txtclave.Text);
                comando.Parameters.AddWithValue("@mat_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@mat_grado", this.cboxgrado.SelectedIndex);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICADO CON EXITO!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Modifico materias", usuario);
                lblnombre.Enabled = false;
                txtnombre.Enabled = false;
                lblgrado.Enabled = false;
                cboxgrado.Enabled = false;
                txtclave.Enabled = true;
                lblclave.Enabled = true;
                txtnombre.Clear();
                txtclave.Clear();
                cboxgrado.SelectedIndex = 0;
                txtclave.Enabled = true;
                txtclave.Focus();
                btnguardar.Enabled = false;
                btneliminar.Enabled = false;
            }
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            //se abre la conexion
            conexion.Open();
            string query = "update  materias set mat_estatus=0 where mat_id=@mat_id  ";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@mat_id", txtclave.Text);

            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Materia eliminada con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Elimino materias", usuario);
            }
            lblnombre.Enabled = false;
            txtnombre.Enabled = false;
            lblgrado.Enabled = false;
            cboxgrado.Enabled = false;
            txtclave.Enabled = true;
            lblclave.Enabled = true;
            txtnombre.Clear();
            cboxgrado.SelectedIndex = 0;
            txtclave.Clear();
            txtclave.Enabled = true;
            txtclave.Focus();
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            conexion.Close();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxgrado.Focus();
            }
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtclave.Clear();
                txtnombre.Clear();
                txtnombre.Enabled = false;
                lblnombre.Enabled = false;
                lblgrado.Enabled = false;
                cboxgrado.Enabled = false;
                cboxgrado.SelectedIndex = 0;
                txtclave.Enabled = true;
                lblclave.Enabled = true;
                txtclave.Focus();
                btnguardar.Enabled = false;
                btneliminar.Enabled = false;
            }
        }

        private void frmmaterias_Click(object sender, EventArgs e)
        {
            cboxbuscar.Visible = false;
        }
    }
}
