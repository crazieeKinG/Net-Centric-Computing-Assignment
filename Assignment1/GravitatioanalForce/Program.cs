using System;

namespace GravitatioanalForce
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Gravitational force calculation...");
            Console.Write("Enter mass of first body (kg): ");
            double m1 = double.Parse(Console.ReadLine());
            Console.Write("Enter mass of second body (kg): ");
            double m2 = double.Parse(Console.ReadLine());
            Console.Write("Enter distance between them (m): ");
            double d = double.Parse(Console.ReadLine());
            const double G = 6.67E-11; // Gravitational constant
            double F = (G * m1 * m2) / (d * d);
            Console.WriteLine($"Gravitational Force = {F} N");
        }
    }
}
