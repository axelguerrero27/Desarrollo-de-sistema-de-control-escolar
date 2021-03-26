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
    public partial class frmacercade : Form
    {
        public frmacercade()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmmenu x = new frmmenu();
            x.Show();
        }
    }
}
