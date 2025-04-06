using System;
using System.Windows.Forms;

namespace proj_vetor
{
    public partial class ex3 : Form
    {
        int[] num = new int[15];
        int l;
        public ex3()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void ex1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ex1 ex1 = new ex1();
            ex1.ShowDialog();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex2 ex2 = new ex2();
            ex2.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if (l < 15)
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

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int numBuscar = Array.IndexOf(num, int.Parse(txt_buscar.Text));
            if (numBuscar > -1)
            {
                int numEncontrado = numBuscar + 1;
                lbl_num_encontrado.Text = numEncontrado.ToString();
            }
            else
            {
                MessageBox.Show("Valor não encontrado", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
