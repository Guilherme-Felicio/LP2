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
    public partial class frmExercício3 : Form
    {
        public frmExercício3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            string texto = rchtxtPalindromo.Text.Trim().ToUpper();
            string texto2 = String.Empty;
            int i;

            //validando se o usuario inseriu algum texto
            if (texto == "")
                MessageBox.Show("Digite algum texto");
            else
            {

                //removendo espaços em branco dentro do texto
                for (i = 0; i < texto.Length; i++)
                    if (char.IsWhiteSpace(texto[i]))
                        texto.Remove(i, 1);

                //array com o texto reverso
                char[] a = texto.ToArray();
                Array.Reverse(a);

                //passando array para string novamente
                foreach (char c in a)
                    texto2 = texto2 + c.ToString();

                if (texto == texto2)
                    MessageBox.Show("E um palíndromo");
                else
                    MessageBox.Show("Não é um palíndromo");
            }
            


















        }
    }
}
