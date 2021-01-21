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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaços_Click(object sender, EventArgs e)
        {
            int i, numEspacos;
            string texto = rchtxtExe1.Text;
            numEspacos = 0;

            //contagem do numero de espaços
            for (i = 0; i < texto.Length; i++)
                if (Char.IsWhiteSpace(texto, i))
                    numEspacos++;

            MessageBox.Show("O número de espaços é: " + numEspacos);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int numR;
            string texto = rchtxtExe1.Text.ToUpper();
            numR = 0;

            //contagem de letras r
            foreach (char c in texto)
                if (c == 'R')
                    numR++;

            MessageBox.Show("O número de 'R' no texto é: " + numR);
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            int numPar;
            string texto = rchtxtExe1.Text.ToUpper();
            char a;
            numPar = -1;
            a = texto[0];

            foreach (char c in texto)
                if (c == a)
                {
                    numPar++;
                    a = c;
                }
                else
                    a = c;

            MessageBox.Show("O numero de pares e: " + numPar);

        }
    }
}
