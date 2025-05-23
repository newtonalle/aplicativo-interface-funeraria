namespace UIFuneraria
{
    partial class AgendamentosPage
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
            this.AgendamentosSelect = new System.Windows.Forms.Button();
            this.PlanosSelect = new System.Windows.Forms.Button();
            this.ContatoSelect = new System.Windows.Forms.Button();
            this.DocumentacaoSelect = new System.Windows.Forms.Button();
            this.LojaSelect = new System.Windows.Forms.Button();
            this.LoginSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgendamentosSelect
            // 
            this.AgendamentosSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AgendamentosSelect.Location = new System.Drawing.Point(93, 12);
            this.AgendamentosSelect.Name = "AgendamentosSelect";
            this.AgendamentosSelect.Size = new System.Drawing.Size(88, 23);
            this.AgendamentosSelect.TabIndex = 3;
            this.AgendamentosSelect.Text = "Agendamentos";
            this.AgendamentosSelect.UseVisualStyleBackColor = false;
            // 
            // PlanosSelect
            // 
            this.PlanosSelect.Location = new System.Drawing.Point(12, 12);
            this.PlanosSelect.Name = "PlanosSelect";
            this.PlanosSelect.Size = new System.Drawing.Size(75, 23);
            this.PlanosSelect.TabIndex = 2;
            this.PlanosSelect.Text = "Planos";
            this.PlanosSelect.UseVisualStyleBackColor = true;
            this.PlanosSelect.Click += new System.EventHandler(this.PlanosSelect_Click);
            // 
            // ContatoSelect
            // 
            this.ContatoSelect.Location = new System.Drawing.Point(188, 12);
            this.ContatoSelect.Name = "ContatoSelect";
            this.ContatoSelect.Size = new System.Drawing.Size(75, 23);
            this.ContatoSelect.TabIndex = 4;
            this.ContatoSelect.Text = "Contato";
            this.ContatoSelect.UseVisualStyleBackColor = true;
            this.ContatoSelect.Click += new System.EventHandler(this.ContatoSelect_Click);
            // 
            // DocumentacaoSelect
            // 
            this.DocumentacaoSelect.Location = new System.Drawing.Point(269, 12);
            this.DocumentacaoSelect.Name = "DocumentacaoSelect";
            this.DocumentacaoSelect.Size = new System.Drawing.Size(89, 23);
            this.DocumentacaoSelect.TabIndex = 5;
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
            this.LoginSelect.Location = new System.Drawing.Point(727, 12);
            this.LoginSelect.Name = "LoginSelect";
            this.LoginSelect.Size = new System.Drawing.Size(61, 23);
            this.LoginSelect.TabIndex = 15;
            this.LoginSelect.Text = "Login";
            this.LoginSelect.UseVisualStyleBackColor = true;
            this.LoginSelect.Click += new System.EventHandler(this.LoginSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFuneraria.Properties.Resources.agendamento2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AgendamentosPage
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
            this.Name = "AgendamentosPage";
            this.Text = "Agendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AgendamentosSelect;
        private System.Windows.Forms.Button PlanosSelect;
        private System.Windows.Forms.Button ContatoSelect;
        private System.Windows.Forms.Button DocumentacaoSelect;
        private System.Windows.Forms.Button LojaSelect;
        private System.Windows.Forms.Button LoginSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}