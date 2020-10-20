using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class MainForm : Form
    {
        private int randomNumber, userInputValue, attempts;

        public MainForm()
        {
            InitializeComponent();
            GenerateRandomNumber();
            attempts = 5;
            AttemptMessage();
        }

        private void GenerateRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void CompareData()
        {
            if (userInputValue == randomNumber)
            {
                messageDisplay(Color.Green, "You Won!!!");
                CorrectMessage();
                DisableInput();
            }
            else
                CheckAttempts();
        }

        private void CheckAttempts()
        {
            attempts--;
            if (attempts == 0)
            {
                messageDisplay(Color.Red, "You Lost!!!");
                CorrectMessage();
                DisableInput();
            }
            else
            {
                ProvideDetailMessage();
                AttemptMessage();
            }
        }

        private void DisableInput()
        {
            userInput.Enabled = false;
            guessButton.Enabled = false;
        }

        private void CorrectMessage()
        {
            infoLabel.Text = $"CORRECT ANSWER: {randomNumber}";
            infoLabel.ForeColor = Color.Green;
        }

        private void AttemptMessage()
        {
            infoLabel.ForeColor = Color.LimeGreen;
            infoLabel.Text = $"ATTEMPTS LEFT: {attempts}";
        }

        private void ProvideDetailMessage()
        {
            if (userInputValue > randomNumber)
                messageDisplay(Color.Orange, "Input is greater than answer.");
            else
                messageDisplay(Color.Orange, "Input is less than answer.");
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            GenerateRandomNumber();
            attempts = 5;
            AttemptMessage();
        }

        private void messageDisplay(Color colorName, string displayText)
        {
            messageLabel.ForeColor = colorName;
            messageLabel.Text = displayText;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            try
            {
                userInputValue = int.Parse(userInput.Text);
                CompareData();
                userInput.Text = "";
            }
            catch
            {
                errorProvider.SetError(userInput, "Please enter valid number");
            }
        }
    }
}
