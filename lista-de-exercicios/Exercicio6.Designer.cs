namespace lista_de_exercicios
{
    partial class Exercicio6
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
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonRed = new System.Windows.Forms.RadioButton();
            this.RadioButtonBlue = new System.Windows.Forms.RadioButton();
            this.RadioButtonGreen = new System.Windows.Forms.RadioButton();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha sua cor favorita:";
            // 
            // RadioButtonRed
            // 
            this.RadioButtonRed.AutoSize = true;
            this.RadioButtonRed.Location = new System.Drawing.Point(15, 31);
            this.RadioButtonRed.Name = "RadioButtonRed";
            this.RadioButtonRed.Size = new System.Drawing.Size(69, 17);
            this.RadioButtonRed.TabIndex = 1;
            this.RadioButtonRed.TabStop = true;
            this.RadioButtonRed.Text = "Vermelho";
            this.RadioButtonRed.UseVisualStyleBackColor = true;
            this.RadioButtonRed.CheckedChanged += new System.EventHandler(this.RadioButtonRed_CheckedChanged);
            // 
            // RadioButtonBlue
            // 
            this.RadioButtonBlue.AutoSize = true;
            this.RadioButtonBlue.Location = new System.Drawing.Point(15, 54);
            this.RadioButtonBlue.Name = "RadioButtonBlue";
            this.RadioButtonBlue.Size = new System.Drawing.Size(45, 17);
            this.RadioButtonBlue.TabIndex = 2;
            this.RadioButtonBlue.TabStop = true;
            this.RadioButtonBlue.Text = "Azul";
            this.RadioButtonBlue.UseVisualStyleBackColor = true;
            this.RadioButtonBlue.CheckedChanged += new System.EventHandler(this.RadioButtonBlue_CheckedChanged);
            // 
            // RadioButtonGreen
            // 
            this.RadioButtonGreen.AutoSize = true;
            this.RadioButtonGreen.Location = new System.Drawing.Point(15, 77);
            this.RadioButtonGreen.Name = "RadioButtonGreen";
            this.RadioButtonGreen.Size = new System.Drawing.Size(53, 17);
            this.RadioButtonGreen.TabIndex = 3;
            this.RadioButtonGreen.TabStop = true;
            this.RadioButtonGreen.Text = "Verde";
            this.RadioButtonGreen.UseVisualStyleBackColor = true;
            this.RadioButtonGreen.CheckedChanged += new System.EventHandler(this.RadioButtonGreen_CheckedChanged);
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(287, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 10;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 253);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.RadioButtonGreen);
            this.Controls.Add(this.RadioButtonBlue);
            this.Controls.Add(this.RadioButtonRed);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio6";
            this.Text = "Exercício VI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio6_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButtonRed;
        private System.Windows.Forms.RadioButton RadioButtonBlue;
        private System.Windows.Forms.RadioButton RadioButtonGreen;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}