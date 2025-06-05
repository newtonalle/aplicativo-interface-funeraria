namespace lista_de_exercicios
{
    partial class Exercicio11
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
            this.ConfirmOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderSummaryLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MussarelaCheckBox = new System.Windows.Forms.CheckBox();
            this.CatupiryCheckBox = new System.Windows.Forms.CheckBox();
            this.BaconCheckBox = new System.Windows.Forms.CheckBox();
            this.OnionCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(376, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 16;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // ConfirmOrderButton
            // 
            this.ConfirmOrderButton.Location = new System.Drawing.Point(12, 156);
            this.ConfirmOrderButton.Name = "ConfirmOrderButton";
            this.ConfirmOrderButton.Size = new System.Drawing.Size(161, 23);
            this.ConfirmOrderButton.TabIndex = 17;
            this.ConfirmOrderButton.Text = "Confirmar Pedido";
            this.ConfirmOrderButton.UseVisualStyleBackColor = true;
            this.ConfirmOrderButton.Click += new System.EventHandler(this.ConfirmOrder);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Resumo do Pedido";
            // 
            // OrderSummaryLabel
            // 
            this.OrderSummaryLabel.AutoSize = true;
            this.OrderSummaryLabel.Location = new System.Drawing.Point(192, 38);
            this.OrderSummaryLabel.MaximumSize = new System.Drawing.Size(180, 0);
            this.OrderSummaryLabel.MinimumSize = new System.Drawing.Size(180, 0);
            this.OrderSummaryLabel.Name = "OrderSummaryLabel";
            this.OrderSummaryLabel.Size = new System.Drawing.Size(180, 26);
            this.OrderSummaryLabel.TabIndex = 19;
            this.OrderSummaryLabel.Text = "Você ainda não confirmou um pedido!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OnionCheckBox);
            this.groupBox1.Controls.Add(this.BaconCheckBox);
            this.groupBox1.Controls.Add(this.CatupiryCheckBox);
            this.groupBox1.Controls.Add(this.MussarelaCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 112);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredientes Extra";
            // 
            // MussarelaCheckBox
            // 
            this.MussarelaCheckBox.AutoSize = true;
            this.MussarelaCheckBox.Location = new System.Drawing.Point(6, 20);
            this.MussarelaCheckBox.Name = "MussarelaCheckBox";
            this.MussarelaCheckBox.Size = new System.Drawing.Size(101, 17);
            this.MussarelaCheckBox.TabIndex = 0;
            this.MussarelaCheckBox.Text = "Mussarela Extra";
            this.MussarelaCheckBox.UseVisualStyleBackColor = true;
            // 
            // CatupiryCheckBox
            // 
            this.CatupiryCheckBox.AutoSize = true;
            this.CatupiryCheckBox.Location = new System.Drawing.Point(6, 43);
            this.CatupiryCheckBox.Name = "CatupiryCheckBox";
            this.CatupiryCheckBox.Size = new System.Drawing.Size(64, 17);
            this.CatupiryCheckBox.TabIndex = 1;
            this.CatupiryCheckBox.Text = "Catupiry";
            this.CatupiryCheckBox.UseVisualStyleBackColor = true;
            // 
            // BaconCheckBox
            // 
            this.BaconCheckBox.AutoSize = true;
            this.BaconCheckBox.Location = new System.Drawing.Point(6, 66);
            this.BaconCheckBox.Name = "BaconCheckBox";
            this.BaconCheckBox.Size = new System.Drawing.Size(57, 17);
            this.BaconCheckBox.TabIndex = 2;
            this.BaconCheckBox.Text = "Bacon";
            this.BaconCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnionCheckBox
            // 
            this.OnionCheckBox.AutoSize = true;
            this.OnionCheckBox.Location = new System.Drawing.Point(6, 89);
            this.OnionCheckBox.Name = "OnionCheckBox";
            this.OnionCheckBox.Size = new System.Drawing.Size(87, 17);
            this.OnionCheckBox.TabIndex = 3;
            this.OnionCheckBox.Text = "Cebola Roxa";
            this.OnionCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pedido de Pizza";
            // 
            // Exercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmOrderButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrderSummaryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextExerciseButton);
            this.Name = "Exercicio11";
            this.Text = "Exercício XI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio11_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextExerciseButton;
        private System.Windows.Forms.Button ConfirmOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrderSummaryLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox OnionCheckBox;
        private System.Windows.Forms.CheckBox BaconCheckBox;
        private System.Windows.Forms.CheckBox CatupiryCheckBox;
        private System.Windows.Forms.CheckBox MussarelaCheckBox;
        private System.Windows.Forms.Label label2;
    }
}