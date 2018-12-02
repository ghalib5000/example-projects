using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_35
{
    class Matrix
    {
        public static int[] subsqr(string[,] mat, int row)
        {
            int[] nums = new int[3];
            int[,] grid = new int[row, row];
            int n=0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if(mat[i,j]=="1"&&(i==0||j==0))
                    {
                        grid[i, j] = 1;
                    }
                    else if (mat[i, j] == "1")
                    {
                        grid[i, j] = Math.Min(grid[i-1,j-1] ,  Math.Min( grid[i - 1, j],grid[i, j-1]))+1;
                        if(grid[i,j]>n)
                        {
                            nums[0] = i;
                            nums[1] = j;
                            nums[2] = grid[i, j];
                            n = grid[i, j];
                        }
                    }
                }
            }
            
            return nums;
        }
    }
}
