using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio9 : Form
    {
        int timerTime = 0;

        public Exercicio9()
        {
            InitializeComponent();
        }

        private void StartTimer(object sender, EventArgs e)
        {
            timer1.Start();
            StartTimerButton.Enabled = false;
            StopTimerButton.Enabled = true;
        }

        private void StopTimer(object sender, EventArgs e)
        {
            timer1.Stop();
            StopTimerButton.Enabled = false;
            StartTimerButton.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTime += 1;

            int timerTimeHours = int.Parse(Math.Floor((double)(timerTime / 3600)).ToString());
            int timerTimeMinutes = int.Parse(Math.Floor((double)(((timerTime - (timerTimeHours * 3600))) / 60)).ToString());
            int timerTimeSeconds = timerTime - (timerTimeHours * 3600) - (timerTimeMinutes * 60);

            string timerTimeHoursString = timerTimeHours.ToString();
            if(timerTimeHours < 10)
            {
                timerTimeHoursString = "0" + timerTimeHoursString;
            }

            string timerTimeMinutesString = timerTimeMinutes.ToString();
            if (timerTimeMinutes < 10)
            {
                timerTimeMinutesString = "0" + timerTimeMinutesString;
            }

            string timerTimeSecondsString = timerTimeSeconds.ToString();
            if (timerTimeSeconds < 10)
            {
                timerTimeSecondsString = "0" + timerTimeSecondsString;
            }

            TimerLabel.Text = timerTimeHoursString + ":" + timerTimeMinutesString + ":" + timerTimeSecondsString;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int currentTimeHours = DateTime.Now.Hour;
            int currentTimeMinutes = DateTime.Now.Minute;
            int currentTimeSeconds = DateTime.Now.Second;

            string currentTimeHoursString = currentTimeHours.ToString();
            if (currentTimeHours < 10)
            {
                currentTimeHoursString = "0" + currentTimeHoursString;
            }

            string currentTimeMinutesString = currentTimeMinutes.ToString();
            if (currentTimeMinutes < 10)
            {
                currentTimeMinutesString = "0" + currentTimeMinutesString;
            }

            string currentTimeSecondsString = currentTimeSeconds.ToString();
            if (currentTimeSeconds < 10)
            {
                currentTimeSecondsString = "0" + currentTimeSecondsString;
            }

            CurrentTimeLabel.Text = currentTimeHoursString + ":" + currentTimeMinutesString + ":" + currentTimeSecondsString;
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio10MDI nextForms = new Exercicio10MDI();
            nextForms.Show();
        }

        private void Exercicio9_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
