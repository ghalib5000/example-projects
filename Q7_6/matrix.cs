using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_6
{
    class matrix
    {
        public static double[,] result(double[,] a, double[,] b)
        {
            double[,] c = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = (a[i, 0] * b[0, j]) + (a[i, 1] * b[1, j])+(a[i, 2] * b[2, j]);
                }
            }
            return c;
        }
        public static void dispmat(double[,]a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine("");
            }
        }
        public static void dispmatr(double[,] a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (i == 1 && j == 3)
                    {
                        Console.Write(" x ");
                    }
                    if (i == 1 && j == 6)
                    {
                        Console.Write(" = ");
                    }
                    if (i != 1 && (j == 3||j==6))
                    {
                        Console.Write("   ");
                    }
                    Console.Write("  "+a[i, j] + " ");
                }
                Console.WriteLine(""); Console.WriteLine("");
            }
        }
        public static double[,] numtaker()
        {
            double[,] a = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }
            return a;
        }
    }
}
