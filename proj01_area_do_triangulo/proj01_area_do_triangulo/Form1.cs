using System;
using System.Windows.Forms;

namespace proj01_area_do_triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtBase.Text == "")
            {
                MessageBox.Show("Por favor insira um valor para a Base", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBase.Focus();
            }
            else if (txtAltura.Text == "")
            {
                MessageBox.Show("Por favor insira um valor para a Altura", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAltura.Focus();
            }
            else
            {
                decimal resultado = decimal.Parse(txtBase.Text) * decimal.Parse(txtAltura.Text) / 2;
                string resultadoformatado = resultado.ToString("F2");
                txtArea.Text = Convert.ToString(resultadoformatado);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBase.Clear();
            txtAltura.Clear();
            txtArea.Clear();
            txtBase.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
