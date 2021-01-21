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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalBruto_Click(object sender, EventArgs e)
        {
            double salario, gratificacao, producao, salarioBruto;

            if (double.TryParse(txtGratificacao.Text, out gratificacao) &&
               double.TryParse(txtSalario.Text, out salario) &&
               double.TryParse(txtProducao.Text, out producao))
            {
                if (producao < 100)
                {
                    salarioBruto = salario + salario * (0.05 * 0 + 0.1 * 0 + 0.1 * 0) + gratificacao;
                    if (salarioBruto > 7000 || gratificacao == 0)
                        salarioBruto = 7000;

                    MessageBox.Show("O salário bruto de " + txtNome.Text + " cujo número de inscrição é "
                     + txtInscricao.Text + " e ocupa o cargo de " + txtCargo.Text + " é: " + salarioBruto);
                }

                else if (producao < 120)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 0 + 0.1 * 0) + gratificacao;
                    if (salarioBruto > 7000 || gratificacao == 0)
                        salarioBruto = 7000;

                    MessageBox.Show("O salário bruto de " + txtNome.Text + " cujo número de inscrição é "
                    + txtInscricao.Text + " e ocupa o cargo de " + txtCargo.Text + " é: " + salarioBruto);
                }

                else if (producao < 150)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 1 + 0.1 * 0) + gratificacao;
                    if (salarioBruto > 7000 || gratificacao == 0)
                        salarioBruto = 7000;

                    MessageBox.Show("O salário bruto de " + txtNome.Text + " cujo número de inscrição é "
                    + txtInscricao.Text + " e ocupa o cargo de " + txtCargo.Text + " é: " + salarioBruto);
                }

                else if (producao >= 150)
                {
                    salarioBruto = salario + salario * (0.05 * 1 + 0.1 * 1 + 0.1 * 1) + gratificacao;
                    if (salarioBruto > 7000 && gratificacao == 0)
                        salarioBruto = 7000;

                    MessageBox.Show("O salário bruto de " + txtNome.Text + " cujo número de inscrição é "
                    + txtInscricao.Text + " e ocupa o cargo de " + txtCargo.Text + " é: " + salarioBruto);
                }
            }
                 else
                    MessageBox.Show("Insira valores válidos");
        }
    }
}
