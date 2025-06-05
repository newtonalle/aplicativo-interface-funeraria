using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio13 : Form
    {
        public class Product
        {
            public string productName;
            public string tag;
            public string type;

            public Product(string productNameContructor, string tagContructor, string typeContructor)
            {
                productName = productNameContructor;
                tag = tagContructor;
                type = typeContructor;
            }
        }

        List<Product> products = new List<Product>();

        public Exercicio13()
        {
            InitializeComponent();

            products.Add(new Product("Pote Gysa", "Pote", "Antiguidade"));
            products.Add(new Product("Pote Berlim", "Pote", "Antiguidade"));
            products.Add(new Product("Terrário de Vidro", "Frágil", "Utilidade"));
            products.Add(new Product("Vaso de Cerâmica", "Pote", "Genérico"));
            products.Add(new Product("Cadeira Tripodal", "Madeira", "Utilidade"));
            products.Add(new Product("Mesa Tripodal", "Madeira", "Utilidade"));
            products.Add(new Product("Ornamento Especial", "Madeira", "Antiguidade"));
            products.Add(new Product("Painel de Vidro", "Frágil", "Genérico"));
            products.Add(new Product("Pote Grandt", "Pote", "Genérico"));
            products.Add(new Product("Vaso de Plantas MII", "Pote", "Utilidade"));
            products.Add(new Product("Porta de Carvalho", "Madeira", "Genérico"));
            products.Add(new Product("Vaso de Plantas MX", "Pote", "Utilidade"));
            products.Add(new Product("Cristal Maia", "Frágil", "Antiguidade"));
            products.Add(new Product("Ornamento de Cerâmica", "Frágil", "Genérico"));
            products.Add(new Product("Graveto Imortal", "Madeira", "Antiguidade"));
        }

        private void ApplyFilters(object sender, EventArgs e)
        {
            FilteredProductsListBox.Items.Clear();

            if (!FilterPot.Checked && !FilterFragile.Checked && !FilterWood.Checked && !FilterUtility.Checked && !FilterGeneric.Checked && !FilterAntique.Checked)
                FilteredProductsListBox.Items.Add("Nenhum filtro selecionado!");
            else
                products.ForEach((product) =>
                {
                    if ((FilterAntique.Checked && (product.type == "Antiguidade")) || (FilterGeneric.Checked && (product.type == "Genérico")) || (FilterUtility.Checked && (product.type == "Utilidade")) || (FilterWood.Checked && (product.tag == "Madeira")) || (FilterFragile.Checked && (product.tag == "Frágil")) || (FilterPot.Checked && (product.tag == "Pote")))
                    {
                        FilteredProductsListBox.Items.Add(product.productName + " - (" + product.type + ", " + product.tag + ")");
                    }
                });
        }

        private void Exercicio13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
