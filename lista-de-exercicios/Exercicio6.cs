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
    public partial class Exercicio6 : Form
    {
        public Exercicio6()
        {
            InitializeComponent();
        }

        private void RadioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void RadioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void RadioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio7 nextForms = new Exercicio7();
            nextForms.Show();
        }

        private void Exercicio6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
