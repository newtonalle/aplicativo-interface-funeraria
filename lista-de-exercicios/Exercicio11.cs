using System;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio12 nextForms = new Exercicio12();
            nextForms.Show();
        }

        private void ConfirmOrder(object sender, EventArgs e)
        {
            string ingredientText = "";
            OrderSummaryLabel.Text = "";

            if (MussarelaCheckBox.Checked)
            {
                ingredientText = "";             
                if (OrderSummaryLabel.Text != "")
                    ingredientText += ", ";
                ingredientText += "Mussarela Extra";
                OrderSummaryLabel.Text += ingredientText;
            }

            if (CatupiryCheckBox.Checked)
            {
                ingredientText = "";
                if (OrderSummaryLabel.Text != "")
                    ingredientText = ", ";
                ingredientText += "Catupiry";
                OrderSummaryLabel.Text += ingredientText;
            }

            if (BaconCheckBox.Checked)
            {
                ingredientText = "";
                if (OrderSummaryLabel.Text != "")
                    ingredientText = ", ";
                ingredientText += "Bacon";
                OrderSummaryLabel.Text += ingredientText;
            }

            if (OnionCheckBox.Checked)
            {
                ingredientText = "";
                if (OrderSummaryLabel.Text != "")
                    ingredientText = ", ";
                ingredientText += "Cebola Roxa";
                OrderSummaryLabel.Text += ingredientText;
            }

            if (OrderSummaryLabel.Text == "")
                OrderSummaryLabel.Text = "Seu pedido não tem ingredientes extras.";
            else
                OrderSummaryLabel.Text = "Seu pedido inclui: " + OrderSummaryLabel.Text;
        }

        private void Exercicio11_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
