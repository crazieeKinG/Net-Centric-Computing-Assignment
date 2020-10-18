using System;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz program from 1-100");
            StartIteration();
        }

        private static void StartIteration()
        {
            for (int i = 1; i <= 100; i++)
                CheckValue(i);
        }

        private static void CheckValue(int i)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.Write("FizzBuzz\t");
            else if (i % 3 == 0)
                Console.Write("Fizz\t");
            else if (i % 5 == 0)
                Console.Write("Buzz\t");
            else
                Console.Write($"{i}\t");
        }
    }
}
