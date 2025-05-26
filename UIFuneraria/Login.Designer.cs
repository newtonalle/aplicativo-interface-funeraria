namespace UIFuneraria
{
    partial class LoginPage
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
            this.LoginSelect = new System.Windows.Forms.Button();
            this.DocumentacaoSelect = new System.Windows.Forms.Button();
            this.ContatoSelect = new System.Windows.Forms.Button();
            this.AgendamentosSelect = new System.Windows.Forms.Button();
            this.PlanosSelect = new System.Windows.Forms.Button();
            this.LojaSelect = new System.Windows.Forms.Button();
            this.InputNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.InputSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LoginCadastroSelect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginSelect
            // 
            this.LoginSelect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginSelect.Location = new System.Drawing.Point(727, 11);
            this.LoginSelect.Name = "LoginSelect";
            this.LoginSelect.Size = new System.Drawing.Size(61, 23);
            this.LoginSelect.TabIndex = 25;
            this.LoginSelect.Text = "Login";
            this.LoginSelect.UseVisualStyleBackColor = false;
            // 
            // DocumentacaoSelect
            // 
            this.DocumentacaoSelect.Location = new System.Drawing.Point(269, 11);
            this.DocumentacaoSelect.Name = "DocumentacaoSelect";
            this.DocumentacaoSelect.Size = new System.Drawing.Size(89, 23);
            this.DocumentacaoSelect.TabIndex = 24;
            this.DocumentacaoSelect.Text = "Documentação";
            this.DocumentacaoSelect.UseVisualStyleBackColor = true;
            this.DocumentacaoSelect.Click += new System.EventHandler(this.DocumentacaoSelect_Click);
            // 
            // ContatoSelect
            // 
            this.ContatoSelect.Location = new System.Drawing.Point(188, 12);
            this.ContatoSelect.Name = "ContatoSelect";
            this.ContatoSelect.Size = new System.Drawing.Size(75, 23);
            this.ContatoSelect.TabIndex = 23;
            this.ContatoSelect.Text = "Contato";
            this.ContatoSelect.UseVisualStyleBackColor = true;
            this.ContatoSelect.Click += new System.EventHandler(this.ContatoSelect_Click);
            // 
            // AgendamentosSelect
            // 
            this.AgendamentosSelect.Location = new System.Drawing.Point(93, 12);
            this.AgendamentosSelect.Name = "AgendamentosSelect";
            this.AgendamentosSelect.Size = new System.Drawing.Size(88, 23);
            this.AgendamentosSelect.TabIndex = 22;
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
            this.PlanosSelect.TabIndex = 21;
            this.PlanosSelect.Text = "Planos";
            this.PlanosSelect.UseVisualStyleBackColor = false;
            this.PlanosSelect.Click += new System.EventHandler(this.PlanosSelect_Click);
            // 
            // LojaSelect
            // 
            this.LojaSelect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LojaSelect.Location = new System.Drawing.Point(518, 12);
            this.LojaSelect.Name = "LojaSelect";
            this.LojaSelect.Size = new System.Drawing.Size(47, 23);
            this.LojaSelect.TabIndex = 20;
            this.LojaSelect.Text = "Loja";
            this.LojaSelect.UseVisualStyleBackColor = false;
            this.LojaSelect.Click += new System.EventHandler(this.LojaSelect_Click);
            // 
            // InputNome
            // 
            this.InputNome.Location = new System.Drawing.Point(310, 153);
            this.InputNome.Name = "InputNome";
            this.InputNome.Size = new System.Drawing.Size(189, 20);
            this.InputNome.TabIndex = 26;
            this.InputNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(310, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Funcionário/Cliente";
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(310, 201);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(189, 20);
            this.InputEmail.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(310, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Email";
            // 
            // InputSenha
            // 
            this.InputSenha.Location = new System.Drawing.Point(310, 247);
            this.InputSenha.Name = "InputSenha";
            this.InputSenha.PasswordChar = '*';
            this.InputSenha.Size = new System.Drawing.Size(189, 20);
            this.InputSenha.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(310, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Senha";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(310, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 17);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Faça log in ou crie uma conta";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // LoginCadastroSelect
            // 
            this.LoginCadastroSelect.BackColor = System.Drawing.Color.Brown;
            this.LoginCadastroSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCadastroSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginCadastroSelect.Location = new System.Drawing.Point(331, 285);
            this.LoginCadastroSelect.Name = "LoginCadastroSelect";
            this.LoginCadastroSelect.Size = new System.Drawing.Size(146, 40);
            this.LoginCadastroSelect.TabIndex = 34;
            this.LoginCadastroSelect.Text = "Login/Cadastro";
            this.LoginCadastroSelect.UseVisualStyleBackColor = false;
            this.LoginCadastroSelect.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UIFuneraria.Properties.Resources.fundologin;
            this.pictureBox1.Location = new System.Drawing.Point(269, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 255);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginCadastroSelect);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputNome);
            this.Controls.Add(this.LoginSelect);
            this.Controls.Add(this.DocumentacaoSelect);
            this.Controls.Add(this.ContatoSelect);
            this.Controls.Add(this.AgendamentosSelect);
            this.Controls.Add(this.PlanosSelect);
            this.Controls.Add(this.LojaSelect);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginSelect;
        private System.Windows.Forms.Button DocumentacaoSelect;
        private System.Windows.Forms.Button ContatoSelect;
        private System.Windows.Forms.Button AgendamentosSelect;
        private System.Windows.Forms.Button PlanosSelect;
        private System.Windows.Forms.Button LojaSelect;
        private System.Windows.Forms.TextBox InputNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button LoginCadastroSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}