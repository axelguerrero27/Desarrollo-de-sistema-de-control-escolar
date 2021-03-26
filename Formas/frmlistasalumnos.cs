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
    public partial class frmlistasalumnos : Form
    {
        Clases.conexion objconexion;
        SqlConnection conexion;
        string usuario;
        string nvl;
        public frmlistasalumnos()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de informes de listas de alumnos", usuario);
        }

        private void frmlistasalumnos_Load(object sender, EventArgs e)
        {
            llenargrado();
            llenarasignatura();
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a consultar informe de listas de alumnos", usuario);
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
            this.cboxmateria.DataSource = dt;
            //defino los campos de la tabla
            this.cboxmateria.ValueMember = "mat_id";
            this.cboxmateria.DisplayMember = "mat_nombre";
            //cierro conexion
            conexion.Close();
        }

        private void rdbtngrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtngrado.Checked)
            {
                cboxgrado.Visible = true;
            }
            else
            {
                cboxgrado.Visible = false;
            }
        }

        private void rdbtnmateria_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnmateria.Checked)
            {
                cboxmateria.Visible = true;
            }
            else
            {
                cboxmateria.Visible = false;
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if(rdbtntodos.Checked && rdbtnpantalla.Checked)
            {
                Informes.todosalumnos grupos = new Informes.todosalumnos();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto listas de todos los inscritos", usuario);
            }
            if(rdbtngrado.Checked && rdbtnpantalla.Checked)
            {
                Formas.frmreporte r = new Formas.frmreporte();
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\Escolar\Informes\alumnosporgrado.rpt");
                rep.SetParameterValue("@grado", cboxgrado.SelectedIndex.ToString());
                r.crystalReportViewer1.ReportSource = rep;
                r.Show();
                Clases.globales.auditoria("Consulto listas por grupo", usuario);
            }
            if (rdbtnmateria.Checked && rdbtnpantalla.Checked)
            {
                Formas.frmreporte r = new Formas.frmreporte();
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\Escolar\Informes\alumnospormateria.rpt");
                rep.SetParameterValue("@materia", cboxmateria.Text);
                r.crystalReportViewer1.ReportSource = rep;
                r.Show();
                Clases.globales.auditoria("Consulto listas por materia", usuario);
            }
        }
    }
}
