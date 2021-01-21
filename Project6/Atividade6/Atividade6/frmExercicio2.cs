using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n, cont;
            double h;
            h = 0;

            if (int.TryParse(txtNum.Text, out n))
                if (n != 0)
                {
                    for (cont = 1; cont <= n; cont++)
                        h = h + 1 / n;
                    MessageBox.Show("O resultado de H é: " + h);
                }
                else
                    MessageBox.Show("Nao é possivel fazer divisões por 0");

            else
                MessageBox.Show("Insira um valor válido");

                
        }
    }
}
