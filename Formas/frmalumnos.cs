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
    public partial class frmalumnos : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        int existe;
        int estatus;
        string usuario;
        string nvl;
        public frmalumnos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de alumnos", usuario);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            cboxbuscar.Visible = true;
            llenarbusqueda();
        }

        private void frmalumnos_Click(object sender, EventArgs e)
        {
            cboxbuscar.Visible = false;
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "select * from alumnos where al_id=@al_id";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@al_id", txtid.Text);
                comando.Parameters.AddWithValue("@al_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@al_apellidopat", txtpaterno.Text);
                comando.Parameters.AddWithValue("@al_apellidomat", txtmaterno.Text);
                comando.Parameters.AddWithValue("@al_sexo", cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_curp", txtcurp.Text);
                comando.Parameters.AddWithValue("@al_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@al_localidad", cboxlocalidad.SelectedIndex);
                comando.Parameters.AddWithValue("@al_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@al_email", txtemail.Text);
                comando.Parameters.AddWithValue("@al_grupo", cboxgrupo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_grado", cboxgrado.SelectedIndex);
                comando.Parameters.AddWithValue("@al_turno", cboxturno.SelectedIndex);
                comando.Parameters.AddWithValue("@al_padre", txtnombrepadre.Text);
                comando.Parameters.AddWithValue("@al_ocupacionpadre", txtocupacion.Text);
                comando.Parameters.AddWithValue("@al_telefonopadre", txttelefonopadre.Text);
                comando.Parameters.AddWithValue("@al_emailpadre", txtemailpadre.Text);

                //asigno a leer el sqldatareader para leer el registro
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    existe = 1;
                    
                    txtid.Text = leer["al_id"].ToString();
                    txtnombre.Text = leer["al_nombre"].ToString();
                    txtnombre.Focus();
                    txtpaterno.Text = leer["al_apellidopat"].ToString();
                    txtmaterno.Text = leer["al_apellidomat"].ToString();
                    cboxsexo.SelectedIndex = int.Parse(leer["al_sexo"].ToString());
                    txtcurp.Text = leer["al_curp"].ToString();
                    txtdomicilio.Text = leer["al_domicilio"].ToString();
                    cboxlocalidad.SelectedValue = leer["al_localidad"].ToString();
                    txttelefono.Text = leer["al_telefono"].ToString();
                    txtemail.Text = leer["al_email"].ToString();
                    cboxgrupo.SelectedIndex = int.Parse(leer["al_grupo"].ToString());
                    cboxgrado.SelectedIndex = int.Parse(leer["al_grado"].ToString());
                    cboxturno.SelectedIndex = int.Parse(leer["al_turno"].ToString());
                    txtnombrepadre.Text = leer["al_padre"].ToString();
                    txtocupacion.Text = leer["al_ocupacionpadre"].ToString();
                    txttelefonopadre.Text = leer["al_telefonopadre"].ToString();
                    txtemailpadre.Text = leer["al_emailpadre"].ToString();
                    estatus = int.Parse(leer["al_estatus"].ToString());
                    if (estatus == 0)
                    {
                        MessageBox.Show("El alumno esta dado de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtid.Focus();
                        deshabilitar();
                        limpiar();
                    }
                    else { habilitar(); }

                    Clases.globales.auditoria("Consulto alumnos", usuario);

                }
                else
                {
                    if (MessageBox.Show("Alumno/a no registrado/a, deseas agregar?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        habilitar();
                        txtnombre.Focus();
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
        private void deshabilitar()
        {
            lblid.Enabled = true;
            txtid.Enabled = true;
            lblnombre.Enabled=false;
            txtnombre.Enabled=false;
            lblpaterno.Enabled=false;
            txtpaterno.Enabled=false;
            lblmaterno.Enabled=false;
            txtmaterno.Enabled=false;
            lblsexo.Enabled=false;
            cboxsexo.Enabled=false;
            lblcurp.Enabled=false;
            txtcurp.Enabled=false;
            lbldomicilio.Enabled=false;
            txtdomicilio.Enabled=false;
            lbllocalidad.Enabled=false;
            cboxlocalidad.Enabled=false;
            lbltelefono.Enabled=false;
            txttelefono.Enabled=false;
            lblemail.Enabled=false;
            txtemail.Enabled=false;
            lblgrupo.Enabled=false;
            cboxgrupo.Enabled=false;
            lblgrado.Enabled=false;
            cboxgrado.Enabled=false;
            lblturno.Enabled=false;
            cboxturno.Enabled=false;
            lblnombrepadre.Enabled=false;
            txtnombrepadre.Enabled=false;
            lblocupacion.Enabled=false;
            txtocupacion.Enabled=false;
            lbltelefonopadre.Enabled=false;
            txttelefonopadre.Enabled=false;
            lblemailpadre.Enabled=false;
            txtemailpadre.Enabled=false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;

        }
        private void habilitar()
        {
            lblid.Enabled = false;
            txtid.Enabled = false;
            lblnombre.Enabled = true;
            txtnombre.Enabled = true;
            lblpaterno.Enabled = true;
            txtpaterno.Enabled = true;
            lblmaterno.Enabled = true;
            txtmaterno.Enabled = true;
            lblsexo.Enabled = true;
            cboxsexo.Enabled = true;
            lblcurp.Enabled = true;
            txtcurp.Enabled = true;
            lbldomicilio.Enabled = true;
            txtdomicilio.Enabled = true;
            lbllocalidad.Enabled = true;
            cboxlocalidad.Enabled = true;
            lbltelefono.Enabled = true;
            txttelefono.Enabled = true;
            lblemail.Enabled = true;
            txtemail.Enabled = true;
            lblgrupo.Enabled = true;
            cboxgrupo.Enabled =true;
            lblgrado.Enabled = true;
            cboxgrado.Enabled = true;
            lblturno.Enabled = true;
            cboxturno.Enabled = true;
            lblnombrepadre.Enabled = true;
            txtnombrepadre.Enabled = true;
            lblocupacion.Enabled = true;
            txtocupacion.Enabled = true;
            lbltelefonopadre.Enabled = true;
            txttelefonopadre.Enabled = true;
            lblemailpadre.Enabled = true;
            txtemailpadre.Enabled = true;
            btnguardar.Enabled = true;
            btneliminar.Enabled = true;
        }
        private void limpiar()
        {
            
            txtid.Clear();
            txtnombre.Clear();
            txtpaterno.Clear();
            txtmaterno.Clear();
            cboxsexo.SelectedIndex = 0;
            txtcurp.Clear();
            txtdomicilio.Clear();
            cboxlocalidad.SelectedIndex = 0;
            txttelefono.Clear();
            txtemail.Clear();
            cboxgrupo.SelectedIndex = 0;
            cboxgrado.SelectedIndex = 0;
            cboxturno.SelectedIndex = 0;
            txtnombrepadre.Clear();
            txtocupacion.Clear();
            txttelefonopadre.Clear();
            txtemailpadre.Clear();
        }
        private void llenarsexo()
        {
            cboxsexo.Items.Add("Seleccione");
            cboxsexo.Items.Add("Hombre");
            cboxsexo.Items.Add("Mujer");
            cboxsexo.SelectedIndex = 0;
        }
        private void llenarbusqueda()
        {
            DataTable dt = new DataTable();//dt=data table
            //establece conexion
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            conexion.Open();
            string query = "select * from valumnos";
            SqlCommand comando = new SqlCommand(query, conexion);
            //defino sql adapter
            SqlDataAdapter da = new SqlDataAdapter(comando); //da= data adapter
            //lleno el data  table
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxbuscar.DataSource = dt;
            //defino los campos de la tabla
            this.cboxbuscar.ValueMember = "al_id";
            this.cboxbuscar.DisplayMember = "Nombre completo";
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
        private void llenargrupo()
        {
            cboxgrupo.Items.Add("Seleccione");
            cboxgrupo.Items.Add("A");
            cboxgrupo.Items.Add("B");
            cboxgrupo.SelectedIndex = 0;
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
        private void llenarturno()
        {
            cboxturno.Items.Add("Seleccione");
            cboxturno.Items.Add("Matutino");
            cboxturno.Items.Add("Vespertino");
            cboxturno.SelectedIndex = 0;
        }
        private void frmalumnos_Load(object sender, EventArgs e)
        {
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a formulario de alumnos", usuario);
            llenarsexo();
            llenarbusqueda();
            llenarlocalidad();
            llenargrupo();
            llenargrado();
            llenarturno();
        }

        private void cboxbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtid.Text = this.cboxbuscar.SelectedValue.ToString();
                cboxbuscar.Visible = false;
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
                string query = "insert into alumnos values (@al_id, @al_nombre, @al_apellidopat, @al_apellidomat, @al_sexo, @al_curp, @al_domicilio, @al_localidad, @al_telefono, @al_email, @al_grupo, @al_grado, @al_turno, @al_padre, @al_ocupacionpadre, @al_telefonopadre, @al_emailpadre,1)";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@al_id", this.txtid.Text);
                comando.Parameters.AddWithValue("@al_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@al_apellidopat", this.txtpaterno.Text);
                comando.Parameters.AddWithValue("@al_apellidomat", this.txtmaterno.Text);
                comando.Parameters.AddWithValue("@al_sexo", this.cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_curp", this.txtcurp.Text);
                comando.Parameters.AddWithValue("@al_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@al_localidad", this.cboxlocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@al_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@al_email", this.txtemail.Text);
                comando.Parameters.AddWithValue("@al_grupo", this.cboxgrupo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_grado", this.cboxgrado.SelectedIndex);
                comando.Parameters.AddWithValue("@al_turno", this.cboxturno.SelectedIndex);
                comando.Parameters.AddWithValue("@al_padre", this.txtnombrepadre.Text);
                comando.Parameters.AddWithValue("@al_ocupacionpadre", this.txtocupacion.Text);
                comando.Parameters.AddWithValue("@al_telefonopadre", this.txttelefonopadre.Text);
                comando.Parameters.AddWithValue("@al_emailpadre", this.txtemailpadre.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("ALUMNO GUARDADO CON EXITO!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deshabilitar();
                limpiar();
                Clases.globales.auditoria("Añadio alumno", usuario);

            }
            else
            {
                objconexion = new Clases.conexion();
                conexion = new SqlConnection(objconexion.conn());
                //se abre la conexion
                conexion.Open();
                string query = "update  alumnos set al_nombre=@al_nombre, al_apellidopat=@al_apellidopat, al_apellidomat=@al_apellidomat, al_sexo=@al_sexo, al_curp=@al_curp, @al_domicilio=@al_domicilio, al_localidad=@al_localidad, al_telefono=@al_telefono, al_email=@al_email, al_grupo=@al_grupo, al_grado=@al_grado, al_turno=@al_turno, al_padre=@al_padre, al_ocupacionpadre=@al_ocupacionpadre, al_telefonopadre=@al_telefonopadre, al_emailpadre=@al_emailpadre where al_id=@al_id  ";
                //asigo a comando el sql command
                SqlCommand comando = new SqlCommand(query, conexion);
                //inicializo cualquier parametro definido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@al_id", this.txtid.Text);
                comando.Parameters.AddWithValue("@al_nombre", this.txtnombre.Text);
                comando.Parameters.AddWithValue("@al_apellidopat", this.txtpaterno.Text);
                comando.Parameters.AddWithValue("@al_apellidomat", this.txtmaterno.Text);
                comando.Parameters.AddWithValue("@al_sexo", this.cboxsexo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_curp", this.txtcurp.Text);
                comando.Parameters.AddWithValue("@al_domicilio", this.txtdomicilio.Text);
                comando.Parameters.AddWithValue("@al_localidad", this.cboxlocalidad.SelectedValue);
                comando.Parameters.AddWithValue("@al_telefono", this.txttelefono.Text);
                comando.Parameters.AddWithValue("@al_email", this.txtemail.Text);
                comando.Parameters.AddWithValue("@al_grupo", this.cboxgrupo.SelectedIndex);
                comando.Parameters.AddWithValue("@al_grado", this.cboxgrado.SelectedIndex);
                comando.Parameters.AddWithValue("@al_turno", this.cboxturno.SelectedIndex);
                comando.Parameters.AddWithValue("@al_padre", this.txtnombrepadre.Text);
                comando.Parameters.AddWithValue("@al_ocupacionpadre", this.txtocupacion.Text);
                comando.Parameters.AddWithValue("@al_telefonopadre", this.txttelefonopadre.Text);
                comando.Parameters.AddWithValue("@al_emailpadre", this.txtemailpadre.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("MODIFICADO CON EXITO!!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deshabilitar();
                limpiar();
                Clases.globales.auditoria("Modifico alumnos", usuario);

            }
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new Clases.conexion();
            conexion = new SqlConnection(objconexion.conn());
            //se abre la conexion
            conexion.Open();
            string query = "update  alumnos set al_estatus=0 where al_id=@al_id  ";
            //asigo a comando el sql command
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@al_id", txtid.Text);

            if (MessageBox.Show("Seguro que quiere eliminar??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Alumno eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clases.globales.auditoria("Elimino alumnos", usuario);
            }
            deshabilitar();
            limpiar();
            conexion.Close();
        }

        private void txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtpaterno.Focus();
            }
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                deshabilitar();
                txtid.Focus();
            }
        }

        private void txtpaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtmaterno.Focus();
            }
        }

        private void txtmaterno_KeyDown(object sender, KeyEventArgs e)
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
                txtcurp.Focus();
            }
        }

        private void txtcurp_KeyDown(object sender, KeyEventArgs e)
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
                txttelefono.Focus();
            }
        }

        private void txttelefono_KeyDown(object sender, KeyEventArgs e)
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

        private void cboxlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxgrado.Focus();
            }
        }

        private void cboxgrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxgrupo.Focus();
            }
        }

        private void cboxgrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxturno.Focus();
            }
        }

        private void cboxturno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtnombrepadre.Focus();
            }
        }

        private void txtnombrepadre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtocupacion.Focus();
            }
        }

        private void txttelefonopadre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtemail.Focus();
            }
        }

        private void txtocupacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txttelefonopadre.Focus();
            }
        }
    }
}
