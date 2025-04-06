using System;
using System.Windows.Forms;

namespace proj02_calcular_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string magro = "Magro", normal = "Normal", sobrepeso = "Sobrepeso", obesidade = "Obsesidade", obsidademorbida = "Obesidade mórbida";
        float altura, peso, imc;

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtAltura.Text == "" || txtPeso.Text == "")
            {
                MessageBox.Show("Insira os valores corretamente para poder continuar", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = float.Parse(txtAltura.Text);
                peso = float.Parse(txtPeso.Text);
                imc = peso / (altura * altura);
                if (imc > 0 && imc <= 18.5)
                {
                    txtIMC.Text = magro;
                }
                else if (imc > 18.5 && imc < 24.9)
                {
                    txtIMC.Text = normal;
                }
                else if (imc > 25 && imc < 29.9)
                {
                    txtIMC.Text = sobrepeso;
                }
                else if (imc > 30 && imc < 39.9)
                {
                    txtIMC.Text = obesidade;
                }
                else if (imc > 40)
                {
                    txtIMC.Text = obsidademorbida;
                }
                else
                {
                    txtIMC.Text = "Não foi possível calcular!";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtIMC.Clear();
            txtPeso.Clear();
            txtAltura.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
