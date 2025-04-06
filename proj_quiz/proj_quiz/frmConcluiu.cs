using System;
using System.Windows.Forms;

namespace proj_quiz
{
    public partial class frmConcluiu : Form
    {
        public frmConcluiu()
        {
            InitializeComponent();
        }

        private void frmConcluiu_Load(object sender, EventArgs e)
        {
            txtNomeInfo.Text = classesGlobais.Nome;
            txtIdadeInfo.Text = classesGlobais.Idade;
            txtCidadeInfo.Text = classesGlobais.Cidade;
            txtEstadoInfo.Text = classesGlobais.Estado;
            lblAcertos.Text = classesGlobais.Acerto.ToString();
            lblErros.Text = classesGlobais.Erro.ToString();
            float acertosPorcent = classesGlobais.Acerto;
            float Porcentagem = (acertosPorcent / 15) * 100;
            lblPorcentagem.Text = Porcentagem.ToString("F") + "%";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
