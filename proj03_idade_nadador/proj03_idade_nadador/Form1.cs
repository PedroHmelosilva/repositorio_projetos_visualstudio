using System;
using System.Windows.Forms;

namespace proj03_idade_nadador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string infantilA = "Infantil A", infantilB = "Infantil B", juvenilA = "Juvenil A", juvenilB = "Juvenil B", senior = "Sênior";

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtIdade.Text == "")
            {
                MessageBox.Show("Por favor insira alguma idade", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idade = int.Parse(txtIdade.Text);
                if (idade >= 5 && idade <= 7)
                {
                    txtNadador.Text = infantilA;
                }
                else if (idade >= 8 && idade <= 10)
                {
                    txtNadador.Text = infantilB;
                }
                else if (idade >= 11 && idade <= 13)
                {
                    txtNadador.Text = juvenilA;
                }
                else if (idade >= 14 && idade <= 17)
                {
                    txtNadador.Text = juvenilB;
                }
                else if (idade >= 18 && idade <= 25)
                {
                    txtNadador.Text = senior;
                }
                else
                {
                    MessageBox.Show("idade fora da faixa etária", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtNadador.Clear();
            txtIdade.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
