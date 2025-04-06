using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace proj_string
{
    public partial class mover_textos : Form
    {
        public mover_textos()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
            this.Dispose();
        }

        private void menu_mover_textos_Click(object sender, EventArgs e)
        {
            verificador_email verificador = new verificador_email();
            verificador.ShowDialog();
            this.Dispose();
        }

        private void menu_exibir_vertical_Click(object sender, EventArgs e)
        {
            exibir_vertical vertical = new exibir_vertical();
            vertical.ShowDialog();
            this.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra = txt_palavra.Text;
                list_lista01.Items.Add(palavra);
            }
        }
        private void btn_add02_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra = txt_palavra.Text;
                list_lista02.Items.Add(palavra);
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_palavra.Clear();
            list_lista01.Items.Clear();
            list_lista02.Items.Clear();
        }

        private void btn_ordenar01_Click(object sender, EventArgs e)
        {
            string[] a = list_lista01.Items.Cast<string>().ToArray();
            list_lista01.Items.Clear();
            var ordenado = a.OrderBy(p => p);
            foreach (var list in ordenado)
                list_lista01.Items.Add(list.ToString());
        }

        private void btn_ordenar02_Click(object sender, EventArgs e)
        {
            string[] a = list_lista02.Items.Cast<string>().ToArray();
            list_lista02.Items.Clear();
            var ordenado = a.OrderBy(p => p);
            foreach (var list in ordenado)
                list_lista02.Items.Add(list.ToString());
        }

        private void btn_remover01_Click(object sender, EventArgs e)
        {
            list_lista01.Items.RemoveAt(list_lista01.SelectedIndex);
        }

        private void btn_remover02_Click(object sender, EventArgs e)
        {
            list_lista02.Items.RemoveAt(list_lista02.SelectedIndex);
        }

        private void btn_mover_list01_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra_list01 = list_lista01.Text;
                list_lista01.Items.RemoveAt(list_lista01.SelectedIndex);
                list_lista02.Items.Add(palavra_list01);
            }
        }

        private void btn_mover_list02_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra_list02 = list_lista02.Text;
                list_lista02.Items.RemoveAt(list_lista02.SelectedIndex);
                list_lista01.Items.Add(palavra_list02);
            }
        }

        private void btn_moverTudo_list01_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] lista_nao_transferida = list_lista01.Items.Cast<string>().ToArray();
                list_lista01.Items.Clear();
                foreach (var lista_transferida in lista_nao_transferida)
                    list_lista02.Items.Add(lista_transferida.ToString());
            }
        }

        private void btn_moverTudo_list02_Click(object sender, EventArgs e)
        {
            if (txt_palavra.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] lista_nao_transferida = list_lista02.Items.Cast<string>().ToArray();
                list_lista02.Items.Clear();
                foreach (var lista_transferida in lista_nao_transferida)
                    list_lista01.Items.Add(lista_transferida.ToString());
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
