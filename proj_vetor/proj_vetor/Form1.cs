using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_vetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex1 ex1 = new ex1();
            ex1.ShowDialog();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex2 ex2 = new ex2();
            ex2.ShowDialog();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex3 ex3 = new ex3();
            ex3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
