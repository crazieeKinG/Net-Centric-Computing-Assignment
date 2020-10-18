using System;
using System.Text;

namespace RandomPasswordGenerator
{
    class Program
    {
        private static Random random = new Random();
        private static string[] optionsList = { "smallLetters", "capitalLetters", "numbers", "specialCharacters" };
        private static string[] selectedOption = { "n", "n", "n", "n" };
        private static char[] specialCharacterList = { '~', '!', '@', '#', '$', '%', '^', '&' };
        static void Main(string[] args)
        {
            int passowrdLength = int.Parse(Input("Enter the length of password: "));
            SelectingOptions();
            string generatedPassword = GenerateRandomPassword(passowrdLength);
            Console.WriteLine($"Generated password: \n{generatedPassword}");
        }

        private static string GenerateRandomPassword(int passowrdLength)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < passowrdLength; i++)
            {
                int randomOptionSelect = GetOneSelectedOption();
                char randomValue = GetRandomValue(randomOptionSelect);
                sb.Append(randomValue);
            }
            return sb.ToString();
        }

        private static int GetOneSelectedOption()
        {
            int randomSelectedOption;
            do
                randomSelectedOption = random.Next(0, 4);
            while (selectedOption[randomSelectedOption] != "y");
            return randomSelectedOption;
        }

        private static char GetRandomValue(int randomOptionSelect)
        {
            if (randomOptionSelect == 0)
                return (char)random.Next(97, 123);
            else if (randomOptionSelect == 1)
                return (char)random.Next(65, 91);
            else if (randomOptionSelect == 2)
                return (char)random.Next(48, 58);
            else
            {
                int selectRandomSpecialCharacter = random.Next(0, specialCharacterList.Length);
                return specialCharacterList[selectRandomSpecialCharacter];
            }
        }

        private static void SelectingOptions()
        {
            int numberOfOptionSelected = 0;
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    selectedOption[i] = Input($"Do you want to include {optionsList[i]} (y/n)? ").ToLower();
                    if (selectedOption[i] == "y")
                        numberOfOptionSelected++;
                }
                if (numberOfOptionSelected == 0)
                    Console.WriteLine("Please select atleast 1 option!!!");
            } while (numberOfOptionSelected == 0);
        }

        private static string Input(string displayText)
        {
            Console.Write(displayText);
            return Console.ReadLine();
        }
    }
}
