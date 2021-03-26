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
    public partial class frmlocalidad : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        string usuario;
        string nvl;
        public frmlocalidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
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
            string query = "select * from localidades where loc_status=1 order by loc_nombre";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxbuscar.DataSource = dt;
            //defino los campos de la tabla
            this.cboxbuscar.ValueMember = "loc_id";
            this.cboxbuscar.DisplayMember = "loc_nombre";
            //cierro conexion
            conexion.Close();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtid.Text))
                {
                    MessageBox.Show("ERROR: No se permite valores nulos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //no fue nulo

                    objconexion = new Clases.conexion();
                    conexion = new SqlConnection(objconexion.conn());
                    //se abre la conexion
                    conexion.Open();
                    string query = "select * from localidades where loc_id=@loc_id";
                    //asigo a comando el sql command
                    SqlCommand comando = new SqlCommand(query, conexion);
                    //inicializo cualquier parametro definido anteriormente
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@loc_id", this.txtid.Text);
                    //asigno a leer el sqldatareader para leer el registro
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {

                        habilitar();
                        txtnombre.Focus();
                        txtid.Enabled = false;
                        txtnombre.Text = leer["loc_nombre"].ToString();
                        Clases.globales.auditoria("Consulto localidades", usuario);
                    }
                    else
                    {
                        //no lo encontro y procede a agregar 

                        if (MessageBox.Show("Localidad no registrado, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                        {
                            habilitar();
                            txtnombre.Focus();
                            txtid.Enabled = false;

                        }
                        else
                        {
                            txtid.Clear();
                            txtid.Focus();
                        }

                    }
                    conexion.Close();
                }
            }
        }
        private void habilitar()
        {
            txtnombre.Enabled = true;
            lblnombre.Enabled = true;
            btnguardar.Enabled = true;
            btneliminar.Enabled = true;
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                deshabilitar();
                txtid.Enabled = true;
                txtid.Focus();
            }
        }
        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();


        }
        private void deshabilitar()
        {
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            txtnombre.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "insert into localidades values (@loc_id,@loc_nombre,1)";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@loc_id", this.txtid.Text);
                comando.Parameters.AddWithValue("@loc_nombre", this.txtnombre.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("LOCALIDAD GUARDADA CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Añadio localidad", usuario);
                deshabilitar();
                limpiar();
                txtid.Enabled = true;
                txtid.Focus();
            }
            else
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "update  localidades set loc_nombre=@loc_nombre where loc_id=@loc_id  ";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@loc_id", int.Parse(txtid.Text));
                comando.Parameters.AddWithValue("@loc_nombre", txtnombre.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICADO CON EXITO!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Modifico localidad", usuario);
                deshabilitar();
                limpiar();
                txtid.Enabled = true;
                txtid.Focus();
            }
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            //se abre la conexion
            conexion.Open();
            string query = "delete from localidades where loc_id=@loc_id  ";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@loc_id", txtid.Text);

            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Localidad eliminada con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Elimino localidad", usuario);
            }
            deshabilitar();
            txtid.Enabled = true;
            txtid.Focus();
            txtnombre.Clear();
            conexion.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de localidades", usuario);
        }

        private void cboxbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtid.Text = this.cboxbuscar.SelectedValue.ToString();
                this.txtnombre.Text = this.cboxbuscar.SelectedText.ToString();
                lblbuscar.Visible = false;
                cboxbuscar.Visible = false;
                txtid.Enabled = false;
                habilitar();
                txtnombre.Focus();
                existe = 1;
            }
        }

        private void frmlocalidad_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = false;
            cboxbuscar.Visible = false;
        }

        private void frmlocalidad_Load(object sender, EventArgs e)
        {
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a localidades", usuario);
        }
    }
}
