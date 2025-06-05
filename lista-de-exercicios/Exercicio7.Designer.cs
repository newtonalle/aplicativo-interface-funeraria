namespace lista_de_exercicios
{
    partial class Exercicio7
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
            this.components = new System.ComponentModel.Container();
            this.CPFTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nextExerciseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CPFTextBox
            // 
            this.CPFTextBox.Location = new System.Drawing.Point(25, 33);
            this.CPFTextBox.MaxLength = 11;
            this.CPFTextBox.Name = "CPFTextBox";
            this.CPFTextBox.Size = new System.Drawing.Size(120, 20);
            this.CPFTextBox.TabIndex = 1;
            this.CPFTextBox.TextChanged += new System.EventHandler(this.ValidateCPF);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira o seu CPF";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(241, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 11;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 169);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPFTextBox);
            this.Name = "Exercicio7";
            this.Text = "Exercício VII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio7_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CPFTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}