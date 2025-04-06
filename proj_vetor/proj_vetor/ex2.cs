using System;
using System.Windows.Forms;
using System.Linq;

namespace proj_vetor
{
    public partial class ex2 : Form
    {
        int[] num = new int[8];
        int l;
        public ex2()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex1 ex1 = new ex1();
            ex1.ShowDialog();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex3 ex3 = new ex3();
            ex3.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (txt_add_itens.Text == "")
            {
                MessageBox.Show("Valores não inseridos conforme solicitado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (l < 8)
                {
                    num[l] = int.Parse(txt_add_itens.Text);
                    l += 1;
                    txt_add_itens.Clear();
                    txt_add_itens.Focus();
                }
                else
                {
                    addItem.Enabled = false;
                    txt_add_itens.Enabled = false;
                }
            }
        }

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            if (txt_add_itens.Text == "")
            {
                MessageBox.Show("Valores não inseridos conforme solicitado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Maior número
                for (int maiorC = 1; maiorC < num.Length; maiorC++)
                {
                    int numMaior = num[0];
                    if (num[maiorC] > numMaior)
                    {
                        numMaior = num[maiorC];
                        lbl_maior.Text = numMaior.ToString();
                    }
                }
                //Menor número
                for (int menorC = 1; menorC < num.Length; menorC++)
                {
                    int numMenor = num[0];
                    if (num[menorC] < numMenor)
                    {
                        numMenor = num[menorC];
                        lbl_menor.Text = numMenor.ToString();
                    }
                }
                //Num par e ímpar
                foreach (int i in num)
                {
                    if (i % 2 == 0)
                    {
                        int numeroAlvo = i;
                        int contagem = num.Count(numero => numero == numeroAlvo);
                        lbl_par.Text = contagem.ToString();
                    }
                    else if (i % 2 != 0)
                    {
                        int numeroAlvo = i;
                        int contagem = num.Count(numero => numero == numeroAlvo);
                        lbl_par.Text = contagem.ToString();
                    }
                }
            }
        }
    }
}
