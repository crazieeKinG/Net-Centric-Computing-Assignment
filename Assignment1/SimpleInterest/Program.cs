using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Simple interest calculation...");
            Console.Write("Enter Principal (Rs.): ");
            decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Time (years) : ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate (%) : ");
            int r = int.Parse(Console.ReadLine());
            decimal i = (p * (decimal)t * r) / 100;
            Console.WriteLine($"Simple interest = Rs. {i}");
        }
    }
}
