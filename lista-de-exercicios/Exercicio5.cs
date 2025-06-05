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
    public partial class Exercicio5 : Form
    {
        public Exercicio5()
        {
            InitializeComponent();
        }

        private void AddListItem(object sender, EventArgs e)
        {
            string newItem = NewItemTextBox.Text;
            listBox1.Items.Add(newItem);
        }

        private void RemoveSelectedListItem(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1) { 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio6 nextForms = new Exercicio6();
            nextForms.Show();
        }

        private void Exercicio5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
