using System;

namespace CompoundInterest
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Compound interest calculation...");
            Console.Write("Enter Principal (Rs.): ");
            decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Time (years) : ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate (%) : ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Enter compunding frequency : ");
            int n = int.Parse(Console.ReadLine());
            decimal ci = p * (decimal)(Math.Pow(1+(r/(100*n)),(n*t))-1);
            Console.WriteLine($"Compound Intersest = Rs. {ci}");
        }
    }
}
