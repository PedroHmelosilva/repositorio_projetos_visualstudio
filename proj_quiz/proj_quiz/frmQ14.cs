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
    public partial class frmQ14 : Form
    {
        public frmQ14()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rdbCerta.Checked == true)
            {
                MessageBox.Show("Resposta correta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                classesGlobais.Acerto++;

                frmQ15 Q15 = new frmQ15();
                Q15.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
            {
                MessageBox.Show("Resposta incorreta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                classesGlobais.Erro++;

                frmQ15 Q15 = new frmQ15();
                Q15.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbCerta_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
