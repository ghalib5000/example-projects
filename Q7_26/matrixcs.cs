using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_26
{
    class matrixcs
    {
        public static double[,] sorter(double[,] mat)
        {
            double temp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (mat[i, j] > mat[i, j + 1])
                    {
                        temp = mat[i, j];
                        mat[i, j] = mat[i, j + 1];
                        mat[i, j + 1] = temp;
                    }

                }
            }
            return mat;
        }
    }
}
