using System;

namespace Q7_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int row=6, col=6;
            Console.Write("Enter rows: ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            col = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int[,] mat = new int[row, col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    mat[i, j] = pattern.randnum(row, col);
                  /*  Console.Write("enter value for row {0} column {1}: ",i,j);
                    mat[i, j] = int.Parse(Console.ReadLine());*/
                }
            }/*
            mat[4, 2] = 9;
            mat[3, 3] = 9;
            mat[2, 4] = 9;
            mat[1, 5] = 9;
            mat[0, 5] = 5;
            mat[1, 4] = 5;
            mat[2, 3] = 5;
            mat[3, 2] = 5;
            */
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine("");
            }
            pattern.checker1(row, col, mat);
            pattern.checker2(row, col, mat);
            pattern.checker3(row, col, mat);
            pattern.checker4(row, col, mat);
        }
    }
}
