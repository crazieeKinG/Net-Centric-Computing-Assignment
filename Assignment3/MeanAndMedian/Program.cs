using System;

namespace MeanAndMedian
{
    class Program
    {
        static void Main()
        {
            int n = InputInt("How many numbers? ");
            int[] listOfNumber = new int[n];
            InputListOfNumber(n, listOfNumber);
            Mean(n, listOfNumber);
            Median(n, listOfNumber);
        }

        private static void Median(int n, int[] listOfNumber)
        {
            double medianPosition = CalculateMedianPosition(n, listOfNumber);
            Console.WriteLine($"Median = { CalculateMedian(n, listOfNumber, medianPosition) }");
        }

        private static double CalculateMedianPosition(int n, int[] listOfNumber)
        {
            Array.Sort(listOfNumber);
            return (n + 1) / 2.0;
        }

        private static double CalculateMedian(int n, int[] listOfNumber, double medianPosition)
        {
            if (n % 2 == 0)
                return (listOfNumber[(int)medianPosition - 1] + listOfNumber[(int)medianPosition]) / 2.0;
            else
                return listOfNumber[(int)medianPosition - 1];
        }

        private static void Mean(int n, int[] listOfNumber)
        {
            int totalSum = 0;
            for (int i = 0; i < n; i++)
                totalSum += listOfNumber[i];
            Console.WriteLine($"Mean = { (double)totalSum / n }");
        }

        private static void InputListOfNumber(int n, int[] listOfNumber)
        {
            for (int i = 0; i < n; i++)
                listOfNumber[i] = InputInt($"Enter { i + 1 } number: ");
        }

        private static int InputInt(string displayText)
        {
            Console.Write(displayText);
            return int.Parse(Console.ReadLine());
        }
    }
}
