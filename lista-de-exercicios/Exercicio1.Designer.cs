namespace lista_de_exercicios
{
    partial class Exercicio1
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
            this.MudarTexto = new System.Windows.Forms.Button();
            this.labelTrocar = new System.Windows.Forms.Label();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MudarTexto
            // 
            this.MudarTexto.Location = new System.Drawing.Point(12, 12);
            this.MudarTexto.Name = "MudarTexto";
            this.MudarTexto.Size = new System.Drawing.Size(75, 23);
            this.MudarTexto.TabIndex = 0;
            this.MudarTexto.Text = "Mudar Texto";
            this.MudarTexto.UseVisualStyleBackColor = true;
            this.MudarTexto.Click += new System.EventHandler(this.MudarTexto_Click);
            // 
            // labelTrocar
            // 
            this.labelTrocar.AutoSize = true;
            this.labelTrocar.Location = new System.Drawing.Point(12, 38);
            this.labelTrocar.Name = "labelTrocar";
            this.labelTrocar.Size = new System.Drawing.Size(39, 13);
            this.labelTrocar.TabIndex = 1;
            this.labelTrocar.Text = "default";
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(220, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 2;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 148);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.labelTrocar);
            this.Controls.Add(this.MudarTexto);
            this.Name = "Exercicio1";
            this.Text = "Exercício I";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MudarTexto;
        private System.Windows.Forms.Label labelTrocar;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}