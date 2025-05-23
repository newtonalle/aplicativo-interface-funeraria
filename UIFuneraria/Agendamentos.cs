using System;
using System.Windows.Forms;

namespace UIFuneraria
{
    public partial class AgendamentosPage : Form
    {
        public AgendamentosPage()
        {
            InitializeComponent();
        }

        public void PlanosSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanosPage tempPage = new PlanosPage();
            tempPage.Show();
        }

        private void ContatoSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContatoPage tempPage = new ContatoPage();
            tempPage.Show();
        }

        private void DocumentacaoSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentacaoPage tempPage = new DocumentacaoPage();
            tempPage.Show();
        }

        private void LojaSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LojaPage tempPage = new LojaPage();
            tempPage.Show();
        }

        private void LoginSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage tempPage = new LoginPage();
            tempPage.Show();
        }
    }
}
