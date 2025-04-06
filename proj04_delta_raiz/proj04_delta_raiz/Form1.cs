using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj04_delta_raiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtA.Text=="" || txtB.Text == "" || txtC.Text == "")
            {
                MessageBox.Show("Insira os valores corretamente para continuar", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int delta;
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                int raiz1;
                int raiz2;
                delta = b ^ 2 - 4 * a * c;
                if (delta < 0)
                {
                    MessageBox.Show("As raízes não existem", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (delta == 0)
                {
                    raiz1 = -b / (2 * a);
                    txtRaiz2.Text = "não existe";
                    txtRaiz1.Text = Convert.ToString(raiz1);
                    txtDelta.Text = Convert.ToString(delta);
                }
                else if (delta > 0) {
                    raiz1 = (int)((-b + Math.Sqrt(delta)) / (2 * a));
                    raiz2 = (int)((-b - Math.Sqrt(delta)) / (2 * a));
                    txtRaiz1.Text = Convert.ToString(raiz1);
                    txtRaiz2.Text = Convert.ToString(raiz2);
                    txtDelta.Text = Convert.ToString(delta);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtDelta.Clear();
            txtRaiz1.Clear();
            txtRaiz2.Clear();
            txtA.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
