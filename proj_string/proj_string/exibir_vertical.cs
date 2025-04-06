using System;
using System.Windows.Forms;

namespace proj_string
{
    public partial class exibir_vertical : Form
    {
        public exibir_vertical()
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
            verificador_email verificador = new verificador_email();
            verificador.ShowDialog();
            this.Dispose();
        }

        private void menu_mover_textos_Click(object sender, EventArgs e)
        {
            mover_textos mover_textos = new mover_textos();
            mover_textos.ShowDialog();
            this.Dispose();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string palavra = txt_palavra.Text;

            if (palavra == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra_list01 = txt_palavra.Text;
                foreach (var itens in palavra_list01)
                {
                    list_palavra.Items.Add(itens.ToString());
                }

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
