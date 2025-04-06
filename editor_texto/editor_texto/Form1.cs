using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace editor_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gravar()
        {
            if (MessageBox.Show("Texto modificado. Gostaria de gravar?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                dlgSalvar.ShowDialog();
                if (dlgSalvar.FileName != "")
                {
                    StreamWriter wr = new StreamWriter(dlgSalvar.FileName, true);

                    foreach (string linhas in richTextBox1.Lines)
                    {
                        wr.WriteLine(linhas);
                    }

                    wr.Close();
                    wr.Dispose();
                }
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravar();
            richTextBox1.Clear();
            status_msg.Text = "Nome do arquivo";
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSalvar.ShowDialog();
            if (dlgSalvar.FileName != "")
            {
                {
                    StreamWriter wr = new StreamWriter(dlgSalvar.FileName, true);

                    foreach (string linhas in richTextBox1.Lines)
                    {
                        wr.WriteLine(linhas);
                    }

                    status_msg.Text = "Nome do arquivo: " + dlgSalvar.FileName;

                    richTextBox1.Modified = false;

                    wr.Close();
                    wr.Dispose();
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dlgAbrir.ShowDialog();
            if (dlgAbrir.FileName != "")
            {
                StreamReader rd = new StreamReader(dlgAbrir.FileName);
                while (!rd.EndOfStream)
                {
                    richTextBox1.Text += rd.ReadLine();
                    richTextBox1.Text += "\n";
                }
                rd.Close();

                status_msg.Text = "Nome do arquivo: " + dlgAbrir.FileName;
            }
            richTextBox1.Modified = false;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gravar();
            Application.Exit();
        }

        private void maiúsculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textoUpper = richTextBox1.Text.ToUpper();
            richTextBox1.Clear();
            richTextBox1.Text = textoUpper;
        }

        private void minusculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textolower = richTextBox1.Text.ToLower();
            richTextBox1.Clear();
            richTextBox1.Text = textolower;
        }

        private void dataEHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            richTextBox1.Text = data.ToString();
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgFonte.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = dlgFonte.Font;
            }
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}