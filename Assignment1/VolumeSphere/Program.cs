using System;

namespace VolumeSphere
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Area of circle calculation... ");
            Console.Write("Enter radius (m): ");
            double r = double.Parse(Console.ReadLine());
            double v = (4.0/3.0) * Math.PI * r * r * r;
            Console.WriteLine($"Volume = {v} m^3");
        }
    }
}
