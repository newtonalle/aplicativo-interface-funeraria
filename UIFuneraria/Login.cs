using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Security.Cryptography;
using System.Text;

namespace UIFuneraria
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormClosing += WhenFormCloses;
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criando conta...");

            try
            {
                //se tiver vazio
                if (InputNome.Text == "")
                {
                    //Alerta para o usuario mensagem verdadeira
                    MessageBox.Show("Nome está vazio!");
                }

                // alerta para o usuario preenchido
                //MessageBox.Show("campo preenchido!");

                if (InputEmail.Text == "")
                {
                    MessageBox.Show("Email está vazio!");
                }

                if (InputSenha.Text == "")
                {
                    MessageBox.Show("Senha está vazia!");
                }

                if (InputSenha.Text != "" && InputEmail.Text != "" && InputNome.Text != "")
                {
                    //caminho de configuração do servidor
                    string data_source = "datasource=localhost;username=root;password='';database=sistema;";

                    //abrindo a conexão
                    MySqlConnection conexao = new MySqlConnection(data_source);

                    // Encriptando senha
                    string senhaHash = BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(InputSenha.Text))).Replace("-", string.Empty);

                    //criando o script sql para inserir as informações
                    string sql = "insert into usuarios(nome,email,senha) values('" + InputNome.Text + "','" + InputEmail.Text + "','" + senhaHash + "')";

                    //montar o script sql para executar
                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    //abrir o banco de dados
                    conexao.Open();

                    //executar a consulta no banco de dados
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Successfuly created account!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado (possivelmente não conectado ao banco de dados): " + ex);
            }
        }
    }
}
