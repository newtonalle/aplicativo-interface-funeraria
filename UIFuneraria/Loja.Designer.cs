namespace UIFuneraria
{
    partial class LojaPage
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
            this.LojaSelect = new System.Windows.Forms.Button();
            this.DocumentacaoSelect = new System.Windows.Forms.Button();
            this.ContatoSelect = new System.Windows.Forms.Button();
            this.AgendamentosSelect = new System.Windows.Forms.Button();
            this.PlanosSelect = new System.Windows.Forms.Button();
            this.LoginSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LojaSelect
            // 
            this.LojaSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LojaSelect.Location = new System.Drawing.Point(518, 12);
            this.LojaSelect.Name = "LojaSelect";
            this.LojaSelect.Size = new System.Drawing.Size(47, 23);
            this.LojaSelect.TabIndex = 14;
            this.LojaSelect.Text = "Loja";
            this.LojaSelect.UseVisualStyleBackColor = false;
            // 
            // DocumentacaoSelect
            // 
            this.DocumentacaoSelect.Location = new System.Drawing.Point(269, 11);
            this.DocumentacaoSelect.Name = "DocumentacaoSelect";
            this.DocumentacaoSelect.Size = new System.Drawing.Size(89, 23);
            this.DocumentacaoSelect.TabIndex = 18;
            this.DocumentacaoSelect.Text = "Documentação";
            this.DocumentacaoSelect.UseVisualStyleBackColor = true;
            this.DocumentacaoSelect.Click += new System.EventHandler(this.DocumentacaoSelect_Click);
            // 
            // ContatoSelect
            // 
            this.ContatoSelect.Location = new System.Drawing.Point(188, 12);
            this.ContatoSelect.Name = "ContatoSelect";
            this.ContatoSelect.Size = new System.Drawing.Size(75, 23);
            this.ContatoSelect.TabIndex = 17;
            this.ContatoSelect.Text = "Contato";
            this.ContatoSelect.UseVisualStyleBackColor = true;
            this.ContatoSelect.Click += new System.EventHandler(this.ContatoSelect_Click);
            // 
            // AgendamentosSelect
            // 
            this.AgendamentosSelect.Location = new System.Drawing.Point(93, 12);
            this.AgendamentosSelect.Name = "AgendamentosSelect";
            this.AgendamentosSelect.Size = new System.Drawing.Size(88, 23);
            this.AgendamentosSelect.TabIndex = 16;
            this.AgendamentosSelect.Text = "Agendamentos";
            this.AgendamentosSelect.UseVisualStyleBackColor = true;
            this.AgendamentosSelect.Click += new System.EventHandler(this.AgendamentosSelect_Click);
            // 
            // PlanosSelect
            // 
            this.PlanosSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PlanosSelect.Location = new System.Drawing.Point(12, 12);
            this.PlanosSelect.Name = "PlanosSelect";
            this.PlanosSelect.Size = new System.Drawing.Size(75, 23);
            this.PlanosSelect.TabIndex = 15;
            this.PlanosSelect.Text = "Planos";
            this.PlanosSelect.UseVisualStyleBackColor = false;
            this.PlanosSelect.Click += new System.EventHandler(this.PlanosSelect_Click);
            // 
            // LoginSelect
            // 
            this.LoginSelect.Location = new System.Drawing.Point(727, 11);
            this.LoginSelect.Name = "LoginSelect";
            this.LoginSelect.Size = new System.Drawing.Size(61, 23);
            this.LoginSelect.TabIndex = 19;
            this.LoginSelect.Text = "Login";
            this.LoginSelect.UseVisualStyleBackColor = true;
            this.LoginSelect.Click += new System.EventHandler(this.LoginSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFuneraria.Properties.Resources.loja1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // LojaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginSelect);
            this.Controls.Add(this.DocumentacaoSelect);
            this.Controls.Add(this.ContatoSelect);
            this.Controls.Add(this.AgendamentosSelect);
            this.Controls.Add(this.PlanosSelect);
            this.Controls.Add(this.LojaSelect);
            this.Name = "LojaPage";
            this.Text = "Loja";
            this.Load += new System.EventHandler(this.LojaPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LojaSelect;
        private System.Windows.Forms.Button DocumentacaoSelect;
        private System.Windows.Forms.Button ContatoSelect;
        private System.Windows.Forms.Button AgendamentosSelect;
        private System.Windows.Forms.Button PlanosSelect;
        private System.Windows.Forms.Button LoginSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}