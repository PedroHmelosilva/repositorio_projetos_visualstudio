using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projteste_esporte_favorito
{
    public partial class frmMsg : Form
    {
        public frmMsg()
        {
            InitializeComponent();
        }

        private void bntExecutar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá " + txtNome.Text + ". O seu esporte favorito é " + txtEsporte.Text, "Seja bem-vindo(a)");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();//limpando a caixa de texto nome
            txtEsporte.Clear();//limpando a caixa de texto esporte
            txtNome.Focus();//colocando o foco no Nome, isso após a limpeza da caixa
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


/*
//Linha de código que cria uma MessageBox.
1. Conteúdo do MessageBox
2. Título
3. Botão
4. Ícone

DialogResult resultado = MessageBox.Show("Você não inseriu nada, por favor insira algo", "Erro", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
if (resultado == DialogResult.Yes)
    MessageBox.Show("Opa aí sim");
else if (resultado == DialogResult.No)
    MessageBox.Show("Ah cara, aí complica");
else
    MessageBox.Show("Blz");
*/