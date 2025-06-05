﻿namespace UIFuneraria
{
    partial class CadastroDeProdutosPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnToStoreButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CreateNewProductButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnToStoreButton
            // 
            this.ReturnToStoreButton.Location = new System.Drawing.Point(398, 12);
            this.ReturnToStoreButton.Name = "ReturnToStoreButton";
            this.ReturnToStoreButton.Size = new System.Drawing.Size(75, 23);
            this.ReturnToStoreButton.TabIndex = 0;
            this.ReturnToStoreButton.Text = "Voltar à Loja";
            this.ReturnToStoreButton.UseVisualStyleBackColor = true;
            this.ReturnToStoreButton.Click += new System.EventHandler(this.ReturnToStore);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço (R$)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PriceTextBox);
            this.groupBox1.Controls.Add(this.TypeTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Produto";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(6, 129);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(188, 20);
            this.PriceTextBox.TabIndex = 5;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(6, 81);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(188, 20);
            this.TypeTextBox.TabIndex = 4;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(6, 32);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // CreateNewProductButton
            // 
            this.CreateNewProductButton.Location = new System.Drawing.Point(12, 179);
            this.CreateNewProductButton.Name = "CreateNewProductButton";
            this.CreateNewProductButton.Size = new System.Drawing.Size(200, 25);
            this.CreateNewProductButton.TabIndex = 5;
            this.CreateNewProductButton.Text = "Cadastrar Produto";
            this.CreateNewProductButton.UseVisualStyleBackColor = true;
            this.CreateNewProductButton.Click += new System.EventHandler(this.CreateNewProduct);
            // 
            // CadastroDeProdutosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 292);
            this.Controls.Add(this.CreateNewProductButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReturnToStoreButton);
            this.Name = "CadastroDeProdutosPage";
            this.Text = "CadastroDeProdutosPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WhenFormCloses);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToStoreButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CreateNewProductButton;
    }
}