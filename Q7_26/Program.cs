using System;

namespace Q7_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0, col = 0;
            double[,] mat = new double[3, 3];// { { 0.15, 0.875, 0.375 }, { 0.55, 0.005, 0.225 }, { 0.30, 0.12, 0.4 } };
            for (row = 0; row < 3; row++) 
            {
                for (col = 0; col < 3; col++)
                {
                    Console.WriteLine("Enter number for row {0} column {1}:", row, col);
                    mat[row, col] = double.Parse(Console.ReadLine());
                }
            }
            double[,] sorted = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sorted[i, j] = mat[i, j];
                }
            }
            int u = 0;
            while (u < 5) {
                sorted = matrixcs.sorter(sorted);
                u++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sorted[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
