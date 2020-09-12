using System;

namespace MeanAndMedian
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many numbers: ");
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[x];
            int total = 0;
            for(int i = 0; i < x; i++)
            {
                Console.Write($"Enter {i+1} number: ");
                arr[i] = int.Parse(Console.ReadLine());
                total += arr[i];
            }
            double mean = (double)total / x;
            Array.Sort(arr);
            double mdn = (x + 1) / 2.0;
            double md = 0;
            if (x % 2 == 0)
                md = (arr[(int)mdn - 1] + arr[(int)mdn]) / 2.0;
            else
                md = arr[(int)mdn-1];
            Console.WriteLine($"Mean = {mean} | Median = {md}");
        }
    }
}
