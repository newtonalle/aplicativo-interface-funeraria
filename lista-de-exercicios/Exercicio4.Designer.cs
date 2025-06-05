namespace lista_de_exercicios
{
    partial class Exercicio4
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
            this.CountingButton = new System.Windows.Forms.Button();
            this.NumberOfClicksLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountingButton
            // 
            this.CountingButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.CountingButton.Location = new System.Drawing.Point(24, 43);
            this.CountingButton.Name = "CountingButton";
            this.CountingButton.Size = new System.Drawing.Size(76, 76);
            this.CountingButton.TabIndex = 0;
            this.CountingButton.UseVisualStyleBackColor = false;
            this.CountingButton.Click += new System.EventHandler(this.CountingButton_Click);
            // 
            // NumberOfClicksLabel
            // 
            this.NumberOfClicksLabel.AutoSize = true;
            this.NumberOfClicksLabel.Location = new System.Drawing.Point(55, 18);
            this.NumberOfClicksLabel.Name = "NumberOfClicksLabel";
            this.NumberOfClicksLabel.Size = new System.Drawing.Size(13, 13);
            this.NumberOfClicksLabel.TabIndex = 1;
            this.NumberOfClicksLabel.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(24, 125);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Resetar";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(300, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 8;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 238);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NumberOfClicksLabel);
            this.Controls.Add(this.CountingButton);
            this.Name = "Exercicio4";
            this.Text = "Exercício IV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CountingButton;
        private System.Windows.Forms.Label NumberOfClicksLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}