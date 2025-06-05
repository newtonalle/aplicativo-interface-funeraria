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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void MudarTexto_Click(object sender, EventArgs e)
        {
            labelTrocar.Text = "Olá, Windows Forms!";
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio2 nextForms = new Exercicio2();
            nextForms.Show();
        }

        private void Exercicio1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
