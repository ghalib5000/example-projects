using System;

namespace Q7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] a = new double[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,] b = new double[3, 3] { { 0, 2, 4 }, { 1, 4.5, 2.2 }, { 1.1, 4.3, 5.2 } };
            double[,] c = new double[3, 3];
            double[,] r = new double[3, 9];
            /*  Console.WriteLine("enter matrix 1 values: ");
              a = matrix.numtaker();
              Console.WriteLine("enter matrix 2 values: ");
              b = matrix.numtaker();*/
            c = matrix.result(a, b);
            matrix.dispmat(a);
            Console.WriteLine("  X");
            matrix.dispmat(b);
            Console.WriteLine("  =");
            matrix.dispmat(c);
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j < 3)
                    {
                        r[i, j] = a[i, j];
                    }
                    else if (j < 6 && j > 2)
                    {
                        r[i, j] = b[i, j-3];
                    }
                    if (j < 9 && j > 5)
                    {
                        r[i, j] = c[i, j-6];
                    }
                }
            }
            matrix.dispmatr(r);
        }
    }
}
