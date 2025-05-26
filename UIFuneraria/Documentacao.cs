using System;
using System.Windows.Forms;

namespace UIFuneraria
{
    public partial class DocumentacaoPage : Form
    {
        public DocumentacaoPage()
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

        private void ContatoSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContatoPage tempPage = new ContatoPage();
            tempPage.Show();
        }

        private void LojaSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LojaPage tempPage = new LojaPage();
            tempPage.Show();
        }

        private void DocumentacaoPage_Load(object sender, EventArgs e)
        {
            this.FormClosing += WhenFormCloses;
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void LoginSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage tempPage = new LoginPage();
            tempPage.Show();
        }
    }
}
