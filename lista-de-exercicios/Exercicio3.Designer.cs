namespace lista_de_exercicios
{
    partial class Exercicio3
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num1.Location = new System.Drawing.Point(36, 80);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 20);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num2.Location = new System.Drawing.Point(233, 80);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(90, 20);
            this.num2.TabIndex = 1;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(144, 59);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(23, 23);
            this.sumButton.TabIndex = 2;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.Sum);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(192, 59);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(23, 23);
            this.subtractionButton.TabIndex = 3;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.Subtract);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(144, 102);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(23, 23);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.Multiply);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(192, 102);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(23, 23);
            this.divisionButton.TabIndex = 5;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.Divide);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(148, 11);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Resultado: -";
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(488, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 7;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 163);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Exercicio3";
            this.Text = "Exercício III";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}