namespace lista_de_exercicios
{
    partial class Exercicio8
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
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(496, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 12;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(12, 218);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(200, 23);
            this.SelectImageButton.TabIndex = 15;
            this.SelectImageButton.Text = "Selecionar Imagem";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.Location = new System.Drawing.Point(12, 247);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Size = new System.Drawing.Size(200, 23);
            this.ResetImageButton.TabIndex = 16;
            this.ResetImageButton.Text = "Resetar Imagem";
            this.ResetImageButton.UseVisualStyleBackColor = true;
            this.ResetImageButton.Click += new System.EventHandler(this.ResetImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Exercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 282);
            this.Controls.Add(this.ResetImageButton);
            this.Controls.Add(this.SelectImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextExerciseButton);
            this.Name = "Exercicio8";
            this.Text = "Exercício VIII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio8_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextExerciseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}