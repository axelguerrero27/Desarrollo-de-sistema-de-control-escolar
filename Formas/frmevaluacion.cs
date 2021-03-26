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
    public partial class frmevaluacion : Form
    {
        string usuario;
        string nvl;
        public frmevaluacion()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de informes de evaluaciones", usuario);
        }

        private void frmevaluacion_Load(object sender, EventArgs e)
        {
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a consultar informe de evaluaciones", usuario);
        }
    }
}
