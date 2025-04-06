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
    public partial class frmQ13 : Form
    {
        public frmQ13()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (rdbCerta.Checked == true)
            {
                MessageBox.Show("Resposta correta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                classesGlobais.Acerto++;

                frmQ14 Q14 = new frmQ14();
                Q14.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
            {
                MessageBox.Show("Resposta incorreta", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                classesGlobais.Erro++;

                frmQ14 Q14 = new frmQ14();
                Q14.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
