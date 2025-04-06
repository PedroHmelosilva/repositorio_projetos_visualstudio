using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_estacoes_do_ano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            mthCalendar.DateSelected += MthCalendar_DateSelected;
        }

        private void MthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime inicioOutono = new DateTime(2023, 3, 20);
            DateTime inicioInverno = new DateTime(2023, 6, 21);
            DateTime inicioPrimavera = new DateTime(2023, 9, 21);
            DateTime inicioVerao = new DateTime(2023, 12, 21);

            DateTime dataAtual = mthCalendar.SelectionStart;

            if (dataAtual >= inicioOutono && dataAtual < inicioInverno)
            {
                txtResultado.Text = "Outono";
                pbImagemEstacao.Load("../../../fotos/outono.jpg");
            }
            else if (dataAtual >= inicioInverno && dataAtual < inicioPrimavera)
            {
                txtResultado.Text = "Inverno";
                pbImagemEstacao.Load("../../../fotos/inverno.jpg");
            }
            else if (dataAtual >= inicioPrimavera && dataAtual < inicioVerao)
            {
                txtResultado.Text = "Primavera";
                pbImagemEstacao.Load("../../../fotos/primavera.jpg");
            }
            else if (dataAtual >= inicioVerao || dataAtual < inicioOutono)
            {
                txtResultado.Text = "Verão";
                pbImagemEstacao.Load("../../../fotos/verao.jpg");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}