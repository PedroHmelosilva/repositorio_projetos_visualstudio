using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proj_string
{
    public partial class stringproj : Form
    {
        public stringproj()
        {
            InitializeComponent();
        }

        //Links do menu
        private void verificadorDeEmailToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void menu_mover_textos_Click(object sender, EventArgs e)
        {
            mover_textos mover_textos = new mover_textos();
            mover_textos.ShowDialog();
            this.Dispose();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 home = new Form1();
            home.ShowDialog();
            this.Dispose();
        }

        //Verificar o tamanho da frase
        private void btn_tamanho_Click(object sender, EventArgs e)
        {
            string frase = txt_frase.Text;
            if (frase == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_total.Text = frase.Length.ToString();
            }
        }

        //inverter frase
        private void inverter_frase(ref string valor)
        {
            Array texto = valor.ToArray();
            Array.Reverse(texto);
            valor = string.Empty;
            foreach (char textoinvertido in texto)
            {
                valor += textoinvertido.ToString();
            }
        }
        private void btn_inverter_Click(object sender, EventArgs e)
        {
            if (txt_frase.Text == "")
            {
                {
                    MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string textocaracter = txt_frase.Text.Trim();
                this.inverter_frase(ref textocaracter);
                txt_frase_invertida.Text = textocaracter;
            }
        }

        //total de vogais
        private void btn_vogais_Click(object sender, EventArgs e)
        {
            var frase = txt_frase.Text;
            var letraA = "a";
            var letraE = "e";
            var letraI = "i";
            var letraO = "o";
            var letraU = "u";

            if (frase == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var quantidade_letraA = contar_letrasA(frase, letraA);
                txt_A.Text = quantidade_letraA.ToString();

                var quantidade_letraE = contar_letrasE(frase, letraE);
                txt_E.Text = quantidade_letraE.ToString();

                var quantidade_letraI = contar_letrasI(frase, letraI);
                txt_I.Text = quantidade_letraI.ToString();

                var quantidade_letraO = contar_letrasO(frase, letraO);
                txt_O.Text = quantidade_letraO.ToString();

                var quantidade_letraU = contar_letrasU(frase, letraU);
                txt_U.Text = quantidade_letraU.ToString();
            }
        }
        private int contar_letrasA(string frase, string letraA)
        {
            return Regex.Matches(frase, letraA).Count;
        }
        private int contar_letrasE(string frase, string letraE)
        {
            return Regex.Matches(frase, letraE).Count;
        }
        private int contar_letrasI(string frase, string letraI)
        {
            return Regex.Matches(frase, letraI).Count;
        }
        private int contar_letrasO(string frase, string letraO)
        {
            return Regex.Matches(frase, letraO).Count;
        }
        private int contar_letrasU(string frase, string letraU)
        {
            return Regex.Matches(frase, letraU).Count;
        }

        //Palíndromo
        private void btn_palindrome_Click(object sender, EventArgs e)
        {
            string textocaracter = txt_frase.Text.Trim();
            this.inverter_frase(ref textocaracter);
            string palavra_invertida = textocaracter;

            if (txt_frase.Text == "")
            {
                {
                    MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (txt_frase.Text == palavra_invertida)
            {
                string palavra = txt_frase.Text;
                {
                    MessageBox.Show("A palavra inserida " + palavra + " é um Palíndromo", "Opa!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else if (txt_frase.Text != palavra_invertida)
            {
                string palavra = txt_frase.Text;
                {
                    MessageBox.Show("A palavra inserida " + palavra + " não é um Palíndromo", "Opa!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //Retirar espaços
        private void btn_retirar_espacos_Click(object sender, EventArgs e)
        {
            if (txt_frase.Text == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_suprimir_espacos.Text = txt_frase.Text.Replace(" ", "");
            }
        }

        //Quebrar a frase em letras na vertical
        private void btn_quebra_letra_Click(object sender, EventArgs e)
        {
            string palavra = txt_frase.Text;

            if (palavra == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra_lista = txt_frase.Text;
                foreach (var itens in palavra_lista)
                {
                    lbx_letra.Items.Add(itens.ToString());
                }
            }
        }

        //Quebra a frase em palavras na vertical
        private void btn_quenra_palavra_Click(object sender, EventArgs e)
        {
            string palavra = txt_frase.Text;

            if (palavra == "")
            {
                MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string palavra_lista = txt_frase.Text;
                string[] palavra_separada = palavra_lista.Split(' ');
                foreach (var palavra_ordem in palavra_separada)
                {
                    lbx_palavra.Items.Add(palavra_ordem);
                }
            }
        }

        //Reniciar todos os textbox e listbox
        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            txt_frase.Clear();

            txt_A.Clear();
            txt_E.Clear();
            txt_I.Clear();
            txt_O.Clear();
            txt_U.Clear();

            txt_frase_invertida.Clear();
            txt_suprimir_espacos.Clear();
            txt_total.Clear();

            lbx_letra.Items.Clear();
            lbx_palavra.Items.Clear();

            txt_frase.Focus();
        }

        //Todos
        private void btn_todos_Click(object sender, EventArgs e)
        {
            if (txt_frase.Text=="")
            {
                {
                    MessageBox.Show("Por favor insira alguma coisa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Verificar o tamanho da frase
                string frase = txt_frase.Text;
                txt_total.Text = frase.Length.ToString();

                //inverter frase
                string textocaracter02 = txt_frase.Text.Trim();
                this.inverter_frase(ref textocaracter02);
                txt_frase_invertida.Text = textocaracter02;

                //total de vogais
                var letraA = "a";
                var letraE = "e";
                var letraI = "i";
                var letraO = "o";
                var letraU = "u";

                var quantidade_letraA = contar_letrasA(frase, letraA);
                txt_A.Text = quantidade_letraA.ToString();

                var quantidade_letraE = contar_letrasE(frase, letraE);
                txt_E.Text = quantidade_letraE.ToString();

                var quantidade_letraI = contar_letrasI(frase, letraI);
                txt_I.Text = quantidade_letraI.ToString();

                var quantidade_letraO = contar_letrasO(frase, letraO);
                txt_O.Text = quantidade_letraO.ToString();

                var quantidade_letraU = contar_letrasU(frase, letraU);
                txt_U.Text = quantidade_letraU.ToString();

                //Retirar espaços
                txt_suprimir_espacos.Text = txt_frase.Text.Replace(" ", "");


                //Quebrar a frase em letras na vertical
                string palavra_lista = txt_frase.Text;
                foreach (var itens in palavra_lista)
                {
                    lbx_letra.Items.Add(itens.ToString());
                }

                //Quebrar a frase em palavras na vertical
                string[] palavra_separada = palavra_lista.Split(' ');
                foreach (var palavra_ordem in palavra_separada)
                {
                    lbx_palavra.Items.Add(palavra_ordem);
                }

                //Palíndromo
                string textocaracter = txt_frase.Text.Trim();
                this.inverter_frase(ref textocaracter);
                string palavra_invertida = textocaracter;

                if (txt_frase.Text == palavra_invertida)
                {
                    {
                        MessageBox.Show("A palavra inserida " + txt_frase.Text + " é um Palíndromo", "Opa!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else if (txt_frase.Text != palavra_invertida)
                {
                    {
                        MessageBox.Show("A palavra inserida " + txt_frase.Text + " não é um Palíndromo", "Opa!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}