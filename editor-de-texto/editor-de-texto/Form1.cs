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

namespace editor_de_texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gravar()
        {
            if(MessageBox.Show("Texto modificado. Gostaria de gravar?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                dlgSalvar.ShowDialog();
                if(dlgSalvar.FileName != "")
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

        private void mnu_Novo_Click(object sender, EventArgs e)
        {
            gravar();
            richTextBox1.Clear();
            status_msg.Text = "Nome do arquivo";
        }

        private void mnu_Salvar_Click(object sender, EventArgs e)
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

        private void mnu_Abrir_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dlgAbrir.ShowDialog();
            if(dlgAbrir.FileName != "")
            {
                StreamWriter wr = new StreamWriter(dlgAbrir.FileName, true);
                while(!rd.EndOStream)
                {
                    richTextBox1.Text += rd.ReadLine();
                    richTextBox1.Text += "\n";
                }
                rd.Close();

                status_msg.Text = "Nome do arquivo: " + dlgAbrir.FileName;
            }
            richTextBox1.Modified = false;
        }
    }
}
