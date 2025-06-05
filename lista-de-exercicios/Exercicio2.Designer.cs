namespace lista_de_exercicios
{
    partial class Exercicio2
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
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaudacoesButton = new System.Windows.Forms.Button();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(12, 33);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira seu nome";
            // 
            // SaudacoesButton
            // 
            this.SaudacoesButton.Location = new System.Drawing.Point(12, 59);
            this.SaudacoesButton.Name = "SaudacoesButton";
            this.SaudacoesButton.Size = new System.Drawing.Size(75, 23);
            this.SaudacoesButton.TabIndex = 3;
            this.SaudacoesButton.Text = "Saudações";
            this.SaudacoesButton.UseVisualStyleBackColor = true;
            this.SaudacoesButton.Click += new System.EventHandler(this.SaudacoesButton_Click);
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(194, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 4;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 133);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.SaudacoesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeTextBox);
            this.Name = "Exercicio2";
            this.Text = "Exercício II";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaudacoesButton;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}