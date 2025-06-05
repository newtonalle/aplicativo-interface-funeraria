using System;
using System.Drawing;
using System.Windows.Forms;

namespace lista_de_exercicios
{
    public partial class Exercicio12 : Form
    {
        string selectedLanguage = "portuguese";
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void NextExercise(object sender, EventArgs e)
        {
            this.Hide();
            Exercicio13 nextForms = new Exercicio13();
            nextForms.Show();
        }

        private void ApplyConfig(object sender, EventArgs e)
        {
            string darkModeString = "";
            string showStatusBarString = "";
            string languageString = "";

            // Dark Mode Switch

            if (DarkModeCheckBox.Checked)
            {
                // Dark Mode

                switch (selectedLanguage)
                {
                    case "portuguese":
                        darkModeString = "Ativado";
                        break;
                    case "english":
                        darkModeString = "Enabled";
                        break;
                    case "spanish":
                        darkModeString = "Activado";
                        break;
                }   

                this.BackColor = Color.Black;
                this.ForeColor = SystemColors.Control;
                ApplyConfigButton.ForeColor = Color.Black;
                ExibitionOptions.ForeColor = SystemColors.Control;
                LanguagePreference.ForeColor = SystemColors.Control;
            }
            else
            {
                // Light Mode

                switch (selectedLanguage)
                {
                    case "portuguese":
                        darkModeString = "Desativado";
                        break;
                    case "english":
                        darkModeString = "Disabled";
                        break;
                    case "spanish":
                        darkModeString = "Desactivado";
                        break;
                }

                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
                ApplyConfigButton.ForeColor = Color.Black;
                ExibitionOptions.ForeColor = Color.Black;
                LanguagePreference.ForeColor = Color.Black;
            }


            // Show Status Bar

            statusStrip1.Visible = ShowStatusBarCheckBox.Checked;

            if(ShowStatusBarCheckBox.Checked) {
                switch (selectedLanguage)
                {
                    case "portuguese":
                        showStatusBarString = "Ativado";
                        break;
                    case "english":
                        showStatusBarString = "Enabled";
                        break;
                    case "spanish":
                        showStatusBarString = "Activado";
                        break;
                }
            }
            else {
                switch (selectedLanguage)
                {
                    case "portuguese":
                        showStatusBarString = "Desativado";
                        break;
                    case "english":
                        showStatusBarString = "Disabled";
                        break;
                    case "spanish":
                        showStatusBarString = "Desactivado";
                        break;
                }
            }
            // Language Preference

            switch (selectedLanguage)
            {
                case "portuguese":
                    nextExerciseButton.Text = "Próximo Exercício ->";

                    ExibitionOptions.Text = "Opções de Exibição";
                    DarkModeCheckBox.Text = "Modo Escuro";
                    ShowStatusBarCheckBox.Text = "Mostrar Barra de Status";

                    LanguagePreference.Text = "Idioma Preferencial";
                    PortugueseRadioButton.Text = "Português";
                    EnglishRadioButton.Text = "Inglês";
                    SpanishRadioButton.Text = "Espanhol";

                    ApplyConfigButton.Text = "Aplicar Configurações";
                    ConfigTitleLabel.Text = "Configurações";

                    toolStripStatusLabel1.Text = "Status I";
                    toolStripStatusLabel2.Text = "Status II";
                    toolStripStatusLabel3.Text = "Status III";

                    this.Text = "Exercício XII";


                    languageString = "Português";

                    ConfigSummaryLabel.Text = "Modo Escuro: " + darkModeString + ", Mostrar Barra de Status: " + showStatusBarString + ", Idioma: " + languageString;
                    break;
                case "english":
                    nextExerciseButton.Text = "Next Exercise ->";

                    ExibitionOptions.Text = "Exibition Options";
                    DarkModeCheckBox.Text = "Dark Mode";
                    ShowStatusBarCheckBox.Text = "Show Status Bar";

                    LanguagePreference.Text = "Language Preference";
                    PortugueseRadioButton.Text = "Portuguese";
                    EnglishRadioButton.Text = "English";
                    SpanishRadioButton.Text = "Spanish";

                    ApplyConfigButton.Text = "Apply Config";
                    ConfigTitleLabel.Text = "Configurations";

                    toolStripStatusLabel1.Text = "Status I";
                    toolStripStatusLabel2.Text = "Status II";
                    toolStripStatusLabel3.Text = "Status III";

                    this.Text = "Exercise XII";

                    languageString = "English";

                    ConfigSummaryLabel.Text = "Dark Mode: " + darkModeString + ", Show Status Bar: " + showStatusBarString + ", Language: " + languageString;
                    break;
                case "spanish":
                    nextExerciseButton.Text = "Próximo Ejercicio ->";

                    ExibitionOptions.Text = "Opciones de Visualización";
                    DarkModeCheckBox.Text = "Modo Oscuro";
                    ShowStatusBarCheckBox.Text = "Mostrar Barra de Estado";

                    LanguagePreference.Text = "Idioma Preferido";
                    PortugueseRadioButton.Text = "Portugués";
                    EnglishRadioButton.Text = "Inglés";
                    SpanishRadioButton.Text = "Español";

                    ApplyConfigButton.Text = "Aplicar Configuración";
                    ConfigTitleLabel.Text = "Configuración";

                    toolStripStatusLabel1.Text = "Estado I";
                    toolStripStatusLabel2.Text = "Estado II";
                    toolStripStatusLabel3.Text = "Estado III";

                    this.Text = "Ejercicio XII";

                    languageString = "Español";

                    ConfigSummaryLabel.Text = "Modo Oscuro: " + darkModeString + ", Mostrar Barra de Estado: " + showStatusBarString + ", Idioma: " + languageString;
                    break;
            }
        }

        private void PortugueseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PortugueseRadioButton.Checked)
                selectedLanguage = "portuguese";
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (EnglishRadioButton.Checked)
                selectedLanguage = "english";
        }

        private void SpanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SpanishRadioButton.Checked)
                selectedLanguage = "spanish";
        }

        private void Exercicio12_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
