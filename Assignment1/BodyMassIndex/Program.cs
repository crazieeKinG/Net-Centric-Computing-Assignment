using System;

namespace BodyMassIndex
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Body mass index calculation...");
            Console.Write("Enter Weight (kg) : ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Enter Height (m) : ");
            double h = double.Parse(Console.ReadLine());
            double bmi = w / (h * h);
            Console.WriteLine($"Body mass index = {bmi} kg/m^2");
        }
    }
}
