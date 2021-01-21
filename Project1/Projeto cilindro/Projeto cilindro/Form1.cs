using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2;
            if((double.TryParse(txtnum1.Text, out verify1) && 
                double.TryParse(txtnum2.Text, out verify2)))
            {
                double calculo;
                calculo = 3.14 *(verify1 * verify1) * verify2;
                txtnum3.Text = calculo.ToString("N2");
            }
            else
                MessageBox.Show("Dados inválidos");
        }

        private void txtnum1_Enter(object sender, EventArgs e)
        {

        }
    }
}
