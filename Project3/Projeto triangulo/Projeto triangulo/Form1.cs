using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;

            //passagem text para double
            if (double.TryParse(txtA.Text, out ladoA)
            && double.TryParse(txtB.Text, out ladoB)
            && double.TryParse(txtC.Text, out ladoC))
            {
                
                //checagem se é triangulo
                if (Math.Abs(ladoB - ladoC) < ladoA && ladoA < (ladoB + ladoC) &&
                          Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC &&
                          Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB)
                {

                    //checar qual tipo do triangulo
                    if (ladoA == ladoB && ladoB == ladoC && ladoA == ladoC)
                    {
                        MessageBox.Show("O triângulo é equilátero");
                    }
                    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    {
                        MessageBox.Show("O triângulo é isósceles");
                    }

                    else
                    {
                        MessageBox.Show("O triângulo é escaleno");
                    }

                }

                else
                    MessageBox.Show("Não é um triangulo");
            
            }
            
            else
            {


                MessageBox.Show("Insira valores válidos");

            }





        }
    }
}
