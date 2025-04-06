using System;
using System.Windows.Forms;

namespace proj02_idade_mes_dia_hora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor insira seu nome para continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else if (txtIdade.Text == "")
            {
                MessageBox.Show("Por favor insira sua idade para continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIdade.Focus();
            }
            else
            {
                int meses = int.Parse(txtIdade.Text) * 12;
                int dias = int.Parse(txtIdade.Text) * 365;
                int horas = int.Parse(txtIdade.Text) * 8760;

                txtMeses.Text = Convert.ToString(meses);
                txtDias.Text = Convert.ToString(dias);
                txtHoras.Text = Convert.ToString(horas);
                txtNomeInserido.Text = txtNome.Text;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtDias.Clear();
            txtMeses.Clear();
            txtNome.Clear();
            txtIdade.Clear();
            txtNomeInserido.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
