using System;
using System.Windows.Forms;

namespace proj03_preco_com_percentual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtCusto.Text == "" || txtAcrescimo.Text == "")
            {
                if (txtCusto.Text == "")
                {
                    MessageBox.Show("Por favor insira o custo do produto para poder continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCusto.Focus();
                }
                else if (txtAcrescimo.Text == "")
                {
                    MessageBox.Show("Por favor insira o acréscimo do produto em % para poder continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAcrescimo.Focus();
                }
            }
            else
            {
                decimal resultado;
                decimal resultadofinal;
                resultado = (decimal.Parse(txtAcrescimo.Text)/100) * decimal.Parse(txtCusto.Text);
                resultadofinal = (decimal.Parse(txtCusto.Text) + resultado);
                txtVenda.Text = Convert.ToString(resultadofinal);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCusto.Clear();
            txtAcrescimo.Clear();
            txtVenda.Clear();
            txtCusto.Focus();
        }
    }
}
