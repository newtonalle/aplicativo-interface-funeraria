namespace lista_de_exercicios
{
    partial class Exercicio9
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimerButton = new System.Windows.Forms.Button();
            this.StopTimerButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.nextExerciseButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            // 
            // StartTimerButton
            // 
            this.StartTimerButton.Location = new System.Drawing.Point(54, 67);
            this.StartTimerButton.Name = "StartTimerButton";
            this.StartTimerButton.Size = new System.Drawing.Size(85, 21);
            this.StartTimerButton.TabIndex = 1;
            this.StartTimerButton.Text = "Iniciar";
            this.StartTimerButton.UseVisualStyleBackColor = true;
            this.StartTimerButton.Click += new System.EventHandler(this.StartTimer);
            // 
            // StopTimerButton
            // 
            this.StopTimerButton.Enabled = false;
            this.StopTimerButton.Location = new System.Drawing.Point(54, 94);
            this.StopTimerButton.Name = "StopTimerButton";
            this.StopTimerButton.Size = new System.Drawing.Size(85, 23);
            this.StopTimerButton.TabIndex = 2;
            this.StopTimerButton.Text = "Parar";
            this.StopTimerButton.UseVisualStyleBackColor = true;
            this.StopTimerButton.Click += new System.EventHandler(this.StopTimer);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora Atual";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(251, 37);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrentTimeLabel.TabIndex = 4;
            this.CurrentTimeLabel.Text = "00:00:00";
            this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(90, 37);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(49, 13);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "00:00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextExerciseButton
            // 
            this.nextExerciseButton.BackColor = System.Drawing.Color.OliveDrab;
            this.nextExerciseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextExerciseButton.Location = new System.Drawing.Point(336, 12);
            this.nextExerciseButton.Name = "nextExerciseButton";
            this.nextExerciseButton.Size = new System.Drawing.Size(114, 23);
            this.nextExerciseButton.TabIndex = 13;
            this.nextExerciseButton.Text = "Próximo Exercício ->";
            this.nextExerciseButton.UseVisualStyleBackColor = false;
            this.nextExerciseButton.Click += new System.EventHandler(this.NextExercise);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Exercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 137);
            this.Controls.Add(this.nextExerciseButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StopTimerButton);
            this.Controls.Add(this.StartTimerButton);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio9";
            this.Text = "Exercício IX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exercicio9_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartTimerButton;
        private System.Windows.Forms.Button StopTimerButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Button nextExerciseButton;
        private System.Windows.Forms.Timer timer2;
    }
}