using System;
using System.Windows.Forms;

namespace UIFuneraria
{
    public partial class PlanosPage : Form
    {
        public PlanosPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += WhenFormCloses;
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
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
