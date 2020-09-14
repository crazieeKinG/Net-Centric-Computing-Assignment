using System;

namespace MatricesSumAndDiff
{
    class Program
    {
        static void Main()
        {
            int row = InputInt("Enter no. of rows: ");
            int column = InputInt("Enter no. of columns: ");
            double[,] matrix1 = new double[row, column], matrix2 = new double[row, column];
            GetMatrices(row, column, matrix1, matrix2);
            SumOfMatrices(row, column, matrix1, matrix2);
            DifferenceOfMatrices(row, column, matrix1, matrix2);
        }

        private static void SumOfMatrices(int row, int column, double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix = new double[row, column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            DisplayMatrix(row, column, matrix, "Sum:");
        }

        private static void DifferenceOfMatrices(int row, int column, double[,] matrix1, double[,] matrix2)
        {
            double[,] matrix = new double[row, column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] = matrix1[i, j] - matrix2[i, j];
            DisplayMatrix(row, column, matrix, "Difference:");
        }

        private static void DisplayMatrix(int row, int column, double[,] matrix, string displayText)
        {
            Console.WriteLine(displayText);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        private static void GetMatrices(int row, int column, double[,] matrix1, double[,] matrix2)
        {
            Console.WriteLine("For Matrix 1");
            GetMatrixValue(row, column, matrix1);
            Console.WriteLine("For Matrix 2");
            GetMatrixValue(row, column, matrix2);
        }

        private static void GetMatrixValue(int row, int column, double[,] matrix)
        {
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    matrix[i, j] = InputDouble($"Enter {i},{j} value: ");
        }

        private static double InputDouble(string displayText)
        {
            Console.Write(displayText);
            return double.Parse(Console.ReadLine());
        }

        private static int InputInt(string displayText)
        {
            Console.Write(displayText);
            return int.Parse(Console.ReadLine());
        }
    }
}
