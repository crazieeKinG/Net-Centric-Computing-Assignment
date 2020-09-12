using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number to generate multiplication table: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Multiplication Table of {x}");
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{x} x {i} = {x*i}");
        }
    }
}
