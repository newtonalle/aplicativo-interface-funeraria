using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void SaudacoesButton_Click(object sender, EventArgs e)
        {
            string message = "Bem-vindo(a), " + NomeTextBox.Text + "!";

            MessageBox.Show(message);
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio3 nextForms = new Exercicio3();
            nextForms.Show();
        }

        private void Exercicio2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
