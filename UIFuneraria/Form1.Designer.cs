namespace UIFuneraria
{
    partial class PlanosPage
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
            this.PlanosSelect = new System.Windows.Forms.Button();
            this.AgendamentosSelect = new System.Windows.Forms.Button();
            this.ContatoSelect = new System.Windows.Forms.Button();
            this.DocumentacaoSelect = new System.Windows.Forms.Button();
            this.LojaSelect = new System.Windows.Forms.Button();
            this.LoginSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanosSelect
            // 
            this.PlanosSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PlanosSelect.Location = new System.Drawing.Point(12, 12);
            this.PlanosSelect.Name = "PlanosSelect";
            this.PlanosSelect.Size = new System.Drawing.Size(75, 23);
            this.PlanosSelect.TabIndex = 0;
            this.PlanosSelect.Text = "Planos";
            this.PlanosSelect.UseVisualStyleBackColor = false;
            this.PlanosSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgendamentosSelect
            // 
            this.AgendamentosSelect.Location = new System.Drawing.Point(93, 12);
            this.AgendamentosSelect.Name = "AgendamentosSelect";
            this.AgendamentosSelect.Size = new System.Drawing.Size(88, 23);
            this.AgendamentosSelect.TabIndex = 1;
            this.AgendamentosSelect.Text = "Agendamentos";
            this.AgendamentosSelect.UseVisualStyleBackColor = true;
            this.AgendamentosSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContatoSelect
            // 
            this.ContatoSelect.Location = new System.Drawing.Point(188, 12);
            this.ContatoSelect.Name = "ContatoSelect";
            this.ContatoSelect.Size = new System.Drawing.Size(75, 23);
            this.ContatoSelect.TabIndex = 2;
            this.ContatoSelect.Text = "Contato";
            this.ContatoSelect.UseVisualStyleBackColor = true;
            this.ContatoSelect.Click += new System.EventHandler(this.ContatoSelect_Click);
            // 
            // DocumentacaoSelect
            // 
            this.DocumentacaoSelect.Location = new System.Drawing.Point(269, 11);
            this.DocumentacaoSelect.Name = "DocumentacaoSelect";
            this.DocumentacaoSelect.Size = new System.Drawing.Size(89, 23);
            this.DocumentacaoSelect.TabIndex = 6;
            this.DocumentacaoSelect.Text = "Documentação";
            this.DocumentacaoSelect.UseVisualStyleBackColor = true;
            this.DocumentacaoSelect.Click += new System.EventHandler(this.DocumentacaoSelect_Click);
            // 
            // LojaSelect
            // 
            this.LojaSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LojaSelect.Location = new System.Drawing.Point(518, 12);
            this.LojaSelect.Name = "LojaSelect";
            this.LojaSelect.Size = new System.Drawing.Size(47, 23);
            this.LojaSelect.TabIndex = 14;
            this.LojaSelect.Text = "Loja";
            this.LojaSelect.UseVisualStyleBackColor = false;
            this.LojaSelect.Click += new System.EventHandler(this.LojaSelect_Click);
            // 
            // LoginSelect
            // 
            this.LoginSelect.Location = new System.Drawing.Point(727, 11);
            this.LoginSelect.Name = "LoginSelect";
            this.LoginSelect.Size = new System.Drawing.Size(61, 23);
            this.LoginSelect.TabIndex = 15;
            this.LoginSelect.Text = "Login";
            this.LoginSelect.UseVisualStyleBackColor = true;
            this.LoginSelect.Click += new System.EventHandler(this.LoginSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFuneraria.Properties.Resources.plano2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PlanosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginSelect);
            this.Controls.Add(this.LojaSelect);
            this.Controls.Add(this.DocumentacaoSelect);
            this.Controls.Add(this.ContatoSelect);
            this.Controls.Add(this.AgendamentosSelect);
            this.Controls.Add(this.PlanosSelect);
            this.Name = "PlanosPage";
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlanosSelect;
        private System.Windows.Forms.Button AgendamentosSelect;
        private System.Windows.Forms.Button ContatoSelect;
        private System.Windows.Forms.Button DocumentacaoSelect;
        private System.Windows.Forms.Button LojaSelect;
        private System.Windows.Forms.Button LoginSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

