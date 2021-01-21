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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {

            //o true no compare é para ignorar case sensitivy
            if (string.Compare(txtPalavra2.Text, txtPalavra1.Text, true) == 0)
                MessageBox.Show("A palavra 1 e a Palavra 2 são iguais");
            else
                MessageBox.Show("A palavra 1 e 2 são diferentes");
        }

        private void btnInsere1_Click(object sender, EventArgs e)
        {
            //Como a variavel é do tipo INT ela vai fazer uma divisão inteira ex: 5/2 = 2
            //caso queira pegar uam letra a mais mude para double e considere a regra do slide da professora
            int meio = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0,meio) + txtPalavra1.Text + 
                               txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);
           

        }

        private void btnInsere2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");   
        }
    }
}
