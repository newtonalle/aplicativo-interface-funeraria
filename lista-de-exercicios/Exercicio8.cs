using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio8 : Form
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
            
        }

        private void ResetImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio9 nextForms = new Exercicio9();
            nextForms.Show();
        }

        private void Exercicio8_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
