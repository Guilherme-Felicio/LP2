using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("você clicou no copiar");
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio2 frm2 = new frmExercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
