using System;

namespace GeometricAverage
{
    class Program
    {
        static void Main()
        {
            double datas = 1; 
            Console.Write("How many numbers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i+1} number: ");
                double temp = double.Parse(Console.ReadLine());
                datas *= temp;
            }
            double geometricAverage = Math.Pow(datas, 1.0 / n);
            Console.WriteLine($"Geomertic Average = {geometricAverage}");
        }
    }
}
