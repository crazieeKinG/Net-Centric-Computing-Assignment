using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissorGame
{
    public partial class MainForm : Form
    {
        int userChoiceValue = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        int GenerateRandomChoice()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }

        void CompareChoices(int computerChoice)
        {
            if (userChoiceValue > computerChoice || (userChoiceValue == 1 && computerChoice == 3))
            {
                resultMessage.ForeColor = Color.Green;
                resultMessage.Text = "You Won !!!";
            }
            else if (userChoiceValue == computerChoice)
            {
                resultMessage.ForeColor = Color.Orange;
                resultMessage.Text = "Tied!!!";
            }
            else
            {
                resultMessage.ForeColor = Color.Red;
                resultMessage.Text = "You Lost !!!";
            }
        }

        void DisplayComputerChoice(int computerChoiceValue)
        {
            if (computerChoiceValue == 1)
                computerChoice.Text = "Rock";
            else if (computerChoiceValue == 2)
                computerChoice.Text = "Paper";
            else
                computerChoice.Text = "Scissor";
        }

        void StartComparision()
        {
            int computerChoiceValue = GenerateRandomChoice();
            DisplayComputerChoice(computerChoiceValue);
            CompareChoices(computerChoiceValue);
        }

        void DisableAllButtons()
        {
            rockButton.Enabled = false;
            paperButton.Enabled = false;
            scissorButton.Enabled = false;
            StartComparision();
        }

        void HighlightButton(Button userChoice)
        {
            userChoice.BackColor = Color.SteelBlue;
            userChoice.ForeColor = Color.White;
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            HighlightButton(rockButton);
            userChoiceValue = 1;
            DisableAllButtons();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            HighlightButton(paperButton);
            userChoiceValue = 2;
            DisableAllButtons();
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            HighlightButton(scissorButton);
            userChoiceValue = 3;
            DisableAllButtons();
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}
