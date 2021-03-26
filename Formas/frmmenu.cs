using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escolar.Formas
{
    public partial class frmmenu : Form
    {
        string usuario;
        string nvl;
        public frmmenu()
        {
            InitializeComponent();
        }

       
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmlogin x = new frmlogin();
            x.Show();
            Clases.globales.auditoria("Salio del sistema", usuario);
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmalumnos x = new Formas.frmalumnos();
            x.Show();
            this.Hide();
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmmaestros x = new Formas.frmmaestros();
            x.Show();
            this.Hide();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmmaterias x = new Formas.frmmaterias();
            x.Show();
            this.Hide();
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Formas.frmdatosgen x = new Formas.frmdatosgen();
            x.Show();
            
            this.Hide();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmcalificaciones x = new Formas.frmcalificaciones();
            x.Show();
            this.Hide();
        }

        private void listaDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmlistasalumnos x = new Formas.frmlistasalumnos();
            x.Show();
            this.Hide();
        }

        private void mejoresAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmevaluacion x = new Formas.frmevaluacion();
            x.Show();
            this.Hide();
        }

        private void boletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmcatalogos x = new Formas.frmcatalogos();
            x.Show();
            this.Hide();
        }

        private void respaldoBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmrespaldo x = new Formas.frmrespaldo();
            x.Show();
            this.Hide();
        }

        private void sistemaAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmacercade x = new Formas.frmacercade();
            x.Show();
            this.Hide();
        }

        private void auditoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formas.frmauditoria x = new Formas.frmauditoria();
            x.Show();
            this.Hide();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmlocalidad x = new Formas.frmlocalidad();
            x.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmlogin x = new frmlogin();
            x.Show();
            usuario = frmlogin.usuario;
            Clases.globales.auditoria("Salio del sistema", usuario);
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmcalificaciones x = new Formas.frmcalificaciones();
            x.Show();
            this.Hide();
        }

        private void asignacionDeMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmasignacionmaestro x = new Formas.frmasignacionmaestro();
            x.Show();
            this.Hide();
        }

        private void cargaMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formas.frmcargameteria x = new Formas.frmcargameteria();
            x.Show();
            this.Hide();
        }
    }
}
