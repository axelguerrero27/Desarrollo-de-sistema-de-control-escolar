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
    public partial class frmmaestros : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        int estatus;
        string usuario;
        string nvl;
        public frmmaestros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de maestros", usuario);
        }

        

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "select * from maestros where ma_id=@ma_id";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ma_id", txtid.Text);
                comando.Parameters.AddWithValue("@ma_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@ma_apellidopat", txtappaterno.Text);
                comando.Parameters.AddWithValue("@ma_apellidomat", txtapmaterno.Text);
                comando.Parameters.AddWithValue("@ma_sexo", cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@ma_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@ma_localidad", cboxlocalidad.SelectedIndex);
                comando.Parameters.AddWithValue("@ma_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@ma_email", txtemail.Text);
                comando.Parameters.AddWithValue("@ma_rfc", txtrfc.Text);

                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    txtid.Text = leer["ma_id"].ToString();
                    txtnombre.Text = leer["ma_nombre"].ToString();
                    txtappaterno.Text = leer["ma_apellidopat"].ToString();
                    txtapmaterno.Text = leer["ma_apellidomat"].ToString();
                    cboxsexo.SelectedIndex = int.Parse(leer["ma_sexo"].ToString());
                    txtdomicilio.Text = leer["ma_domicilio"].ToString();
                    cboxlocalidad.SelectedValue= leer["ma_localidad"].ToString();
                    txttelefono.Text = leer["ma_telefono"].ToString();
                    txtemail.Text = leer["ma_email"].ToString();
                    txtrfc.Text = leer["ma_rfc"].ToString();
                    
                    estatus = int.Parse(leer["ma_estatus"].ToString());
                    if (estatus == 0)
                    {
                        MessageBox.Show("El maestro esta dado de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        txtid.Focus();
                        deshabilitar();
                        limpiar();
                    }
                    else { habilitar(); }
                    
                    Clases.globales.auditoria("Consulto maestros", usuario);

                }
                else
                {
                    if (MessageBox.Show("Maestro/a no registrado/a, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        habilitar();

                    }
                    else
                    {
                        txtid.Clear();
                        txtid.Focus();
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
            lblid.Enabled = false;
            txtid.Enabled = false;
            lblnombre.Enabled = true;
            txtnombre.Enabled = true;
            lblappaterno.Enabled = true;
            txtappaterno.Enabled = true;
            lblapmaterno.Enabled = true;
            txtapmaterno.Enabled = true;
            lblsexo.Enabled = true;
            cboxsexo.Enabled = true;
            lbldomicilio.Enabled = true;
            txtdomicilio.Enabled = true;
            lbllocalidad.Enabled = true;
            cboxlocalidad.Enabled = true;
            lblrfc.Enabled = true;
            txtrfc.Enabled = true;
            lbltelefono.Enabled = true;
            txttelefono.Enabled = true;
            lblemail.Enabled = true;
            txtemail.Enabled = true;
            btnguardar.Enabled = true;
            btnelininar.Enabled = true;
            txtnombre.Focus();
        }

        private void deshabilitar()
        {
            lblid.Enabled = true;
            txtid.Enabled = true;
            lblnombre.Enabled = false;
            txtnombre.Enabled = false;
            lblappaterno.Enabled = false;
            txtappaterno.Enabled = false;
            lblapmaterno.Enabled = false;
            txtapmaterno.Enabled = false;
            lblsexo.Enabled = false;
            cboxsexo.Enabled = false;
            lbldomicilio.Enabled = false;
            txtdomicilio.Enabled = false;
            lbllocalidad.Enabled = false;
            cboxlocalidad.Enabled = false;
            lblrfc.Enabled = false;
            txtrfc.Enabled = false;
            lbltelefono.Enabled = false;
            txttelefono.Enabled = false;
            lblemail.Enabled = false;
            txtemail.Enabled = false;
            btnguardar.Enabled = false;
            btnelininar.Enabled = false;
            txtid.Focus();
        }

        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtappaterno.Clear();
            txtapmaterno.Clear();
            cboxsexo.SelectedIndex = 0;
            txtdomicilio.Clear();
            cboxlocalidad.SelectedIndex = 0;
            txttelefono.Clear();
            txtemail.Clear();
            txtrfc.Clear();
        }

        private void llenarsexo()
        {
            cboxsexo.Items.Add("Seleccione");
            cboxsexo.Items.Add("Hombre");
            cboxsexo.Items.Add("Mujer");
            cboxsexo.SelectedIndex = 0;
        }

        private void frmmaestros_Load(object sender, EventArgs e)
        {
            llenarsexo();
            llenarbusqueda();
            llenarlocalidad();
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a formulario maestros", usuario);
        }

        

        private void llenarbusqueda()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from vmaestros";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxbusqueda.DataSource = dt;
            //defino los campos de la tabla
            this.cboxbusqueda.ValueMember = "ma_id";
            this.cboxbusqueda.DisplayMember = "Nombre completo";
            //cierro conexion
            conexion.Close();
        }

        private void llenarlocalidad()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from localidades";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxlocalidad.DataSource = dt;
            //defino los campos de la tabla
            this.cboxlocalidad.ValueMember = "loc_nombre";
            this.cboxlocalidad.DisplayMember = "loc_nombre";
            //cierro conexion
            conexion.Close();
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cboxbusqueda.Visible = true;
            llenarbusqueda();
        }

        private void cboxbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtid.Text = this.cboxbusqueda.SelectedValue.ToString();
                cboxbusqueda.Visible = false;
                txtid.Enabled = true;
                txtid.Focus();
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
                string query = "insert into maestros values (@ma_id, @ma_nombre, @ma_apellidopat, @ma_apellidomat, @ma_sexo, @ma_domicilio, @ma_localidad, @ma_telefono, @ma_email,@ma_rfc,1)";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ma_id", this.txtid.Text);
                comando.Parameters.AddWithValue("@ma_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@ma_apellidopat", this.txtappaterno.Text);
                comando.Parameters.AddWithValue("@ma_apellidomat", this.txtapmaterno.Text);
                comando.Parameters.AddWithValue("@ma_sexo", this.cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@ma_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@ma_localidad", this.cboxlocalidad.Text);
                comando.Parameters.AddWithValue("@ma_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@ma_email", this.txtemail.Text);
                comando.Parameters.AddWithValue("@ma_rfc", this.txtrfc.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MAESTRO GUARDADO CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deshabilitar();
                limpiar();
                Clases.globales.auditoria("Añadio maestro", usuario);

            }
            else
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "update  maestros set ma_nombre=@ma_nombre, ma_apellidopat=@ma_apellidopat, ma_apellidomat=@ma_apellidomat, ma_sexo=@ma_sexo, ma_domicilio=@ma_domicilio, ma_localidad=@ma_localidad, ma_telefono=@ma_telefono, ma_email=@ma_email, ma_rfc=@ma_rfc where ma_id=@ma_id  ";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ma_id", this.txtid.Text);
                comando.Parameters.AddWithValue("@ma_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@ma_apellidopat", this.txtappaterno.Text);
                comando.Parameters.AddWithValue("@ma_apellidomat", this.txtapmaterno.Text);
                comando.Parameters.AddWithValue("@ma_sexo", this.cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@ma_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@ma_localidad", this.cboxlocalidad.Text);
                comando.Parameters.AddWithValue("@ma_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@ma_email", this.txtemail.Text);
                comando.Parameters.AddWithValue("@ma_rfc", this.txtrfc.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICADO CON EXITO!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deshabilitar();
                limpiar();
                Clases.globales.auditoria("Modifico maestros", usuario);
                
            }
            conexion.Close();
        }

        private void btnelininar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            //se abre la conexion
            conexion.Open();
            string query = "update  maestros set ma_estatus=0 where ma_id=@ma_id  ";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@ma_id", txtid.Text);

            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Maestro eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Elimino maestros", usuario);
            }
            deshabilitar();
            limpiar();
            conexion.Close();
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                deshabilitar();

                
            }
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtappaterno.Focus();
            }
        }

        private void txtappaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtapmaterno.Focus();
            }
        }

        private void txtapmaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxsexo.Focus();
            }
        }

        private void cboxsexo_KeyDown(object sender, KeyEventArgs e)
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
                cboxlocalidad.Focus();
            }
        }

        private void txtlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtrfc.Focus();
            }
        }

        private void txtrfc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txttelefono.Focus();
            }
        }

        private void txttelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtemail.Focus();
            }
        }

        private void cboxlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtrfc.Focus();
            }
        }
    }
}
