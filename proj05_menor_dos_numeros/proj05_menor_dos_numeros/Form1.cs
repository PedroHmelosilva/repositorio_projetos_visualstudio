using System;
using System.Windows.Forms;

namespace proj05_menor_dos_numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float n1, n2, n3;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtResultado.Clear();
            txtN1.Focus();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "" || txtN2.Text == "" || txtN3.Text == "")
            {
                MessageBox.Show("Por favor, insira os devidos valores para continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n1 = float.Parse(txtN1.Text);
                n2 = float.Parse(txtN2.Text);
                n3 = float.Parse(txtN3.Text);

                if (n1 < n2 && n1 < n3)
                {
                    txtResultado.Text = Convert.ToString(n1);
                }
                else if (n2 < n1 && n2 < n3)
                {
                    txtResultado.Text = Convert.ToString(n2);
                }
                else if (n3 < n1 && n3 < n2)
                {
                    txtResultado.Text = Convert.ToString(n3);
                }
                else
                {
                    MessageBox.Show("Não foi possível fazer o cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
