using System;
using System.Windows.Forms;

namespace UIFuneraria
{
    public partial class LojaPage : Form
    {
        public LojaPage()
        {
            InitializeComponent();
        }

        private void DocumentacaoSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocumentacaoPage tempPage = new DocumentacaoPage();
            tempPage.Show();
        }

        private void ContatoSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContatoPage tempPage = new ContatoPage();
            tempPage.Show();
        }

        private void AgendamentosSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendamentosPage tempPage = new AgendamentosPage();
            tempPage.Show();
        }

        private void PlanosSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanosPage tempPage = new PlanosPage();
            tempPage.Show();
        }

        private void LoginSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage tempPage = new LoginPage();
            tempPage.Show();
        }

        private void LojaPage_Load(object sender, EventArgs e)
        {
            this.FormClosing += WhenFormCloses;
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
