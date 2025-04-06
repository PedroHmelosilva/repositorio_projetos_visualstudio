using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj04_media_aritimetica
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
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtNomeInserido.Clear();
            txtNome.Clear();
            txtMediaInserida.Clear();
            txtNome.Focus();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor insira o seu nome para continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
            else if (txtnota1.Text == "" || txtnota2.Text == "" || txtnota3.Text == "")
            {
                MessageBox.Show("Por favor insira a sua nota para continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnota1.Focus();
            }
            else
            {
                decimal resultado;
                txtNomeInserido.Text = txtNome.Text;
                resultado = (decimal.Parse(txtnota1.Text) + decimal.Parse(txtnota2.Text) + decimal.Parse(txtnota3.Text)) / 3;
                string resultadoformatado = resultado.ToString("F2");
                txtMediaInserida.Text = Convert.ToString(resultadoformatado);
            }
        }
    }
}
