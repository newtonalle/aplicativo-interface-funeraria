namespace lista_de_exercicios
{
    partial class Exercicio10MDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.OpenForms1Button = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenForms2Button = new System.Windows.Forms.ToolStripMenuItem();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenForms1Button,
            this.OpenForms2Button});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // OpenForms1Button
            // 
            this.OpenForms1Button.Name = "OpenForms1Button";
            this.OpenForms1Button.Size = new System.Drawing.Size(112, 20);
            this.OpenForms1Button.Text = "Abrir Formulário I";
            this.OpenForms1Button.Click += new System.EventHandler(this.OpenForms1);
            // 
            // OpenForms2Button
            // 
            this.OpenForms2Button.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.OpenForms2Button.Name = "OpenForms2Button";
            this.OpenForms2Button.Size = new System.Drawing.Size(115, 20);
            this.OpenForms2Button.Text = "Abrir Formulário II";
            this.OpenForms2Button.Click += new System.EventHandler(this.OpenForms2);
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(506, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 15;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // Exercicio10MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Exercicio10MDI";
            this.Text = "Exercício X";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio10MDI_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenForms1Button;
        private System.Windows.Forms.ToolStripMenuItem OpenForms2Button;
        private System.Windows.Forms.Button nextExerciseButton;
    }
}



