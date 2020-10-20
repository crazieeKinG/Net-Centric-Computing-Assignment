using System;
using System.Text;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{
    public partial class PasswordGeneratorForm : Form
    {
        Random random = new Random();
        int rangeValue;
        char[] specialCharacterList = { '~', '@', '#', '$', '%', '&', '_' };
        // 0-small letters, 1 - capital letters, 2 - numbers, 3 - special characters
        bool[] checkedBox = { true, false, false, false };
        public PasswordGeneratorForm()
        {
            InitializeComponent();
            rangeValue = MainForm.maxRangeValue;
            letterCountBar.Maximum = rangeValue;
            letterCountBar.Value = rangeValue;
            GeneratePassword();
        }

        private void GeneratePassword()
        {
            if (CheckWhetherAnyBoxIsChecked())
                StartGeneration();
            else
                generatedPassword.Text = "Please select atleast one option !!!";
        }

        private void StartGeneration()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < rangeValue; i++)
            {
                int characterIndex = ChooseOneSelectedCharacterFormat();
                char character = SelectRandomCharacter(characterIndex);
                sb.Append(character);
            }
            generatedPassword.Text = sb.ToString();
        }

        private int ChooseOneSelectedCharacterFormat()
        {
            int randomNumber;
            do
            {
                randomNumber = random.Next(0, 4);
            } while (!checkedBox[randomNumber]);
            return randomNumber;
        }

        private char SelectRandomCharacter(int characterIndex)
        {
            if (characterIndex == 0)
                return (char)random.Next(97, 123);
            else if (characterIndex == 1)
                return (char)random.Next(65, 91);
            else if (characterIndex == 2)
                return (char)random.Next(48, 58);
            else
            {
                int index = random.Next(0, specialCharacterList.Length);
                return specialCharacterList[index];
            }
        }

        private bool CheckWhetherAnyBoxIsChecked()
        {
            for (int i = 0; i < 4; i++)
                if (checkedBox[i])
                    return true;
            return false;
        }

        private void LetterCountBar_Scroll(object sender, EventArgs e)
        {
            rangeValue = letterCountBar.Value;
            GeneratePassword();
        }

        private void CapitalLetter_CheckedChanged(object sender, EventArgs e)
        {
            checkedBox[1] = !checkedBox[1];
            GeneratePassword();
        }

        private void Number_CheckedChanged(object sender, EventArgs e)
        {
            checkedBox[2] = !checkedBox[2];
            GeneratePassword();
        }

        private void SpecialCharacter_CheckedChanged(object sender, EventArgs e)
        {
            checkedBox[3] = !checkedBox[3];
            GeneratePassword();
        }

        private void smallLetter_CheckedChanged(object sender, EventArgs e)
        {
            checkedBox[0] = !checkedBox[0];
            GeneratePassword();
        }

        private void PasswordGeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = (MainForm)Tag;
            mainForm.Show();
        }
    }
}
