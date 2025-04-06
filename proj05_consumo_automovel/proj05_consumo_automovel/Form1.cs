using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj05_consumo_automovel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCombustivel.Clear();
            txtConsumo.Clear();
            txtDistancia.Clear();
            txtDistancia.Focus();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtDistancia.Text == "")
            {
                MessageBox.Show("Por favor insira a distância percorrida pelo seu automóvel", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtCombustivel.Text == "")
            {
                MessageBox.Show("Por favor insira a quantidade de combustível em litros do seu automóvel", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal resultado;
                resultado = (decimal.Parse(txtDistancia.Text) / decimal.Parse(txtCombustivel.Text));
                string formatted = resultado.ToString("F2");
                txtConsumo.Text = Convert.ToString(formatted);
            }
        }
    }
}