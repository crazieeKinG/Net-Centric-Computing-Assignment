using System;

namespace MassEnergyEquivalence
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Mass-Energy equivalence calculation... ");
            Console.Write("Enter mass (kg): ");
            double m = double.Parse(Console.ReadLine());
            double c = 3E+8; // Speed of light m/s
            double E = m * c;
            Console.WriteLine($"Energy = {E} J");
        }
    }
}
