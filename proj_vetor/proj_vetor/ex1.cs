using System;
using System.Windows.Forms;

namespace proj_vetor
{
    public partial class ex1 : Form
    {
        int[] num = new int[10];
        int l = 0;

        public ex1()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex2 ex2 = new ex2();
            ex2.ShowDialog();
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
            if (l < 10)
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

        private void btn_exibir_Click(object sender, EventArgs e)
        {
            foreach (int i in num)
            {
                if (i % 2 == 0)
                {
                    int numPar = i;
                    int numParDivido = numPar / 2;
                    lbx_itens.Items.Add(numPar);
                    lbx_itens_depois.Items.Add(numParDivido);
                }
                else if (i % 2 != 0)
                {
                    int numIpar = i;
                    int numIparDivido = numIpar * 2;
                    lbx_itens.Items.Add(numIpar);
                    lbx_itens_depois.Items.Add(numIparDivido);
                }
            }
        }
    }
}