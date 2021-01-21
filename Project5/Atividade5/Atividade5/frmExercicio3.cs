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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao;
            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);   

            while(posicao >=0)

        }
    }
}
