using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guessing Game...");
            do
                StartGame();
            while (ConfirmReplay() == "Y");
        }

        private static string ConfirmReplay()
        {
            Console.Write("Replay (Y/N) ?: ");
            return Console.ReadLine().ToUpper();        
        }

        private static void StartGame()
        {
            int randomNumber = GenerateRandomNumber();
            GuessTheNumber(randomNumber);
        }

        private static void GuessTheNumber(int correctNumber)
        {
            bool userWon = StartGuessing(correctNumber);
            if (!userWon)
                FailedMessage(correctNumber);
        }
        
        private static bool StartGuessing(int correctNumber)
        {
            bool userWon = false;
            for (int i = 5; i > 0 && !userWon; i--)
            {
                Console.WriteLine($"{i} tries left");
                int guess = InputGuess();
                userWon = CheckGuess(guess, correctNumber);
            }
            return userWon;
        }
        
        private static void FailedMessage(int correctNumber)
        {
            Console.WriteLine("Oh no! You lost.");
            Console.WriteLine($"Correct answer is {correctNumber} !!");
        }

        private static bool CheckGuess(int guessNumber, int correctNumber)
        {
            if (guessNumber == correctNumber)
            {
                Console.WriteLine("Hooray! You won.");
                return true;
            }
            else if (guessNumber > correctNumber)
                Console.WriteLine("Guessed number is greater than answer.");
            else
                Console.WriteLine("Guessed number is smaller than answer.");
            return false;
        }
        
        private static int InputGuess()
        {
            Console.Write("Guess the number: ");
            return int.Parse(Console.ReadLine());
        }

        private static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
    }
}
