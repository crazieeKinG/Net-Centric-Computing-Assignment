using System;

namespace BillSplitvalue
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("biil split value per person (2 people) (in apartment) calculation... ");
            Console.Write("Enter roommate salary (Rs.): ");
            decimal salary1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter your salary (Rs.): ");
            decimal salary2 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter total amount to pay (Rs.): ");
            decimal total = decimal.Parse(Console.ReadLine());
            decimal roommateShare = total * (salary1 / (salary1 + salary2));
            Console.WriteLine($"Roommate share = Rs. {roommateShare}");
            Console.WriteLine($"Yours share = Rs. {total - roommateShare}");
        }
    }
}
