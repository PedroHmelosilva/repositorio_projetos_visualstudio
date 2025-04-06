using System;
using System.Windows.Forms;

namespace proj_quiz
{
    public partial class infoQuiz : Form
    {
        public infoQuiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text, idade = txtIdade.Text, cidade = txtCidade.Text, estado = txtEstado.Text;

            if (nome == "" || idade == "" || cidade == "" || estado == "")
            {
                MessageBox.Show("Insira as informações pedidas!", "OPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                classesGlobais.Nome = nome;
                classesGlobais.Idade = idade;
                classesGlobais.Cidade = cidade;
                classesGlobais.Estado = estado;

                frmQ1 Q1 = new frmQ1();
                Q1.ShowDialog();
                this.Dispose();
            }
        }
    }
}
