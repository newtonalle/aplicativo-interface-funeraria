using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

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

        private void CreateOrLoginAccount_Click(object sender, EventArgs e)
        {
            MySqlDataReader foundUser = FindUserByEmail(InputEmail.Text);
            if (foundUser != null) 
            {
                // User already using this email
                MessageBox.Show("Welcome " + foundUser.GetString(1) + "!");
                PlanosSelect_Click(sender, e);
            }
            else
            {
                CreateUser(InputEmail.Text, InputEmail.Text, InputSenha.Text);
            }
        }

        private void CreateUser(string nome, string email, string senha)
        {
            MessageBox.Show("Criando conta...");

            try
            {
                //se tiver vazio
                if (nome == "")
                {
                    //Alerta para o usuario mensagem verdadeira
                    MessageBox.Show("Nome está vazio!");
                }

                // alerta para o usuario preenchido
                //MessageBox.Show("campo preenchido!");

                if (email == "")
                {
                    MessageBox.Show("Email está vazio!");
                }

                if (senha == "")
                {
                    MessageBox.Show("Senha está vazia!");
                }

                if (senha != "" && email != "" && nome != "")
                {
                    //caminho de configuração do servidor
                    string data_source = "datasource=localhost;username=root;password='';database=sistema;";

                    //abrindo a conexão
                    MySqlConnection conexao = new MySqlConnection(data_source);

                    // Encriptando senha
                    string senhaHash = BitConverter.ToString(new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha))).Replace("-", string.Empty);

                    //criando o script sql para inserir as informações
                    string sql = "insert into usuarios(nome,email,senha) values('" + nome + "','" + email + "','" + senhaHash + "')";

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

        private DataTable FindUserByEmail(string email)
        {
            DataTable userTable = new DataTable();

            DataColumn column0 = new DataColumn();
            column0.DataType = System.Type.GetType("System.Int32");
            column0.ColumnName = "id";
            column0.AutoIncrement = true;
            column0.Caption = "id";
            column0.ReadOnly = false;
            column0.Unique = true;
            userTable.Columns.Add(column0);

            DataColumn column1 = new DataColumn();
            column1.DataType = System.Type.GetType("System.String");
            column1.ColumnName = "name";
            column1.AutoIncrement = false;
            column1.Caption = "name";
            column1.ReadOnly = false;
            column1.Unique = false;
            userTable.Columns.Add(column1);

            DataColumn column2 = new DataColumn();
            column2.DataType = System.Type.GetType("System.String");
            column2.ColumnName = "email";
            column2.AutoIncrement = false;
            column2.Caption = "email";
            column2.ReadOnly = false;
            column2.Unique = false;
            userTable.Columns.Add(column2);

            DataColumn column3 = new DataColumn();
            column3.DataType = System.Type.GetType("System.String");
            column3.ColumnName = "password";
            column3.AutoIncrement = false;
            column3.Caption = "password";
            column3.ReadOnly = false;
            column3.Unique = false;
            userTable.Columns.Add(column3);


            DataRow row = userTable.NewRow();
            row["id"] = i;
            row["name"] = "Item " + i;
            row["email"] = 0;
            table.Rows.Add(row);

            string data_source = "datasource=localhost;username=root;password='';database=sistema;";

            using (MySqlConnection conexao = new MySqlConnection(data_source))
            {
                string sql = "select * from usuarios where email = '" + email + "'";

                using (MySqlCommand command = new MySqlCommand(sql, conexao))
                {
                    conexao.Open();
                    using (MySqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            userTable.NewRow(1, 2, 3);
                            return reader;
                        }
                    }
                }
            }

            return null;
        }
    }
}
