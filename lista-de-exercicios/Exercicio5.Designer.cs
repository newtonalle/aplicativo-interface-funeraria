namespace lista_de_exercicios
{
    partial class Exercicio5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddListItemButton = new System.Windows.Forms.Button();
            this.NewItemTextBox = new System.Windows.Forms.TextBox();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 199);
            this.listBox1.TabIndex = 0;
            // 
            // AddListItemButton
            // 
            this.AddListItemButton.Location = new System.Drawing.Point(118, 10);
            this.AddListItemButton.Name = "AddListItemButton";
            this.AddListItemButton.Size = new System.Drawing.Size(25, 23);
            this.AddListItemButton.TabIndex = 1;
            this.AddListItemButton.Text = "+";
            this.AddListItemButton.UseVisualStyleBackColor = true;
            this.AddListItemButton.Click += new System.EventHandler(this.AddListItem);
            // 
            // NewItemTextBox
            // 
            this.NewItemTextBox.Location = new System.Drawing.Point(12, 12);
            this.NewItemTextBox.Name = "NewItemTextBox";
            this.NewItemTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewItemTextBox.TabIndex = 2;
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(232, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 9;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remover Selecionado";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RemoveSelectedListItem);
            // 
            // Exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.NewItemTextBox);
            this.Controls.Add(this.AddListItemButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Exercicio5";
            this.Text = "Exercício V";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio5_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddListItemButton;
        private System.Windows.Forms.TextBox NewItemTextBox;
        private System.Windows.Forms.Button nextExerciseButton;
        private System.Windows.Forms.Button button1;
    }
}