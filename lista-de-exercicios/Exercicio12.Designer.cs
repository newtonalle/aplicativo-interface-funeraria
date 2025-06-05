namespace lista_de_exercicios
{
    partial class Exercicio12
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
            this.ExibitionOptions = new System.Windows.Forms.GroupBox();
            this.LanguagePreference = new System.Windows.Forms.GroupBox();
            this.DarkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowStatusBarCheckBox = new System.Windows.Forms.CheckBox();
            this.PortugueseRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            this.ApplyConfigButton = new System.Windows.Forms.Button();
            this.ConfigTitleLabel = new System.Windows.Forms.Label();
            this.ConfigSummaryLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ExibitionOptions.SuspendLayout();
            this.LanguagePreference.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(385, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 17;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // ExibitionOptions
            // 
            this.ExibitionOptions.Controls.Add(this.ShowStatusBarCheckBox);
            this.ExibitionOptions.Controls.Add(this.DarkModeCheckBox);
            this.ExibitionOptions.Location = new System.Drawing.Point(12, 31);
            this.ExibitionOptions.Name = "ExibitionOptions";
            this.ExibitionOptions.Size = new System.Drawing.Size(200, 73);
            this.ExibitionOptions.TabIndex = 18;
            this.ExibitionOptions.TabStop = false;
            this.ExibitionOptions.Text = "Opções de Exibição";
            // 
            // LanguagePreference
            // 
            this.LanguagePreference.Controls.Add(this.SpanishRadioButton);
            this.LanguagePreference.Controls.Add(this.EnglishRadioButton);
            this.LanguagePreference.Controls.Add(this.PortugueseRadioButton);
            this.LanguagePreference.Location = new System.Drawing.Point(12, 110);
            this.LanguagePreference.Name = "LanguagePreference";
            this.LanguagePreference.Size = new System.Drawing.Size(200, 101);
            this.LanguagePreference.TabIndex = 19;
            this.LanguagePreference.TabStop = false;
            this.LanguagePreference.Text = "Idioma Preferencial";
            // 
            // DarkModeCheckBox
            // 
            this.DarkModeCheckBox.AutoSize = true;
            this.DarkModeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.DarkModeCheckBox.Name = "DarkModeCheckBox";
            this.DarkModeCheckBox.Size = new System.Drawing.Size(89, 17);
            this.DarkModeCheckBox.TabIndex = 0;
            this.DarkModeCheckBox.Text = "Modo Escuro";
            this.DarkModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowStatusBarCheckBox
            // 
            this.ShowStatusBarCheckBox.AutoSize = true;
            this.ShowStatusBarCheckBox.Location = new System.Drawing.Point(6, 42);
            this.ShowStatusBarCheckBox.Name = "ShowStatusBarCheckBox";
            this.ShowStatusBarCheckBox.Size = new System.Drawing.Size(137, 17);
            this.ShowStatusBarCheckBox.TabIndex = 1;
            this.ShowStatusBarCheckBox.Text = "Mostrar Barra de Status";
            this.ShowStatusBarCheckBox.UseVisualStyleBackColor = true;
            // 
            // PortugueseRadioButton
            // 
            this.PortugueseRadioButton.AutoSize = true;
            this.PortugueseRadioButton.Location = new System.Drawing.Point(6, 20);
            this.PortugueseRadioButton.Name = "PortugueseRadioButton";
            this.PortugueseRadioButton.Size = new System.Drawing.Size(73, 17);
            this.PortugueseRadioButton.TabIndex = 0;
            this.PortugueseRadioButton.TabStop = true;
            this.PortugueseRadioButton.Text = "Português";
            this.PortugueseRadioButton.UseVisualStyleBackColor = true;
            this.PortugueseRadioButton.CheckedChanged += new System.EventHandler(this.PortugueseRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 43);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(53, 17);
            this.EnglishRadioButton.TabIndex = 1;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "Inglês";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(6, 66);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(69, 17);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.TabStop = true;
            this.SpanishRadioButton.Text = "Espanhol";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.SpanishRadioButton_CheckedChanged);
            // 
            // ApplyConfigButton
            // 
            this.ApplyConfigButton.Location = new System.Drawing.Point(12, 218);
            this.ApplyConfigButton.Name = "ApplyConfigButton";
            this.ApplyConfigButton.Size = new System.Drawing.Size(200, 22);
            this.ApplyConfigButton.TabIndex = 20;
            this.ApplyConfigButton.Text = "Aplicar Configurações";
            this.ApplyConfigButton.UseVisualStyleBackColor = true;
            this.ApplyConfigButton.Click += new System.EventHandler(this.ApplyConfig);
            // 
            // ConfigTitleLabel
            // 
            this.ConfigTitleLabel.AutoSize = true;
            this.ConfigTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigTitleLabel.Location = new System.Drawing.Point(9, 255);
            this.ConfigTitleLabel.Name = "ConfigTitleLabel";
            this.ConfigTitleLabel.Size = new System.Drawing.Size(88, 13);
            this.ConfigTitleLabel.TabIndex = 21;
            this.ConfigTitleLabel.Text = "Configurações";
            // 
            // ConfigSummaryLabel
            // 
            this.ConfigSummaryLabel.AutoSize = true;
            this.ConfigSummaryLabel.Location = new System.Drawing.Point(9, 278);
            this.ConfigSummaryLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ConfigSummaryLabel.Name = "ConfigSummaryLabel";
            this.ConfigSummaryLabel.Size = new System.Drawing.Size(199, 39);
            this.ConfigSummaryLabel.TabIndex = 22;
            this.ConfigSummaryLabel.Text = "Modo Escuro: Desativado, Mostrar Barra de Status: Desativado, Idioma: Português";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status I";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel2.Text = "Status II";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel3.Text = "Status III";
            // 
            // Exercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 357);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ConfigSummaryLabel);
            this.Controls.Add(this.ConfigTitleLabel);
            this.Controls.Add(this.ApplyConfigButton);
            this.Controls.Add(this.LanguagePreference);
            this.Controls.Add(this.ExibitionOptions);
            this.Controls.Add(this.nextExerciseButton);
            this.Name = "Exercicio12";
            this.Text = "Exercício XII";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio12_FormClosing);
            this.ExibitionOptions.ResumeLayout(false);
            this.ExibitionOptions.PerformLayout();
            this.LanguagePreference.ResumeLayout(false);
            this.LanguagePreference.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextExerciseButton;
        private System.Windows.Forms.GroupBox ExibitionOptions;
        private System.Windows.Forms.CheckBox ShowStatusBarCheckBox;
        private System.Windows.Forms.CheckBox DarkModeCheckBox;
        private System.Windows.Forms.GroupBox LanguagePreference;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.RadioButton PortugueseRadioButton;
        private System.Windows.Forms.Button ApplyConfigButton;
        private System.Windows.Forms.Label ConfigTitleLabel;
        private System.Windows.Forms.Label ConfigSummaryLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}