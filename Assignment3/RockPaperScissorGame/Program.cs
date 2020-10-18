using System;

namespace RockPaperScissorGame
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissor Game!!!");
            do
                StartGame();
            while (Replay()) ;
        }

        private static bool Replay()
        {
            Console.Write("Do you want to replay (y/n)? ");
            return Console.ReadLine().ToLower() == "y";
        }

        private static void StartGame()
        {
            int userPick;
            do
                userPick = UserPick();
            while (userPick < 1 || userPick > 3);
            int computerPick = ComputerChoice();
            ComparePicks(userPick, computerPick);
        }

        private static int ComputerChoice()
        {
            int computerPick = random.Next(1, 4);
            ComputerPickDisplay(computerPick);
            return computerPick;
        }

        private static void ComputerPickDisplay(int computerPick)
        {
            if (computerPick == 1)
                Console.WriteLine("Computer pick: Rock");
            else if (computerPick == 2)
                Console.WriteLine("Computer pick: Paper");
            else
                Console.WriteLine("Computer pick: Scissor");
        }

        private static void ComparePicks(int userPick, int computerPick)
        {
            if (userPick > computerPick || (userPick == 1 && computerPick == 3))
                Console.WriteLine("You Won!!!");
            else if (userPick == computerPick)
                Console.WriteLine("Tied!!!");
            else
                Console.WriteLine("You Lost !!!");
        }

        private static int UserPick()
        {
            Console.WriteLine("Your pick:");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissor");
            return int.Parse(Console.ReadLine());
        }
    }
}
