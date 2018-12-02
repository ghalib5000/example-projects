using System;

namespace Q7_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ans = new int[3];
            int row = 5;
               Console.Write("Enter number of rows in the matrix: ");
               row = int.Parse(Console.ReadLine());
            string[,] mat = new string[row,row];// { { "1", "0", "1", "0", "1" }, { "1", "1", "1", "0", "1" }, { "1", "0", "1", "1", "1" }, { "1", "0", "1", "1", "1" }, { "1", "0", "1", "1", "1" }, };
            string[] ar = new string[row];
            for (int i = 0; i < row; i++)
               
            {
                Console.WriteLine("enter numbers(for more than one numbers use ','): ");
                string s = Console.ReadLine();
                ar = s.Split(',');
                for (int j = 0; j < row; j++)
                {
                    mat[i, j] = ar[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                   Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine("");
            }
            ans = Matrix.subsqr(mat, row);
            Console.WriteLine("size: ");
            Console.WriteLine("The maximum submatrix is at({0}, {1}) with size {2}",ans[0],ans[1],ans[2]);
           
        }
    }
}
