namespace lista_de_exercicios
{
    partial class Exercicio13
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
            this.ApplyFiltersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilterPot = new System.Windows.Forms.CheckBox();
            this.FilterWood = new System.Windows.Forms.CheckBox();
            this.FilterFragile = new System.Windows.Forms.CheckBox();
            this.FilterAntique = new System.Windows.Forms.CheckBox();
            this.FilterGeneric = new System.Windows.Forms.CheckBox();
            this.FilteredProductsListBox = new System.Windows.Forms.ListBox();
            this.FilterUtility = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplyFiltersButton
            // 
            this.ApplyFiltersButton.Location = new System.Drawing.Point(492, 179);
            this.ApplyFiltersButton.Name = "ApplyFiltersButton";
            this.ApplyFiltersButton.Size = new System.Drawing.Size(176, 23);
            this.ApplyFiltersButton.TabIndex = 0;
            this.ApplyFiltersButton.Text = "Aplicar Filtros";
            this.ApplyFiltersButton.UseVisualStyleBackColor = true;
            this.ApplyFiltersButton.Click += new System.EventHandler(this.ApplyFilters);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilterUtility);
            this.groupBox1.Controls.Add(this.FilterGeneric);
            this.groupBox1.Controls.Add(this.FilterAntique);
            this.groupBox1.Controls.Add(this.FilterFragile);
            this.groupBox1.Controls.Add(this.FilterWood);
            this.groupBox1.Controls.Add(this.FilterPot);
            this.groupBox1.Location = new System.Drawing.Point(492, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // FilterPot
            // 
            this.FilterPot.AutoSize = true;
            this.FilterPot.Location = new System.Drawing.Point(6, 19);
            this.FilterPot.Name = "FilterPot";
            this.FilterPot.Size = new System.Drawing.Size(48, 17);
            this.FilterPot.TabIndex = 0;
            this.FilterPot.Text = "Pote";
            this.FilterPot.UseVisualStyleBackColor = true;
            // 
            // FilterWood
            // 
            this.FilterWood.AutoSize = true;
            this.FilterWood.Location = new System.Drawing.Point(6, 42);
            this.FilterWood.Name = "FilterWood";
            this.FilterWood.Size = new System.Drawing.Size(64, 17);
            this.FilterWood.TabIndex = 1;
            this.FilterWood.Text = "Madeira";
            this.FilterWood.UseVisualStyleBackColor = true;
            // 
            // FilterFragile
            // 
            this.FilterFragile.AutoSize = true;
            this.FilterFragile.Location = new System.Drawing.Point(6, 65);
            this.FilterFragile.Name = "FilterFragile";
            this.FilterFragile.Size = new System.Drawing.Size(51, 17);
            this.FilterFragile.TabIndex = 2;
            this.FilterFragile.Text = "Frágil";
            this.FilterFragile.UseVisualStyleBackColor = true;
            // 
            // FilterAntique
            // 
            this.FilterAntique.AutoSize = true;
            this.FilterAntique.Location = new System.Drawing.Point(6, 88);
            this.FilterAntique.Name = "FilterAntique";
            this.FilterAntique.Size = new System.Drawing.Size(82, 17);
            this.FilterAntique.TabIndex = 3;
            this.FilterAntique.Text = "Antiguidade";
            this.FilterAntique.UseVisualStyleBackColor = true;
            // 
            // FilterGeneric
            // 
            this.FilterGeneric.AutoSize = true;
            this.FilterGeneric.Location = new System.Drawing.Point(6, 111);
            this.FilterGeneric.Name = "FilterGeneric";
            this.FilterGeneric.Size = new System.Drawing.Size(69, 17);
            this.FilterGeneric.TabIndex = 4;
            this.FilterGeneric.Text = "Genérico";
            this.FilterGeneric.UseVisualStyleBackColor = true;
            // 
            // FilteredProductsListBox
            // 
            this.FilteredProductsListBox.FormattingEnabled = true;
            this.FilteredProductsListBox.Items.AddRange(new object[] {
            "Nenhum filtro selecionado!"});
            this.FilteredProductsListBox.Location = new System.Drawing.Point(12, 12);
            this.FilteredProductsListBox.Name = "FilteredProductsListBox";
            this.FilteredProductsListBox.Size = new System.Drawing.Size(454, 420);
            this.FilteredProductsListBox.TabIndex = 2;
            // 
            // FilterUtility
            // 
            this.FilterUtility.AutoSize = true;
            this.FilterUtility.Location = new System.Drawing.Point(6, 134);
            this.FilterUtility.Name = "FilterUtility";
            this.FilterUtility.Size = new System.Drawing.Size(67, 17);
            this.FilterUtility.TabIndex = 5;
            this.FilterUtility.Text = "Utilidade";
            this.FilterUtility.UseVisualStyleBackColor = true;
            // 
            // Exercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilteredProductsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ApplyFiltersButton);
            this.Name = "Exercicio13";
            this.Text = "Exercício XIII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio13_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ApplyFiltersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FilterGeneric;
        private System.Windows.Forms.CheckBox FilterAntique;
        private System.Windows.Forms.CheckBox FilterFragile;
        private System.Windows.Forms.CheckBox FilterWood;
        private System.Windows.Forms.CheckBox FilterPot;
        private System.Windows.Forms.ListBox FilteredProductsListBox;
        private System.Windows.Forms.CheckBox FilterUtility;
    }
}