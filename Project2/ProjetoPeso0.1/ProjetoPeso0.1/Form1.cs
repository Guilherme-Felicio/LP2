using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPeso0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            double altura, peso, pesoIdeal, pesoIdeal2;
            if ((double.TryParse(mskbxAltura.Text, out altura) &&
                double.TryParse(mskbxPeso.Text, out peso)))
            {
                if (rbtnFem.Checked)
                {
                    pesoIdeal = 62.1 * altura - 44.7;
                    if(peso == pesoIdeal)
                        MessageBox.Show("parabens, voce esta no peso ideal");

                    if (peso < pesoIdeal)
                        MessageBox.Show("Precisa comer mais massa e doces");
        
                    if(peso > pesoIdeal)
                        MessageBox.Show("Acima do peso, passe no nutricionista"); 
                }
                if (rbtnMasc.Checked)
                {
                    pesoIdeal2 = 72.7 * altura - 58;
                    if (peso == pesoIdeal2)
                        MessageBox.Show("Parabens, voce esta no peso ideal");

                    if (peso < pesoIdeal2)
                        MessageBox.Show("Precisa comer mais massa e doces");

                    if (peso > pesoIdeal2)
                        MessageBox.Show("Acima do peso, passe no nutricionista");
                }
        }
            else
                MessageBox.Show("Digite um peso e uma altura valida");




        }

        private void mskbxAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
