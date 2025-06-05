using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UIFuneraria
{
    public partial class CadastroDeProdutosPage : Form
    {
        public CadastroDeProdutosPage()
        {
            InitializeComponent();
        }

        public void CreateSQLTables()
        {
            /*
            create table if NOT EXISTS usuarios(
            id int primary key auto_increment,
            nome varchar(50),
            email varchar(50),
            senha varchar(50)
            );

            create table if NOT EXISTS produtos(
            id int primary key auto_increment,
            nome varchar(50),
            preco int,
            tipo varchar(50)
            ); 
            
             */

            string data_source = "datasource=localhost;username=root;password='';database=sistema;";

            MySqlConnection conexao = new MySqlConnection(data_source);

            string sql = "create table if NOT EXISTS usuarios(id int primary key auto_increment, nome varchar(50), email varchar(50), senha varchar(50));";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            comando.ExecuteNonQuery();


            MySqlConnection conexaoB = new MySqlConnection(data_source);

            sql = "create table if NOT EXISTS produtos(id int primary key auto_increment, nome varchar(50), preco int, tipo varchar(50));";

            MySqlCommand comandoB = new MySqlCommand(sql, conexao);

            conexaoB.Open();

            comandoB.ExecuteNonQuery();
        }

        private void ReturnToStore(object sender, EventArgs e)
        {
            this.Hide();
            LojaPage tempPage = new LojaPage();
            tempPage.Show();
        }

        private void WhenFormCloses(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void CreateNewProduct(object sender, EventArgs e)
        {
            CreateSQLTables();
            MessageBox.Show("Criando produto...");

            try
            {
                if (NameTextBox.Text == "")
                {
                    MessageBox.Show("Nome está vazio!");
                }

                if (PriceTextBox.Text == "")
                {
                    MessageBox.Show("Preço está vazio!");
                }

                if (TypeTextBox.Text == "")
                {
                    MessageBox.Show("Tipo está vazio!");
                }

                if (NameTextBox.Text != "" && PriceTextBox.Text != "" && TypeTextBox.Text != "")
                {
                    string data_source = "datasource=localhost;username=root;password='';database=sistema;";

                    MySqlConnection conexao = new MySqlConnection(data_source);

                    string sql = "insert into produtos(nome,preco,tipo) values('" + NameTextBox.Text + "'," + PriceTextBox.Text + ",'" + TypeTextBox.Text + "')";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    conexao.Open();

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Produto criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado (possivelmente não conectado ao banco de dados): " + ex);
            }
        }
    }
}
