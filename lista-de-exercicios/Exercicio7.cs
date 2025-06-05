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
    public partial class Exercicio7 : Form
    {
        public Exercicio7()
        {
            InitializeComponent();
        }

        private void ValidateCPF(object sender, EventArgs e)
        {
            int CPF;

            if (CPFTextBox.Text.Length != 11)
            {
                errorProvider1.SetError(this.CPFTextBox, "CPF deve conter 11 dígitos!");
            } else
            {
                errorProvider1.Clear();
            }
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio8 nextForms = new Exercicio8();
            nextForms.Show();
        }

        private void Exercicio7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
