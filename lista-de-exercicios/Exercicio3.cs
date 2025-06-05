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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void Sum(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "") {
                MessageBox.Show("Valores nulos ou inválidos!");
                return;
            }

            float result = float.Parse(num1.Text) + float.Parse(num2.Text);

            resultLabel.Text = "Resultado: " + result.ToString();
        }

        private void Subtract(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                MessageBox.Show("Valores nulos ou inválidos!");
                return;
            }
            

            float result = float.Parse(num1.Text) - float.Parse(num2.Text);

            resultLabel.Text = "Resultado: " + result.ToString();
        }

        private void Multiply(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                MessageBox.Show("Valores nulos ou inválidos!");
                return;
            }            

            float result = float.Parse(num1.Text) * float.Parse(num2.Text);

            resultLabel.Text = "Resultado: " + result.ToString();
        }

        private void Divide(object sender, EventArgs e)
        {
            if (num1.Text == "" || num2.Text == "")
            {
                MessageBox.Show("Valores nulos ou inválidos!");
                return;
            }
            

            if (float.Parse(num2.Text) == 0)
            {
                // Caso haja divisão por 0

                resultLabel.Text = "Divisão por 0!";
            } else { 
                float result = float.Parse(num1.Text) / float.Parse(num2.Text);
                resultLabel.Text = "Resultado: " + result.ToString();
            }
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio4 nextForms = new Exercicio4();
            nextForms.Show();
        }

        private void Exercicio3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
