using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_quiz
{
    public partial class frmQ15 : Form
    {
        public frmQ15()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (ckbCerta1.Checked == true && ckbCerta2.Checked == true)
            {
                MessageBox.Show("Resposta correta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                classesGlobais.Acerto++;

                frmConcluiu Concluiu = new frmConcluiu();
                Concluiu.ShowDialog();
                this.Dispose();
            }
            else if (checkBox2.Checked == true || checkBox1.Checked == true || checkBox4.Checked == true || ckbCerta1.Checked == true || ckbCerta2.Checked == true)
            {
                MessageBox.Show("Resposta incorreta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                classesGlobais.Erro++;

                frmConcluiu Concluiu = new frmConcluiu();
                Concluiu.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
