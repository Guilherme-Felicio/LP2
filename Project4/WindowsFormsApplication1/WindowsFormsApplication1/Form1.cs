using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class lblAliInss : Form
    {
        public lblAliInss()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {
            double salarioBruto, numeroFilhos,salarioFamilia, salarioLiquido, 
                   descontoINSS, descontoIRPF;
            string nomeFuncionario;

            nomeFuncionario = mskbxNome.Text;
            if ((double.TryParse(mskbxNumFilhos.Text, out numeroFilhos) &&
                double.TryParse(mskbxSalariobruto.Text, out salarioBruto)))
            {
                //verificação de check dos botões
                if (rbtnMasc.Checked == false && rbtnFem.Checked == false)
                    MessageBox.Show("Marque uma opção de sexo");
                else
                {

                    if (rbtnFem.Checked)
                        if (rbtnCasado.Checked)
                            lblDados.Text = "Os descontos do salário da " + nomeFuncionario +
                                "\n que é casada, e que tem " + numeroFilhos + " filhos são: ";
                        else
                            lblDados.Text = "Os descontos do salário da " + nomeFuncionario +
                                    " \n que é solteira, e que tem " + numeroFilhos + " filhos são: ";
                    if (rbtnMasc.Checked)
                        if (rbtnCasado.Checked)
                            lblDados.Text = "Os descontos do salário do " + nomeFuncionario +
                                " \n que é casado, e que tem " + numeroFilhos + " filhos são: ";
                        else
                            lblDados.Text = "Os descontos do salário do " + nomeFuncionario +
                                    " \n que é solteiro, e que tem " + numeroFilhos + " filhos são: ";


                    //Cálculo Aliquota Inss
                    if (salarioBruto < 800.48)
                    {
                        mskbxAliquotaINSS.Text = "7.65%";
                        descontoINSS = salarioBruto * 0.0765;

                    }
                    else if (salarioBruto <= 1050)
                    {
                        mskbxAliquotaINSS.Text = "8.65%";
                        descontoINSS = salarioBruto * 0.0865;
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        mskbxAliquotaINSS.Text = "9.00%";
                        descontoINSS = salarioBruto * 0.09;
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        mskbxAliquotaINSS.Text = "11.00%";
                        descontoINSS = salarioBruto * 0.11;
                    }
                    else
                    {
                        mskbxAliquotaINSS.Text = "308.17";
                        descontoINSS = 308.17;
                    }

                    //Calculo Aliquota IRPF
                    if (salarioBruto <= 1257.12)
                    {
                        mskbxAliquotaIRPF.Text = "0%";
                        descontoIRPF = 0;
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        mskbxAliquotaIRPF.Text = "15%";
                        descontoIRPF = salarioBruto * 0.15;
                    }
                    else
                    {
                        mskbxAliquotaIRPF.Text = "27.5%";
                        descontoIRPF = 0.275 * salarioBruto;
                    }

                    //Calculo salario Familia
                    if (salarioBruto <= 435.52)
                        salarioFamilia = 22.43 * numeroFilhos;
                    else if (salarioBruto <= 654.61)
                        salarioFamilia = 15.74 * numeroFilhos;
                    else
                        salarioFamilia = 0;

                    //Calculo salario bruto
                    salarioLiquido = salarioBruto - descontoIRPF -
                                     descontoINSS + salarioFamilia;


                    mskbxSalLiquido.Text = Convert.ToString(Math.Round(salarioLiquido,2));
                    mskbxSalFamilia.Text = Convert.ToString(Math.Round(salarioFamilia,2));
                    mskbxDescINSS.Text = Convert.ToString(Math.Round(descontoINSS,2));
                    mskbxDescIRPF.Text = Convert.ToString(Math.Round(descontoIRPF,2));

                }
            }
            else
                MessageBox.Show("Insira dados válidos");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
