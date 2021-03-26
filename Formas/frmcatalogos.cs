using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmcatalogos : Form
    {
        string usuario;
        string nvl;
        public frmcatalogos()
        {
            InitializeComponent();
        }

        private void frmcatalogos_Load(object sender, EventArgs e)
        {
            cboxgrado.Items.Add("Seleccione");
            cboxgrado.Items.Add("1");
            cboxgrado.Items.Add("2");
            cboxgrado.Items.Add("3");
            cboxgrado.Items.Add("4");
            cboxgrado.Items.Add("5");
            cboxgrado.Items.Add("6");
            cboxgrado.SelectedIndex = 0;
            usuario = frmlogin.usuario;
            nvl = frmlogin.nvl;
            Clases.globales.auditoria("Ingreso a consultar informe de catalogos", usuario);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Formas.frmmenu x = new Formas.frmmenu();
            x.Text = "Menu principal VERSION 1.0 USUARIO: " + usuario + " " + "NIVEL: " + nvl;
            x.Show();
            Clases.globales.auditoria("Salio de informes de catalogos", usuario);
        }

        

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (rdbtnmaestros.Checked && rdbtnpantalla.Checked && rdbtnclave.Checked)
            {
                Informes.maestrosporclave grupos = new Informes.maestrosporclave();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de maestros ordenado por clave", usuario);
            }
            if (rdbtnmaestros.Checked && rdbtnpantalla.Checked && rbtnnombre.Checked)
            {
                Informes.maestrospornombre grupos = new Informes.maestrospornombre();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de maestros ordenado por nombre", usuario);
            }
            if (rdbtnlocalidades.Checked && rdbtnpantalla.Checked && rdbtnclave.Checked)
            {
                Informes.localidadesporclave grupos = new Informes.localidadesporclave();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de localidades ordenado por clave", usuario);
            }
            if (rdbtnlocalidades.Checked && rdbtnpantalla.Checked && rbtnnombre.Checked)
            {
                Informes.localidadespornombre grupos = new Informes.localidadespornombre();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de localidades ordenado por nombre", usuario);
            }
            if (rdbtnmateria.Checked && rdbtnpantalla.Checked && rdbtnclave.Checked)
            {
                Informes.materiasporclave grupos = new Informes.materiasporclave();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de materia ordenado por clave", usuario);
            }
            if (rdbtnmateria.Checked && rdbtnpantalla.Checked && rbtnnombre.Checked)
            {
                Informes.materiaspornombre grupos = new Informes.materiaspornombre();
                Formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = grupos;
                reporte.ShowDialog();
                Clases.globales.auditoria("Consulto informe de materias ordenado por nombre", usuario);
            }
            if (rdbtnmateria.Checked && rdbtnpantalla.Checked && rbtngrupo.Checked)
            {
                Formas.frmreporte r = new Formas.frmreporte();
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\Escolar\Informes\materiasporgrado.rpt");
                rep.SetParameterValue("@grado", cboxgrado.SelectedIndex.ToString());
                r.crystalReportViewer1.ReportSource = rep;
                r.Show();
                Clases.globales.auditoria("Consulto informe de materias de grupo", usuario);
            }
        }

        private void rdbtnmateria_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbtnmateria.Checked)
            {
                rbtngrupo.Visible = true;
                
            }
            else
            {
                rbtngrupo.Visible = false;
                
            }
        }

        private void rbtngrupo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtngrupo.Checked)
            {
                cboxgrado.Visible =true;
            }
            else
            {
                cboxgrado.Visible=false;
            }
        }
    }
}
