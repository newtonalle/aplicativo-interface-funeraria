using System;
using System.Windows.Forms;

namespace UIFuneraria
{
    public partial class ContatoPage : Form
    {
        public ContatoPage()
        {
            InitializeComponent();
        }

        private void PlanosSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanosPage tempPage = new PlanosPage();
            tempPage.Show();
        }

        private void AgendamentosSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            AgendamentosPage tempPage = new AgendamentosPage();
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

        private void ContatoPage_Load(object sender, EventArgs e)
        {
            this.FormClosing += WhenFormCloses;
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}
