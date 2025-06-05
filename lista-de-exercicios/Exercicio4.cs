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
    public partial class Exercicio4 : Form
    {
        public int counter = 0;
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void CountingButton_Click(object sender, EventArgs e)
        {
            counter++;
            NumberOfClicksLabel.Text = counter.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            counter = 0;
            NumberOfClicksLabel.Text = counter.ToString();
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio5 nextForms = new Exercicio5();
            nextForms.Show();
        }

        private void Exercicio4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
