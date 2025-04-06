using System;
using System.Windows.Forms;

namespace proj_string
{
    public partial class verificador_email : Form
    {
        public verificador_email()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
            this.Dispose();
        }

        private void menu_exibir_vertical_Click(object sender, EventArgs e)
        {
            exibir_vertical vertical = new exibir_vertical();
            vertical.ShowDialog();
            this.Dispose();
        }

        private void menu_mover_textos_Click(object sender, EventArgs e)
        {
            mover_textos mover_textos = new mover_textos();
            mover_textos.ShowDialog();
            this.Dispose();
        }

        private void verificar_arroba_Click(object sender, EventArgs e)
        {
            string arroba = txt_email.Text;
            if (arroba == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (arroba.Contains("@"))
            {
                int posicaoArroba = arroba.IndexOf('@');
                MessageBox.Show($"Esse é um E-mail valido, e sua posição é {posicaoArroba}", "Valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esse é um E-mail é invalido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verificar_usuario_Click(object sender, EventArgs e)
        {
            string arrobaUsuario = txt_email.Text;
            if (arrobaUsuario.Contains("@"))
            {
                int posicaoArroba = arrobaUsuario.IndexOf('@');

                MessageBox.Show($"Esse é um E-mail valido, e seu usuário é {arrobaUsuario.Substring(0, posicaoArroba)}", "Valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esse é um E-mail é invalido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verificar_provedor_Click(object sender, EventArgs e)
        {
            string Provedor = txt_email.Text;
            if (Provedor.Contains(".com") && Provedor.Contains("@"))
            {
                int posicaoArroba = Provedor.IndexOf('@');

                MessageBox.Show($"Esse é um E-mail valido, e o provedor é {Provedor.Substring(posicaoArroba)}", "Valido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esse é um E-mail é invalido", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manipulaçãoDeStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stringproj stringproj = new stringproj();
            stringproj.ShowDialog();
        }
    }
}