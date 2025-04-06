using System;
using System.Windows.Forms;

namespace proj_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verificador_email verificador = new verificador_email();
            verificador.ShowDialog();
            this.Dispose();
        }

        private void exibir_vertical_Click(object sender, EventArgs e)
        {
            exibir_vertical vertical = new exibir_vertical();
            vertical.ShowDialog();
            this.Dispose();
        }

        private void mover_textos_Click(object sender, EventArgs e)
        {
            mover_textos mover_textos = new mover_textos();
            mover_textos.ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stringproj stringproj = new stringproj();
            stringproj.ShowDialog();
        }
    }
}
