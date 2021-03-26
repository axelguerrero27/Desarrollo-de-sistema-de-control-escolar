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
    public partial class frmboletas : Form
    {
        public frmboletas()
        {
            InitializeComponent();
        }

        private void frmboletas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmenu x = new frmmenu();
            x.Show();
        }
    }
}
