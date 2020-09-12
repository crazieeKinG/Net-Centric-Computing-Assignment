using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guessing Game...");
            string choice;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                Console.WriteLine($"Random Number = {randomNumber}");
                bool userWon = false;
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine($"{i} tries left");
                    Console.Write("Guess the number: ");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Hooray! You won.");
                        userWon = true;
                        break;
                    }
                    else if (guess > randomNumber)
                        Console.WriteLine("Guessed number is greater than answer.");
                    else
                        Console.WriteLine("Guessed number is smaller than answer.");
                }
                if (!userWon)
                {
                    Console.WriteLine("Oh no! You lost.");
                    Console.WriteLine($"Correct answer is {randomNumber} !!");
                }
                Console.Write("Replay (Y/N) ?: ");
                choice = Console.ReadLine().ToUpper();
            } while (choice == "Y");
        }
    }
}
