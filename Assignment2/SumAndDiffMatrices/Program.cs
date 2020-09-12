using System;

namespace SumAndDiffMatrices
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter no. of rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter no. of columns: ");
            int c = int.Parse(Console.ReadLine());
            double[,] m1 = new double[r,c], m2 = new double[r,c], s = new double[r, c], d = new double[r, c];
            Console.WriteLine("For Matrix m1");
            for (int i = 0; i < r; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.Write($"Enter {i},{j} value: ");
                    m1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("For Matrix m2");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Enter {i},{j} value: ");
                    m2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    s[i, j] = m1[i, j] + m2[i, j];
                    d[i, j] = m1[i, j] - m2[i, j];
                }
            }
            Console.WriteLine("Sum:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{s[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Difference:");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"{d[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
