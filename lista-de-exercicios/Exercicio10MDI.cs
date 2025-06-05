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
    public partial class Exercicio10MDI : Form
    {

        public Exercicio10MDI()
        {
            InitializeComponent();
        }

        private void OpenForms1(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Formulário I";
            childForm.Show();
        }

        private void OpenForms2(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Formulário II";
            childForm.Show();
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio11 nextForms = new Exercicio11();
            nextForms.Show();
        }

        private void Exercicio10MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
