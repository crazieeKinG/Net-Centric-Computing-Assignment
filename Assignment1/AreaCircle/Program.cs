using System;
using System.Runtime.ConstrainedExecution;

namespace AreaCircle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Area of circle calculation... ");
            Console.Write("Enter radius (m) : ");
            double r = double.Parse(Console.ReadLine());
            double a = Math.PI * r * r;
            Console.WriteLine($"Area = {a} m^2");
        }
    }
}
